﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Windows.Documents;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;

namespace API_Database.Controllers
{
    public class msController : ApiController
    {

        MiniStoreDataContext db = new MiniStoreDataContext("");

        //hello
        [HttpGet]
        [Route("api/ms")]
        public string hello()
        {
            return "Hello from default web api !";
        }


        //list acc
        [HttpGet]
        [Route("api/ms/lacc")]
        public List<Employee> listAcc()
        {
            return db.Employees.ToList();
        }

        //find acc jwt
        [HttpGet]
        [Route("api/ms/facc")]
        public IHttpActionResult FindAccountjwt(string username, string password)
        {
            // Nếu tài khoản hợp lệ
            EmployeeDTO empDTO = FindAccount(username, password);

            string jwt = JWTUtils.GenerateJWTFAcc(empDTO);

            return Ok(new { jwt });
        }

        //find acc had TimeCheckIn
        [HttpGet]
        [Route("api/ms/facct")]
        public EmployeeDTO FindAccount(string username, string password)
        {
            Employee emp = db.Employees.SingleOrDefault(acc => acc.Username.Equals(username) && acc.Password.Equals(password));

            if (emp == null)
            {
                return null;
            }

            if (!DateTime.TryParse(DateTime.Now.Date.ToString(), out DateTime searchDate))
            {
                throw new ArgumentException("Ngày không hợp lệ");
            }
            SheetDetail sheetD = db.SheetDetails.SingleOrDefault(sd => sd.CheckNight == true && sd.Roles == 3);

            WorkSheet wS = db.WorkSheets.SingleOrDefault(ws => ws.IdEmp.Equals((string)emp.IdEmp) && ws.Date == searchDate);

            TimeSpan? nowTime = DateTime.Now.TimeOfDay;
            TimeSpan? startTimeIn = sheetD.ShiftStartTime - TimeSpan.FromMinutes(15);
            if (startTimeIn < TimeSpan.Zero)
            {
                startTimeIn += TimeSpan.FromHours(24);
            }
            TimeSpan? endTimeIn = DateTime.MaxValue.TimeOfDay;
            TimeSpan? endtTimeOut = sheetD.ShiftStartTime + TimeSpan.FromMinutes(30);
            TimeSpan? startTimeOut = sheetD.ShiftStartTime;

            DateTime dateT = DateTime.MinValue;
            if (nowTime >= startTimeIn && nowTime <= endTimeIn)
            {
                if (wS != null ? (sheetD.Sheet == wS.Sheet.GetValueOrDefault()) : false && wS != null ? wS.Status.Value : false && wS != null ? wS.TimeCheckOut.HasValue : false)
                {
                    if (wS.TimeCheckOut != null)
                    {
                        searchDate = searchDate.AddDays(1);
                        wS = db.WorkSheets.SingleOrDefault(ws => ws.IdEmp.Trim().Equals((string)emp.IdEmp.Trim()) && ws.Date == searchDate);
                    }
                }
            }
            if (nowTime >= startTimeOut && nowTime <= endtTimeOut)
            {
                if (wS != null ? (sheetD.Sheet != wS.Sheet.GetValueOrDefault()) : false)
                {
                    searchDate = searchDate.AddDays(-1);
                    wS = db.WorkSheets.SingleOrDefault(ws => ws.IdEmp.Trim().Equals((string)emp.IdEmp.Trim()) && ws.Date == searchDate);
                    if (wS != null ? !wS.Status.Value : false && wS != null ? !wS.TimeCheckOut.HasValue : false)
                    {
                        if (wS.TimeCheckOut.HasValue)
                        {
                            searchDate = searchDate.AddDays(1);
                            wS = db.WorkSheets.SingleOrDefault(ws => ws.IdEmp.Trim().Equals((string)emp.IdEmp.Trim()) && ws.Date == searchDate);
                        }
                    }
                }
            }
            EmployeeDTO empDTO = new EmployeeDTO
            {
                FullNameEmp = (string)emp.FullNameEmp,
                IdEmp = (string)emp.IdEmp,
                Roles = (string)emp.Roles.ToString(),
                IsActive = (Boolean)emp.IsActive,
                Sheet = wS != null ? wS.Sheet?.ToString() : "noOut",
                Date = searchDate.ToString("yyyy-MM-dd"),
                Total_working_hours = wS != null ? wS.Total_working_hours.ToString() : "noOut",
                TimeCheckIn = wS != null ? wS.TimeCheckIn.ToString() : "nonsheet",
                TimeCheckOut = wS != null ? wS.TimeCheckOut.ToString() : "noOut"
            };

            return empDTO;
        }

