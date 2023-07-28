/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package com.ministore.web.Controller;

import com.ministore.web.DAO.ErrorManageProduct;
import com.ministore.web.DAO.ProductDAO;
import com.ministore.web.DTO.ProductDTO;
import jakarta.servlet.RequestDispatcher;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.SQLException;
import java.util.List;
import javax.naming.NamingException;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.MultipartConfig;
//import javax.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.Part;
import java.io.InputStream;

/**
 *
 * @author daigi
 */
 @MultipartConfig(maxFileSize = 1024 * 1024 * 5)
public class UpdateProductsServlet extends HttpServlet {

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
////        response.setContentType("text/html;charset=UTF-8");
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
       // processRequest(request, response);
        
       
       ProductDAO dao = new ProductDAO();
       try {
           String id = request.getParameter("Id");
//            System.out.println("ttttt" + id);
           ProductDTO dto = dao.getProductBySKU(id);
          
           request.setAttribute("pr", dto);
          
            List<String> productTypes = dao.getAllProductTypes(); 
            request.setAttribute("productTypes", productTypes);
            
            List<String> IdSup = dao.GetallIdSup();
            request.setAttribute("nameSupplier", IdSup);
           
        } catch (SQLException ex) {
           log("errors Update Servlet" + ex.toString());
        } catch (NamingException ex) {
          
        } finally{
             request.getRequestDispatcher("components_update_product.jsp").forward(request,response);
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
       String url = "components_update_product.jsp";
        ProductDAO dao = new ProductDAO();
        boolean result = false;
         try {
        String sku = request.getParameter("txtSkuProduct");
        String type = request.getParameter("txtTypeProduct");
        String NameProduct = request.getParameter("TxtNameProduct");
        String IdSupplier = request.getParameter("txtIdSupplier");
        String Status = request.getParameter("txtStatus");
        boolean statusP = Boolean.parseBoolean(Status);
        ErrorManageProduct errors = new ErrorManageProduct();
        boolean foundErros = false;
        Part filePart = request.getPart("newPictureFile");
        InputStream fileInputStream = filePart.getInputStream();
        String pictureBase64 = dao.convertImageToBase64(fileInputStream);
         if (NameProduct.trim().length()<1 ){
             foundErros = true;
               errors.setNameProductErrorCharracter("Name Product is required input >= 1 characters");
         }
         if(foundErros){
                 request.setAttribute("UPDATE_ERRORS", errors);
        }else {
             result= dao.updateProduct(sku, type, NameProduct,IdSupplier , statusP,pictureBase64);
              if (result) {
//                 response.sendRedirect("showproduct");
                   url = "showproduct";
                 
             }
         }
            
        } catch (SQLException ex) {
           log("errors Update Servlet" + ex.toString());
        } catch (NamingException ex) {
          
        } finally{
//             response.sendRedirect("components_manage_product.jsp");
//             if (result) {
//                 response.sendRedirect("showproduct");
//                 
//             }else {
//                 request.getRequestDispatcher("components_update_product.jsp").forward(request,response);
//             }
          RequestDispatcher rd = request.getRequestDispatcher(url);
          rd.forward(request, response);
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
