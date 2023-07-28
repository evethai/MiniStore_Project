/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package com.ministore.web.Controller;

import com.ministore.web.DAO.ProductDAO;
import java.io.IOException;
import java.io.PrintWriter;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.MultipartConfig;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.Part;
import java.io.InputStream;
import java.sql.Date;
import java.sql.SQLException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.naming.NamingException;

/**
 *
 * @author daigi
 */
 @MultipartConfig(maxFileSize = 1024 * 1024 * 5)
public class CrearteProductServlet extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
//    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
//            throws ServletException, IOException {
//        response.setContentType("text/html;charset=UTF-8");
//        
//    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
          ProductDAO dao = new ProductDAO();
          try {
               List<String> productTypes = dao.getAllProductTypes(); 
            if (productTypes != null) {
                request.setAttribute("productTypes", productTypes);
            } 
          }catch (SQLException ex) {
           log("errors Update Servlet" + ex.toString());
        } catch (NamingException ex) {
            
        } finally{
//              response.sendRedirect("showproduct");
          }
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
   
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        ProductDAO dao = new ProductDAO();
        boolean result = false;
           
         try {
           
        String sku = request.getParameter("txtSku");
        String type = request.getParameter("txtType");
        String NameProduct = request.getParameter("txtNameProduct");
        String IdSupplier = request.getParameter("txtIdSup");
        
//        String MFG = request.getParameter("txtMfg");
//        Date mfg = (Date) new SimpleDateFormat("yyyy-MM-dd").parse(MFG);
//        String EXP =  request.getParameter("txtExp");
//        Date exp = (Date)new SimpleDateFormat("yyyy-MM-dd").parse(EXP);
//        String dateImport =  request.getParameter("txtDateImport");
//        Date Dateimport =(Date) new SimpleDateFormat("yyyy-MM-dd").parse(dateImport);
        String MFG = request.getParameter("txtMfg");
        java.sql.Date mfg = java.sql.Date.valueOf(MFG);

        String EXP = request.getParameter("txtExp");
        java.sql.Date exp = java.sql.Date.valueOf(EXP);

        String dateImport = request.getParameter("txtDateImport");
        java.sql.Date dateIm = java.sql.Date.valueOf(dateImport);
        
        String status = request.getParameter("txtStatus");
//        String PictureProduct = request.getParameter("txtPicture");
        Part filePart = request.getPart("txtPicture");
        InputStream fileInputStream = filePart.getInputStream();
        String pictureBase64 = dao.convertImageToBase64(fileInputStream);
        boolean active = false;
         if (status !=null){
             active = true;
         }
          dao.CreateAcc(sku, type, NameProduct,IdSupplier, mfg,exp, dateIm, active, pictureBase64 );
                     
           
            
        } catch (SQLException ex) {
           log("errors Update Servlet" + ex.toString());
        } catch (NamingException ex) {
          
        } finally{
//             response.sendRedirect("components_manage_product.jsp");
//             if (result) {
                 response.sendRedirect("showproduct");
                 
//             }else {
//                 request.getRequestDispatcher("components_create_product.jsp").forward(request,response);
//             }
        }
        
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