        //find acc had TimeCheckIn
        [HttpGet]
        [Route("api/ms/faccInfot")]
        public EmployeeDTO FindAccountInfo(string idemp)
        {
            Employee emp = db.Employees.SingleOrDefault(acc => acc.IdEmp.Equals(idemp));

            if (emp == null)
            {
                return null;
            }

            EmployeeDTO empDTO = new EmployeeDTO
            {
                Sex = (string)emp.Sex.ToString(),
                CCCD = (string)emp.CCCD.ToString(),
                DoB = emp.DoB.Value.ToString("dd/MM/yyyy"),
                AddressEmp = (string)emp.AddressEmp.ToString(),
                Phone = (string)emp.PhoneEmp.ToString(),
                password = (string)emp.Password.ToString(),
                Picture = (string)emp.PictureEmp.ToString(),
                Email = (string)emp.Email.ToString(),
            };

            return empDTO;
        }

        //find acc info jwt
        [HttpGet]
        [Route("api/ms/faccInfo")]
        public IHttpActionResult FindAccountInfojwt(string idemp)
        {
            // Nếu tài khoản hợp lệ
            EmployeeDTO empDTO = FindAccountInfo(idemp);

            string jwt = JWTUtils.GenerateJWTFAccInfo(empDTO);

            return Ok(new { jwt });
        }

        //get password jwt 
        [HttpGet]
        [Route("api/ms/gp")]
        public IHttpActionResult GetPasswordjwt(string mail)
        {
            string password = GetPassword(mail);

            string jwt = JWTUtils.GenerateJWTEmail(password);

            return Ok(new { jwt });
        }
        // get password 
        [HttpGet]
        [Route("api/ms/gpt")]
        public string GetPassword(string mail)
        {
            Employee emp = db.Employees.SingleOrDefault(acc => acc.Email.Trim().ToLower().Equals(mail.Trim().ToLower()));

            if (emp == null)
            {
                return "null";
            }

            string password = emp.Password.Trim();
            return password;
        }

        //update worksheet jwt by qr
        [HttpGet]
        [Route("api/ms/uppwd")]
        public IHttpActionResult UpdatePasswordjwt(string token)
        {
            string fin = UpdatePassword(token);
            string jwt = JWTUtils.GenerateJWTReturn(fin);
            return Ok(new { jwt });
        }

        public string UpdatePassword(string token)
        {
            try
            {
                var claimsPrincipal = JWTUtils.ValidateJWT(token);
                var claims = claimsPrincipal.Claims;
                string password = "";
                string email = "";

                // Lấy các thông tin cần thiết từ JWT
                if (claims != null)
                {
                    password = claims.FirstOrDefault(c => c.Type == "password")?.Value;
                    email = claims.FirstOrDefault(c => c.Type == "Email")?.Value;
                }
                else
                {
                    return "JWT bị null.";
                }

                // Kiểm tra thông tin cần thiết
                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
                {
                    return "Dữ liệu không hợp lệ từ JWT.";
                }

                // Kiểm tra sự tồn tại của bản ghi trong cơ sở dữ liệu
                var existingRecord = db.Employees.SingleOrDefault(wsh => wsh.Email.Trim() == email.Trim());
                if (existingRecord == null)
                {
                    return "Không tìm thấy bản ghi trong cơ sở dữ liệu.";
                }

                // Cập nhật mật khẩu
                existingRecord.Password = password;

                // Thực hiện lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                return "Successfully";
            }
            catch (Exception ex)
            {
                return "catcherror";
            }
        }


        //find list fws by date jwt
        [HttpGet]
        [Route("api/ms/fwsd")]
        public IHttpActionResult listWorkSheetByDatejwt(string idemp, string dateStar, string dateEnd)
        {

            List<WorkSheetDTO> worksheetDTOs = ListWorkSheetByDate(idemp, dateStar, dateEnd);

            string jwt = JWTUtils.GenerateJWTFLWS(worksheetDTOs);

            return Ok(new { jwt });
        }

