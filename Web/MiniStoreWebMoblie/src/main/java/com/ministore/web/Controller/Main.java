/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.Controller;

import com.ministore.web.DAO.CatalogyDAO;
import com.ministore.web.DAO.MemberDAO;
import com.ministore.web.DAO.OrderDAO;
import com.ministore.web.DAO.ProductDAO;
import com.ministore.web.DAO.RevenueDAO;
import com.ministore.web.DAO.SalaryDAO;
import com.ministore.web.DAO.TopSellerDAO;
import com.ministore.web.DAO.UnitDAO;
import com.mycompany.ministorewebmoblie.DTO.CatalogyDTO;
import com.mycompany.ministorewebmoblie.DTO.MemberDTO;
import com.mycompany.ministorewebmoblie.DTO.OrderDTO;
import com.mycompany.ministorewebmoblie.DTO.ProductDTO;
import com.mycompany.ministorewebmoblie.DTO.RevenueDTO;
import com.mycompany.ministorewebmoblie.DTO.SalaryDTO;
import com.mycompany.ministorewebmoblie.DTO.TopSellerDTO;
import com.mycompany.ministorewebmoblie.DTO.UnitDTO;
import java.sql.Date;
import java.util.ArrayList;
import java.util.Calendar;

/**
 *
 * @author PC
 */
public class Main {

    private static boolean isSameDay(Date date1, Date date2) {
        return date1.toLocalDate().isEqual(date2.toLocalDate());
    }

    public static void main(String[] args) throws Exception {

//        RevenueDAO daoR = new RevenueDAO();
//        ArrayList<RevenueDTO> lr = daoR.getAllRevenue();
//        Calendar calendar = Calendar.getInstance();
//        int currentMonth = calendar.get(Calendar.MONTH) + 1; // Tháng được lấy từ 0 đến 11, nên cần cộng 1
//        double rom = 0;
//        for (RevenueDTO r : lr) {
//            Date date = r.getDateRevenues();
//            calendar.setTime(date);
//            int month = calendar.get(Calendar.MONTH) + 1; // Tháng được lấy từ 0 đến 11, nên cần cộng 1
//
//            if (month == currentMonth) {
//                rom += r.getTotalRevenueOfDay();
//            }
//        }
//        System.out.println(rom);
        ///////////
////        RevenueDAO daoR = new RevenueDAO();
//        OrderDAO daoOr = new OrderDAO();
//
//        //begin line chart
////        ArrayList<RevenueDTO> revenues = daoR.get7DayRevenue();
//        ArrayList<OrderDTO> orders = daoOr.getAllOrder();
//
//
//        int n = 0;
//        for (RevenueDTO r : revenues) {
//            for (OrderDTO o : orders) {
//                if (isSameDay(o.getDateOrder(), r.getDateRevenues())) {
//                    n++;
//                }
//            }
//        }
//        System.out.println(n);
//         int n =0;
//         OrderDAO daoOr = new OrderDAO();
//         ArrayList<OrderDTO> lo = daoOr.getAllOrder();
//         Calendar c = Calendar.getInstance();
//         int curDate = c.get(Calendar.DATE);
//         int curMonth = c.get(Calendar.MONTH)+1; 
//         int curYear = c.get(Calendar.YEAR);
//         System.out.println(curDate);
//         for (OrderDTO o : lo) {
//            Date date = o.getDateOrder();
//            c.setTime(date);
//            int today = c.get(Calendar.DATE);
//            int toMonth = c.get(Calendar.MONTH)+1;
//            int toYear = c.get(Calendar.YEAR);
//            if(today==curDate && toMonth == curMonth &&toYear == curYear){
//                n++;
//            }
//        }
//         System.out.println(n);
//         System.out.println(curMonth);
//         System.out.println(curYear);
//        CatalogyDAO daoC = new CatalogyDAO();
//        ArrayList<CatalogyDTO> Ca_list = daoC.getAllCatalogy();
//        ArrayList<CatalogyDTO> Ca_list_num = daoC.getAllNumOfCatalogy();
//        ArrayList<CatalogyDTO> Ca_list_num_true = new ArrayList<>();
//        int n_ca =0;
//        for (CatalogyDTO lc : Ca_list) {
//            CatalogyDTO ca = new CatalogyDTO();
//            for (CatalogyDTO lnc : Ca_list_num) {
//                if(lc.getId()== lnc.getId()){
//                    n_ca += lnc.getNumber();
//                }
//            }
//            ca.setId(lc.getId());
//            ca.setNumber(n_ca);
//            ca.setProductType(lc.getProductType());
//            Ca_list_num_true.add(ca);
//            n_ca = 0;
//        }
//        System.out.println(Ca_list_num_true);
//        System.out.println(Ca_list_num);

          SalaryDAO daoS = new SalaryDAO();
          ArrayList<SalaryDTO> list = daoS.getAllSalary();
          System.out.println(list);
        

    }

}
