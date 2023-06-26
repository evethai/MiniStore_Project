package com.mycompany.ministorewebmoblie.Utils;

import com.google.zxing.BarcodeFormat;
import com.google.zxing.MultiFormatWriter;
import com.google.zxing.WriterException;
import com.google.zxing.client.j2se.MatrixToImageWriter;
import com.google.zxing.common.BitMatrix;
import com.mycompany.ministorewebmoblie.DTO.SheetTimeSlotDTO;
import io.jsonwebtoken.Claims;
import jakarta.servlet.ServletException;
import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.time.LocalTime;
import java.time.format.DateTimeParseException;
import java.util.ArrayList;
import java.util.Base64;
import java.util.Collections;
import java.util.List;
import org.json.JSONException;
import org.json.JSONObject;

public class MyUtils {

    private static final int checkInStart = 5;//minus Minutes
    private static final int checkInEnd = 5;//minus Minutes
    private static final int checkOutStart = 6;//hours minus
    private static final int checkOutEnd = 30;//minus plus

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

    // Lấy danh sách Sheet đã có từ API
    public static List<String> getSheetAvailable(String date) {
        try {
            // Lấy danh sách Sheet từ API
            String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/fwsd?date=" + date);
            JSONObject json = new JSONObject(jsonResponse);

            String jwt = json.optString("jwt");

            // Check JWT
            if (jwt.isEmpty() || jwt.equals("Unauthorized")) {
                // Invalid user
                System.out.println("Invalid JWT");
                return Collections.emptyList();
            }

            Claims claims = JWTUtils.parseJWT(jwt);
            Object sheetClaimValue = claims.get("Sheet");

            // Convert the claim value to a list manually
            List<String> sheetNumbers = new ArrayList<>();
            if (sheetClaimValue instanceof List<?>) {
                List<?> sheetList = (List<?>) sheetClaimValue;
                for (Object sheet : sheetList) {
                    if (sheet instanceof String) {
                        sheetNumbers.add((String) sheet);
                    }
                }
            } else if (sheetClaimValue instanceof String) {
                // Trường hợp sheetClaimValue là một giá trị duy nhất
                String sheet = (String) sheetClaimValue;
                sheetNumbers.add(sheet);
            }

            return sheetNumbers;
        } catch (Exception e) {
            // Handle error
            e.printStackTrace();
            return Collections.emptyList();
        }
    }

    // Lấy danh sách SheetTimeSlotDTO từ API
    public static List<SheetTimeSlotDTO> getSheetTimeSlots(boolean check) throws IOException {
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
        
        
        List<SheetTimeSlotDTO> sheetTimeSlots = new ArrayList<>();

        for (int i = 0; i < sheetNumbers.size(); i++) {
            String sheetNumber = sheetNumbers.get(i);
            String shiftStartTime = shiftStartTimes.get(i);
            String shiftEndTime = shiftEndTimes.get(i);
            SheetTimeSlotDTO sheetTimeSlot;
            if (check) {
                sheetTimeSlot = createSheetTimeSlotCheckin(sheetNumber, shiftStartTime, shiftEndTime);
            } else {
                sheetTimeSlot = createSheetTimeSlotCheckOut(sheetNumber, shiftStartTime, shiftEndTime);
            }

            sheetTimeSlots.add(sheetTimeSlot);
        }

        return sheetTimeSlots;
    }

    // Tạo đối tượng SheetTimeSlotDTO từ thông tin phiếu và chuỗi thời gian
    private static SheetTimeSlotDTO createSheetTimeSlotCheckin(String sheetNumber, String shiftStartTime, String shiftEndTime) {
        LocalTime startTime;
        LocalTime endTime;
        LocalTime shiftStartTimeLC;
//        LocalTime shiftEndTimeLC;
        
        
        try {
            startTime = LocalTime.parse(shiftStartTime).minusMinutes(checkInStart);
            endTime = LocalTime.parse(shiftEndTime).minusMinutes(checkInEnd);
            shiftStartTimeLC = LocalTime.parse(shiftStartTime);
//            shiftEndTimeLC = LocalTime.parse(shiftEndTime);
        } catch (DateTimeParseException e) {
            // Xử lý lỗi khi phân tích chuỗi thời gian
            e.printStackTrace();
            return null;
        }

        return new SheetTimeSlotDTO(sheetNumber, startTime, endTime, shiftStartTimeLC, null);
    }

    private static SheetTimeSlotDTO createSheetTimeSlotCheckOut(String sheetNumber, String shiftStartTime, String shiftEndTime) {
        LocalTime startTime;
        LocalTime endTime;
//        LocalTime shiftStartTimeLC;
        LocalTime shiftEndTimeLC;
        
        try {
            startTime = LocalTime.parse(shiftStartTime).plusHours(checkOutStart);
            endTime = LocalTime.parse(shiftEndTime).plusMinutes(checkOutEnd);
//            shiftStartTimeLC = LocalTime.parse(shiftStartTime);
            shiftEndTimeLC = LocalTime.parse(shiftEndTime);
        } catch (DateTimeParseException e) {
            // Xử lý lỗi khi phân tích chuỗi thời gian
            e.printStackTrace();
            return null;
        }

        return new SheetTimeSlotDTO(sheetNumber, startTime, endTime, null, shiftEndTimeLC);
    }

    //update worksheet
    public static boolean updateWorksheet(String idemp, String date, String update, String check) throws IOException {
        String url = "http://localhost/swp/api/ms/uco";
        URL urlObj = new URL(url);
        HttpURLConnection conn = (HttpURLConnection) urlObj.openConnection();
        conn.setRequestMethod("PUT");
        conn.setRequestProperty("Content-Type", "application/json");
        conn.setDoOutput(true);
        String jwt = "";
        if (check.equals("checkin")) {
            jwt = JWTUtils.generateJWTUWS(idemp, date, update, "TimeCheckIn");
        } else{
            jwt = JWTUtils.generateJWTUWS(idemp, date, update, "TimeCheckOut");
        }
        

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

}
