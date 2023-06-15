package com.mycompany.ministorewebmoblie;

import com.mycompany.ministorewebmoblie.Utils.MyUtils;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import java.io.IOException;
import org.json.JSONException;
import org.json.JSONObject;

public class LoginServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        // Lấy username và password từ login.jsp
        String username = request.getParameter("txtusername");
        String password = request.getParameter("txtpassword");

        try {
            // Gửi yêu cầu GET đến API và nhận phản hồi
            String jsonResponse = MyUtils.sendGetRequest("http://localhost/swp/api/ms/facc?username=" + username + "&password=" + password);

            // Phân tích phản hồi JSON
            JSONObject json = new JSONObject(jsonResponse);
            String fullnameemapi = json.getString("FullNameEmp");
            String IdEmpapi = json.getString("IdEmp");
            String rolesapi = json.getString("Roles");
            boolean IsActiveapi = json.getBoolean("IsActive");
            if (IsActiveapi) {
                if (rolesapi.equals("Guard")) {
                    // Nếu password đúng, thiết lập thuộc tính và chuyển tiếp yêu cầu đến QRCodeServlet
                    HttpSession session = request.getSession();
                    session.setAttribute("fullnameemapi", "Welcome " + fullnameemapi);
                    session.setAttribute("IdEmpapi", IdEmpapi);
                    response.sendRedirect("qr-code.jsp");
                } else {
                    request.setAttribute("errorMessage", "Just Guard can join !!!");
                    request.getRequestDispatcher("Login.jsp").forward(request, response);
                }
            } else {
                request.setAttribute("errorMessage", "Account not active!!!");
                request.getRequestDispatcher("Login.jsp").forward(request, response);
            }

        } catch (JSONException e) {
            // Xử lý ngoại lệ phân tích JSON và hiển thị thông báo lỗi
            request.setAttribute("errorMessage", "Tên đăng nhập hoặc mật khẩu không chính xác");
            request.getRequestDispatcher("Login.jsp").forward(request, response);
        }
    }

}
