package com.mycompany.ministorewebmoblie;

import com.mycompany.ministorewebmoblie.Utils.MyUtils;
import io.jsonwebtoken.Claims;
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
            JSONObject json = new JSONObject(jsonResponse);
            String jwt = json.getString("jwt");
            // Kiểm tra phản hồi từ API
            if (jwt.equals("Unauthorized")) {
                // Người dùng không hợp lệ
                request.setAttribute("errorMessage", "Invalid credentials");
                request.getRequestDispatcher("Login.jsp").forward(request, response);
            }

            // Phân tích phản hồi JSON và tạo JWT
            Claims claims = MyUtils.parseJWT(jwt);
            String fullnameemapi = claims.get("FullNameEmp", String.class);
            String IdEmpapi = claims.get("IdEmp", String.class);
            String rolesapi = claims.get("Roles", String.class);
            String IsActiveapi = claims.get("IsActive", String.class);
            if (IsActiveapi.equals("True")) {
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
