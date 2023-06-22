package com.mycompany.ministorewebmoblie.Controller;

import com.mycompany.ministorewebmoblie.DTO.SheetTimeSlot;
import com.mycompany.ministorewebmoblie.Utils.JWTUtils;
import com.mycompany.ministorewebmoblie.Utils.MyUtils;
import io.jsonwebtoken.Claims;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.time.LocalTime;
import java.util.Date;
import java.util.List;
import org.json.JSONObject;

public class CheckOutServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html");
        HttpSession session = request.getSession();
        String idemp = (String) session.getAttribute("IdEmpapi");
        String checkDay = new SimpleDateFormat("yyyy-MM-dd").format(new Date());
        String checkOutTime = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss").format(new Date());
        LocalTime checkTime = LocalTime.now();
        LocalTime timeS4OutF = LocalTime.parse("09:00");
        LocalTime timeS4OutL = LocalTime.parse("18:30");
        LocalTime timeS5OutF = LocalTime.parse("06:00");
        LocalTime timeS5OutL = LocalTime.parse("06:30");

        String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/fws?idemp=" + idemp + "&date=" + checkDay);
        JSONObject json = null;
        try {
            json = new JSONObject(jsonResponse);
        } catch (Exception e) {
            // Handle JSON parsing error
        }
        String jwt = json.getString("jwt");

        if (jwt.equals("Unauthorized")) {
            // Invalid user
            request.setAttribute("errorMessage", "Invalid credentials");
            request.getRequestDispatcher("Login.jsp").forward(request, response);
            return;
        }

        Claims claims = JWTUtils.parseJWT(jwt);
        String checkoutTimeapi = claims.get("TimeCheckOut", String.class);
        String sheet = claims.get("Sheet", String.class);

        List<SheetTimeSlot> sheetTimeSlots = MyUtils.getSheetTimeSlots();
        boolean isCheckOutTimeValid = false;

        for (SheetTimeSlot sheetTimeSlot : sheetTimeSlots) {
            String slotSheet = sheetTimeSlot.getSheet();
            LocalTime slotStartTime = sheetTimeSlot.getStartTime();
            LocalTime slotEndTime = sheetTimeSlot.getEndTime();

            if (sheet.equals(slotSheet) && checkTime.isAfter(slotStartTime) && checkTime.isBefore(slotEndTime)) {
                isCheckOutTimeValid = true;
                break;
            }
        }
        if (!checkoutTimeapi.equals("01/01/0001 00:00:00")) {
            request.setAttribute("errorMessage", "đã check Out");
        } else if (isCheckOutTimeValid) {
            if (MyUtils.updateWorksheet(idemp, checkDay, checkOutTime)) {
                String qrCodeURL = MyUtils.generateQRCodeURL(idemp, checkOutTime);
                request.setAttribute("qrCodeURL", qrCodeURL);
            } else {
                request.setAttribute("errorMessage", "check out failed");
            }
        } else {
            request.setAttribute("errorMessage", "không phải giờ check out");
        }

        request.getRequestDispatcher("qr-code.jsp").forward(request, response);
    }
}
