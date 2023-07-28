<%-- 
    Document   : home_ministore
    Created on : Jul 12, 2023, 3:39:16 PM
    Author     : DUY KHANH
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html lang="en">

    <head>
        <meta charset="utf-8">
        <meta content="width=device-width, initial-scale=1.0" name="viewport">

        <title>Dashboard - NiceAdmin Bootstrap Template</title>
        <meta content="" name="description">
        <meta content="" name="keywords">

        <!-- Favicons -->
        <link href="assets/img/favicon.png" rel="icon">
        <link href="assets/img/apple-touch-icon.png" rel="apple-touch-icon">

        <!-- Google Fonts -->
        <link href="https://fonts.gstatic.com" rel="preconnect">
        <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Nunito:300,300i,400,400i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">

        <!-- Vendor CSS Files -->
        <link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
        <link href="assets/vendor/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
        <link href="assets/vendor/boxicons/css/boxicons.min.css" rel="stylesheet">
        <link href="assets/vendor/quill/quill.snow.css" rel="stylesheet">
        <link href="assets/vendor/quill/quill.bubble.css" rel="stylesheet">
        <link href="assets/vendor/remixicon/remixicon.css" rel="stylesheet">
        <link href="assets/vendor/simple-datatables/style.css" rel="stylesheet">

        <!-- Template Main CSS File -->
        <link href="assets/css/style.css" rel="stylesheet">

        <!-- =======================================================
        * Template Name: NiceAdmin
        * Updated: May 30 2023 with Bootstrap v5.3.0
        * Template URL: https://bootstrapmade.com/nice-admin-bootstrap-admin-html-template/
        * Author: BootstrapMade.com
        * License: https://bootstrapmade.com/license/
        ======================================================== -->
    </head>

    <body>

        <!-- ======= Header ======= -->
        <header id="header" class="header fixed-top d-flex align-items-center">

            <div class="d-flex align-items-center justify-content-between">
                <a href="DispathController" class="logo d-flex align-items-center">
                    <img src="assets/img/logo.png" alt="">
                    <span class="d-none d-lg-block">NiceAdmin</span>
                </a>
                <i class="bi bi-list toggle-sidebar-btn"></i>
            </div><!-- End Logo -->

            <!--            <div class="search-bar">
                            <form class="search-form d-flex align-items-center" method="POST" action="#">
                                <input type="text" name="query" placeholder="Search" title="Enter search keyword">
                                <button type="submit" title="Search"><i class="bi bi-search"></i></button>
                            </form>
                        </div> End Search Bar -->

            <!--            <nav class="header-nav ms-auto">
                            <ul class="d-flex align-items-center">
            
                                <li class="nav-item d-block d-lg-none">
                                    <a class="nav-link nav-icon search-bar-toggle " href="#">
                                        <i class="bi bi-search"></i>
                                    </a>
                                </li> End Search Icon
            
                                <li class="nav-item dropdown">
            
                                    <a class="nav-link nav-icon" href="#" data-bs-toggle="dropdown">
                                        <i class="bi bi-bell"></i>
                                        <span class="badge bg-primary badge-number">4</span>
                                    </a> End Notification Icon 
            
                                    <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow notifications">
                                        <li class="dropdown-header">
                                            You have 4 new notifications
                                            <a href="#"><span class="badge rounded-pill bg-primary p-2 ms-2">View all</span></a>
                                        </li>
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
            
                                        <li class="notification-item">
                                            <i class="bi bi-exclamation-circle text-warning"></i>
                                            <div>
                                                <h4>Lorem Ipsum</h4>
                                                <p>Quae dolorem earum veritatis oditseno</p>
                                                <p>30 min. ago</p>
                                            </div>
                                        </li>
            
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
            
                                        <li class="notification-item">
                                            <i class="bi bi-x-circle text-danger"></i>
                                            <div>
                                                <h4>Atque rerum nesciunt</h4>
                                                <p>Quae dolorem earum veritatis oditseno</p>
                                                <p>1 hr. ago</p>
                                            </div>
                                        </li>
            
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
            
                                        <li class="notification-item">
                                            <i class="bi bi-check-circle text-success"></i>
                                            <div>
                                                <h4>Sit rerum fuga</h4>
                                                <p>Quae dolorem earum veritatis oditseno</p>
                                                <p>2 hrs. ago</p>
                                            </div>
                                        </li>
            
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
            
                                        <li class="notification-item">
                                            <i class="bi bi-info-circle text-primary"></i>
                                            <div>
                                                <h4>Dicta reprehenderit</h4>
                                                <p>Quae dolorem earum veritatis oditseno</p>
                                                <p>4 hrs. ago</p>
                                            </div>
                                        </li>
            
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
                                        <li class="dropdown-footer">
                                            <a href="#">Show all notifications</a>
                                        </li>
            
                                    </ul> End Notification Dropdown Items 
            
                                </li> End Notification Nav 
            
                                <li class="nav-item dropdown">
            
                                    <a class="nav-link nav-icon" href="#" data-bs-toggle="dropdown">
                                        <i class="bi bi-chat-left-text"></i>
                                        <span class="badge bg-success badge-number">3</span>
                                    </a> End Messages Icon 
            
                                    <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow messages">
                                        <li class="dropdown-header">
                                            You have 3 new messages
                                            <a href="#"><span class="badge rounded-pill bg-primary p-2 ms-2">View all</span></a>
                                        </li>
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
            
                                        <li class="message-item">
                                            <a href="#">
                                                <img src="assets/img/messages-1.jpg" alt="" class="rounded-circle">
                                                <div>
                                                    <h4>Maria Hudson</h4>
                                                    <p>Velit asperiores et ducimus soluta repudiandae labore officia est ut...</p>
                                                    <p>4 hrs. ago</p>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
            
                                        <li class="message-item">
                                            <a href="#">
                                                <img src="assets/img/messages-2.jpg" alt="" class="rounded-circle">
                                                <div>
                                                    <h4>Anna Nelson</h4>
                                                    <p>Velit asperiores et ducimus soluta repudiandae labore officia est ut...</p>
                                                    <p>6 hrs. ago</p>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
            
                                        <li class="message-item">
                                            <a href="#">
                                                <img src="assets/img/messages-3.jpg" alt="" class="rounded-circle">
                                                <div>
                                                    <h4>David Muldon</h4>
                                                    <p>Velit asperiores et ducimus soluta repudiandae labore officia est ut...</p>
                                                    <p>8 hrs. ago</p>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
            
                                        <li class="dropdown-footer">
                                            <a href="#">Show all messages</a>
                                        </li>
            
                                    </ul> End Messages Dropdown Items 
            
                                </li> End Messages Nav 
            
                                <li class="nav-item dropdown pe-3">
            
                                    <a class="nav-link nav-profile d-flex align-items-center pe-0" href="#" data-bs-toggle="dropdown">
                                        <img src="assets/img/profile-img.jpg" alt="Profile" class="rounded-circle">
                                        <span class="d-none d-md-block dropdown-toggle ps-2">K. Anderson</span>
                                    </a> End Profile Iamge Icon 
            
                                    <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow profile">
                                        <li class="dropdown-header">
                                            <h6>Kevin Anderson</h6>
                                            <span>Web Designer</span>
                                        </li>
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
                                        <li>
                                            <hr class="dropdown-divider">
                                        </li>
            
                                        <li>
                                            <a class="dropdown-item d-flex align-items-center" href="#">
                                                <i class="bi bi-box-arrow-right"></i>
                                                <span>Sign Out</span>
                                            </a>
                                        </li>
            
                                    </ul> End Profile Dropdown Items 
                                </li> End Profile Nav 
            
                            </ul>
                        </nav> End Icons Navigation -->

        </header><!-- End Header -->

        <!-- ======= Sidebar ======= -->

        <!-- CODE HERE -->
        <form action="DispathController" method="POST">
            <aside id="sidebar" class="sidebar">

                <ul class="sidebar-nav" id="sidebar-nav">

                    <li class="nav-item">
                        <a class="nav-link " href="DispathController">
                            <i class="bi bi-grid"></i>
                            <span>Dashboard</span>
                        </a>
                    </li><!-- End Dashboard Nav -->

                    <li class="nav-item">
                        <a class="nav-link collapsed" data-bs-target="#components-nav" data-bs-toggle="collapse" href="#">
                            <i class="bi bi-menu-button-wide"></i><span>Manage Worksheet</span><i class="bi bi-chevron-down ms-auto"></i>
                        </a>
                        <ul id="components-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
                            <!--                            <li>
                                                            <a href="components-alerts.html">
                                                                <i class="bi bi-circle"></i><span>Alerts</span>
                                                            </a>
                                                        </li>-->
                            <li>
                                <a href="WorksheetManagementServlet"  >
                                    <i class="bi bi-circle"></i><span>Worksheet</span>
                                </a>
                            </li>
                            <!--                            <li>
                                                            <button class="btn btn-success" value="Details_Worksheet" name="btAction">
                                                                <i class="bi bi-circle"></i><span>Details Worksheet</span>
                                                            </button>
                                                        </li>-->
                        </ul>
                    </li><!-- End Components Nav -->
                    <li class="nav-item">
                        <a class="nav-link collapsed" data-bs-target="#forms-nav" data-bs-toggle="collapse" href="#">
                            <i class="bi bi-journal-text"></i><span>Manage Employee</span><i class="bi bi-chevron-down ms-auto"></i>
                        </a>
                        <ul id="forms-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
                            <li>
                                <a href="ShowEmployeeServlet"  >
                                    <i class="bi bi-circle"></i><span>Employee</span>
                                </a>
                            </li>
                        </ul>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link collapsed" data-bs-target="#forms-nav" data-bs-toggle="collapse" href="#">
                            <i class="bi bi-journal-text"></i><span>Manage Products</span><i class="bi bi-chevron-down ms-auto"></i>
                        </a>
                        <ul id="forms-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
                            <li>
                                <a href="showproduct"  >
                                    <i class="bi bi-circle"></i><span>Products</span>
                                </a>

                            </li>
                            <li>
                                <a href="ShowUnitServelet"  >
                                    <i class="bi bi-circle"></i><span>Units</span>
                                </a>
                            </li>
                            <li>
                                <a href="ShowSupplierServlet"  >
                                    <i class="bi bi-circle"></i><span>Suppliers</span>
                                </a>
                            </li>
                        </ul>
                    </li>

                    <li class="nav-item">
                        <a class="nav-link collapsed" data-bs-target="#forms-nav" data-bs-toggle="collapse" href="#">
                            <i class="bi bi-journal-text"></i><span>Manage Salary</span><i class="bi bi-chevron-down ms-auto"></i>
                        </a>
                        <ul id="forms-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
                            <!--                            <li>
                                                            <button class="btn btn-success" value="Salary_detail" name="btAction">
                                                                <i class="bi bi-circle"></i><span>Salary</span>
                                                            </button>
                                                        </li>-->
                            <li>
                                <a href="SalaryController"  >
                                    <i class="bi bi-circle"></i><span>Salary</span>
                                </a>
                            </li>
                        </ul>
                    </li><!-- End Forms Nav -->


                    <li class="nav-heading">Pages</li>

                    <li class="nav-item">
                        <a class="nav-link collapsed" href="Login">
                            <i class="bi bi-box-arrow-in-right"></i>
                            <span>Logout</span>
                        </a>
                    </li><!-- End Login Page Nav -->
                </ul>
            </aside><!-- End Sidebar-->
        </form>

        <!-- END CODE HERE -->

        <main id="main" class="main">
            <div class="pagetitle">
                <h1>Dashboard</h1>
                <nav>
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="DispathController">Home</a></li>
                        <li class="breadcrumb-item active">Dashboard</li>
                    </ol>
                </nav>
            </div><!-- End Page Title -->

            <section class="section dashboard">
                <div class="row">

                    <!-- Left side columns -->
                    <div class="col-lg-8">
                        <div class="row">

                            <!-- Sales Card -->
                            <c:set var="numberOrder" value="${requestScope.NUMORDERS}"/>
                            <div class="col-xxl-4 col-md-6">
                                <div class="card info-card sales-card">

                                    <div class="filter">
                                        <a class="icon" href="#" data-bs-toggle="dropdown"><i class="bi bi-three-dots"></i></a>
                                        <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow">
                                            <li class="dropdown-header text-start">
                                                <h6>Filter</h6>
                                            </li>

                                            <li><a class="dropdown-item" href="#">Today</a></li>
                                            <li><a class="dropdown-item" href="#">This Month</a></li>
                                            <li><a class="dropdown-item" href="#">This Year</a></li>
                                        </ul>
                                    </div>

                                    <div class="card-body">
                                        <h5 class="card-title">Sales <span>| Today</span></h5>

                                        <div class="d-flex align-items-center">
                                            <div class="card-icon rounded-circle d-flex align-items-center justify-content-center">
                                                <i class="bi bi-cart"></i>
                                            </div>
                                            <div class="ps-3">
                                                <h6>${numberOrder} orders</h6>
                                                <!--<span class="text-success small pt-1 fw-bold">12%</span> <span class="text-muted small pt-2 ps-1">increase</span>-->

                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div><!-- End Sales Card -->

                            <!-- Revenue Card -->
                            <c:set var="rom"  value="${requestScope.ROM}"/>
                            <div class="col-xxl-4 col-md-6">
                                <div class="card info-card revenue-card">

                                    <div class="filter">
                                        <a class="icon" href="#" data-bs-toggle="dropdown"><i class="bi bi-three-dots"></i></a>
                                        <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow">
                                            <li class="dropdown-header text-start">
                                                <h6>Filter</h6>
                                            </li>

                                            <li><a class="dropdown-item" href="#">Today</a></li>
                                            <li><a class="dropdown-item" href="#">This Month</a></li>
                                            <li><a class="dropdown-item" href="#">This Year</a></li>
                                        </ul>
                                    </div>

                                    <div class="card-body">
                                        <h5 class="card-title">Revenue <span>| This Month</span></h5>

                                        <div class="d-flex align-items-center">
                                            <div class="card-icon rounded-circle d-flex align-items-center justify-content-center">
                                                <i class="bi bi-currency-dollar"></i>
                                            </div>
                                            <div class="ps-3">
                                                <h6> ${rom} VND</h6>
                                                <!--                                                <span class="text-success small pt-1 fw-bold">8%</span> <span class="text-muted small pt-2 ps-1">increase</span>-->

                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div><!-- End Revenue Card -->

                            <!-- Customers Card -->
                            <c:set var="member" value="${requestScope.MEMBER}"/>
                            <div class="col-xxl-4 col-xl-12">

                                <div class="card info-card customers-card">

                                    <div class="filter">
                                        <a class="icon" href="#" data-bs-toggle="dropdown"><i class="bi bi-three-dots"></i></a>
                                        <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow">
                                            <li class="dropdown-header text-start">
                                                <h6>Filter</h6>
                                            </li>

                                            <li><a class="dropdown-item" href="#">Today</a></li>
                                            <li><a class="dropdown-item" href="#">This Month</a></li>
                                            <li><a class="dropdown-item" href="#">This Year</a></li>
                                        </ul>
                                    </div>

                                    <div class="card-body">
                                        <h5 class="card-title">Member <span>| This Year</span></h5>

                                        <div class="d-flex align-items-center">
                                            <div class="card-icon rounded-circle d-flex align-items-center justify-content-center">
                                                <i class="bi bi-people"></i>
                                            </div>
                                            <div class="ps-3">
                                                <h6>${member} people</h6>
                                            </div>
                                        </div>

                                    </div>
                                </div>

                            </div><!-- End Customers Card -->

                            <!-- Reports -->
                            <div class="col-12">
                                <div class="card">

                                    <div class="filter">
                                        <a class="icon" href="#" data-bs-toggle="dropdown"><i class="bi bi-three-dots"></i></a>
                                        <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow">
                                            <li class="dropdown-header text-start">
                                                <h6>Filter</h6>
                                            </li>

                                            <li><a class="dropdown-item" href="#">Today</a></li>
                                            <li><a class="dropdown-item" href="#">This Month</a></li>
                                            <li><a class="dropdown-item" href="#">This Year</a></li>
                                        </ul>
                                    </div>

                                    <div class="card-body">
                                        <h5 class="card-title">Reports <span>/Today</span></h5>

                                        <!-- Line Chart -->
                                        <c:set var="revenues" value="${sessionScope.REVENUESOF7DAY}"/>
                                        <c:set var="orders" value="${sessionScope.ORDEROF7DAY}"/>
                                        <c:if test="${not empty orders}">
                                            <c:if test="${not empty revenues}">
                                                <div id="reportsChart"></div>

                                                <script>
                                                    document.addEventListener("DOMContentLoaded", () => {
                                                    new ApexCharts(document.querySelector("#reportsChart"), {
                                                    series: [
                                                    {
                                                    name: 'Number of order',
                                                            data: [
                                                    <c:forEach var="dto1" items="${orders}" varStatus="counter">
                                                        ${dto1.quantity}<c:if test="${not counter.last}">, </c:if>
                                                    </c:forEach>
                                                            ],
                                                            type: 'column' // Kiểu biểu đồ cột cho số lượng đơn hàng
                                                    },
                                                    {
                                                    name: 'Revenue',
                                                            data: [
                                                    <c:forEach var="dto" items="${revenues}" varStatus="counter">
                                                        ${dto.totalRevenueOfDay} <c:if test="${not counter.last}">, </c:if>
                                                    </c:forEach>
                                                            ],
                                                            type: 'line' // Kiểu biểu đồ đường cho doanh thu
                                                    }
                                                    ],
                                                            chart: {
                                                            height: 350,
                                                                    type: 'line',
                                                                    toolbar: {
                                                                    show: false
                                                                    }
                                                            },
                                                            markers: {
                                                            size: 4
                                                            },
                                                            colors: ['#4154f1', '#b3151b'],
                                                            fill: {
                                                            type: "gradient",
                                                                    gradient: {
                                                                    shadeIntensity: 1,
                                                                            opacityFrom: 0.3,
                                                                            opacityTo: 0.4,
                                                                            stops: [0, 90, 100]
                                                                    }
                                                            },
                                                            dataLabels: {
                                                            enabled: false
                                                            },
                                                            stroke: {
                                                            curve: 'smooth',
                                                                    width: 2
                                                            },
                                                            xaxis: {
                                                            type: 'datetime',
                                                                    labels: {
                                                                    datetimeUTC: false,
                                                                            format: 'dd/MM/yy'
                                                                    },
                                                                    categories: [
                                                    <c:forEach var="dto" items="${revenues}" varStatus="counter">
                                                                    new Date('${dto.dateRevenues}').getTime()<c:if test="${not counter.last}">, </c:if>
                                                    </c:forEach>
                                                                    ]
                                                            },
                                                            yaxis: [
                                                            {
                                                            title: {
                                                            text: 'Number of order',
                                                            },
                                                            },
                                                            {
                                                            opposite: true,
                                                                    title: {
                                                                    text: 'Revenue',
                                                                    },
                                                            },
                                                            ],
                                                            tooltip: {
                                                            x: {
                                                            format: 'dd/MM/yy'
                                                            },
                                                            }
                                                    }).render();
                                                    });
                                                </script>
                                            </c:if>
                                        </c:if>
                                        <!-- End Line Chart -->

                                    </div>

                                </div>
                            </div><!-- End Reports -->



                            <!-- Top Selling -->
                            <c:set var="top" value="${sessionScope.TOPSELLER}"/>
                            <c:if test="${not empty top}">
                                <div class="col-12">
                                    <div class="card top-selling overflow-auto">

                                        <div class="filter">
                                            <a class="icon" href="#" data-bs-toggle="dropdown"><i class="bi bi-three-dots"></i></a>
                                            <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow">
                                                <li class="dropdown-header text-start">
                                                    <h6>Filter</h6>
                                                </li>

                                                <li><a class="dropdown-item" href="#">Today</a></li>
                                                <li><a class="dropdown-item" href="#">This Month</a></li>
                                                <li><a class="dropdown-item" href="#">This Year</a></li>
                                            </ul>
                                        </div>

                                        <div class="card-body pb-0">
                                            <h5 class="card-title">Top Selling <span>| Today</span></h5>

                                            <table class="table table-borderless">
                                                <thead>
                                                    <tr>
                                                        <th scope="col">Preview</th>
                                                        <th scope="col">Product</th>
                                                        <th scope="col">Price</th>
                                                        <th scope="col">Sold</th>
                                                        <th scope="col">Revenue</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <c:forEach var="dto" items="${top}">
                                                        <tr>
                                                            <th scope="row"><a href="#"><img src="data:image/jpeg;base64,${dto.img}" alt=""></a></th>
                                                            <td><a href="#" class="text-primary fw-bold"></a>${dto.name}</td>
                                                            <td><c:set var="formattedPrice"><fmt:formatNumber value="${dto.price}" pattern="#,###,###" /></c:set>${formattedPrice}</td>
                                                            <td class="fw-bold">${dto.quantity}</td>
                                                            <td><c:set var="formattedRevenues"><fmt:formatNumber value="${dto.revenues}" pattern="#,###,###" /></c:set>${formattedRevenues}</td>
                                                            </tr>
                                                    </c:forEach>
                                                </tbody>
                                            </table>

                                        </div>

                                    </div>
                                </div>
                            </c:if>

                            <!-- End Top Selling -->

                        </div>
                    </div><!-- End Left side columns -->

                    <!-- Right side columns -->
                    <div class="col-lg-4">

                        <!-- Website Traffic -->
                        <c:set var="catalogy" value="${sessionScope.CATALOGY}"/>
                        <c:if test="${not empty catalogy}">
                            <div class="card">
                                <div class="filter">
                                    <a class="icon" href="#" data-bs-toggle="dropdown"><i class="bi bi-three-dots"></i></a>
                                    <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow">
                                        <li class="dropdown-header text-start">
                                            <h6>Filter</h6>
                                        </li>

                                        <li><a class="dropdown-item" href="#">Today</a></li>
                                        <li><a class="dropdown-item" href="#">This Month</a></li>
                                        <li><a class="dropdown-item" href="#">This Year</a></li>
                                    </ul>
                                </div>

                                <div class="card-body pb-0">
                                    <h5 class="card-title"> Product Type <span>| Sum all</span></h5>

                                    <div id="trafficChart" style="min-height: 400px;" class="echart"></div>

                                    <script>
                                        document.addEventListener("DOMContentLoaded", () => {
                                        echarts.init(document.querySelector("#trafficChart")).setOption({
                                        tooltip: {
                                        trigger: 'item'
                                        },
                                                legend: {
                                                top: '5%',
                                                        left: 'center'
                                                },
                                                series: [{
                                                name: 'Access From',
                                                        type: 'pie',
                                                        radius: ['40%', '70%'],
                                                        avoidLabelOverlap: false,
                                                        label: {
                                                        show: false,
                                                                position: 'center'
                                                        },
                                                        emphasis: {
                                                        label: {
                                                        show: true,
                                                                fontSize: '18',
                                                                fontWeight: 'bold'
                                                        }
                                                        },
                                                        labelLine: {
                                                        show: false
                                                        },
                                                        data: [
                                        <c:forEach var="dto" items="${catalogy}" varStatus="">
                                                        {
                                                        value: ${dto.number},
                                                                name: '${dto.productType}'
                                                        }<c:if test="${not counter.last}">, </c:if>
                                        </c:forEach>

//                                                        {
//                                                        value: 735,
//                                                                name: 'Direct'
//                                                        },
//                                                        {
//                                                        value: 580,
//                                                                name: 'Email'
//                                                        },
//                                                        {
//                                                        value: 484,
//                                                                name: 'Union Ads'
//                                                        },
//                                                        {
//                                                        value: 300,
//                                                                name: 'Video Ads'
//                                                        }
                                                        ]
                                                }]
                                        });
                                        });
                                    </script>

                                </div>
                            </div>
                        </c:if>

                        <!-- End Website Traffic -->

                        <!-- News & Updates Traffic -->
                        <div class="card">
                            <div class="filter">
                                <a class="icon" href="#" data-bs-toggle="dropdown"><i class="bi bi-three-dots"></i></a>
                                <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow">
                                    <li class="dropdown-header text-start">
                                        <h6>Filter</h6>
                                    </li>

                                    <li><a class="dropdown-item" href="#">Today</a></li>
                                    <li><a class="dropdown-item" href="#">This Month</a></li>
                                    <li><a class="dropdown-item" href="#">This Year</a></li>
                                </ul>
                            </div>
                        </div>
                        </section>

                        </main><!-- End #main -->

                        <!-- ======= Footer ======= -->
                        <footer id="footer" class="footer">
                            <div class="copyright">
                                &copy; Copyright <strong><span>NiceAdmin</span></strong>. All Rights Reserved
                            </div>
                            <div class="credits">
                                <!-- All the links in the footer should remain intact. -->
                                <!-- You can delete the links only if you purchased the pro version. -->
                                <!-- Licensing information: https://bootstrapmade.com/license/ -->
                                <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/nice-admin-bootstrap-admin-html-template/ -->
                                Designed by <a href="https://bootstrapmade.com/">BootstrapMade</a>
                            </div>
                        </footer><!-- End Footer -->

                        <a href="#" class="back-to-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>

                        <!-- Vendor JS Files -->
                        <script src="assets/vendor/apexcharts/apexcharts.min.js"></script>
                        <script src="assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
                        <script src="assets/vendor/chart.js/chart.umd.js"></script>
                        <script src="assets/vendor/echarts/echarts.min.js"></script>
                        <script src="assets/vendor/quill/quill.min.js"></script>
                        <script src="assets/vendor/simple-datatables/simple-datatables.js"></script>
                        <script src="assets/vendor/tinymce/tinymce.min.js"></script>
                        <script src="assets/vendor/php-email-form/validate.js"></script>

                        <!-- Template Main JS File -->
                        <script src="assets/js/main.js"></script>

                        </body>

                        </html>
