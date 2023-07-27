
package com.mycompany.ministorewebmoblie.DTO;


/**
 *
 * @author nanat
 */
public class WorksheetDTO {
    private String date;
    private String timeCheckIn;
    private String timeCheckOut;
    private String total;
  
    public WorksheetDTO() {
    }

    public WorksheetDTO(String date, String timeCheckIn, String timeCheckOut, String total) {
        this.date = date;
        this.timeCheckIn = timeCheckIn;
        this.timeCheckOut = timeCheckOut;
        this.total = total;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
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

    public String getTotal() {
        return total;
    }

    public void setTotal(String total) {
        this.total = total;
    }
    
   

    
}