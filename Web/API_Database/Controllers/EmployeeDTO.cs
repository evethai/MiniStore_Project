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
        public string Sex { get; set; }
        public string CCCD { get; set; }
        public string DoB { get; set; }
        public string AddressEmp { get; set; }
        public string Phone { get; set; }
        public string password { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
        public String TimeCheckIn { get; set; }
        public String TimeCheckOut { get; set; }
        public String Total_working_hours { get; set; }

    }
}