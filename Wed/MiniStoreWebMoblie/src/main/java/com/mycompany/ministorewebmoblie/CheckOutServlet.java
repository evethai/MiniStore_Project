/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.ministorewebmoblie;

import com.mycompany.ministorewebmoblie.Utils.MyUtils;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;
import org.json.JSONObject;

/**
 *
 * @author nanat
 */
public class CheckOutServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html");
        HttpSession session = request.getSession();
        String check = "checkout";
        String idemp = (String) session.getAttribute("IdEmpapi");
        String checkDay = new SimpleDateFormat("yyyy-MM-dd").format(new Date());
        String checkTime = new SimpleDateFormat("HH:mm").format(new Date());
        String checkOutTime = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss").format(new Date());

        String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/fws?idemp=" + idemp + "&date=" + checkDay);

        // Phân tích phản hồi JSON
        JSONObject json = new JSONObject(jsonResponse);
        int sheet = json.getInt("Sheet");
        String checkoutTimeapi = json.getString("TimeCheckOut");
        if (sheet == 4 && checkTime.compareTo("18:00") >= 0 && checkTime.compareTo("18:15") < 0) {
            // Do something when sheet equals 4 and checkTime is between 5:45 and 7:15
            if (!checkoutTimeapi.equals("0001-01-01T00:00:00")) {
                request.setAttribute("errorMessage", "đã check In");
                request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            } else if (MyUtils.updateWorksheet(idemp, checkDay, checkOutTime, check)) {
                // Ghi dữ liệu thành công
                String qrCodeURL = MyUtils.generateQRCodeURL(idemp, checkOutTime);

                request.setAttribute("qrCodeURL", qrCodeURL);
                request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            } else {
                // Ghi dữ liệu thất bại
                // Xử lý lỗi tại đây
                request.setAttribute("errorMessage", "check in failed");
                request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            }
        } else if (sheet == 5 && checkTime.compareTo("6:00") >= 0 && checkTime.compareTo("6:15") < 0) {
            if (!checkoutTimeapi.equals("0001-01-01T00:00:00")) {
                request.setAttribute("errorMessage", "đã check In");
                request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            } else if (MyUtils.updateWorksheet(idemp, checkDay, checkOutTime, check)) {
                // Ghi dữ liệu thành công
                String qrCodeURL = MyUtils.generateQRCodeURL(idemp, checkOutTime);

                request.setAttribute("qrCodeURL", qrCodeURL);
                request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            } else {
                // Ghi dữ liệu thất bại
                // Xử lý lỗi tại đây
                request.setAttribute("errorMessage", "check in failed");
                request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            }
        } else {
            request.setAttribute("errorMessage", "không phải giờ check out");
            request.getRequestDispatcher("qr-code.jsp").forward(request, response);
        }

    }
}
