<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css">
        <link rel="stylesheet" href="CSS/logincss.css"/>
        <title>New Password</title>
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
            .form-group {
                margin: 10px 0px;
            }
        </style>
    </head>
    <body>
        <section>
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-12 col-md-9 col-lg-7 col-xl-6 mt-5">
                        <div class="container bg-white rounded mt-2 mb-2 px-0" style="background-color: rgba(255, 255, 255, 0.8) !important">
                            <div class="row justify-content-center align-items-center pt-3">
                                <h1 class="text-center">
                                    <strong>Reset Password</strong>
                                </h1>
                            </div>
                            <div class="pt-3 pb-3">
                                <form class="form-horizontal" action="newPass" method="POST" onsubmit="return validatePasswords(event)">
                                    <div class="form-group row justify-content-center px-3">
                                        <div class="col-9 px-0">
                                            <div class="input-group">
                                                <input type="password" name="password" value="${param.password}" id="password" placeholder="New Password" class="form-control border-info" required>
                                                <button type="button" class="btn btn-outline-secondary" onclick="togglePasswordVisibility('password', 'passwordToggleIcon')">
                                                    <ion-icon name="eye-outline" id="passwordToggleIcon"></ion-icon>
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group row justify-content-center px-3">
                                        <div class="col-9 px-0">
                                            <div class="input-group">
                                                <input type="password" name="confPassword" value="${param.confPassword}" id="confPassword" placeholder="Confirm New Password" class="form-control border-info" required>
                                                <button type="button" class="btn btn-outline-secondary" onclick="togglePasswordVisibility('confPassword', 'confPasswordToggleIcon')">
                                                    <ion-icon name="eye-outline" id="confPasswordToggleIcon"></ion-icon>
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group row justify-content-center">
                                        <div class="col-6 px-3 mt-3 d-flex justify-content-between">
                                            <button type="button" class="btn btn-success w-100" onclick="clearPasswords()">Clear</button>
                                            <button type="submit" class="btn btn-info w-100 ms-5" id="loginButton">Reset</button>
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <c:if test="${not empty errorMessage}">
            <script>
                document.addEventListener('DOMContentLoaded', function () {
                    var errorMessage = "${errorMessage}";
                    var myModal = new bootstrap.Modal(document.getElementById('alertModal'));
                    var modalBody = document.getElementById('alertModalBody');
                    modalBody.innerHTML = errorMessage;
                    myModal.show();
                });
            </script>
        </c:if>
        <div class="modal fade" id="alertModal" tabindex="-1" aria-labelledby="alertModalLabel" aria-hidden="true">
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

        <button type="button" class="btn btn-secondary position-fixed top-0 end-0 m-3" onclick="toggleTheme()">
            <ion-icon name="contrast-outline"></ion-icon>
        </button>

        <script>
            function togglePasswordVisibility(inputId, toggleIconId) {
                var passwordInput = document.getElementById(inputId);
                var toggleButton = document.getElementById(toggleIconId);

                if (passwordInput.type === "password") {
                    passwordInput.type = "text";
                    toggleButton.setAttribute("name", "eye-off-outline");
                } else {
                    passwordInput.type = "password";
                    toggleButton.setAttribute("name", "eye-outline");
                }
            }

            function clearPasswords() {
                var passwordInput = document.getElementById("password");
                var confPasswordInput = document.getElementById("confPassword");

                passwordInput.value = "";
                confPasswordInput.value = "";
            }
        </script>

        <script src="JavaScript/changetheme.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/js/bootstrap.bundle.min.js"></script>
        <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
        <script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
    </body>
</html>
