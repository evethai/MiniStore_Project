using System;
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
            // Kiểm tra tài khoản và mật khẩu
            Employee emp = db.Employees.SingleOrDefault(acc => acc.Username.Equals(username) && acc.Password.Equals(password));

            if (emp == null)
            {
                return null;
            }

            if (!DateTime.TryParse(DateTime.Now.Date.ToString(), out DateTime searchDate))
            {
                throw new ArgumentException("Ngày không hợp lệ");
            }

            WorkSheet worksheet = db.WorkSheets.SingleOrDefault(ws => ws.IdEmp.Equals((string)emp.IdEmp) && ws.Date == searchDate);


            // Nếu tài khoản hợp lệ
            EmployeeDTO empDTO = new EmployeeDTO
            {
                FullNameEmp = (string)emp.FullNameEmp,
                IdEmp = (string)emp.IdEmp,
                Roles = (string)emp.Roles.ToString(),
                IsActive = (Boolean)emp.IsActive,
                TimeCheckIn = worksheet != null ? (string)worksheet.TimeCheckIn.ToString() : "nonsheet",
                TimeCheckOut = worksheet != null ? (string)worksheet.TimeCheckOut.ToString() : "noOut"
            };

            string jwt = JWTUtils.GenerateJWTFAcc(empDTO);

            return Ok(new { jwt });
        }

        // jwt and chuyển trang
        [HttpGet]
        [Route("api/ms/faccct")]
        public IHttpActionResult FindAccountjwttran(string username, string password)
        {
            // Kiểm tra tài khoản và mật khẩu
            Employee emp = db.Employees.SingleOrDefault(acc => acc.Username.Equals(username) && acc.Password.Equals(password));

            if (emp == null)
            {
                return null;
            }

            // Nếu tài khoản hợp lệ
            EmployeeDTO empDTO = new EmployeeDTO
            {
                FullNameEmp = (string)emp.FullNameEmp,
                IdEmp = (string)emp.IdEmp,
                Roles = (string)emp.Roles.ToString(),
                IsActive = (Boolean)emp.IsActive
            };

            string jwt = JWTUtils.GenerateJWTFAcc(empDTO);

            // Redirect to qr-code.jsp
            var response = Redirect("http://localhost:9990/MiniStoreWebMoblie/qr-code.jsp");
            return response;
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

            WorkSheet worksheet = db.WorkSheets.SingleOrDefault(ws => ws.IdEmp.Equals((string)emp.IdEmp) && ws.Date == searchDate);

            EmployeeDTO empDTO = new EmployeeDTO
            {
                FullNameEmp = (string)emp.FullNameEmp,
                IdEmp = (string)emp.IdEmp,
                Roles = (string)emp.Roles.ToString(),
                IsActive = (Boolean)emp.IsActive,
                TimeCheckIn = worksheet != null ? (string)worksheet.TimeCheckIn.ToString() : "nonsheet",
                TimeCheckOut = worksheet != null ? (string)worksheet.TimeCheckOut.ToString() : "noOut"
            };

            return empDTO;
        }



        //find list fws by date jwt
        [HttpGet]
        [Route("api/ms/fwsd")]
        public IHttpActionResult listWorkSheetByDatejwt(string idemp, string dateStar, string dateEnd)
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
                Date = ws.Date.HasValue ? ws.TimeCheckIn.Value : DateTime.MinValue,
                TimeCheckIn = ws.TimeCheckIn.HasValue ? ws.TimeCheckIn.Value.ToString("HH:mm:ss") : string.Empty,
                TimeCheckOut = ws.TimeCheckOut.HasValue ? ws.TimeCheckOut.Value.ToString("HH:mm:ss") : string.Empty
            }).ToList();

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
                Date = ws.Date.HasValue ? ws.TimeCheckIn.Value : DateTime.MinValue,
                TimeCheckIn = ws.TimeCheckIn.HasValue ? ws.TimeCheckIn.Value.ToString("HH:mm:ss") : string.Empty,
                TimeCheckOut = ws.TimeCheckOut.HasValue ? ws.TimeCheckOut.Value.ToString("HH:mm:ss") : string.Empty
            }).ToList();

            return worksheetDTOs;
        }



        //find fws jwt
        [HttpGet]
        [Route("api/ms/fws")]
        public IHttpActionResult FindWorkSheets(string idemp, string date)
        {
            if (!DateTime.TryParse(date, out DateTime searchDate))
            {
                throw new ArgumentException("Ngày không hợp lệ");
            }

            WorkSheet worksheet = db.WorkSheets.SingleOrDefault(ws => ws.IdEmp.Equals(idemp) && ws.Date == searchDate);

            if (worksheet == null)
            {
                return Ok();
            }

            // Nếu tài khoản hợp lệ
            WorkSheetDTO worksheetDTO = new WorkSheetDTO
            {
                Status = worksheet.Status.ToString(),
                Sheet = (int)worksheet.Sheet,
                TimeCheckIn = worksheet.TimeCheckIn.HasValue ? worksheet.TimeCheckIn.Value.ToString() : string.Empty,
                TimeCheckOut = worksheet.TimeCheckOut.HasValue ? worksheet.TimeCheckOut.Value.ToString() : string.Empty
            };

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
                TimeCheckOut = worksheet.TimeCheckOut.HasValue ? worksheet.TimeCheckOut.Value.ToString() : string.Empty
            };

            return worksheetDTO;
        }
        //find list sheet guard jwt
        [HttpGet]
        [Route("api/ms/fst")]
        public IHttpActionResult FindSheetjwt()
        {
            List<SheetDetailDTO> sheetList = new List<SheetDetailDTO>();

            List<SheetDetail> sheetDetails = db.SheetDetails.ToList();

            foreach (SheetDetail sheetD in sheetDetails)
            {
                if (sheetD.DescriptionS.Trim() == "Guard")
                {
                    SheetDetailDTO sheetDDTO = new SheetDetailDTO
                    {
                        Sheet = sheetD.Sheet,
                        ShiftStartTime = sheetD.ShiftStartTime.HasValue
        ? sheetD.ShiftStartTime.Value.ToString(@"hh\:mm\:ss")
        : string.Empty,
                        ShiftEndTime = sheetD.ShiftEndTime.HasValue
        ? sheetD.ShiftEndTime.Value.ToString(@"hh\:mm\:ss")
        : string.Empty
                    };
                    sheetList.Add(sheetDDTO);
                }
            }

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
                if (sheetD.DescriptionS.Trim() == "Guard")
                {
                    SheetDetailDTO sheetDDTO = new SheetDetailDTO
                    {
                        Sheet = sheetD.Sheet,
                        ShiftStartTime = sheetD.ShiftStartTime.HasValue
        ? sheetD.ShiftStartTime.Value.ToString(@"hh\:mm\:ss")
        : string.Empty,
                        ShiftEndTime = sheetD.ShiftEndTime.HasValue
        ? sheetD.ShiftEndTime.Value.ToString(@"hh\:mm\:ss")
        : string.Empty
                    };
                    sheetList.Add(sheetDDTO);
                }
            }
            return sheetList;
        }

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
                }
                else
                {
                    existingRecord.TimeCheckOut = DateTime.ParseExact(update, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
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


        //update worksheet jwt by qr
        [HttpPut]
        [Route("api/ms/ucoqr")]
        public IHttpActionResult UpdateWorksheetQR(string token)
        {
            try
            {
                var claimsPrincipal = JWTUtils.ValidateJWT(token);
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
                }
                else
                {
                    existingRecord.TimeCheckOut = DateTime.ParseExact(update, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                }

                // Thực hiện lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                // Chuyển hướng người dùng đến trang "http://localhost:9990/MiniStoreWebMoblie/messageSCCI.jsp"
                return Redirect("http://localhost:9990/MiniStoreWebMoblie/messageSCCI.jsp");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return InternalServerError(ex);
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



        //add worksheet jwt
        [HttpPost]
        [Route("api/ms/addws")]
        public bool AddWorkSheet([FromBody] JObject jsonData)
        {
            try
            {
                string jwt = jsonData["jwt"].ToString();
                var claimsPrincipal = JWTUtils.ValidateJWT(jwt);
                var claims = claimsPrincipal.Claims;
                string idEmpjwt = "";
                string datejwt = "";
                string sheetjwt = "";
                string timeCheckInjwt = "";

                // Lấy IdWorkSheet cuối cùng
                var lastIdWorkSheet = db.WorkSheets
                    .OrderByDescending(ws => ws.IdWorkSheet)
                    .Select(ws => ws.IdWorkSheet)
                    .FirstOrDefault();
                var newIdWorkSheet = Myutils.IncrementIdWorkSheet(lastIdWorkSheet);

                // Lấy các thông tin cần thiết từ JWT
                if (claims != null)
                {
                    idEmpjwt = claims.FirstOrDefault(c => c.Type == "IdEmp")?.Value;
                    datejwt = claims.FirstOrDefault(c => c.Type == "Date")?.Value;
                    sheetjwt = claims.FirstOrDefault(c => c.Type == "Sheet")?.Value;
                    timeCheckInjwt = claims.FirstOrDefault(c => c.Type == "TimeCheckIn")?.Value;
                }
                else
                {
                    Console.WriteLine("JWT bị null!!!");
                    return false;
                }

                WorkSheet workSheet = new WorkSheet
                {
                    IdWorkSheet = newIdWorkSheet,
                    IdEmp = idEmpjwt,
                    Date = DateTime.ParseExact(datejwt, "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Sheet = int.Parse(sheetjwt),
                    TimeCheckIn = DateTime.ParseExact(timeCheckInjwt, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                };
                db.WorkSheets.InsertOnSubmit(workSheet);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi o day: " + ex.Message);
                return false;
            }
        }




        //update worksheet
        //[HttpPut]
        //[Route("api/ms/uci")]
        //public bool UpdateWorksheet([FromBody] WorkSheet ws)
        //{
        //    try
        //    {
        //        WorkSheet old = db.WorkSheets.SingleOrDefault(wsh => wsh.IdEmp == ws.IdEmp && wsh.Date == ws.Date);
        //        if (ws.TimeCheckIn.HasValue)
        //        {
        //            old.TimeCheckIn = ws.TimeCheckIn;
        //        }
        //        else
        //        {
        //            old.TimeCheckOut = ws.TimeCheckOut;
        //        }

        //        db.SubmitChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Loi o day: " + ex.Message);
        //        return false;
        //    }
        //}



    }
}
