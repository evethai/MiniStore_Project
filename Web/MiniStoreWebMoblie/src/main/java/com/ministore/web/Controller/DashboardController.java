/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package com.ministore.web.Controller;

import com.ministore.web.DAO.CatalogyDAO;
import com.ministore.web.DAO.MemberDAO;
import com.ministore.web.DAO.OrderDAO;
import com.ministore.web.DAO.RevenueDAO;
import com.ministore.web.DAO.TopSellerDAO;
import com.mycompany.ministorewebmoblie.DTO.CatalogyDTO;
import com.mycompany.ministorewebmoblie.DTO.MemberDTO;
import com.mycompany.ministorewebmoblie.DTO.OrderDTO;
import com.mycompany.ministorewebmoblie.DTO.RevenueDTO;
import com.mycompany.ministorewebmoblie.DTO.TopSellerDTO;
import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import java.io.IOException;
import java.sql.Date;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Calendar;
import javax.naming.NamingException;

/**
 *
 * @author PC
 */
@WebServlet(name = "DashboardController", urlPatterns = {"/DashboardController"})
public class DashboardController extends HttpServlet {

    private final String HOME_PAGE = "home_ministore.jsp";

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
        response.setContentType("text/html;charset=UTF-8");
        String url = HOME_PAGE;
        try {
            HttpSession session = request.getSession();

            RevenueDAO daoR = new RevenueDAO();
            OrderDAO daoOr = new OrderDAO();
            TopSellerDAO daoT = new TopSellerDAO();
            MemberDAO daoM = new MemberDAO();
            CatalogyDAO daoC = new CatalogyDAO();
            //begin line chart
            ArrayList<RevenueDTO> revenues = daoR.get7DayRevenue();
            ArrayList<OrderDTO> orders = daoOr.getAllOrder();
            ArrayList<OrderDTO> orders7day = new ArrayList<>();
            int n = 0;
            for (RevenueDTO r : revenues) {
                OrderDTO dto = new OrderDTO();
                for (OrderDTO o : orders) {
                    if (isSameDay(o.getDateOrder(), r.getDateRevenues())) {
                        n++;
                    }
                }
                dto.setDateOrder(r.getDateRevenues());
                dto.setQuantity(n);
                orders7day.add(dto);
                n = 0;
            }
            session.setAttribute("REVENUESOF7DAY", revenues);
            session.setAttribute("ORDEROF7DAY", orders7day);
            //end line chart

            //begin top 5 product best seller
            ArrayList<OrderDTO> ordersTop5 = daoOr.get5MostUnit();
            ArrayList<TopSellerDTO> lt = new ArrayList<>();
            for (OrderDTO o : ordersTop5) {
                lt.add(daoT.getAProductTopSeller(o.getIdUnit()));
            }
            for (TopSellerDTO t : lt) {
                for (OrderDTO o : ordersTop5) {
                    if (t.getIdUnit().equals(o.getIdUnit())) {
                        t.setQuantity(o.getQuantity());
                        t.setRevenues(t.getPrice() * o.getQuantity());
                    }
                }
            }
            session.setAttribute("TOPSELLER", lt);
            //end best seller
            //Member
            ArrayList<MemberDTO> lm = daoM.getAllMember();
            request.setAttribute("MEMBER", lm.size());
            //End member

            //Revenues of month
            ArrayList<RevenueDTO> lr = daoR.getAllRevenue();
            Calendar calendar = Calendar.getInstance();
            int currentMonth = calendar.get(Calendar.MONTH) + 1; // Tháng được lấy từ 0 đến 11, nên cần cộng 1
            int CurYear = calendar.get(Calendar.YEAR);
            double rom = 0;
            for (RevenueDTO r : lr) {
                Date date = r.getDateRevenues();
                calendar.setTime(date);
                int month = calendar.get(Calendar.MONTH) + 1; // Tháng được lấy từ 0 đến 11, nên cần cộng 1
                int year = calendar.get(Calendar.YEAR);
                if (month == currentMonth && year == CurYear) {
                    rom += r.getTotalRevenueOfDay();
                }
            }
            request.setAttribute("ROM", rom);
            //end revenues of month
            //begin order total
            int numberOrder = 0;
            ArrayList<OrderDTO> lo = daoOr.getAllOrder();
            Calendar c = Calendar.getInstance();
            int curDate = c.get(Calendar.DATE);
            int curMonth = c.get(Calendar.MONTH) + 1;
            int curYear = c.get(Calendar.YEAR);
            System.out.println(curDate);
            for (OrderDTO o : lo) {
                Date date = o.getDateOrder();
                c.setTime(date);
                int today = c.get(Calendar.DATE);
                int toMonth = c.get(Calendar.MONTH) + 1;
                int toYear = c.get(Calendar.YEAR);
                if (today == curDate && toMonth == curMonth && toYear == curYear) {
                    numberOrder++;
                }
            }
            request.setAttribute("NUMORDERS", numberOrder);
            //end order total
            //begin Traffic
            ArrayList<CatalogyDTO> Ca_list = daoC.getAllCatalogy();
            ArrayList<CatalogyDTO> Ca_list_num = daoC.getAllNumOfCatalogy();
            ArrayList<CatalogyDTO> Ca_list_num_true = new ArrayList<>();
            int n_ca = 0;
            for (CatalogyDTO lc : Ca_list) {
                CatalogyDTO ca = new CatalogyDTO();
                for (CatalogyDTO lnc : Ca_list_num) {
                    if (lc.getId() == lnc.getId()) {
                        n_ca += lnc.getNumber();
                    }
                }
                ca.setId(lc.getId());
                ca.setNumber(n_ca);
                ca.setProductType(lc.getProductType());
                Ca_list_num_true.add(ca);
                n_ca = 0;
            }
            session.setAttribute("CATALOGY", Ca_list_num_true);
            //end Traffic
        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (NamingException ex) {
            ex.printStackTrace();
        } finally {
            RequestDispatcher rd = request.getRequestDispatcher(url);
            rd.forward(request, response);
        }
    }

    private boolean isSameDay(Date date1, Date date2) {
        return date1.toLocalDate().isEqual(date2.toLocalDate());
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
