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
/**
 *
 * @author daigi
 */
@Getter
@Setter
@ToString
@NoArgsConstructor
@AllArgsConstructor
public class SupplierDTO {
    private String idSupplier;
    private String nameSupplier;
    private String address;
    private String note;
}
