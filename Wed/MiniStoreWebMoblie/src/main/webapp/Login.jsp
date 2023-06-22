<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
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
        <section>
            <div class="form-box">
                <div class="form-value">
                    <form action="login" method="POST" onsubmit="return validateForm()">
                        <h2>Đăng nhập</h2>
                        <div class="inputbox">
                            <ion-icon name="mail-outline"></ion-icon>
                            <input type="text" name="txtusername" required maxlength="20">
                            <label for="">Username:</label>
                        </div>
                        <div class="inputbox">
                            <ion-icon name="lock-closed-outline"></ion-icon>
                            <input type="password" name="txtpassword" required maxlength="20">
                            <label for="">Password</label>
                        </div>
                        <div class="g-recaptcha" data-sitekey="6Lcf9XcmAAAAAJjJG3BepTpkCmglEjKSh8HCdMIQ"></div>
                        <input type="submit" value="Đăng nhập" id="loginButton">
                    </form>
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
