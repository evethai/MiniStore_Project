/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.ministorewebmoblie.DTO;

import java.time.LocalTime;

/**
 *
 * @author nanat
 */
public class SheetTimeSlot {
    private String sheet;
    private LocalTime startTime;
    private LocalTime endTime;

    public SheetTimeSlot() {
    }

    public SheetTimeSlot(String sheet, LocalTime startTime, LocalTime endTime) {
        this.sheet = sheet;
        this.startTime = startTime;
        this.endTime = endTime;
    }

    public String getSheet() {
        return sheet;
    }

    public void setSheet(String sheet) {
        this.sheet = sheet;
    }

    public LocalTime getStartTime() {
        return startTime;
    }

    public void setStartTime(LocalTime startTime) {
        this.startTime = startTime;
    }

    public LocalTime getEndTime() {
        return endTime;
    }

    public void setEndTime(LocalTime endTime) {
        this.endTime = endTime;
    }
    
}
