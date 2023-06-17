using System;
using System.Collections.Generic;
//using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
//using Microsoft.IdentityModel.Tokens;

namespace API_Database.Controllers
{
    public class msController : ApiController
    {

        MiniStoreDataContext db = new MiniStoreDataContext("");

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

        //find acc
        [HttpGet]
        [Route("api/ms/facc")]
        public Employee FindAccount(string username, string password)
        {
            return db.Employees.SingleOrDefault(acc => acc.Username.Equals(username) && acc.Password.Equals(password));
        }

        //find wS

    [HttpGet]
    [Route("api/ms/fws")]
    public WorkSheetDTO FindWorkSheets(string idemp, string date)
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
                    IdWorkSheet = worksheet.IdWorkSheet,
                    IdEmp = worksheet.IdEmp,
                    Date = (DateTime)worksheet.Date,
                    Sheet = (int)worksheet.Sheet,
                    TimeCheckIn = worksheet.TimeCheckIn.HasValue ? worksheet.TimeCheckIn.Value : DateTime.MinValue,
                    TimeCheckOut = worksheet.TimeCheckOut.HasValue ? worksheet.TimeCheckOut.Value : DateTime.MinValue
                };

        return worksheetDTO;
    }


        //update worksheet
        [HttpPut]
        [Route("api/ms/uci")]
        public bool UpdateWorksheet([FromBody] WorkSheet ws)
        {
            try
            {
                WorkSheet old = db.WorkSheets.SingleOrDefault(wsh => wsh.IdEmp == ws.IdEmp && wsh.Date == ws.Date);
                if (ws.TimeCheckIn.HasValue)
                {
                    old.TimeCheckIn = ws.TimeCheckIn;
                }
                else
                {
                    old.TimeCheckOut = ws.TimeCheckOut;
                }
                
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi o day: " + ex.Message);
                return false;
            }
        }



    }
}
