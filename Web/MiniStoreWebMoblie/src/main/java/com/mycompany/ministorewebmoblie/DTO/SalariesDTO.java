/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.ministorewebmoblie.DTO;

/**
 *
 * @author nanat
 */
public class SalariesDTO {
    String FullName;
    String SalaryByHour;
    String SubSalary;
    String BasicSalary;
    String SalaryBeforTax;
    String AdvSalary;
    String FinalSalary;
    String Month;

    public SalariesDTO() {
    }

    public SalariesDTO(String FullName, String SalaryByHour, String SubSalary, String BasicSalary, String SalaryBeforTax, String AdvSalary, String FinalSalary, String Month) {
        this.FullName = FullName;
        this.SalaryByHour = SalaryByHour;
        this.SubSalary = SubSalary;
        this.BasicSalary = BasicSalary;
        this.SalaryBeforTax = SalaryBeforTax;
        this.AdvSalary = AdvSalary;
        this.FinalSalary = FinalSalary;
        this.Month = Month;
    }

    public String getFullName() {
        return FullName;
    }

    public void setFullName(String FullName) {
        this.FullName = FullName;
    }

    public String getSalaryByHour() {
        return SalaryByHour;
    }

    public void setSalaryByHour(String SalaryByHour) {
        this.SalaryByHour = SalaryByHour;
    }

    public String getSubSalary() {
        return SubSalary;
    }

    public void setSubSalary(String SubSalary) {
        this.SubSalary = SubSalary;
    }

    public String getBasicSalary() {
        return BasicSalary;
    }

    public void setBasicSalary(String BasicSalary) {
        this.BasicSalary = BasicSalary;
    }

    public String getSalaryBeforTax() {
        return SalaryBeforTax;
    }

    public void setSalaryBeforTax(String SalaryBeforTax) {
        this.SalaryBeforTax = SalaryBeforTax;
    }

    public String getAdvSalary() {
        return AdvSalary;
    }

    public void setAdvSalary(String AdvSalary) {
        this.AdvSalary = AdvSalary;
    }

    public String getFinalSalary() {
        return FinalSalary;
    }

    public void setFinalSalary(String FinalSalary) {
        this.FinalSalary = FinalSalary;
    }

    public String getMonth() {
        return Month;
    }

    public void setMonth(String Month) {
        this.Month = Month;
    }
    
}
