/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import com.mycompany.ministorewebmoblie.DTO.MemberDTO;
import com.mycompany.ministorewebmoblie.DTO.OrderDTO;
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
public class MemberDAO {
    public ArrayList<MemberDTO> getAllMember()
            throws SQLException, NamingException {
        ArrayList<MemberDTO> members = new ArrayList<>();
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;

        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select * from Member ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    members.add(new MemberDTO(rs.getString(1), rs.getInt(2), rs.getString(3), rs.getString(4), rs.getString(5),rs.getString(6), rs.getString(7)));
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
        return members;
    }
}
