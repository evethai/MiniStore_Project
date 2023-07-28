/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package com.ministore.web.Controller;

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;
//import javax.servlet.ServletException;
//import javax.servlet.annotation.WebServlet;
//import javax.servlet.http.HttpServlet;
//import javax.servlet.http.HttpServletRequest;
//import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author DUY KHANH
 */
@WebServlet(name = "DispathController", urlPatterns = {"/DispathController"})
public class DispathController extends HttpServlet {
//private final String HOME_PAGE = "home_ministore.jsp";

    private final String WORKSHEET_MANAGEMENT = "WorksheetManagementServlet";
    private final String WORKSHEET_DETAILS = "SheetDetailsManagementServlet";
    private final String WORKSHEET_UPDATE = "WorksheetUpdateServlet";
    private final String DASHBOARD_CONTROLLER = "DashboardController";
    private final String SALARY_DETAIL = "SalaryController";

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String button = request.getParameter("btAction");
        String url = "#";
        try {
            if (button == null) {
                url = DASHBOARD_CONTROLLER;
            } else if (button.equals("Worksheet_Management")) {
                url = WORKSHEET_MANAGEMENT;
            } else if (button.equals("Details_Worksheet")) {
                url = WORKSHEET_DETAILS;
            } else if (button.equals("Update")) {
                url = WORKSHEET_UPDATE;
            } else if(button.equals("Salary_detail")){
                url = SALARY_DETAIL;
            }
        } finally {
            RequestDispatcher rd = request.getRequestDispatcher(url);
            rd.forward(request, response);
        }
    }

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
        processRequest(request, response);
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
        processRequest(request, response);
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