        //find list fws by date ol
        [HttpGet]
        [Route("api/ms/fwsdt")]
        public List<WorkSheetDTO> ListWorkSheetByDate(string idemp, string dateStar, string dateEnd)
        {
            if (!DateTime.TryParse(dateStar, out DateTime startDate) || !DateTime.TryParse(dateEnd, out DateTime endDate))
            {
                throw new ArgumentException("Ngày không hợp lệ");
            }

            List<WorkSheet> filteredWorksheets = db.WorkSheets
       .Where(ws => ws.IdEmp == idemp && ws.Date >= startDate && ws.Date <= endDate && ws.Status == true)
       .ToList();

            List<WorkSheetDTO> worksheetDTOs = filteredWorksheets.Select(ws => new WorkSheetDTO
            {
                Date = ws.Date.HasValue ? ws.Date.Value.ToString("dd/MM/yyyy") : string.Empty,
                TimeCheckIn = ws.TimeCheckIn.HasValue ? ws.TimeCheckIn.Value.ToString("HH:mm:ss") : string.Empty,
                TimeCheckOut = ws.TimeCheckOut.HasValue ? ws.TimeCheckOut.Value.ToString("HH:mm:ss") : string.Empty,
                Total_working_hours = ws.Total_working_hours.HasValue ? ws.Total_working_hours.Value.ToString() : string.Empty,
            }).ToList();

            return worksheetDTOs;
        }



        //find fws jwt
        [HttpGet]
        [Route("api/ms/fws")]
        public IHttpActionResult FindWorkSheets(string idemp, string date)
        {


            WorkSheetDTO worksheetDTO = FindWorkSheetst(idemp, date);

            string jwt = JWTUtils.GenerateJWTFWS(worksheetDTO);

            return Ok(new { jwt });
        }

        //find wS
        [HttpGet]
        [Route("api/ms/fwst")]
        public WorkSheetDTO FindWorkSheetst(string idemp, string date)
        {
            if (!DateTime.TryParse(date, out DateTime searchDate))
            {
                throw new ArgumentException("Ngày không hợp lệ");
            }

            WorkSheet worksheet = db.WorkSheets.SingleOrDefault(ws => ws.IdEmp.Equals(idemp) && ws.Date == searchDate);

            if (worksheet == null)
            {
                return null;
            }

            WorkSheetDTO worksheetDTO = new WorkSheetDTO
            {
                Status = worksheet.Status.ToString(),
                Sheet = (int)worksheet.Sheet,
                TimeCheckIn = worksheet.TimeCheckIn.HasValue ? worksheet.TimeCheckIn.Value.ToString() : string.Empty,
                TimeCheckOut = worksheet.TimeCheckOut.HasValue ? worksheet.TimeCheckOut.Value.ToString() : string.Empty,
                Total_working_hours = worksheet.Total_working_hours.HasValue ? worksheet.Total_working_hours.Value.ToString() : string.Empty,
            };

            return worksheetDTO;
        }
        //find list sheet guard jwt
        [HttpGet]
        [Route("api/ms/fst")]
        public IHttpActionResult FindSheetjwt()
        {
            List<SheetDetailDTO> sheetList = FindSheet();

            string jwt = JWTUtils.GenerateJWTFSD(sheetList);

            return Ok(new { jwt });
        }


        //list sheet Guard
        [HttpGet]
        [Route("api/ms/fstt")]
        public List<SheetDetailDTO> FindSheet()
        {
            List<SheetDetailDTO> sheetList = new List<SheetDetailDTO>();

            List<SheetDetail> sheetDetails = db.SheetDetails.ToList();

            foreach (SheetDetail sheetD in sheetDetails)
            {
                if (sheetD.Roles == 3)
                {
                    SheetDetailDTO sheetDDTO = new SheetDetailDTO
                    {
                        Sheet = sheetD.Sheet,
                        ShiftStartTime = sheetD.ShiftStartTime.HasValue ? sheetD.ShiftStartTime.Value.ToString(@"hh\:mm\:ss") : string.Empty,
                        ShiftEndTime = sheetD.ShiftEndTime.HasValue ? sheetD.ShiftEndTime.Value.ToString(@"hh\:mm\:ss") : string.Empty,
                        CheckNight = sheetD.CheckNight.HasValue ? sheetD.CheckNight.ToString() : string.Empty,
                        CoefficientsSalary = sheetD.CoefficientsSalary.HasValue ? sheetD.CoefficientsSalary.ToString() : string.Empty
                    };
                    sheetList.Add(sheetDDTO);
                }
            }
            return sheetList;
        }

