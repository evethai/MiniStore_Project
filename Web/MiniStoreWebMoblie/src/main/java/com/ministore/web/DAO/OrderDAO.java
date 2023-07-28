/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import com.mycompany.ministorewebmoblie.DTO.OrderDTO;
import com.mycompany.ministorewebmoblie.DTO.RevenueDTO;
import com.mycompany.ministorewebmoblie.Utils.DBUtil;
import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.naming.NamingException;

/**
 *
 * @author PC
 */
public class OrderDAO {

    public ArrayList<OrderDTO> getAllOrder()
            throws SQLException, NamingException {
        ArrayList<OrderDTO> orders = new ArrayList<>();
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;

        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select * from Orders order by dateOrders desc ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    orders.add(new OrderDTO(rs.getString(1), rs.getString(2), rs.getInt(3), rs.getDate(4), rs.getString(5), rs.getDouble(6), rs.getString(7)));
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
        return orders;
    }

    //
    public ArrayList<OrderDTO> get5MostUnit()
            throws SQLException, NamingException {
        ArrayList<OrderDTO> orders = new ArrayList<>();
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;

        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " SELECT top 5 ID_Unit, COUNT(*) AS TotalSold "
                        + " FROM Orders "
                        + " GROUP BY ID_Unit "
                        + " ORDER BY TotalSold DESC ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    orders.add(new OrderDTO("", "", rs.getInt(2), Date.valueOf("2023-05-02"), "", 0, rs.getString(1)));
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
        return orders;
    }
}
