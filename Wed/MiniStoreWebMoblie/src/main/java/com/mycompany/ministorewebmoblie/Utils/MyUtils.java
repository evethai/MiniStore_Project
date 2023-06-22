package com.mycompany.ministorewebmoblie.Utils;

import com.google.zxing.BarcodeFormat;
import com.google.zxing.MultiFormatWriter;
import com.google.zxing.WriterException;
import com.google.zxing.client.j2se.MatrixToImageWriter;
import com.google.zxing.common.BitMatrix;
import com.mycompany.ministorewebmoblie.DTO.SheetTimeSlot;
import io.jsonwebtoken.Claims;
import jakarta.servlet.ServletException;
import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeParseException;
import java.util.ArrayList;
import java.util.Base64;
import java.util.Collections;
import java.util.List;
import org.json.JSONException;
import org.json.JSONObject;

public class MyUtils {

    // Gửi yêu cầu GET và trả về phản hồi dạng chuỗi JSON
    public static String sendGetRequest(String apiUrl) throws IOException {
        URL url = new URL(apiUrl);
        HttpURLConnection conn = (HttpURLConnection) url.openConnection();
        conn.setRequestMethod("GET");
        conn.setRequestProperty("Accept", "application/json");

        if (conn.getResponseCode() != 200) {
            throw new RuntimeException("Lỗi: Mã lỗi HTTP: " + conn.getResponseCode());
        }

        try ( BufferedReader br = new BufferedReader(new InputStreamReader(conn.getInputStream()))) {
            StringBuilder responseBuilder = new StringBuilder();
            String line;
            while ((line = br.readLine()) != null) {
                responseBuilder.append(line);
            }
            return responseBuilder.toString();
        } finally {
            conn.disconnect();
        }
    }

    // Lấy danh sách SheetTimeSlot từ API
    public static List<SheetTimeSlot> getSheetTimeSlots() throws IOException {
        String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/fst");
        JSONObject json;

        try {
            json = new JSONObject(jsonResponse);
        } catch (JSONException e) {
            // Xử lý lỗi khi phân tích phản hồi JSON
            e.printStackTrace();
            return Collections.emptyList();
        }

        String jwt = json.optString("jwt");

        // Kiểm tra JWT
        if (jwt.isEmpty() || jwt.equals("Unauthorized")) {
            // Người dùng không hợp lệ
            System.out.println("Invalid JWT");
            return Collections.emptyList();
        }

        Claims claims = JWTUtils.parseJWT(jwt);

        List<String> sheetNumbers = claims.get("Sheet", List.class);
        List<String> shiftStartTimes = claims.get("ShiftStartTime", List.class);
        List<String> shiftEndTimes = claims.get("ShiftEndTime", List.class);

        List<SheetTimeSlot> sheetTimeSlots = new ArrayList<>();

        for (int i = 0; i < sheetNumbers.size(); i++) {
            String sheetNumber = sheetNumbers.get(i);
            String shiftStartTime = shiftStartTimes.get(i);
            String shiftEndTime = shiftEndTimes.get(i);

            LocalTime startTime;
            LocalTime endTime;

            try {
                startTime = LocalTime.parse(shiftStartTime);
                endTime = LocalTime.parse(shiftEndTime);
            } catch (DateTimeParseException e) {
                // Xử lý lỗi khi phân tích chuỗi thời gian
                e.printStackTrace();
                continue;
            }

            SheetTimeSlot sheetTimeSlot = new SheetTimeSlot(sheetNumber, startTime, endTime);
            sheetTimeSlots.add(sheetTimeSlot);
        }

        return sheetTimeSlots;
    }

    //update worksheet
    public static boolean updateWorksheet(String idemp, String date, String update) throws IOException {
        String url = "http://localhost/swp/api/ms/uco";
        URL urlObj = new URL(url);
        HttpURLConnection conn = (HttpURLConnection) urlObj.openConnection();
        conn.setRequestMethod("PUT");
        conn.setRequestProperty("Content-Type", "application/json");
        conn.setDoOutput(true);
        String jwt = "";

        jwt = JWTUtils.generateJWTUWS(idemp, date, update);

        if (jwt == null || jwt.isEmpty()) {
            return false;
        }

        JSONObject jsonObject = new JSONObject();
        jsonObject.put("jwt", jwt);
        String jsonString = jsonObject.toString();
        DataOutputStream outputStream = new DataOutputStream(conn.getOutputStream());
        outputStream.writeBytes(jsonString);
        outputStream.flush();
        outputStream.close();

        int responseCode = conn.getResponseCode();
        if (responseCode == HttpURLConnection.HTTP_OK) {
            // Dữ liệu đã được đưa vào database thành công.
            return true;
        } else {
            // Lỗi HTTP
            return false;
        }
    }

