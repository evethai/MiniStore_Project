package com.mycompany.ministorewebmoblie.Utils;

import com.google.zxing.BarcodeFormat;
import com.google.zxing.MultiFormatWriter;
import com.google.zxing.WriterException;
import com.google.zxing.client.j2se.MatrixToImageWriter;
import com.google.zxing.common.BitMatrix;
import com.mycompany.ministorewebmoblie.DTO.EmployeeDTO;
import com.mycompany.ministorewebmoblie.DTO.SheetTimeSlotDTO;
import com.mycompany.ministorewebmoblie.DTO.WorksheetDTO;
import io.jsonwebtoken.Claims;
import jakarta.servlet.ServletException;
import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.text.SimpleDateFormat;
import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;
import java.util.ArrayList;
import java.util.Base64;
import java.util.Collections;
import java.util.Date;
import java.util.List;
import org.json.JSONException;
import org.json.JSONObject;

public class MyUtils {

    private static final int checkInStart = 15;  //minus Minutes
    private static final int checkInEnd = 0;    //minus Minutes
    private static final int checkOutStart = 0; //hours minus
    private static final int checkOutEnd = 30;   //minus plus

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

    // tổng total time 
    public static String sumTotalTime(List<WorksheetDTO> ListWS) throws IOException {
        try {
            int totalHours = 0;
            int totalMinutes = 0;
            int totalSeconds = 0;

            for (WorksheetDTO worksheet : ListWS) {
                String total = worksheet.getTotal();
                if (total != null && total.matches("\\d{2}:\\d{2}:\\d{2}")) {
                    String[] parts = total.split(":");
                    int hours = Integer.parseInt(parts[0]);
                    int minutes = Integer.parseInt(parts[1]);
                    int seconds = Integer.parseInt(parts[2]);

                    totalHours += hours;
                    totalMinutes += minutes;
                    totalSeconds += seconds;
                }
            }

            totalMinutes += totalSeconds / 60;
            totalSeconds = totalSeconds % 60;

            totalHours += totalMinutes / 60;
            totalMinutes = totalMinutes % 60;

            return String.format("%02d:%02d:%02d", totalHours, totalMinutes, totalSeconds);
        } catch (Exception e) {
            return null;
        }
    }

    //kiểm tra email có tồn tại trong data base hay không
    public static EmployeeDTO getInfo(String idemp) throws IOException {
        try {
            // Lấy danh sách Sheet từ API
            String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/faccInfo?idemp=" + idemp);
            JSONObject json = new JSONObject(jsonResponse);

            String jwt = json.optString("jwt");
            // Check JWT
            if (jwt.isEmpty() || jwt.equals("Unauthorized")) {
                // Invalid user
                System.out.println("Invalid JWT");
                return null;
            }

            Claims claims = JWTUtils.parseJWT(jwt);
            // Convert the claim value to a string manually
            String sex = claims.get("Sex", String.class);
            if (sex.equals("False")) {
                sex = "Male";
            } else {
                sex = "Female";
            }
            String cccd = claims.get("CCCD", String.class);
            String dbo = claims.get("DoB", String.class);
            String address = claims.get("AddressEmp", String.class);
            String phone = claims.get("Phone", String.class);
            String pass = claims.get("password", String.class);
            String picture = claims.get("Picture", String.class);
            String email = claims.get("Email", String.class);

            return new EmployeeDTO(sex, cccd, dbo, address, phone, pass, picture, email);
        } catch (Exception e) {
            // Handle error
            e.printStackTrace();
            return null;
        }
    }

