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
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import org.json.JSONObject;

public class CheckInServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html");
        HttpSession session = request.getSession();
        String idemp = (String) session.getAttribute("IdEmpapi");
        String date = new SimpleDateFormat("yyyy-MM-dd").format(new Date());
        String checkinTime = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss").format(new Date());
        LocalTime checkTime = LocalTime.now();

        // Check if employee already checked in
        String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/fws?idemp=" + idemp + "&date=" + date);
        JSONObject json = null;
        try {
            json = new JSONObject(jsonResponse);
        } catch (Exception e) {
            // Handle JSON parsing error
        }

        if (json != null) {
            // Employee has already checked in
            request.setAttribute("errorMessage", "đã check In");
            request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            return;
        }

        // Lấy danh sách SheetTimeSlot từ API
        List<SheetTimeSlot> sheetTimeSlots = MyUtils.getSheetTimeSlots();

        String sheet = "";

        // Kiểm tra thời gian check-in trong danh sách sheetTimeSlots
        for (SheetTimeSlot slot : sheetTimeSlots) {
            if (checkTime.isAfter(slot.getStartTime()) && checkTime.isBefore(slot.getEndTime())) {
                // Thực hiện check-in cho sheet hiện tại
                sheet = slot.getSheet();
                break;
            }
        }

        if (sheet.isEmpty()) {
            // Invalid check-in time
            request.setAttribute("errorMessage", "không phải giờ check in");
            request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            return;
        }

        if (MyUtils.AddWorksheet(idemp, date, sheet, checkinTime)) {
            // Check-in successful
            String qrCodeURL = MyUtils.generateQRCodeURL(idemp, checkinTime);
            request.setAttribute("qrCodeURL", qrCodeURL);
            request.getRequestDispatcher("qr-code.jsp").forward(request, response);
        } else {
            // Check-in failed
            request.setAttribute("errorMessage", "check in failed");
            request.getRequestDispatcher("qr-code.jsp").forward(request, response);
        }
    }
}
