/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DTO;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.ToString;
import java.sql.Date;

/**
 *
 * @author daigi
 */
@Getter
@Setter
@ToString
@NoArgsConstructor
@AllArgsConstructor
public class ProductDTO {
    private String sku;
    private String typeProduct;
    private String nameProduct;
    private String nameSupplier;
    private Date MFG;
    private Date EXP;
    private Date dateImport;
    private Boolean statusP;
    private String  pictureProduct;
   
    public static enum ProductStatus {
        AVAILABLE, SOLDOUT
    };
    public static ProductStatus getEnumIndex(boolean i) {
        ProductStatus[] arr = ProductStatus.values();
        if (i==true){
            return arr[0];
        }
        else {
            return arr[1];
        }
        
    }
}