    //cập nhật mật khẩu
    public static boolean updatePassword(String email, String password) throws IOException {
        try {
            // Lấy danh sách Sheet từ API
            String token = JWTUtils.generateJWTUpPwd(email, password);
            String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/uppwd?token=" + token);
            JSONObject json = new JSONObject(jsonResponse);

            String jwt = json.optString("jwt");

            // Check JWT
            if (jwt.isEmpty() || jwt.equals("Unauthorized")) {
                // Invalid user
                System.out.println("Invalid JWT");
                return true;
            }

            Claims claims = JWTUtils.parseJWT(jwt);

            // Convert the claim value to a string manually
            String fin = claims.get("Fin", String.class);
            if (fin.equals("Successfully")) {
                return true;
            }
            return false;
        } catch (Exception e) {
            // Handle error
            e.printStackTrace();
            return true;
        }
    }

    public static String getTotalTime(String idemp, String date) throws IOException {
        try {
            // Lấy danh sách Sheet từ API
            String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/fws?idemp="+idemp.trim()+"&date="+ date.trim());
            JSONObject json = new JSONObject(jsonResponse);

            String jwt = json.optString("jwt");

            // Check JWT
            if (jwt.isEmpty() || jwt.equals("Unauthorized")) {
                // Invalid user
                System.out.println("Invalid JWT");
                return "null";
            }

            Claims claims = JWTUtils.parseJWT(jwt);
            // Convert the claim value to a string manually
            String Total = claims.get("Total_working_hours", String.class);
            
            if (Total == null) {
                return "null";
            }

            return Total;
        } catch (Exception e) {
            // Handle error
            e.printStackTrace();
            return "null";
        }
    }

    //kiểm tra email có tồn tại trong data base hay không
    public static String checkEmail(String Email) throws IOException {
        try {
            // Lấy danh sách Sheet từ API
            String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/gp?mail=" + Email);
            JSONObject json = new JSONObject(jsonResponse);

            String jwt = json.optString("jwt");

            // Check JWT
            if (jwt.isEmpty() || jwt.equals("Unauthorized")) {
                // Invalid user
                System.out.println("Invalid JWT");
                return "null";
            }

            Claims claims = JWTUtils.parseJWT(jwt);

            // Convert the claim value to a string manually
            String Password = claims.get("Password", String.class);
            if (Password.equals("null")) {
                return "null";
            }

            return Password;
        } catch (Exception e) {
            // Handle error
            e.printStackTrace();
            return "null";
        }
    }

