<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ page import="com.mycompany.ministorewebmoblie.Utils.MyUtils" %>
<!DOCTYPE html>
<html>
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css">
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/js/bootstrap.bundle.min.js"></script>
        <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
        <link rel="stylesheet" href="CSS/qrcss.css"/>
        <title>QR-page</title>
        <style>
            .loginButton {
                width: 100%;
                height: 40px;
                border-radius: 40px;
                background: #fff;
                border: none;
                outline: none;
                cursor: pointer;
                font-size: 1em;
                font-weight: 600;
                padding: 0 20px;
                margin: 3px 0;
            }

            section {
                background: url('background/morning.jpg')no-repeat;
                background-position: center;
                background-size: cover;
            }

            .night {
                background: url('background/background6.jpg')no-repeat;
                background-position: center;
                background-size: cover;
            }
        </style>
    </head>
    <body>
        <c:if test="${not empty errorMessage}">
            <!-- Modal -->
            <div class="modal fade" id="errorModal" tabindex="-1" aria-labelledby="errorModalLabel" aria-hidden="true">
                <div class="modal-dialog modal-dialog-centered">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="errorModalLabel">Thông báo</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            ${errorMessage}
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Đóng</button>
                        </div>
                    </div>
                </div>
            </div>
            <script>
                // Show the error modal on page load
                document.addEventListener('DOMContentLoaded', function () {
                    var myModal = new bootstrap.Modal(document.getElementById('errorModal'));
                    myModal.show();
                });
            </script>
        </c:if>

        <c:if test="${not empty fullnameemapi}">
            <section class="d-flex justify-content-center align-items-center min-vh-100 bg-cover bg-center">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-md-5 col-sm-10 col-xs-10">
                            <h2 name="welcome"> ${fullnameemapi}</h2>
                            <div class="row justify-content-center">
                                <form class="col-md-6" style="width: auto !important;" action="Logout" method="POST" id="logoutForm">
                                    <input type="button" value="Đăng xuất" class="btn btn-danger loginButton" style="background-color: #dc3545; color: #000000;"  onclick="showLogoutConfirmation()">
                                </form>
                            </div>
                            <br>
                            <div class="row justify-content-center">
                                <div class="col-md-6 col-sm-6 col-xs-6 card border-2 border-white rounded-3 shadow-lg bg-transparent align-items-center" style="width: auto !important;">
                                    <c:if test="${empty TimeCheckInapi}">
                                        <form action="CheckIn" method="post">
                                            <input type="submit" value="Check In" class="loginButton">
                                        </form>
                                    </c:if>
                                    <c:if test="${not empty TimeCheckInapi}">
                                        <form action="CheckOut" method="post">
                                            <input type="submit" value="Check Out" class="loginButton">
                                        </form>
                                    </c:if>
                                </div>
                            </div>
                            <br>
                            <c:if test="${not empty qrCodeURL}">
                                <div class="row justify-content-center">
                                    <div class="col-md-10 card border-2 border-white rounded-3 shadow-lg bg-transparent align-items-center" style="width: auto !important;">
                                        <img name="qrimg" src="${qrCodeURL}" alt="QR Code">
                                    </div>
                                </div>
                                <br>
                            </c:if>

                            <!-- Trường nhập liệu ngày bắt đầu -->
                            <form action="ShowList" method="post">
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
                                    <table class="table">
                                        <thead>
                                            <tr>
                                                <th scope="col">No</th>
                                                <th scope="col">Date</th>
                                                <th scope="col">Time Check in</th>
                                                <th scope="col">Time Check out</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <c:forEach var="worksheet" items="${worksheetList}" varStatus="status">
                                                <tr>
                                                    <th scope="row">${status.index + 1}</th>
                                                    <td>${worksheet.date}</td>
                                                    <td>${worksheet.timeCheckIn}</td>
                                                    <td>${worksheet.timeCheckOut}</td>
                                                </tr>
                                            </c:forEach>
                                        </tbody>
                                    </table>
                                </div>

                            </c:if>
                        </div>
                    </div>
                </div>
            </section>
            <!-- Place this button before the closing body tag -->
            <button type="button" class="btn btn-secondary position-fixed top-0 end-0 m-3" onclick="toggleTheme()">
                <ion-icon name="contrast-outline"></ion-icon>
            </button>
        </c:if>
        <!-- Modal logout-->
        <div class="modal fade" id="logoutModal" tabindex="-1" role="dialog" aria-labelledby="logoutModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="logoutModalLabel">Xác nhận đăng xuất</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        Bạn có chắc chắn muốn đăng xuất?
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Không</button>
                        <button type="button" class="btn btn-danger" onclick="logout()">Đăng xuất</button>
                    </div>
                </div>
            </div>
        </div>
        <!-- Modal login-->
        <div class="modal fade" id="loginModal" tabindex="-1" role="dialog" aria-labelledby="loginModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header d-flex justify-content-center">
                        <h5 class="modal-title text-danger" id="loginModalLabel">Thông báo</h5>
                    </div>
                    <div class="modal-body text-center text-danger">
                        Vui lòng đăng nhập để truy cập vào trang này!!!
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" onclick="redirectToLoginPage()">Đăng nhập</button>
                    </div>
                </div>
            </div>
        </div>

        <c:if test="${empty fullnameemapi}">
            <script>
                $(document).ready(function () {
                    $('#loginModal').modal('show');
                });

                function redirectToLoginPage() {
                    window.location.href = "Login.jsp";
                }
            </script>
        </c:if>

        <script>
            function showLogoutConfirmation() {
                $('#logoutModal').modal('show');
            }

            function logout() {
                $('#logoutForm').submit();
            }

            $(document).ready(function () {
                $('#logoutModal').on('hidden.bs.modal', function () {
                    // Reset the form inside the modal
                    $('#logoutForm').trigger('reset');
                });
            });
        </script>
        
        
        <script src="JavaScript/changetheme.js"></script>
    </body>
</html>
