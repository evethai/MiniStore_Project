/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DTO;

import java.io.Serializable;



/**
 *
 * @author daigi
 */

public class UnitDTO implements Serializable{
    private String ID_Unit;
    private String sku;
    private String nameUnit;
    private int quantity;
    private Float priceImport;
    private Float priceExport;

    public UnitDTO() {
    }

    public UnitDTO(String ID_Unit, String sku, String nameUnit, int quantity, Float priceImport, Float priceExport) {
        this.ID_Unit = ID_Unit;
        this.sku = sku;
        this.nameUnit = nameUnit;
        this.quantity = quantity;
        this.priceImport = priceImport;
        this.priceExport = priceExport;
    }

    
    public String getID_Unit() {
        return ID_Unit;
    }

    public void setID_Unit(String ID_Unit) {
        this.ID_Unit = ID_Unit;
    }

    public String getSku() {
        return sku;
    }

    public void setSku(String sku) {
        this.sku = sku;
    }

    public String getNameUnit() {
        return nameUnit;
    }

    public void setNameUnit(String nameUnit) {
        this.nameUnit = nameUnit;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public Float getPriceImport() {
        return priceImport;
    }

    public void setPriceImport(Float priceImport) {
        this.priceImport = priceImport;
    }

    public Float getPriceExport() {
        return priceExport;
    }

    public void setPriceExport(Float priceExport) {
        this.priceExport = priceExport;
    }

    
    
    
}
