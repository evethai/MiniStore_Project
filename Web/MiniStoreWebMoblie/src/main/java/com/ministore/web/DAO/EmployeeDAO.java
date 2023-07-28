/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import com.ministore.web.DTO.EmployeeDTO;
import java.io.IOException;
import java.io.Serializable;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.naming.NamingException;
import com.mycompany.ministorewebmoblie.Utils.DBUtil;
/**
 *
 * @author daigi
 */
public class EmployeeDAO implements Serializable{
    public ArrayList<EmployeeDTO>ShowEmp() throws SQLException,NamingException, IOException{
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        ArrayList<EmployeeDTO> dto = new ArrayList<>();
        
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = "select * from Employee "
                        + "Where Roles > 1 ";

                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    dto.add(new EmployeeDTO(rs.getString("IdEmp"),
                            rs.getString("FullNameEmp"),
                            rs.getBoolean("Sex"),
                            rs.getString("CCCD"),
                            rs.getDate("DoB"),
                            rs.getString("AddressEmp"),
                            rs.getString("PhoneEmp"),
                            rs.getDate("DateJoin"), 
                            rs.getString("Username"),
                            rs.getString("Password"),
                            rs.getInt("Roles"),
                            rs.getBoolean("IsActive"),
                            rs.getString("PictureEmp"),
                            rs.getInt("SNPT")));
                    
                }
                
            }
        } finally {
            if (con != null) {
                con.close();
            }
            if (stm != null) {
                stm.close();
            }
            if (rs != null) {
                rs.close();
            }
        }
        return dto;
    }
}
