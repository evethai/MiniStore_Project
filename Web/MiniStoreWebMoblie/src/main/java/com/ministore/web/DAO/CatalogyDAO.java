/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import com.mycompany.ministorewebmoblie.DTO.CatalogyDTO;
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
public class CatalogyDAO {

    public ArrayList<CatalogyDTO> getAllCatalogy()
            throws SQLException, NamingException {
        ArrayList<CatalogyDTO> ca = new ArrayList<>();
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;

        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select * from Catalogy ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    ca.add(new CatalogyDTO(rs.getInt(1), rs.getString(2), 0));
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
        return ca;
    }
    //
        public ArrayList<CatalogyDTO> getAllNumOfCatalogy()
            throws SQLException, NamingException {
        ArrayList<CatalogyDTO> ca = new ArrayList<>();
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;

        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select c.IdCa, c.ProductType, o.QuantityOrders from Orders o join unit u on o.ID_Unit = u.ID_Unit join Product p on p.SKU = u.SKU join Catalogy c on c.ProductType = p.ProductType ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    ca.add(new CatalogyDTO(rs.getInt(1), rs.getString(2), rs.getInt(3)));
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
        return ca;
    }
    
}
