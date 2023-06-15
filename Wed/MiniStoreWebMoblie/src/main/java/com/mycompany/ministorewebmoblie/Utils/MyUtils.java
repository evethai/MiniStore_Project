/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.ministorewebmoblie.Utils;

import com.google.zxing.BarcodeFormat;
import com.google.zxing.MultiFormatWriter;
import com.google.zxing.WriterException;
import com.google.zxing.client.j2se.MatrixToImageWriter;
import com.google.zxing.common.BitMatrix;
import jakarta.servlet.ServletException;
import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Base64;
import org.json.JSONObject;

/**
 *
 * @author nanat
 */
public class MyUtils {

    // Gửi yêu cầu GET và trả về phản hồi dạng chuỗi JSON
    public static String sendGetRequest(String apiUrl) throws IOException {
        HttpURLConnection conn = null;
        try {
            URL url = new URL(apiUrl);
            conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");
            conn.setRequestProperty("Accept", "application/json");

            if (conn.getResponseCode() != 200) {
                throw new RuntimeException("Lỗi: Mã lỗi HTTP: " + conn.getResponseCode());
            }

            BufferedReader br = new BufferedReader(new InputStreamReader(conn.getInputStream()));
            StringBuilder responseBuilder = new StringBuilder();
            String line;
            while ((line = br.readLine()) != null) {
                responseBuilder.append(line);
            }
            return responseBuilder.toString();
        } finally {
            if (conn != null) {
                conn.disconnect();
            }
        }
    }

    // tạo qrcode url
    public static String generateQRCodeURL(String idemp, String Time) throws ServletException {
        String qrCodeData = "IDEMP: " + idemp + "\n"
                + "Login Time: " + Time;

        int width = 200;
        int height = 200;
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

    //update worksheet
    public static boolean updateWorksheet(String idemp, String date, String update, String check) throws IOException {
        String url = "http://localhost/swp/api/ms/uci";
        URL urlObj = new URL(url);
        HttpURLConnection conn = (HttpURLConnection) urlObj.openConnection();
        conn.setRequestMethod("PUT");
        conn.setRequestProperty("Content-Type", "application/json");
        conn.setDoOutput(true);

        JSONObject jsonObject = new JSONObject();
        if (check.equals("checkin")) {
            jsonObject.put("TimeCheckIn", update);
        } else {
            jsonObject.put("TimeCheckOut", update);
        }
        jsonObject.put("IdEmp", idemp);
        jsonObject.put("Date", date);

        String jsonString = jsonObject.toString();

        DataOutputStream outputStream = new DataOutputStream(conn.getOutputStream());
        outputStream.writeBytes(jsonString);
        outputStream.flush();
        outputStream.close();

        int responseCode = conn.getResponseCode();
        if (responseCode == HttpURLConnection.HTTP_OK) {
//           Dữ liệu đã được đưa vào database thành công.
            return true;
        } else {
//            System.out.println("Lỗi HTTP: " + responseCode);
            return false;
        }
    }
}
