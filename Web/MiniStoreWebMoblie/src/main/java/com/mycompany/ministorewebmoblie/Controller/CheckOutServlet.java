package com.mycompany.ministorewebmoblie.Controller;

import com.mycompany.ministorewebmoblie.DTO.SheetTimeSlotDTO;
import com.mycompany.ministorewebmoblie.Utils.JWTUtils;
import com.mycompany.ministorewebmoblie.Utils.MyUtils;
import io.jsonwebtoken.Claims;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import java.io.IOException;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.util.List;
import org.json.JSONObject;

public class CheckOutServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html");
        HttpSession session = request.getSession();
        String idemp = (String) session.getAttribute("IdEmpapi");
//        String checkDay = LocalDateTime.now().format(DateTimeFormatter.ofPattern("yyyy-MM-dd"));
        String dateapi = (String) session.getAttribute("DateApi");
        String sheetapi = (String) session.getAttribute("sheetApi");
        String checkOutTime = LocalDateTime.now().format(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss"));
        LocalTime checkTime = LocalTime.now();
        String timeCOut = null;

        String check = "checkout";
//        if (checkTime.isAfter(LocalTime.MIDNIGHT) && checkTime.isBefore(LocalTime.MIDNIGHT.plusMinutes(30))) {
//            LocalDate previousDate = LocalDate.parse(checkDay).minusDays(1);
//            checkDay = previousDate.format(DateTimeFormatter.ofPattern("yyyy-MM-dd"));
////            checkOutTime = LocalDateTime.of(previousDate, LocalTime.MAX).format(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss"));
//        }
        String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/fws?idemp=" + idemp + "&date=" + dateapi);
        JSONObject json = null;
        try {
            json = new JSONObject(jsonResponse);
        } catch (Exception e) {
            // Handle JSON parsing error
            if (idemp == null || idemp.isEmpty()) {
                request.setAttribute("errorMessage", "Đã hết phiên làm việc hãy đăng nhập lại!!!");
                request.getRequestDispatcher("Login.jsp").forward(request, response);
                return;
            } else {
                request.setAttribute("errorMessage", "không có ca trong ngày hôm nay");
                request.getRequestDispatcher("qr-code.jsp").forward(request, response);
                return;
            }
        }

        String jwt = json.getString("jwt");

        if (jwt.equals("Unauthorized")) {
            // Invalid user
            request.setAttribute("errorMessage", "Invalid credentials");
            request.getRequestDispatcher("Login.jsp").forward(request, response);
            return;
        }

        Claims claims = JWTUtils.parseJWT(jwt);
//        String checkoutTimeapi = claims.get("TimeCheckOut", String.class);
//        String sheet = claims.get("Sheet", String.class);

        boolean isCheckOutTimeValid = false;
        String coeffi = "";
        // Lấy danh sách SheetTimeSlotDTO từ API
        List<SheetTimeSlotDTO> sheetTimeSlots = MyUtils.getSheetTimeSlots(false);

        if (!sheetTimeSlots.isEmpty()) {

            for (SheetTimeSlotDTO slot : sheetTimeSlots) {
                LocalTime startTime = slot.getStartTime();
                LocalTime endTime = slot.getEndTime();
                LocalTime shiftEndTime = slot.getShiftEndTime();
                coeffi = slot.getCoefficientsSalary();
                if (sheetapi.equals(slot.getSheet())) {
                    // Check if the end time is on the next day
                    if (startTime.isAfter(endTime)) {
                        // Check if the check time is after the start time or before the end of the day
                        if (checkTime.isBefore(endTime) || checkTime.isAfter(startTime)) {
                            isCheckOutTimeValid = true;
                            if (checkTime.isBefore(endTime) && checkTime.isAfter(LocalTime.MIN)) {
//                                LocalDate nextDate = LocalDate.parse(checkDay).minusDays(1);
//                                checkDay = nextDate.format(DateTimeFormatter.ofPattern("yyyy-MM-dd"));
                                LocalDate date = LocalDate.parse(dateapi);
                                checkOutTime = LocalDateTime.of(date, shiftEndTime).format(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss"));
                                timeCOut = LocalDateTime.of(date, shiftEndTime).format(DateTimeFormatter.ofPattern("dd/MM/yyyy hh:mm:ss a"));
                            }
                            break;
                        }
                    } else {
                        // Check if the check time is between the start time and end time
                        if (checkTime.isAfter(startTime) && checkTime.isBefore(endTime)) {
                            isCheckOutTimeValid = true;
                            if (checkTime.isAfter(shiftEndTime) && checkTime.isBefore(endTime)) {
                                LocalDate localDate = LocalDate.parse(dateapi, DateTimeFormatter.ofPattern("yyyy-MM-dd"));
                                LocalDateTime checkoutDateTime = LocalDateTime.of(localDate, shiftEndTime);
                                checkOutTime = checkoutDateTime.format(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss"));
                                DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy hh:mm:ss a");
                                String formattedDateTime = checkoutDateTime.format(formatter);
                            }
                            break;
                        }
                    }
                }
            }
            if (!isCheckOutTimeValid) {
                request.setAttribute("errorMessage", "không phải giờ check out");
                request.getRequestDispatcher("qr-code.jsp").forward(request, response);
                return;
            }
        } else {
            request.setAttribute("errorMessage", "không phải giờ check out");
            request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            return;
        }
        // Check if the check-in time is valid
        String Status = claims.get("Status", String.class);
        if (Status.equals("False")) {
            request.setAttribute("errorMessage", "Chưa check in vui lòng check in trước");
            request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            return;
        }
        if (isCheckOutTimeValid) {
            jwt = MyUtils.updateWorksheetQR(idemp, dateapi, checkOutTime, check, coeffi);
            if (jwt != null) {
                String qrCodeURL = MyUtils.generateQRCodeURLG(jwt);
                session.setAttribute("TimeCheckOutapi", checkOutTime);
                request.setAttribute("qrCodeURL", qrCodeURL);
            } else {
                request.setAttribute("errorMessage", "check out failed");
            }
        } else {
            request.setAttribute("errorMessage", "không phải giờ check out");
        }

        request.getRequestDispatcher("ShowList").forward(request, response);
    }
}
