/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package com.ministore.web.Controller;

import com.ministore.web.DAO.UnitDAO;
import com.ministore.web.DTO.UnitDTO;
import jakarta.servlet.RequestDispatcher;
import java.io.IOException;
import java.io.PrintWriter;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.sql.SQLException;
import javax.naming.NamingException;

/**
 *
 * @author daigi
 */
public class UpdateUnitServlet extends HttpServlet {

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
//        processRequest(request, response);
        UnitDAO dao = new UnitDAO();
        try{
            String id = request.getParameter("Id");
            UnitDTO dto = dao.getUnitByID(id);
            request.setAttribute("pr", dto);
        }catch (SQLException ex) {
           log("errors Update Servlet" + ex.toString());
        } catch (NamingException ex) {
          
        } finally{
             request.getRequestDispatcher("components_update_unit.jsp").forward(request,response);
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
//        processRequest(request, response);
        String url = "components_update_unit.jsp";
        UnitDAO dao = new UnitDAO();
        boolean result = false;
        try {
            String id = request.getParameter("txtIdUnit");
            String quantity = request.getParameter("TxtQuantity");
            String PriceExport = request.getParameter("txtPriceExport");
            int quant = Integer.parseInt(quantity);
            float price = Float.parseFloat(PriceExport);
            result = dao.updateProduct(id, quant, price);
            if(result){
                url = "ShowUnitServelet";
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
