/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import com.mycompany.ministorewebmoblie.DTO.RevenueDTO;
import com.mycompany.ministorewebmoblie.DTO.SalaryDTO;
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
public class SalaryDAO {
    public ArrayList<SalaryDTO> getAllSalary()
            throws SQLException, NamingException {
        ArrayList<SalaryDTO> salarys = new ArrayList<>();
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select * from Salary order by DateImonth desc ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    salarys.add(new SalaryDTO(rs.getString(1), rs.getString(2), rs.getDouble(3), rs.getDouble(4), rs.getDouble(5), rs.getDouble(6), rs.getDouble(7), rs.getDouble(8), rs.getDouble(9), rs.getDate(10), rs.getDate(11)));
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
        return salarys;
    }
}
