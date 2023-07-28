/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import com.mycompany.ministorewebmoblie.DTO.RevenueDTO;
import com.mycompany.ministorewebmoblie.Utils.DBUtil;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.naming.NamingException;

/**
 *
 * @author PC
 */
public class RevenueDAO {
    public ArrayList<RevenueDTO> getAllRevenue()
            throws SQLException, NamingException {
        ArrayList<RevenueDTO> revenues = new ArrayList<>();
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select * from Revenue ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    revenues.add(new RevenueDTO(rs.getDate(1), rs.getDouble(2)));
                }
            }
        } finally {
            if (rs != null) {
                rs.close();
            }
            if (stm != null) {
                stm.close();
            }
            if (con != null) {
                con.close();
            }
        }
        return revenues;
    }
    
        public ArrayList<RevenueDTO> get7DayRevenue()
            throws SQLException, NamingException {
            
        ArrayList<RevenueDTO> revenues = new ArrayList<>();
        Connection con = null;
        
        PreparedStatement stm = null;
        ResultSet rs = null;
        
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select top 7 * from Revenue order by DateRevenue desc ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    revenues.add(new RevenueDTO(rs.getDate(1), rs.getDouble(2)));
                }
            }
        } finally {
            if (rs != null) {
                rs.close();
            }
            if (stm != null) {
                stm.close();
            }
            if (con != null) {
                con.close();
            }
        }
        return revenues;
    }
}
