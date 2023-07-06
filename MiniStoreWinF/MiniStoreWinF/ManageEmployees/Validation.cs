using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF.ManageEmployees
{
    public class Validation : ServiceMiniStore<Employee>
    {
        MiniStoreContext _context;
        DbSet<Employee> _employees;
        EmployeeService _employeeService = new EmployeeService();
        public Validation()
        {
            _context = new MiniStoreContext();
            _employees = _context.Set<Employee>();
        }
        public void Add(Employee employee, string prefix)
        {
            var lastRecord = _employees.OrderByDescending(record => record.IdEmp).FirstOrDefault();
            if (lastRecord != null)
            {
                employee.IdEmp = autoID(lastRecord.IdEmp, prefix);
            }
            else
            {
                employee.IdEmp = autoID(prefix+"00", prefix);
            }

            _employees.Add(employee);
            _context.SaveChanges();
        }
        public string autoID(string id, string prefix)
        {
            //SEXX
            string result = "";
            int cutID = int.Parse(id.Substring(2, 2));
            cutID++;
            int digits = 2;
            

            // Convert the current ID to string with leading zeros
            string idString = cutID.ToString().PadLeft(digits, '0');
            result = prefix + idString;

            // Combine the prefix and the formatted ID
            return result;

        }
        //Get name from application and compare with database
        public List<Employee> SearchEmployee(string name)
        {
            frmShowEmployee valid = new frmShowEmployee();
            
            var records = DataLoad().Where(entity => entity.FullNameEmp.Contains(name, StringComparison.OrdinalIgnoreCase) || entity.PhoneEmp.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            return records;
        }
        List<Employee> DataLoad()
        {
            if (ContextScope.currentEmployee.Roles >= 1)
            {
                var employeeService = _employeeService.GetAll().Where(e => e.IsActive == true && e.Roles >= 2).ToList();
               
                return employeeService;

            }
            else
            {
                var employeeService = _employeeService.GetAll().Where(e => e.IsActive == true && e.Roles >= 1).ToList();
                
                return employeeService;
            }

        }


    }
}
