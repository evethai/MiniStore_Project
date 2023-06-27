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
                Roles = (string)emp.Roles.ToString(),
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

        //find fws by date jwt
        [HttpGet]
        [Route("api/ms/fwsd")]
        public IHttpActionResult listWorkSheetByDatejwt(string date)
        {
            if (!DateTime.TryParse(date, out DateTime searchDate))
            {
                throw new ArgumentException("Ngày không hợp lệ");
            }

            // Giả sử bạn có một tập hợp các đối tượng WorkSheet được gọi là 'worksheets'
            List<WorkSheet> filteredWorksheets = db.WorkSheets.Where(ws => ws.Date.ToString().Equals(searchDate.Date)).ToList();
            if (filteredWorksheets == null)
            {
                return Ok();
            }

            List<WorkSheetDTO> worksheetDTOs = filteredWorksheets.Select(ws => new WorkSheetDTO
            {
                Sheet = (int)ws.Sheet, // Điều chỉnh tùy thuộc vào thuộc tính Sheet trong lớp WorkSheetDTO
                TimeCheckIn = ws.TimeCheckIn.HasValue ? ws.TimeCheckIn.Value : DateTime.MinValue,
                TimeCheckOut = ws.TimeCheckOut.HasValue ? ws.TimeCheckOut.Value : DateTime.MinValue
            }).ToList();

            string jwt = JWTUtils.GenerateJWTFLWS(worksheetDTOs);

            return Ok(new { jwt });
        }

        //find fws by date 
        [HttpGet]
        [Route("api/ms/fwsdt")]
        public List<WorkSheetDTO> listWorkSheetByDate(string date)
        {
            if (!DateTime.TryParse(date, out DateTime searchDate))
            {
                throw new ArgumentException("Ngày không hợp lệ");
            }

            // Giả sử bạn có một tập hợp các đối tượng WorkSheet được gọi là 'worksheets'
            List<WorkSheet> filteredWorksheets = db.WorkSheets.Where(ws => ws.Date.ToString().Equals(searchDate.Date)).ToList();
            if (filteredWorksheets == null)
            {
                return null;
            }

            List<WorkSheetDTO> worksheetDTOs = filteredWorksheets.Select(ws => new WorkSheetDTO
            {
                Sheet = (int)ws.Sheet, // Điều chỉnh tùy thuộc vào thuộc tính Sheet trong lớp WorkSheetDTO
                TimeCheckIn = ws.TimeCheckIn.HasValue ? ws.TimeCheckIn.Value : DateTime.MinValue,
                TimeCheckOut = ws.TimeCheckOut.HasValue ? ws.TimeCheckOut.Value : DateTime.MinValue
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
                TimeCheckIn = worksheet.TimeCheckIn.HasValue ? worksheet.TimeCheckIn.Value : DateTime.MinValue,
                TimeCheckOut = worksheet.TimeCheckOut.HasValue ? worksheet.TimeCheckOut.Value : DateTime.MinValue
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
                TimeCheckIn = worksheet.TimeCheckIn.HasValue ? worksheet.TimeCheckIn.Value : DateTime.MinValue,
                TimeCheckOut = worksheet.TimeCheckOut.HasValue ? worksheet.TimeCheckOut.Value : DateTime.MinValue
            };

            return worksheetDTO;
        }
        //find sheet guard jwt
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
