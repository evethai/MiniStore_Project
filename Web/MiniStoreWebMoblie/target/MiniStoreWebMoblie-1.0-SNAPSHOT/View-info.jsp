<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css">
        <link rel="stylesheet" href="CSS/qrcss.css"/>
        <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
        <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
        <title>Info guard</title>
        <style>
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
            .profile-image {
                display: flex;
                justify-content: center;
                margin-bottom: 20px;
            }
            .profile-image img {
                width: 200px;
                height: 200px;
                object-fit: cover;
                border-radius: 50%;
            }
            .profile-info-img {
                background-color: rgba(255, 255, 255, 0.8);
                border-radius: 10px;
                padding: 20px;
                margin-bottom: 20px;
            }
            .profile-form-wrapper {
                background-color: rgba(255, 255, 255, 0.8);
                border-radius: 10px;
                padding: 20px;
                margin-bottom: 20px;
            }
            .profile-info label {
                font-weight: bold;
            }
            .profile-form input {
                margin-bottom: 10px;
            }
            .icon-box {
                color: #fff;
                width: 95px;
                height: 95px;
                display: inline-block;
                border-radius: 50%;
                z-index: 9;
                border: 5px solid #fff;
                padding: 15px;
                text-align: center;
            }
            .modal-headerS {
                background: #47c9a2;
                border-bottom: none;
                position: relative;
                text-align: center;
                border-radius: 5px 5px 0 0;
                padding: 35px 0;
            }
            .material-icons {
                font-family: 'Material Icons';
                font-weight: normal;
                font-style: normal;
                font-size: 24px;
                line-height: 1;
                letter-spacing: normal;
                text-transform: none;
                display: inline-block;
                white-space: nowrap;
                word-wrap: normal;
                direction: ltr;
                -webkit-font-smoothing: antialiased;
            }
            .icon-box i {
                font-size: 48px;
            }
            .butRe{
                margin-top: 10px;
            }
        </style>
    </head>
    <body>
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
        <c:if test="${empty EmployeeDTOAPI}">
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
        <c:if test="${not empty EmployeeDTOAPI}">
            <section>
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-lg-6 col-md-6 ">
                            <c:set var="emp" value="${EmployeeDTOAPI}" />
                            <div class="profile-info-img">
                                <div class="profile-image">
                                    <img src="data:image/jpeg;base64, ${emp.getPicture()}" alt="Profile Image">
                                </div>
                                <div class="profile-info-wrapper">
                                    <div class="profile-info">
                                        <label for="name">Name:</label>
                                        <p id="name">${fullnameemapi}</p>
                                        <label for="gender">Gender:</label>
                                        <p id="gender">${emp.getSex()}</p>
                                        <label for="cccd">CCCD:</label>
                                        <p id="cccd">${emp.getCCD()}</p>
                                        <label for="dob">Date of Birth:</label>
                                        <p id="dob">${emp.getDoB()}</p>
                                        <label for="address">Address:</label>
                                        <p id="address">${emp.getAddressEmp()}</p>
                                        <label for="phone">Phone:</label>
                                        <p id="phone">${emp.getPhone()}</p>
                                        <label for="email">Email:</label>
                                        <p id="email">${emp.getEmail()}</p>
                                    </div>
                                </div>
                            </div>
                            <div class="profile-form-wrapper">
                                <form id="password-form" action="changePass" method="POST">
                                    <h3>Change Password</h3>
                                    <div class="form-group">
                                        <label for="old-password">Old Password:</label>
                                        <input type="password" id="old-password" name="oldPassword" value="${param.oldPassword}" class="form-control" required >
                                    </div>
                                    <div class="form-group">
                                        <label for="new-password">New Password:</label>
                                        <input type="password" id="new-password" name="newPassword" class="form-control" required value="${param.newPassword}">
                                    </div>
                                    <div class="form-group">
                                        <label for="confirm-password">Confirm New Password:</label>
                                        <input type="password" id="confirm-password" name="confirmPassword" class="form-control" required value="${param.confirmPassword}">
                                    </div>
                                    <div class="form-group">
                                        <input type="checkbox" id="show-passwords-checkbox">
                                        <label for="show-passwords-checkbox">Show Passwords</label>
                                    </div>
                                    <button type="submit" class="btn btn-primary">Change Password</button>
                                </form>
                                <button type="submit" class="butRe btn btn-danger" onclick="redirectToQrPage()">Return</button>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </c:if>
        <button type="button" class="btn btn-secondary position-fixed top-0 end-0 m-3" onclick="toggleTheme()">
            <ion-icon name="contrast-outline"></ion-icon>
        </button>

        <!--model alert-->
        <div class="modal fade" id="alertModal" tabindex="-1" aria-labelledby="alertModalLabel" aria-hidden="true" style="position: fixed; bottom: 0;">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="alertModalLabel">Thông báo</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body" id="alertModalBody">
                        <!-- Error message will be displayed here -->
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Đóng</button>
                    </div>
                </div>
            </div>
        </div>

        <!-- Modal success-->
        <div class="modal fade" id="successModal"  aria-labelledby="alertModalLabel" aria-hidden="true" data-bs-backdrop="static" data-bs-keyboard="false">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content justify-content-center">
                    <div class="modal-headerS">
                        <div class="icon-box">
                            <i class="material-icons">&#xE876;</i>
                        </div>
                    </div>
                    <div class="modal-body justify-content-center text-center">
                        <p id="successMessage" class="text-center"></p>
                        <!-- Error message will be displayed here -->
                    </div>
                    <div class="modal-footer justify-content-center">
                        <button type="button" class="btn btn-success" data-bs-dismiss="modal" onclick="redirectToQrPage()">Trở lại</button>
                    </div>
                </div>
            </div>
        </div>



        <c:if test="${not empty Message}">
            <script>
                document.addEventListener('DOMContentLoaded', function () {
                    var message = "${Message}";
                    var successModal = new bootstrap.Modal(document.getElementById('successModal'));
                    var successMessage = document.getElementById('successMessage');
                    successMessage.innerHTML = message;
                    successModal.show();
                });
            </script>
        </c:if>
        <c:if test="${not empty errorM}">
            <script>
                document.addEventListener('DOMContentLoaded', function () {
                    var errorMessage = "${errorM}";
                    var myModal = new bootstrap.Modal(document.getElementById('alertModal'));
                    var modalBody = document.getElementById('alertModalBody');
                    modalBody.innerHTML = errorMessage;
                    myModal.show();
                });
            </script>
        </c:if>
        <script>
            var checkbox = document.getElementById('show-passwords-checkbox');
            var passwordInputs = document.querySelectorAll('input[type="password"]');

            checkbox.addEventListener('change', function (event) {
                passwordInputs.forEach(function (input) {
                    input.type = checkbox.checked ? 'text' : 'password';
                });
            });

            function redirectToQrPage() {
                var form = document.createElement("form");
                form.method = "POST";
                form.action = "ShowList";

                document.body.appendChild(form);
                form.submit();
            }

            document.addEventListener('DOMContentLoaded', function () {
                var alertModal = document.getElementById('alertModal');

                alertModal.addEventListener('shown.bs.modal', function () {
                    // Di chuyển cuộn trang xuống cuối trang
                    window.scrollTo(0, document.body.scrollHeight);
                });
            });
        </script>


        <script src="JavaScript/changetheme.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/js/bootstrap.bundle.min.js"></script>
        <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
        <script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
        <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    </body>
</html>
