/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import com.mycompany.ministorewebmoblie.DTO.OrderDTO;
import com.mycompany.ministorewebmoblie.DTO.UnitDTO;
import com.mycompany.ministorewebmoblie.Utils.DBUtil;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.naming.NamingException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author PC
 */
public class UnitDAO {

    public ArrayList<UnitDTO> getAllUnit()
            throws SQLException, NamingException {
        ArrayList<UnitDTO> units = new ArrayList<>();
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;

        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select * from unit ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    units.add(new UnitDTO(rs.getString(1), rs.getString(2), rs.getString(3), rs.getInt(4), rs.getDouble(5), rs.getDouble(6)));
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
        return units;
    }
private List<com.ministore.web.DTO.UnitDTO> itemsList;

    public List<com.ministore.web.DTO.UnitDTO> getItemsList() {
        return itemsList;
    }
    public void ShowUnit() throws SQLException,NamingException{
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
//        ArrayList<UnitDTO> dto = new ArrayList<>();
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
//                String sql = "select * from unit";
                String sql ="Select ID_Unit, SKU, Unit_Name, Quantity_Unit, PriceImport, PriceExport "
                        + "From unit ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
//                    dto.add(new UnitDTO(rs.getString(1),rs.getString(2),rs.getString(3),rs.getInt(4),rs.getFloat(5),rs.getFloat(6)));
                    String id = rs.getString("ID_Unit");
                    String sku = rs.getString("SKU");
                    String name = rs.getString("Unit_Name");
                    int quantity = rs.getInt("Quantity_Unit");
                    float priceImport = rs.getFloat("PriceImport");
                    float priceExport = rs.getFloat("PriceExport");
                    com.ministore.web.DTO.UnitDTO dto = new com.ministore.web.DTO.UnitDTO(id, sku, name, quantity, priceImport, priceExport);
                    if(this.itemsList==null){
                        this.itemsList = new ArrayList<>();
                    }//end book list is existed
                    this.itemsList.add(dto);
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
//        return dto;
    }
    public com.ministore.web.DTO.UnitDTO getUnitByID(String id)throws SQLException, NamingException{
         Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        com.ministore.web.DTO.UnitDTO dto = new com.ministore.web.DTO.UnitDTO();
        try {
            //1. Connect DB
            con = DBUtil.makeConnection();
            //2. Create SQL String
            String sql = "Select * from Unit "
                    + "Where ID_Unit like ? ";
            //3. Create statement
            stm = con.prepareStatement(sql);
            stm.setString(1,id);
            //4. Execute query
            rs = stm.executeQuery();
            while (rs.next()){
                 dto = new com.ministore.web.DTO.UnitDTO( rs.getString("ID_Unit"), 
                                    rs.getString("SKU"),
                                    rs.getString("Unit_Name"),
                                    rs.getInt("Quantity_Unit"),
                                    rs.getFloat("PriceImport"),
                                    rs.getFloat("PriceExport"));
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
    public boolean updateProduct(String id, int quantity, float PriceExpot)
            throws SQLException, NamingException {
        Connection con = null;
        PreparedStatement stm = null;
        boolean result = false;
        try {
            con = DBUtil.makeConnection();
            String sql = "Update unit "
                    + "Set Quantity_Unit = ?, PriceExport = ? "
                    + "Where ID_Unit = ? ";
            stm = con.prepareStatement(sql);
            stm.setInt(1, quantity);
            stm.setFloat(2, PriceExpot);
            stm.setString(3, id);
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
    public com.ministore.web.DTO.UnitDTO CreateUnit( String id ,String sku, String nameUnit, int quantity, float PriceImport, float PriceExport )
         throws SQLException, NamingException{
         Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
       com.ministore.web.DTO.UnitDTO dto = new com.ministore.web.DTO.UnitDTO();
        boolean result = false;
        try {
            //1. Connect DB
            con = DBUtil.makeConnection();
            //2. Create SQL String
            String sql = "Insert into unit( "
                    + "ID_Unit, SKU, Unit_Name, Quantity_Unit, PriceImport, PriceExport  "
                    + " ) "
                    + "Values(?, ?, ?, ?, ?, ? "
                    + " ) ";
            stm = con.prepareStatement(sql);
            stm.setString(1, id);
            stm.setString(2, sku);
            stm.setString(3,nameUnit);
            stm.setInt(4,quantity);
            stm.setFloat(5,PriceImport);
            stm.setFloat(6,PriceExport);
     
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

    public UnitDTO getAUnit(String id) throws SQLException, NamingException {
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        UnitDTO unit=null;
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select * from unit where ID_Unit = ? ";
                
                stm = con.prepareStatement(sql);
                stm.setString(1, id);      
                rs = stm.executeQuery();
            }
            if(rs.next()){
               unit = (UnitDTO) new UnitDTO(rs.getString(1), rs.getString(2), rs.getString(3),rs.getInt(4) , rs.getDouble(5), rs.getDouble(6));
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
        return unit;
    }

}