    //add worksheet
    public static boolean AddWorksheet(String idemp, String date, String sheet, String timecheckin) throws IOException {
        String url = "http://localhost/swp/api/ms/addws";
        URL urlObj = new URL(url);
        HttpURLConnection conn = (HttpURLConnection) urlObj.openConnection();
        conn.setRequestMethod("POST");
        conn.setRequestProperty("Content-Type", "application/json");
        conn.setDoOutput(true);
        String jwt = "";
        jwt = JWTUtils.generateJWTAWS(idemp, date, sheet, timecheckin);

        if (jwt == null || jwt.isEmpty()) {
            return false;
        }

        JSONObject jsonObject = new JSONObject();
        jsonObject.put("jwt", jwt);
        String jsonString = jsonObject.toString();
        DataOutputStream outputStream = new DataOutputStream(conn.getOutputStream());
        outputStream.writeBytes(jsonString);
        outputStream.flush();
        outputStream.close();

        int responseCode = conn.getResponseCode();
        if (responseCode == HttpURLConnection.HTTP_OK) {
            // Dữ liệu đã được đưa vào database thành công.
            return true;
        } else {
            // Lỗi HTTP
            return false;
        }
    }

    // tạo qrcode url
    public static String generateQRCodeURL(String idemp, String Time) throws ServletException {
        String qrCodeData = "IDEMP: " + idemp + "\n"
                + "Login Time: " + Time;

        int width = 200;
        int height = 200;
        String imageFormat = "png";

        BitMatrix bitMatrix;
        try {
            bitMatrix = new MultiFormatWriter().encode(qrCodeData, BarcodeFormat.QR_CODE, width, height);
        } catch (WriterException e) {
            throw new ServletException("Error generating QR code", e);
        }

        ByteArrayOutputStream baos = new ByteArrayOutputStream();
        try {
            MatrixToImageWriter.writeToStream(bitMatrix, imageFormat, baos);
        } catch (IOException e) {
            throw new ServletException("Error writing QR code to stream", e);
        }

        byte[] qrCodeBytes = baos.toByteArray();
        String base64Image = Base64.getEncoder().encodeToString(qrCodeBytes);

        return "data:image/" + imageFormat + ";base64," + base64Image;
    }

    public static String checkSundayHoliday() {
        String sheet;
        LocalDate today = LocalDate.now();
        DayOfWeek dayOfWeek = today.getDayOfWeek();

        if (dayOfWeek == DayOfWeek.SUNDAY) {
            boolean isHoliday = checkHoliday(today);
            if (isHoliday) {
                sheet = "9"; // Ngày nghỉ lễ là Chủ Nhật
            } else {
                sheet = "8"; // Chủ Nhật không phải ngày nghỉ lễ
            }
        } else {
            sheet = ""; // Các ngày khác
        }

        return sheet;
    }

    private static boolean checkHoliday(LocalDate date) {
        int year = date.getYear();
        List<LocalDate> holidayDates = getHolidayDates(year);

        // Kiểm tra ngày hôm nay có thuộc danh sách ngày nghỉ lễ hay không
        return holidayDates.contains(date);
    }

    private static List<LocalDate> getHolidayDates(int year) {
        List<LocalDate> holidayDates = new ArrayList<>();

        // Tết Dương lịch: 1/1, 2/1, 3/1
        holidayDates.add(LocalDate.of(year, 1, 1));
        holidayDates.add(LocalDate.of(year, 1, 2));
        holidayDates.add(LocalDate.of(year, 1, 3));

        // Tết Nguyên đán: 21/1, 22/1, 23/1, 24/1, 25/1, 26/1, 27/1
        holidayDates.add(LocalDate.of(year, 1, 21));
        holidayDates.add(LocalDate.of(year, 1, 22));
        holidayDates.add(LocalDate.of(year, 1, 23));
        holidayDates.add(LocalDate.of(year, 1, 24));
        holidayDates.add(LocalDate.of(year, 1, 25));
        holidayDates.add(LocalDate.of(year, 1, 26));
        holidayDates.add(LocalDate.of(year, 1, 27));

        // Giỗ tổ Hùng Vương: 4/4, 5/4, 6/4, 7/4, 8/4
        holidayDates.add(LocalDate.of(year, 4, 4));
        holidayDates.add(LocalDate.of(year, 4, 5));
        holidayDates.add(LocalDate.of(year, 4, 6));
        holidayDates.add(LocalDate.of(year, 4, 7));
        holidayDates.add(LocalDate.of(year, 4, 8));

        // Lễ 30/4 - 1/5: 29/4, 30/4, 1/5, 2/5, 3/5
        holidayDates.add(LocalDate.of(year, 4, 29));
        holidayDates.add(LocalDate.of(year, 4, 30));
        holidayDates.add(LocalDate.of(year, 5, 1));
        holidayDates.add(LocalDate.of(year, 5, 2));
        holidayDates.add(LocalDate.of(year, 5, 3));

        // Quốc khánh: 2/9, 3/9, 4/9, 5/9
        holidayDates.add(LocalDate.of(year, 9, 2));
        holidayDates.add(LocalDate.of(year, 9, 3));
        holidayDates.add(LocalDate.of(year, 9, 4));
        holidayDates.add(LocalDate.of(year, 9, 5));

        return holidayDates;
    }
}
