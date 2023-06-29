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
    private LocalTime timeCheckIn;
    private LocalTime timeCheckOut;

    public WorksheetDTO() {
    }

    public WorksheetDTO(LocalDate date, LocalTime timeCheckIn, LocalTime timeCheckOut) {
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

    public LocalTime getTimeCheckIn() {
        return timeCheckIn;
    }

    public void setTimeCheckIn(LocalTime timeCheckIn) {
        this.timeCheckIn = timeCheckIn;
    }

    public LocalTime getTimeCheckOut() {
        return timeCheckOut;
    }

    public void setTimeCheckOut(LocalTime timeCheckOut) {
        this.timeCheckOut = timeCheckOut;
    }
}
