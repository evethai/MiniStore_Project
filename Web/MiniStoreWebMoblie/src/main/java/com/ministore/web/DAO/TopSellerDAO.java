/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import com.mycompany.ministorewebmoblie.DTO.ProductDTO;
import com.mycompany.ministorewebmoblie.DTO.TopSellerDTO;
import com.mycompany.ministorewebmoblie.Utils.DBUtil;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.naming.NamingException;

/**
 *
 * @author PC
 */
public class TopSellerDAO {
    public TopSellerDTO getAProductTopSeller(String id) throws SQLException, NamingException {
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        TopSellerDTO products = null;
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select u.ID_Unit,p.PictureProduct,p.NameProduct,u.PriceExport from unit u join Product p on u.SKU = p.SKU where u.ID_Unit = ? ";
                
                stm = con.prepareStatement(sql);
                stm.setString(1, id);      
                rs = stm.executeQuery();
            }
            if(rs.next()){
               products = (TopSellerDTO) new TopSellerDTO(rs.getString(1), rs.getString(2), rs.getString(3), rs.getDouble(4), 0, 0);
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
        return products;
    }
}
