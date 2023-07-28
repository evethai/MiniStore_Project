/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import com.mycompany.ministorewebmoblie.DTO.ProductDTO;
import com.mycompany.ministorewebmoblie.Utils.DBUtil;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.naming.NamingException;
import jakarta.xml.bind.DatatypeConverter;
import java.io.Serializable;
import java.awt.image.BufferedImage;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.sql.Date;
import java.util.Base64;
import java.util.List;
import javax.imageio.ImageIO;
import javax.imageio.ImageIO;
import javax.naming.NamingException;
/**
 *
 * @author PC
 */
public class ProductDAO implements Serializable{

    public ArrayList<ProductDTO> getAllProoduct()
            throws SQLException, NamingException {
        ArrayList<ProductDTO> products = new ArrayList<>();
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;

        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select * from Product ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    products.add(new ProductDTO(rs.getString(1), rs.getString(2), rs.getString(3), rs.getString(4), rs.getString(5), rs.getString(6), rs.getString(7), rs.getBoolean(8), rs.getString(9)));
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
        return products;
    }
    
    public ProductDTO getAProduct(String id) throws SQLException, NamingException {
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        ProductDTO products=null;
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
                String sql = " select * from Product where SKU = ? ";
                
                stm = con.prepareStatement(sql);
                stm.setString(1, id);      
                rs = stm.executeQuery();
            }
            if(rs.next()){
               products = (ProductDTO) new ProductDTO(rs.getString(1), rs.getString(2), rs.getString(3), rs.getString(4), rs.getString(5), rs.getString(6), rs.getString(7), rs.getBoolean(8), rs.getString(9));
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
public ArrayList<com.ministore.web.DTO.ProductDTO>ShowProduct() throws SQLException,NamingException, IOException{
        Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        ArrayList<com.ministore.web.DTO.ProductDTO> dto = new ArrayList<>();
        
        try {
            con = DBUtil.makeConnection();
            if (con != null) {
//                String sql = "select * from Product";
                String sql = "SELECT P.SKU, P.ProductType, P.NameProduct, S.Name_supplier, P.MFG, P.EXP, P.Date_Import, P.StatusP, P.PictureProduct "
                    + "FROM Product P "
                    + "JOIN Supplier S ON P.ID_supplier = S.ID_supplier ";
                stm = con.prepareStatement(sql);
                rs = stm.executeQuery();
                while (rs.next()) {
                    dto.add(new com.ministore.web.DTO.ProductDTO(rs.getString("SKU"),
                            rs.getString("ProductType"),
                            rs.getString("NameProduct"),
                            rs.getString("Name_supplier"),
                            rs.getDate("MFG"), 
                            rs.getDate("EXP"), 
                            rs.getDate("Date_Import"),
                            rs.getBoolean("StatusP"),
                            rs.getString("PictureProduct")));
                    
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
    public String convertImageToBase64(InputStream inputStream) throws IOException {
        if (inputStream == null) {
            return null;
        }

        // Đọc dữ liệu từ InputStream vào một mảng byte[]
        ByteArrayOutputStream outputStream = new ByteArrayOutputStream();
        byte[] buffer = new byte[4096];
        int bytesRead;
        while ((bytesRead = inputStream.read(buffer)) != -1) {
            outputStream.write(buffer, 0, bytesRead);
        }

        // Chuyển đổi mảng byte[] thành chuỗi Base64
        byte[] imageBytes = outputStream.toByteArray();
        return Base64.getEncoder().encodeToString(imageBytes);
    }
      public List<String> getAllProductTypes() throws SQLException, NamingException {
        List<String> productTypes = new ArrayList<>();
        Connection conn = null;
        PreparedStatement stm = null;
        ResultSet rs = null;

        try {
            conn = DBUtil.makeConnection(); 

            String query = "SELECT DISTINCT ProductType FROM Product "; 

            stm = conn.prepareStatement(query);
            rs = stm.executeQuery();

            while (rs.next()) {
                String typeProduct = rs.getString("ProductType");
                productTypes.add(typeProduct);
            }
        } finally {
            if (conn != null) {
                conn.close();
            }
            if (stm != null) {
                stm.close();
            }
            if (rs != null) {
                rs.close();
            }
        }

        return productTypes;
    }
      public List<String> GetallIdSup() throws SQLException, NamingException {
        List<String> productTypes = new ArrayList<>();
        Connection conn = null;
        PreparedStatement stm = null;
        ResultSet rs = null;

        try {
            conn = DBUtil.makeConnection(); 

            String query = "select ID_supplier from Supplier "; 

            stm = conn.prepareStatement(query);
            rs = stm.executeQuery();

            while (rs.next()) {
                String idSupplier = rs.getString("ID_supplier");
                productTypes.add(idSupplier);
            }
        } finally {
            if (conn != null) {
                conn.close();
            }
            if (stm != null) {
                stm.close();
            }
            if (rs != null) {
                rs.close();
            }
        }

        return productTypes;
    }

    public List<String> getALLnameSup() throws SQLException, NamingException {
        List<String> namesupplier = new ArrayList<>();
        Connection conn = null;
        PreparedStatement stm = null;
        ResultSet rs = null;

        try {
            conn = DBUtil.makeConnection(); 

            String query = "SELECT DISTINCT Name_supplier FROM Supplier "; 

            stm = conn.prepareStatement(query);
            rs = stm.executeQuery();

            while (rs.next()) {
                String name = rs.getString("Name_supplier");
                namesupplier.add(name);
            }
        } finally {
            if (conn != null) {
                conn.close();
            }
            if (stm != null) {
                stm.close();
            }
            if (rs != null) {
                rs.close();
            }
        }

        return namesupplier;
    }
    public boolean SearchNameSupplier(String NameSupplier)
            throws SQLException, NamingException {
        Connection con = null;
        PreparedStatement stm = null;
        boolean result = false;
        try {
            //1. Connect DB
            con = DBUtil.makeConnection();
            //2. Create SQL String
            String sql = "Select ID_supplier "
                    + "from Supplier "
                    + "Where Name_supplier = ? ";
            //3. Create statement
            stm = con.prepareStatement(sql);
            stm.setString(1, NameSupplier);
            
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
            }
        }
        return result;
    }
    public com.ministore.web.DTO.ProductDTO getProductBySKU(String sku)throws SQLException, NamingException{
         Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
       com.ministore.web.DTO.ProductDTO dto = new com.ministore.web.DTO.ProductDTO();
        try {
            //1. Connect DB
            con = DBUtil.makeConnection();
            //2. Create SQL String
            String sql = "Select * from Product "
                    + "Where SKU like ? ";
            //3. Create statement
            stm = con.prepareStatement(sql);
            stm.setString(1,sku);
            //4. Execute query
            rs = stm.executeQuery();
            while (rs.next()){
                 dto = new com.ministore.web.DTO.ProductDTO(rs.getString("SKU"),
                            rs.getString("ProductType"),
                            rs.getString("NameProduct"),
                            rs.getString("ID_supplier"),
                            rs.getDate("MFG"), 
                            rs.getDate("EXP"), 
                            rs.getDate("Date_Import"),
                            rs.getBoolean("StatusP"),
                            rs.getString("PictureProduct"));
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
    public boolean updateProduct(String sku,String type, String nameProduct, String idSup, boolean Status, String picture)
            throws SQLException, NamingException {
        Connection con = null;
        PreparedStatement stm = null;
        boolean result = false;
        try {
            //1. Connect DB
            con = DBUtil.makeConnection();
            //2. Create SQL String
//            String sql = "Update Product "
//                    + "Set ProductType = ?, NameProduct = ?  "
//                    + "Where SKU = ? ";
            String sql = "Update Product "
                    + "Set ProductType = ?, NameProduct = ?, ID_supplier = ? ,StatusP = ? , PictureProduct = ?   "
                    + "Where SKU = ? ";
            //3. Create statement
            stm = con.prepareStatement(sql);
            stm.setString(1, type);
            stm.setString(2, nameProduct);
            stm.setString(3, idSup);
            stm.setBoolean(4, Status);
            stm.setString(5,picture);
            stm.setString(6,sku);
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
            }
        }
        return result;
    }
    public com.ministore.web.DTO.ProductDTO CreateAcc(String sku, String type, String NamProduct,String IdNameSup, Date Mfg, Date Exp, Date DateImport,
         boolean Status, String PictureProduct)
         throws SQLException, NamingException{
         Connection con = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
       com.ministore.web.DTO.ProductDTO dto = new com.ministore.web.DTO.ProductDTO();
        boolean result = false;
        try {
            //1. Connect DB
            con = DBUtil.makeConnection();
            //2. Create SQL String
            String sql = "Insert into Product( "
                    + "SKU, ProductType, NameProduct, ID_supplier, MFG, EXP, Date_Import, StatusP, PictureProduct "
                    + " ) "
                    + "Values(?, ?, ?, ?, ?, ?, ?, ?, ? "
                    + " ) ";
            stm = con.prepareStatement(sql);
            stm.setString(1, sku);
            stm.setString(2, type);
            stm.setString(3,NamProduct);
            stm.setString(4,IdNameSup);
            stm.setDate(5,Mfg);
            stm.setDate(6,Exp);
            stm.setDate(7,DateImport);
            stm.setBoolean(8, Status);
            
//             byte[] imageBytes = Base64.getDecoder().decode(PictureProduct);
            stm.setString(9,PictureProduct);
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
