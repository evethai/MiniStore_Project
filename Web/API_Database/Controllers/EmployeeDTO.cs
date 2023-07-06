using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Database.Controllers
{
    public class EmployeeDTO
    {
        public string IdEmp { get; set; }
        public string FullNameEmp { get; set; }
        public string Roles { get; set; }
        public Boolean IsActive { get; set; }

        public String TimeCheckIn { get; set; }
        public String TimeCheckOut { get; set; }
    }
}