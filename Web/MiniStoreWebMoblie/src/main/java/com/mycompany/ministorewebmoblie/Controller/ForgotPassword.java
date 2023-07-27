package com.mycompany.ministorewebmoblie.Controller;

import com.mycompany.ministorewebmoblie.Utils.MyUtils;
import java.io.IOException;
import java.util.Properties;
import java.util.Random;

import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.PasswordAuthentication;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;
import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;

public class ForgotPassword extends HttpServlet {

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        String email = request.getParameter("email");
        String action = (String) request.getParameter("actionform");
        RequestDispatcher dispatcher = null;
        int otpvalue = 0;
        HttpSession mySession = request.getSession();

        if (action.equals("back")) {
            dispatcher = request.getRequestDispatcher("Login");
            dispatcher.forward(request, response);
            return;
        }
        String oldpassword = MyUtils.checkEmail(email);
        if (oldpassword.equals("null")) {
            dispatcher = request.getRequestDispatcher("forgot-password.jsp");
            request.setAttribute("error", "Email chưa được đăng ký");
            dispatcher.forward(request, response);
            return;
        }
        if (email != null && !email.isEmpty()) {
            // Sending OTP
            Random rand = new Random();
            int otpLength = 6; // Độ dài của OTP
            int otpValue = rand.nextInt((int) Math.pow(10, otpLength));

            String to = email;
            final String from = "quangbmse160878@fpt.edu.vn"; // Update with your email address
            final String password = "abfqzeoeefkkqbpe"; // Update with your email password

            Properties props = new Properties();
            props.put("mail.smtp.host", "smtp.gmail.com");
            props.put("mail.smtp.port", "587");
            props.put("mail.smtp.auth", "true");
            props.put("mail.smtp.starttls.enable", "true");

            Session session = Session.getInstance(props, new javax.mail.Authenticator() {
                protected PasswordAuthentication getPasswordAuthentication() {
                    return new PasswordAuthentication(from, password);
                }
            });

            try {
                Message message = new MimeMessage(session);
                message.setFrom(new InternetAddress(from));
                message.setRecipients(Message.RecipientType.TO, InternetAddress.parse(to));
                StringBuilder emailContent = new StringBuilder();
                emailContent.append("Chào bạn,\n\n");
                emailContent.append("Bạn đã yêu cầu đặt lại mật khẩu cho tài khoản của mình.\n");
                emailContent.append("Dưới đây là mã OTP để xác nhận:\n\n");
                emailContent.append("Mã OTP: " + otpValue + "\n\n");
                emailContent.append("Mã OTP này sẽ chỉ có hiệu lực trong vòng 30 phút.\n");
                emailContent.append("Vui lòng đặt lại mật khẩu của bạn trước khi thời gian này kết thúc.\n");
                emailContent.append("Nếu bạn không yêu cầu đặt lại mật khẩu, xin vui lòng bỏ qua email này.\n\n");
                emailContent.append("Trân trọng,\nMini Store.");

                message.setSubject("Đặt lại mật khẩu - Mã OTP");
                message.setText(emailContent.toString());

                Transport.send(message);
                System.out.println("Message sent successfully");
            } catch (MessagingException e) {
                dispatcher = request.getRequestDispatcher("forgot-password.jsp");
                request.setAttribute("error", "Email is required");
                dispatcher.forward(request, response);
                return;
            }

            dispatcher = request.getRequestDispatcher("EnterOtp.jsp");
            request.setAttribute("message", "OTP đã được gửi đến email của bạn");
            mySession.setAttribute("otp", otpValue);
            mySession.setAttribute("email", email);
            mySession.setAttribute("oldpassword", oldpassword);
            dispatcher.forward(request, response);
        } else {
            dispatcher = request.getRequestDispatcher("forgot-password.jsp");
            request.setAttribute("error", "Email is required");
            dispatcher.forward(request, response);
        }
    }
}
