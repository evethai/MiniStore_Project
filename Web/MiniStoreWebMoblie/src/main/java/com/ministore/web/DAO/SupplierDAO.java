/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import java.io.IOException;
import java.io.Serializable;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.naming.NamingException;
import com.ministore.web.DTO.SupplierDTO;
import com.mycompany.ministorewebmoblie.Utils.DBUtil;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
/**
 *
 * @author daigi
 */
public class SupplierDAO implements Serializable {
    public ArrayList<SupplierDTO>ShowSupplier() throws SQLException,NamingException, IOException{
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        ArrayList<SupplierDTO> dto = new ArrayList<>();
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = "select * from Supplier";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    dto.add(new SupplierDTO(rs.getString(1),rs.getString(2),rs.getString(3),rs.getString(4)));
                    
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
    public SupplierDTO DetailSupplier (String id) throws SQLException{
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        SupplierDTO dto = new SupplierDTO();
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = "select * from Supplier where "
                        + "ID_supplier = ? ";
                stm = con.prepareStatement(sql);
                stm.setString(1,id);
                rs = stm.executeQuery();
                while (rs.next()) {
                    dto.setIdSupplier(rs.getString("ID_supplier"));
                    dto.setNameSupplier(rs.getString("Name_supplier"));
                    dto.setAddress(rs.getString("Address_supplier"));
                    dto.setNote(rs.getString("Note"));
                    return dto;
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
       return null;
    }
    public boolean UpdateSup(String id, String NameSup, String Address, String note)
            throws SQLException, NamingException {
        Connection con = null;
        PreparedStatement stm = null;
        boolean result = false;
        try {
            con = DBUtil.makeConnection();
            String sql = "Update Supplier "
                    + "Set Name_supplier = ?, Address_supplier = ?, Note = ? "
                    + "Where ID_supplier = ? ";
            stm = con.prepareStatement(sql);
            stm.setString(1, NameSup);
            stm.setString(2, Address);
            stm.setString(3, note);
            stm.setString(4, id);
            int effectedRows = stm.executeUpdate();
            //5. Process result
            if (effectedRows > 0) {
                result = true;
            }
        } finally {
            if (stm != null) {
                stm.close();
            }
            if (con != null) {
                con.close();
            }
        }
        return result;
    }
    public SupplierDTO getSupplierByID(String id)throws SQLException, NamingException{
         Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        SupplierDTO dto = new SupplierDTO();
        try {
            //1. Connect DB
            con = DBUtil.makeConnection();
            //2. Create SQL String
            String sql = "Select * from Supplier "
                    + "Where ID_supplier like ? ";
            //3. Create statement
            stm = con.prepareStatement(sql);
            stm.setString(1,id);
            //4. Execute query
            rs = stm.executeQuery();
            while (rs.next()){
                 dto = new SupplierDTO( rs.getString("ID_supplier"), 
                                    rs.getString("Name_supplier"),
                                    rs.getString("Address_supplier"),
                                    rs.getString("Note"));
                return dto;
            }
        } finally {
            if (stm != null) {
                stm.close();
            }
            if (con != null) {
                con.close();
            }if (rs!=null){
                rs.close();
            }
        }
        return null;
    }
    public SupplierDTO CreateSupplier( String id ,String NameSup, String Address, String note )
         throws SQLException, NamingException{
         Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
       SupplierDTO dto = new SupplierDTO();
        boolean result = false;
        try {
            //1. Connect DB
            con = DBUtil.makeConnection();
            //2. Create SQL String
            String sql = "Insert into Supplier( "
                    + "ID_supplier, Name_supplier, Address_supplier, Note  "
                    + " ) "
                    + "Values(?, ?, ?, ? "
                    + " ) ";
            stm = con.prepareStatement(sql);
            stm.setString(1, id);
            stm.setString(2, NameSup);
            stm.setString(3,Address);
           stm.setString(4,note);
            //4. Execute query
            int effectedRows = stm.executeUpdate();
            //5. Process result
            if (effectedRows > 0) {
                result = true;
            }
            
        } finally {
            if (stm != null) {
                stm.close();
            }
            if (con != null) {
                con.close();
            }if (rs!=null){
                rs.close();
            }
        }
        return null;
        
    }
}
