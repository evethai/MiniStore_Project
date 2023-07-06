package com.mycompany.ministorewebmoblie.Controller;

import com.mycompany.ministorewebmoblie.Utils.JWTUtils;
import com.mycompany.ministorewebmoblie.Utils.MyUtils;
import io.jsonwebtoken.Claims;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import java.io.IOException;
import org.json.JSONObject;

public class newPassword extends HttpServlet {

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String password = request.getParameter("password");
        String confPassword = request.getParameter("confPassword");
        HttpSession session = request.getSession();

        if (!password.equals(confPassword)) {
            request.setAttribute("errorMessage", "Mật khẩu nhập lại và mật khẩu mới không giống nhau");
            request.getRequestDispatcher("newPassword.jsp").forward(request, response);
            return;
        }
        try {
            
//            session.setAttribute("IdEmpapi", IdEmpapi);
            request.getRequestDispatcher("ShowList").forward(request, response);
        } catch (Exception e) {
            request.setAttribute("errorMessage", "Tên đăng nhập hoặc mật khẩu không chính xác");
            request.getRequestDispatcher("newPassword.jsp").forward(request, response);
        }
    }

}
