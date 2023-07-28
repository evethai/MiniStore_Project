/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.ministore.web.DAO;

import java.io.Serializable;

/**
 *
 * @author daigi
 */
public class ErrorManageProduct implements Serializable{
    private String NameProductErrorCharracter;

    public ErrorManageProduct() {
    }

    public String getNameProductErrorCharracter() {
        return NameProductErrorCharracter;
    }

    public void setNameProductErrorCharracter(String NameProductErrorCharracter) {
        this.NameProductErrorCharracter = NameProductErrorCharracter;
    }
   
    
}
