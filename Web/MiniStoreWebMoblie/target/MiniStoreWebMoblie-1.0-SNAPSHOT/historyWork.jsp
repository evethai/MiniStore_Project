<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>

<h3 name="welcome" style="color: white">Lịch sử làm việc</h3>
<!-- Trường nhập liệu ngày bắt đầu -->
<form action="ShowList" method="post" onsubmit="return validateDates()">
    <div class="row">
        <div class="col-md-6 col-sm-6 col-xs-6">
            <label for="startDate" style="color: white">From:</label>
            <input type="date" class="form-control" id="startDate" name="startDate" required="" value="${sessionScope.dateStarS}">
        </div>
        <div class="col-md-6 col-sm-6 col-xs-6">
            <label for="endDate" style="color: white">To:</label>
            <input type="date" class="form-control" id="endDate" name="endDate" required="" value="${sessionScope.dateEndS}">
        </div>
    </div>
    <br>
    <div class="row justify-content-center">
        <div class="col-md-6 col-sm-6 col-xs-6">
            <label for="sortOrder" style="color: white">Sort Worksheets:</label>
            <select class="form-select" id="sortOrder" name="sortOrder">
                <option value="ascending" ${sessionScope.sortOrder == 'ascending' ? 'selected' : ''}>Cũ nhất</option>
                <option value="descending" ${sessionScope.sortOrder == 'descending' ? 'selected' : ''}>Mới nhất</option>
            </select>
        </div>
    </div>
    <br>
    <div class="col-md-12">
        <div class="form-group">
            <input type="submit" class="btn btn-primary" value="Search">
        </div>
    </div>
</form>
<br>


<c:set var="worksheetList" value="${sessionScope.worksheetList}" />
<c:if test="${not empty worksheetList}">
    <div id="paginationContainer">
        <table id="example" class="table table-striped table-bordered" style="width:100%">
            <thead class="thead-dark">
                <tr class="table-dark">
                    <th scope="col">No</th>
                    <th scope="col">Date</th>
                    <th scope="col">Time Check in</th>
                    <th scope="col">Time Check out</th>
                    <th scope="col">Total Time</th>
                </tr>
            </thead>
            <tbody>
                <c:forEach var="worksheet" items="${worksheetList}" varStatus="status">
                    <tr class="table-success">
                        <th scope="row" class="table-light">${status.index + 1}</th>
                        <td class="table-info">${worksheet.date}</td>
                        <td>${worksheet.timeCheckIn}</td>
                        <c:if test="${not empty worksheet.timeCheckOut}">
                            <td>${worksheet.timeCheckOut}</td>
                        </c:if>
                        <c:if test="${empty worksheet.timeCheckOut}">
                            <td class="table-warning">__-__-__</td>
                        </c:if>
                        <c:if test="${not empty worksheet.timeCheckOut}">
                            <td>${worksheet.total}</td>
                        </c:if>
                        <c:if test="${empty worksheet.timeCheckOut}">
                            <td class="table-warning">__-__-__</td>
                        </c:if>
                    </tr>
                </c:forEach>
            </tbody>
        </table>
    </div>
    <c:if test="${not empty totalTime }">
        <div class="row justify-content-center">
            <div class="col-md-6 col-sm-6 col-xs-6 card border-2 border-white rounded-3 shadow-lg bg-transparent align-items-center" style="width: auto !important; margin-top: 20px">
                <p style="color: white">Tổng thời gian làm là ${totalTime}</p>
            </div>
        </div>
        <br>
    </c:if>
</c:if>

<c:if test="${empty worksheetList}">
    <br>
    <div class="col-md-6 col-sm-6 col-xs-6 card border-2 border-white rounded-3 shadow-lg bg-transparent align-items-center" style="width: auto !important; background-color: rgba(255, 255, 255, 0.8) !important">
        <h3 style="color: #ff3333">Hiện chưa có dữ liệu của khoảng thời gian này</h3>
    </div>
</c:if>


