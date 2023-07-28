/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.ministorewebmoblie.DTO;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.ToString;

/**
 *
 * @author PC
 */
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@ToString
public class TopSellerDTO {
    private String idUnit;
    private String img;
    private String name;
    private double price;
    private int quantity;
    private double revenues;
}
