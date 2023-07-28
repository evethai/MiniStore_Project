/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.ministorewebmoblie.DTO;

import java.sql.Date;
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
public class SalaryDTO {
    private String id;
    private String idEmp;
    private double salaryHour;
    private double subSalary;
    private double basicSalary;
    private double salaryBeforTax;
    private double tax;
    private double advSalary;
    private double finalSalary;
    private Date dateIn;
    private Date dateOut;
    
}
