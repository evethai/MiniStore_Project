<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css">
        <link rel="stylesheet" href="CSS/logincss.css"/>
        <script src="https://www.google.com/recaptcha/api.js" async defer></script>
        <title>JSP Page</title>
    </head>
    <body>
        <c:if test="${not empty errorMessage}">
            <script>
                alert("${errorMessage}");
            </script>
        </c:if>
        <section class="d-flex justify-content-center align-items-center min-vh-100 bg-cover bg-center">
            <div class="container"> 
                <div class="row justify-content-center">
                    <div class="col-md-5 col-sm-11 col-xs-11">
                        <div class="card border-2 border-white rounded-3 shadow-lg bg-transparent">
                            <div class="card-body p-5 col-md-12">
                                <form action="login" method="POST" onsubmit="return validateForm()">
                                    <h2 class="mb-4">Đăng nhập</h2>
                                    <div class="mb-3"> 
                                        <div class="inputbox ">
                                            <ion-icon name="person-outline"></ion-icon>
                                            <input type="text" name="txtusername" required maxlength="20">
                                            <label for="">Username:</label>
                                        </div>
                                    </div>
                                    <div class="mb-3"> 
                                        <div class="inputbox">
                                            <ion-icon name="lock-closed-outline"></ion-icon>
                                            <input type="password" name="txtpassword" required maxlength="20">
                                            <label for="">Password</label>
                                        </div>
                                    </div>
                                    <div class="g-recaptcha mb-3" data-sitekey="6Lcf9XcmAAAAAJjJG3BepTpkCmglEjKSh8HCdMIQ"></div>
                                    <button type="submit" class="btn btn-primary w-100" id="loginButton">Đăng nhập</button>
                                    <!--<input type="submit" value="Đăng nhập" >-->
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <script>
            // Hàm kiểm tra và xác nhận reCAPTCHA trước khi gửi form
            function validateForm() {
                var response = grecaptcha.getResponse();
                if (response.length === 0) {
                    alert("Vui lòng hoàn thành reCAPTCHA để Đăng nhập!!!");
                    return false;
                }
            }
        </script>
        <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
        <script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
    </body>
</html>
