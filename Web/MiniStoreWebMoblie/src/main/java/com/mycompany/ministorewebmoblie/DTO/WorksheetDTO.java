/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.ministorewebmoblie.DTO;

import java.time.LocalDate;
import java.time.LocalTime;

/**
 *
 * @author nanat
 */
public class WorksheetDTO {
    private LocalDate date;
    private String timeCheckIn;
    private String timeCheckOut;

    public WorksheetDTO() {
    }

    public String getTimeCheckIn() {
        return timeCheckIn;
    }

    public void setTimeCheckIn(String timeCheckIn) {
        this.timeCheckIn = timeCheckIn;
    }

    public String getTimeCheckOut() {
        return timeCheckOut;
    }

    public void setTimeCheckOut(String timeCheckOut) {
        this.timeCheckOut = timeCheckOut;
    }

    public WorksheetDTO(LocalDate date, String timeCheckIn, String timeCheckOut) {
        this.date = date;
        this.timeCheckIn = timeCheckIn;
        this.timeCheckOut = timeCheckOut;
    }

    

    public LocalDate getDate() {
        return date;
    }

    public void setDate(LocalDate date) {
        this.date = date;
    }

    
}