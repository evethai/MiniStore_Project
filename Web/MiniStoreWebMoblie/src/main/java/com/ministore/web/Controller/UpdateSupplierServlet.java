/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package com.ministore.web.Controller;

import com.ministore.web.DAO.SupplierDAO;
import com.ministore.web.DTO.SupplierDTO;
import jakarta.servlet.RequestDispatcher;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.SQLException;
import javax.naming.NamingException;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

/**
 *
 * @author daigi
 */
public class UpdateSupplierServlet extends HttpServlet {

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
//       
//        }
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
       SupplierDAO  dao = new SupplierDAO();
       try{
            String id = request.getParameter("Id");
//            String NameSup = request.getParameter("Id");
//            String Addr = request.getParameter("Id");
//            String Note = request.getParameter("Id");
            SupplierDTO dto = dao.getSupplierByID(id);
            request.setAttribute("pr", dto);
            
        }catch (SQLException ex) {
           log("errors Update Servlet" + ex.toString());
        } catch (NamingException ex) {
          
        } finally{
             request.getRequestDispatcher("components_update_supplier.jsp").forward(request,response);
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
        //   processRequest(request, response);
        String url = "components_update_supplier.jsp";
        SupplierDAO dao = new SupplierDAO();
        boolean result = false;
        try {
            String id = request.getParameter("txtIDSup");
            String NameSup = request.getParameter("txtNameSup");
            String Addre = request.getParameter("txtAddress");
            String Note = request.getParameter("txtNote");
            
            result = dao.UpdateSup(id, NameSup, Addre, Note);
            if(result){
                url = "ShowSupplierServlet";
            }
            
        } catch (SQLException ex) {
            log("errors Update Servlet" + ex.toString());
        } catch (NamingException ex) {

        } finally {
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