    // Lấy danh sách Sheet đã có từ API
    public static List<WorksheetDTO> getSheetAvailable(String idemp, String dateStar, String dateEnd, boolean type) {
        try {
            // Lấy danh sách Sheet từ API
            String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/fwsd?idemp=" + idemp + "&dateStar=" + dateStar + "&dateEnd=" + dateEnd);
            JSONObject json = new JSONObject(jsonResponse);

            String jwt = json.optString("jwt");

            // Check JWT
            if (jwt.isEmpty() || jwt.equals("Unauthorized")) {
                // Invalid user
                System.out.println("Invalid JWT");
                return Collections.emptyList();
            }

            Claims claims = JWTUtils.parseJWT(jwt);

            // Convert the claim value to a list manually
            List<String> Datejwt = claims.get("Date", List.class);
            List<String> TimeCheckInjwt = claims.get("TimeCheckIn", List.class);
            List<String> TimeCheckOutjwt = claims.get("TimeCheckOut", List.class);
            List<String> Totaljwt = claims.get("Total_working_hours", List.class);

            List<WorksheetDTO> sheetTimeSlots = new ArrayList<>();

            for (int i = 0; i < Datejwt.size(); i++) {
                String date = Datejwt.get(i);
                String timeCheckIn = TimeCheckInjwt.get(i);
                String timeCheckOut = TimeCheckOutjwt.get(i);
                String total = Totaljwt.get(i);

                WorksheetDTO sheetTimeSlot = new WorksheetDTO(date, timeCheckIn, timeCheckOut, total);
                sheetTimeSlots.add(sheetTimeSlot);
            }
            if (!type) {
                Collections.reverse(sheetTimeSlots);
            }

            return sheetTimeSlots;
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
        List<String> CheckNights = claims.get("CheckNight", List.class);
        List<String> CoefficientsSalarys = claims.get("CoefficientsSalary", List.class);

        List<SheetTimeSlotDTO> sheetTimeSlots = new ArrayList<>();

        for (int i = 0; i < sheetNumbers.size(); i++) {
            String sheetNumber = sheetNumbers.get(i);
            String shiftStartTime = shiftStartTimes.get(i);
            String shiftEndTime = shiftEndTimes.get(i);
            String CheckNight = CheckNights.get(i);
            String CoefficientsSalary = CoefficientsSalarys.get(i);
            SheetTimeSlotDTO sheetTimeSlot;
            if (check) {
                sheetTimeSlot = createSheetTimeSlotCheckin(sheetNumber, shiftStartTime, shiftEndTime, CheckNight, CoefficientsSalary);
            } else {
                sheetTimeSlot = createSheetTimeSlotCheckOut(sheetNumber, shiftStartTime, shiftEndTime, CheckNight, CoefficientsSalary);
            }

            sheetTimeSlots.add(sheetTimeSlot);
        }

        return sheetTimeSlots;
    }

    // Tạo đối tượng SheetTimeSlotDTO từ thông tin phiếu và chuỗi thời gian
    private static SheetTimeSlotDTO createSheetTimeSlotCheckin(String sheetNumber, String shiftStartTime, String shiftEndTime, String checkNoght, String CoefficientsSalary) {
        LocalTime startTime;
        LocalTime endTime;
        LocalTime shiftStartTimeLC;
        LocalTime shiftEndTimeLC;
        try {
            startTime = LocalTime.parse(shiftStartTime).minusMinutes(checkInStart);
            endTime = LocalTime.parse(shiftEndTime).minusMinutes(checkInEnd);
            shiftStartTimeLC = LocalTime.parse(shiftStartTime);
            shiftEndTimeLC = LocalTime.parse(shiftEndTime);
        } catch (DateTimeParseException e) {
            // Xử lý lỗi khi phân tích chuỗi thời gian
            e.printStackTrace();
            return null;
        }

        return new SheetTimeSlotDTO(sheetNumber, startTime, endTime, shiftStartTimeLC, shiftEndTimeLC, checkNoght, CoefficientsSalary);
    }

    // Tạo đối tượng SheetTimeSlotDTO từ thông tin phiếu và chuỗi thời gia
    private static SheetTimeSlotDTO createSheetTimeSlotCheckOut(String sheetNumber, String shiftStartTime, String shiftEndTime, String checkNoght, String CoefficientsSalary) {
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

        return new SheetTimeSlotDTO(sheetNumber, startTime, endTime, null, shiftEndTimeLC, checkNoght, CoefficientsSalary);
    }

    //update worksheet
    public static String updateWorksheetQR(String idemp, String date, String update, String check, String coeffi) throws IOException {
        String jwt = "";
        String sunday = "";
        if (check.equals("checkin")) {
            jwt = JWTUtils.generateJWTUWS(idemp, date, update, "TimeCheckIn", coeffi, sunday);
        } else {
            jwt = JWTUtils.generateJWTUWS(idemp, date, update, "TimeCheckOut", coeffi, sunday);
        }

        if (jwt == null || jwt.isEmpty()) {
            return null;
        }

        return jwt;
    }

    //kiem tra xem co phai chu nhat hay khong
    private String isSunday(String date) {
        String sunday = "";

        // Chuyển đổi chuỗi thành LocalDate
        LocalDate localDate = LocalDate.parse(date);

        // Kiểm tra xem ngày đó có phải là Chủ nhật hay không
        boolean isSunday = localDate.getDayOfWeek() == DayOfWeek.SUNDAY;
        if (isSunday) {
            sunday = "true";
        }

        return sunday;
    }

    // tạo qr code chứa api jwt để update
    public static String generateQRCodeURLG(String jwt) throws ServletException {
        String qrCodeData = "http://localhost/swp/api/ms/uco/ucoqrG?token=" + jwt;

        int width = 300;
        int height = 300;
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
