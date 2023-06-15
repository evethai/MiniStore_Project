/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.ministorewebmoblie;

import com.google.zxing.BarcodeFormat;
import com.google.zxing.MultiFormatWriter;
import com.google.zxing.WriterException;
import com.google.zxing.client.j2se.MatrixToImageWriter;
import com.google.zxing.common.BitMatrix;
import jakarta.servlet.ServletException;

import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;

/**
 *
 * @author nanat
 */
public class QRCodeServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html");
        // Lấy thông tin idemp và ngày giờ từ request
        String idemp = (String) request.getAttribute("IdEmpapi");
        String loginTime = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss").format(new Date());
        // Tạo URL cho QR code
        String qrCodeData = "IDEMP: " + idemp + "\n"
                + "Login Time: " + loginTime;

        // Tạo QR code
        int width = 200;
        int height = 200;
        String imageFormat = "png";
        BitMatrix bitMatrix;
        try {
            bitMatrix = new MultiFormatWriter().encode(qrCodeData, BarcodeFormat.QR_CODE, width, height);
        } catch (WriterException e) {
            throw new ServletException("Error generating QR code", e);
        }
        // Chuyển dữ liệu QR code thành byte array
        ByteArrayOutputStream baos = new ByteArrayOutputStream();
        MatrixToImageWriter.writeToStream(bitMatrix, imageFormat, baos);
        byte[] qrCodeBytes = baos.toByteArray();

        String qrCodeURL = "data:image/" + imageFormat + ";base64," + java.util.Base64.getEncoder().encodeToString(qrCodeBytes);
        request.setAttribute("qrCodeURL", qrCodeURL);

        request.getRequestDispatcher("qr-code.jsp").forward(request, response);
    }
}
