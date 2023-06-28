<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css">
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
            <section class="d-flex justify-content-center align-items-center min-vh-100 bg-cover bg-center">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-md-5 col-sm-10 col-xs-10">

                            <h2 name="welcome"> ${fullnameemapi}</h2>
                            <div class="row justify-content-center">
                                <div class="col-md-6 col-sm-6 col-xs-6 card border-2 border-white rounded-3 shadow-lg bg-transparent align-items-center" style="width: auto !important;">
                                    <form action="CheckInServlet" method="post">
                                        <input type="submit" value="Check In" class="loginButton">
                                    </form>
                                    <form action="CheckOutServlet" method="post">
                                        <input type="submit" value="Check Out" class="loginButton">
                                    </form>
                                </div>
                            </div>
                            <c:if test="${not empty qrCodeURL}">
                                <div class="row justify-content-center">
                                    <div class="col-md-10 card border-2 border-white rounded-3 shadow-lg bg-transparent align-items-center" style="width: auto !important;">
                                        <img name="qrimg" src="${qrCodeURL}" alt="QR Code">
                                    </div>
                                </div>
                            </c:if>
                            <br>

                            <div class="row justify-content-center">
                                <form class="col-md-6" style="width: auto !important;" action="LogoutServlet" method="POST">
                                    <input type="submit" value="Đăng xuất" class="loginButton">
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
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
