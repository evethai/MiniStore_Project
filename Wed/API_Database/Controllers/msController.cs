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
        public IHttpActionResult FindAccount(string username, string password)
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
                Roles = (string)emp.Roles,
                IsActive = (Boolean)emp.IsActive
            };

            string jwt = JWTUtils.GenerateJWTFAcc(empDTO);

            return Ok(new { jwt });
        }

        //find acc
        //[HttpGet]
        //[Route("api/ms/facc")]
        //public EmployeeDTO FindAccount(string username, string password)
        //{
        //    Employee emp = db.Employees.SingleOrDefault(acc => acc.Username.Equals(username) && acc.Password.Equals(password));

        //    if (emp == null)
        //    {
        //        return null;
        //    }
        //    EmployeeDTO empDTO = new EmployeeDTO
        //    {
        //        FullNameEmp = (string)emp.FullNameEmp,
        //        IdEmp = (string)emp.IdEmp,
        //        Roles = (string)emp.Roles,
        //        IsActive = (Boolean)emp.IsActive
        //    };

        //    return empDTO;
        //}

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
                Sheet = (int)worksheet.Sheet,
                TimeCheckIn = worksheet.TimeCheckIn.HasValue ? worksheet.TimeCheckIn.Value : DateTime.MinValue,
                TimeCheckOut = worksheet.TimeCheckOut.HasValue ? worksheet.TimeCheckOut.Value : DateTime.MinValue
            };

            string jwt = JWTUtils.GenerateJWTFWS(worksheetDTO);

            return Ok(new { jwt });
        }

        //find wS
        [HttpGet]
        [Route("api/ms/fwst")]
        public WorkSheet FindWorkSheetst(string idemp, string date)
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
                Sheet = (int)worksheet.Sheet,
                TimeCheckIn = worksheet.TimeCheckIn.HasValue ? worksheet.TimeCheckIn.Value : DateTime.MinValue,
                TimeCheckOut = worksheet.TimeCheckOut.HasValue ? worksheet.TimeCheckOut.Value : DateTime.MinValue
            };

            return worksheet;
        }
        //find sheet
        [HttpGet]
        [Route("api/ms/fst")]
        public List<SheetDetailDTO> FindSheetjwt()
        {
            List<SheetDetailDTO> sheetList = new List<SheetDetailDTO>();

            List<SheetDetail> sheetDetails = db.SheetDetails.ToList();
            foreach (SheetDetail sheetD in sheetDetails)
            {
                SheetDetailDTO sheetDDTO = new SheetDetailDTO
                {
                    Sheet = sheetD.Sheet,
                    ShiftStartTime = sheetD.ShiftStartTime,
                    ShiftEndTime = sheetD.ShiftEndTime
                };
                sheetList.Add(sheetDDTO);
            }

            string jwt = JWTUtils.GenerateJWTFSD(sheetList;

            return sheetList; // Trả về danh sách chứa thông tin bản ghi
        }

        //find sheet
        [HttpGet]
        [Route("api/ms/fstt")]
        public List<SheetDetailDTO> FindSheet()
        {
            List<SheetDetailDTO> sheetList = new List<SheetDetailDTO>();

            List<SheetDetail> sheetDetails = db.SheetDetails.ToList();
            foreach (SheetDetail sheetD in sheetDetails)
            {
                SheetDetailDTO sheetDDTO = new SheetDetailDTO
                {   
                    Sheet = sheetD.Sheet,
                    ShiftStartTime = sheetD.ShiftStartTime,
                    ShiftEndTime = sheetD.ShiftEndTime
                };
                sheetList.Add(sheetDDTO);
            }

            return sheetList; // Trả về danh sách chứa thông tin bản ghi
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
                // Lấy các thông tin cần thiết từ JWT
                if (claims != null)
                {
                    idEmp = claims.FirstOrDefault(c => c.Type == "IdEmp")?.Value;
                    date = claims.FirstOrDefault(c => c.Type == "Date")?.Value;
                    update = claims.FirstOrDefault(c => c.Type == "TimeCheckOut")?.Value;
                }
                else
                {
                    Console.WriteLine("JWT bị null.");
                    return false;
                }
                // Kiểm tra thông tin cần thiết
                if (string.IsNullOrEmpty(idEmp) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(update))
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
                existingRecord.TimeCheckOut = DateTime.ParseExact(update, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);


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


        //add worksheet 
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
