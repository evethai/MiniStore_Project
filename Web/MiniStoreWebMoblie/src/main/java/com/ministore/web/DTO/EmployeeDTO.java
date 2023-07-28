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
public class EmployeeDTO {
    private String idEmp;
    private String fullname;
    private boolean sex;
    private String cccd;
    private Date dob;
    private String address;
    private String phone;
    private Date datejoin;
    private String username;
    private String password;
    private int roles;
    private boolean isactive; 
    private String picture;
    private int snpt;
}