        //update worksheet jwt by qr
        [HttpGet]
        [Route("api/ms/uco/ucoqrG")]
        public IHttpActionResult UpdateWorksheetQRGet(string token)
        {
            try
            {
                var claimsPrincipal = JWTUtils.ValidateJWT(token);
                var claims = claimsPrincipal.Claims;
                string idEmp = "";
                string date = "";
                string update = "";
                string check = "";
                string coeffi = "";
                string sunday = "";

                // Lấy các thông tin cần thiết từ JWT
                if (claims != null)
                {
                    idEmp = claims.FirstOrDefault(c => c.Type == "IdEmp")?.Value;
                    date = claims.FirstOrDefault(c => c.Type == "Date")?.Value;
                    check = claims.FirstOrDefault(c => c.Type == "TimeCheckIn" || c.Type == "TimeCheckOut")?.Type;
                    update = claims.FirstOrDefault(c => c.Type == check)?.Value;
                    coeffi = claims.FirstOrDefault(c => c.Type == "default_coefficient")?.Value;
                    sunday = claims.FirstOrDefault(c => c.Type == "sunday")?.Value;
                }
                else
                {
                    Console.WriteLine("JWT bị null.");
                    return BadRequest("JWT bị null.");
                }

                // Kiểm tra thông tin cần thiết
                if (string.IsNullOrEmpty(idEmp) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(check) || string.IsNullOrEmpty(update))
                {
                    Console.WriteLine("Dữ liệu không hợp lệ từ JWT.");
                    return BadRequest("Dữ liệu không hợp lệ từ JWT.");
                }

                // Kiểm tra sự tồn tại của bản ghi trong cơ sở dữ liệu
                var existingRecord = db.WorkSheets.SingleOrDefault(wsh => wsh.IdEmp == idEmp && wsh.Date.ToString() == date);
                if (existingRecord == null)
                {
                    Console.WriteLine("Không tìm thấy bản ghi trong cơ sở dữ liệu.");
                    return NotFound();
                }

                // Cập nhật dữ liệu vào database
                if (check == "TimeCheckIn")
                {
                    existingRecord.TimeCheckIn = DateTime.ParseExact(update, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    existingRecord.Status = true;
                    existingRecord.default_coefficient = double.TryParse(coeffi, out double coeffiValue) ? coeffiValue : 0;
                    if (sunday.Equals("true"))
                    {
                        existingRecord.sunday_coefficient = 0.5;
                    }
                    else
                    {
                        existingRecord.sunday_coefficient = 0;
                    }
                }
                else
                {
                    existingRecord.TimeCheckOut = DateTime.ParseExact(update, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    TimeSpan? totalWorkingHours = existingRecord.TimeCheckOut - existingRecord.TimeCheckIn;
                    existingRecord.Total_working_hours = totalWorkingHours;
                }

                // Thực hiện lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();
                if (check == "TimeCheckIn")
                {
                    return Redirect("http://localhost:9990/MiniStoreWebMoblie/messageSCCI.jsp");
                }
                else
                {
                    return Redirect("http://localhost:9990/MiniStoreWebMoblie/messageSCCO.jsp");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return Redirect("http://localhost:9990/MiniStoreWebMoblie/error.jsp");
            }
        }


        //update worksheet jwt
        [HttpPut]
        [Route("api/ms/uco")]
        public bool UpdateWorksheet([FromBody] JObject jsonData)
        {
            try
            {
                string jwt = jsonData["jwt"].ToString();
                var claimsPrincipal = JWTUtils.ValidateJWT(jwt);
                var claims = claimsPrincipal.Claims;
                string idEmp = "";
                string date = "";
                string update = "";
                string check = "";

                // Lấy các thông tin cần thiết từ JWT
                if (claims != null)
                {
                    idEmp = claims.FirstOrDefault(c => c.Type == "IdEmp")?.Value;
                    date = claims.FirstOrDefault(c => c.Type == "Date")?.Value;
                    check = claims.FirstOrDefault(c => c.Type == "TimeCheckIn" || c.Type == "TimeCheckOut")?.Type;
                    update = claims.FirstOrDefault(c => c.Type == check)?.Value;
                }
                else
                {
                    Console.WriteLine("JWT bị null.");
                    return false;
                }

                // Kiểm tra thông tin cần thiết
                if (string.IsNullOrEmpty(idEmp) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(check) || string.IsNullOrEmpty(update))
                {
                    Console.WriteLine("Dữ liệu không hợp lệ từ JWT.");
                    return false;
                }

                // Kiểm tra sự tồn tại của bản ghi trong cơ sở dữ liệu
                var existingRecord = db.WorkSheets.SingleOrDefault(wsh => wsh.IdEmp == idEmp && wsh.Date.ToString() == date);
                if (existingRecord == null)
                {
                    Console.WriteLine("Không tìm thấy bản ghi trong cơ sở dữ liệu.");
                    return false;
                }

                // Cập nhật dữ liệu vào database
                if (check == "TimeCheckIn")
                {
                    existingRecord.TimeCheckIn = DateTime.ParseExact(update, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    existingRecord.Status = true;
                }
                else
                {
                    existingRecord.TimeCheckOut = DateTime.ParseExact(update, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                }

                // Thực hiện lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }





    }
}
