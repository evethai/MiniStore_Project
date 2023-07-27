package com.mycompany.ministorewebmoblie.Controller;

import com.mycompany.ministorewebmoblie.DTO.SheetTimeSlotDTO;
import com.mycompany.ministorewebmoblie.DTO.WorksheetDTO;
import com.mycompany.ministorewebmoblie.Utils.MyUtils;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import java.io.IOException;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.util.List;

public class ShowListWSServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html");
        HttpSession session = request.getSession();
        String idemp = (String) session.getAttribute("IdEmpapi");
        String dateStar = (String) request.getParameter("startDate");
        String dateEnd = (String) request.getParameter("endDate");
        String sortOrder = (String) request.getParameter("sortOrder");
        String sheetapi = (String) session.getAttribute("sheetApi");
        String date = (String) session.getAttribute("DateApi");
        boolean type = false;
        if (idemp == null || idemp.isEmpty()) {
            request.setAttribute("errorMessage", "Vui lòng đăng nhập để vào trang này!!!");
            request.getRequestDispatcher("Login.jsp").forward(request, response);
            return;
        }

        if (dateStar == null && dateEnd == null && sortOrder == null) {
            // Lấy đầu tháng hiện tại
            LocalDate firstDayOfMonth = LocalDate.now().withDayOfMonth(1);
            // Lấy cuối tháng hiện tại
            LocalDate lastDayOfMonth = LocalDate.now().withDayOfMonth(LocalDate.now().lengthOfMonth());
            sortOrder = "descending";
            dateStar = firstDayOfMonth.toString();
            dateEnd = lastDayOfMonth.toString();
        } else {
            if (sortOrder.equals("ascending")) {
                type = true;
            }
        }

        List<WorksheetDTO> ListWS = MyUtils.getSheetAvailable(idemp, dateStar, dateEnd, type);
        String totalTime = MyUtils.sumTotalTime(ListWS);

        List<SheetTimeSlotDTO> sheetTimeSlots = MyUtils.getSheetTimeSlots(true);
        String startTime = "";
        String endTime = "";
        if (!sheetTimeSlots.isEmpty()) {
            for (SheetTimeSlotDTO slot : sheetTimeSlots) {
                LocalTime shiftStartTime = slot.getShiftStartTime();
                LocalTime shiftEndTime = slot.getShiftEndTime();
                DateTimeFormatter formatter = DateTimeFormatter.ofPattern("HH:mm");
                if (sheetapi.equals(slot.getSheet())) {
                    startTime = shiftStartTime.format(formatter);
                    endTime = shiftEndTime.format(formatter);
                }
            }
        } else {
            request.setAttribute("errorMessage", "không lấy được sheet");
            request.getRequestDispatcher("qr-code.jsp").forward(request, response);
            return;
        }
        String TotalApi = MyUtils.getTotalTime(idemp, date);
                
        session.setAttribute("dateStarS", dateStar);
        session.setAttribute("dateEndS", dateEnd);
        session.setAttribute("sortOrder", sortOrder);
        session.setAttribute("startTime", startTime);
        session.setAttribute("endTime", endTime);
        if (!TotalApi.equals("null")) {
            session.setAttribute("TotalApi", TotalApi);
        }
        if (totalTime != null) {
            session.setAttribute("totalTime", totalTime);
        }
        session.setAttribute("worksheetList", ListWS);
//        response.sendRedirect("qr-code.jsp");
        request.getRequestDispatcher("qr-code.jsp").forward(request, response);
    }
}
