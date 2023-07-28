<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page import="com.mycompany.ministorewebmoblie.Utils.MyUtils" %>
<!DOCTYPE html>
<html>
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css">
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/js/bootstrap.bundle.min.js"></script>
        <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
        <script src="https://unpkg.com/qrcodescanner/dist/qrcodescanner.min.js"></script>

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
            .dataTables_length {
                color: white; /* Đổi màu sắc theo ý muốn */
                margin-bottom: 20px;
            }

            .dataTables_info {
                color: white; /* Đổi màu sắc theo ý muốn */
                margin-top: 10px; /* Đổi khoảng cách theo ý muốn */
                margin-bottom: 10px;
            }
            .dataTables_filter {
                margin-bottom: 10px;
                color: white;
            }

            .dataTables_paginate .paginate_button.previous,
            .dataTables_paginate .paginate_button.next {
                color: #3300ff; /* Đổi màu sắc theo ý muốn */
                margin: 0 auto; /* Căn giữa */
                margin-top: 20px;
                margin-bottom: 30px; /* Khoảng cách dưới */
                width: fit-content; /* Đóng gói theo nội dung */
                padding: 5px; /* Khoảng cách giữa nội dung và viền */
            }

            .paginate_button {
                color: #3300ff;
                margin: 0 5px;
                border-radius: 50%;
                padding: 5px;
                background-color: #f0f0f0; /* Màu nền */
                border: 1px solid #ccc; /* Viền */
                padding: 5px 10px; /* Khoảng cách giữa nội dung và viền */
                border-radius: 5px; /* Bo hình nút */
            }

            .current {
                color: white;
                background-color: #0000ff; /* Màu nền */
                border: 1px solid #ccc; /* Viền */
                padding: 5px 10px; /* Khoảng cách giữa nội dung và viền */
                border-radius: 5px; /* Bo hình nút */
            }

            .disabled
            {
                color: #979494 !important;
                background-color: #ccc  !important; /* Màu nền khi nút "Previous" ở trang đầu */
            }

            /* Customize the modal size for messModal */
            #messModal .modal-dialog {
                max-width: 80%; /* Adjust the width as needed */
            }

            /* Customize the modal size for salaryModal */
            #salaryModal .modal-dialog {
                max-width: 90%; /* Adjust the width as needed */
            }

            /* Optional: Center the modals on larger screens */
            @media (min-width: 768px) {
                #messModal .modal-dialog,
                #salaryModal .modal-dialog {
                    margin: 30px auto;
                }
            }
        </style>


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
                    <div class="col-md-7 col-sm-10 col-xs-10">
                        <br>
                        <h2 name="welcome">Welcome ${fullnameemapi}</h2>
                        <div class="row justify-content-center">
                            <form class="col-md-6" style="width: auto !important;" action="Info" method="POST">
                                <label for="logoutButton" class="btn btn-info" style="background: transparent; color: white">
                                    <ion-icon name="person-outline"></ion-icon> Thông tin tài khoản
                                </label>
                                <input type="submit" id="logoutButton" value="Đăng xuất" style="display: none;">
                            </form>
                        </div>
                        <br>
                        <div class="row justify-content-center">
                            <form class="col-md-6" style="width: auto !important;" action="Login" method="POST" id="logoutForm">
                                <input type="button" value="Đăng xuất" class="btn btn-danger loginButton" style="background-color: #dc3545; color: #000000;"  onclick="showLogoutConfirmation()">
                            </form>
                        </div>
                        <br>
                        <c:if test="${empty TimeCheckOutapi}">
                            <div class="row justify-content-center">
                                <div class="col-md-6 col-sm-6 col-xs-6 card border-2 border-white rounded-3 shadow-lg bg-transparent align-items-center" style="width: auto !important;">
                                    <p style="color: white">Hôm nay bạn làm ca từ ${startTime}  đến  ${endTime} </p>
                                </div>
                            </div>
                            <br>
                        </c:if>
                        <div class="row justify-content-center">
                            <div class="col-md-6 col-sm-6 col-xs-6 card border-2 border-white rounded-3 shadow-lg bg-transparent align-items-center" style="width: auto !important;">

                                <c:choose>
                                    <c:when test="${TimeCheckInapi == 'nonsheet' && TimeCheckOutapi == 'noOut'}">
                                        <p style="color: white">Hôm nay bạn không có ca làm!!!</p> 
                                    </c:when>
                                    <c:otherwise>
                                        <c:if test="${empty TimeCheckInapi}">
                                            <form action="CheckIn" method="post">
                                                <input type="submit" value="Check In" class="loginButton">
                                            </form>
                                        </c:if>
                                        <c:if test="${empty TimeCheckOutapi && not empty TimeCheckInapi}">
                                            <form action="CheckOut" method="post">
                                                <input type="submit" value="Check Out" class="loginButton">
                                            </form>
                                        </c:if>
                                        <c:if test="${not empty TimeCheckOutapi && not empty qrCodeURL || not empty TimeCheckInapi && not empty qrCodeURL}">
                                            <br>
                                            <p style="color: white">Hãy quét mã qr để Check In hoặc Check Out</p>
                                        </c:if>
                                        <c:if test="${not empty TimeCheckOutapi && not empty TimeCheckInapi && empty qrCodeURL}">
                                            <br>
                                            <p style="color: white">Đã hoàn thành ca làm</p>
                                        </c:if>
                                        <c:if test="${not empty TotalApi && not empty TimeCheckOutapi && not empty TimeCheckInapi && empty qrCodeURL}">
                                            <br>
                                            <p style="color: white">Tổng thời gian làm việc hôm nay ${TotalApi}</p>
                                        </c:if>
                                    </c:otherwise>
                                </c:choose>

                            </div>
                        </div>
                        <br>


                        <br>
                        <c:if test="${not empty qrCodeURL}">
                            <div class="row justify-content-center">
                                <div class="col-md-10 card border-2 border-white rounded-3 shadow-lg bg-transparent align-items-center" style="width: auto !important;">
                                    <img name="qrimg" src="${qrCodeURL}" alt="QR Code">
                                </div>
                            </div>
                            <br>

                        </c:if>
                        <br>

                        <!-- Import trang work-history.jsp -->
                        <jsp:include page="historyWork.jsp" />
                        <br> 
                        <c:if test="${not empty salaries}">
                            <h3 name="welcome" style="color: white">Lương tháng ${mothpre}:</h3>

                            <div class="row justify-content-center">
                                <form id="salaryForm" class="col-md-6" style="width: auto !important;" method="POST">
                                    <label for="logout" class="btn btn-info" style="background: transparent; color: white">
                                        <ion-icon name="cash-outline"></ion-icon> Lương cuối tháng là : ${salaries.getFinalSalary()} VND
                                    </label>
                                    <input type="submit" id="logout" value="Đăng xuất" style="display: none;">
                                </form>
                            </div>
                            <br>
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
    <div class="modal fade" id="loginModal" tabindex="-1" role="dialog" aria-labelledby="loginModalLabel" aria-hidden="true" data-bs-backdrop="static" data-bs-keyboard="false">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header d-flex justify-content-center">
                    <h5 class="modal-title text-danger" id="loginModalLabel">Thông báo</h5>
                </div>
                <div class="modal-body text-center text-danger">
                    Phiên làm việc đã hết hạn vui lòng đăng nhập lại!!!
                </div>
                <div class="modal-footer justify-content-center">
                    <button type="button" class="btn btn-danger" onclick="redirectToLoginPage()">Đăng nhập</button>
                </div>
            </div>
        </div>
    </div>

    <!-- Modal mess-->
    <div class="modal fade" id="messModal" tabindex="-1" role="dialog" aria-labelledby="messModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="messModalLabel">Thông báo</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <p>Ngày bắt đầu không thể sau ngày kết thúc.</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Đóng</button>
                </div>
            </div>
        </div>
    </div>
    <!-- Modal popup -->
    <div class="modal fade" id="salaryModal" tabindex="-1" aria-labelledby="salaryModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" style="">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="salaryModalLabel">Bảng lương cuối tháng chi tiết</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <!-- Place the table here -->
                    <div id="paginationContainer">
                        <!-- Your table code goes here -->
                        <div id="paginationContainer">
                            <div class="row justify-content-center">
                                <table id="example" class="table table-striped table-bordered" style="width:100%">
                                    <thead class="thead-success">
                                        <tr class="table-success">
                                            <th scope="col">Họ và tên</th>
                                            <th scope="col">Lương theo giờ</th>
                                            <th scope="col">Phụ cấp</th>
                                            <th scope="col">Lương căn bản</th>
                                            <th scope="col">Lương trước thuế</th>
                                            <th scope="col">Lương ứng trước</th>
                                            <th scope="col">Lương cuối tháng</th>
                                            <th scope="col">Tháng</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class="table-light">

                                        <tr>
                                            <td>${salaries.getFullName()}</td>
                                            <td>${salaries.getSalaryByHour()}</td>
                                            <td>${salaries.getSubSalary()}</td>
                                            <td>${salaries.getBasicSalary()}</td>
                                            <td>${salaries.getSalaryBeforTax()}</td>
                                            <td>${salaries.getAdvSalary()}</td>
                                            <td>${salaries.getFinalSalary()}</td>
                                            <td>${salaries.getMonth()}</td>
                                        </tr>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <!--end code-->
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Đóng</button>
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
                var form = document.createElement("form");
                form.method = "POST";
                form.action = "Login"; // Thay thế "LogoutServlet" bằng URL của Servlet xử lý logout

                document.body.appendChild(form);
                form.submit();
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

        $(document).ready(function () {
            $('#example').DataTable();
        });

        function validateDates() {
            var startDate = document.getElementById("startDate").value;
            var endDate = document.getElementById("endDate").value;

            if (startDate > endDate) {
                $('#messModal').modal('show'); // Hiển thị modal khi ngày bắt đầu sau ngày kết thúc
                return false; // Ngăn không cho form được gửi đi
            }

            return true; // Cho phép form được gửi đi
        }


        $(document).ready(function () {
            // Show the modal when the button is clicked
            $("#salaryForm").on("submit", function (e) {
                e.preventDefault(); // Prevent the form from submitting
                $("#salaryModal").modal("show"); // Show the modal
            });
        });


    </script>



    <script src="https://code.jquery.com/jquery-3.5.1.js" ></script>
    <script src="https://cdn.datatables.net/1.13.4/js/jquery.dataTables.min.js" ></script>
    <script src=https://cdn.datatables.net/1.13.4/js/dataTables.bootstrap5.min.js"" ></script>
    <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
    <script src="JavaScript/changetheme.js"></script>
</body>
</html>
