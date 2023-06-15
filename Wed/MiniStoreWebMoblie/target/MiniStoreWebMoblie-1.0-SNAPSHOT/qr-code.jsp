<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
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
        </style>
    </head>
    <body>
        <c:if test="${not empty errorMessage}">
            <script>
                alert("${errorMessage}");
            </script>
        </c:if>
        <c:if test="${not empty fullnameemapi}">
            <section>
                <h2 name="welcome"> ${fullnameemapi}</h2>
                <div class="form-box">
                    <form action="CheckInServlet" method="post">
                        <input type="submit" value="Check In" class="loginButton">
                    </form>
                    <form action="CheckOutServlet" method="post">
                        <input type="submit" value="Check Out" class="loginButton">
                    </form>
                </div>

                <c:if test="${not empty qrCodeURL}">
                    <div class="form-box">
                        <img name="qrimg" src="${qrCodeURL}" alt="QR Code">
                    </div>
                </c:if>

                <br>


                <form action="LogoutServlet" method="POST">
                    <input type="submit" value="Đăng xuất" class="loginButton">
                </form>
            </section>
        </c:if>
        <c:if test="${empty fullnameemapi}">
            <script>
                alert("Please log in to access this page");
                window.location.href = "Login.jsp";
            </script>
        </c:if>
    </body>
</html>
