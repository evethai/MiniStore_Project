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
        public Validation()
        {
            _context = new MiniStoreContext();
            _employees = _context.Set<Employee>();
        }
        public void Add(Employee employee)
        {
            var lastRecord = _employees.OrderByDescending(record => record.IdEmp).FirstOrDefault();
            if (lastRecord != null)
            {
                employee.IdEmp = autoID(lastRecord.IdEmp);
            }
            else
            {
                employee.IdEmp = autoID("SE00");
            }

            _employees.Add(employee);
            _context.SaveChanges();
        }
        public string autoID(string id)
        {
            //SEXX
            string result = "";
            int cutID = int.Parse(id.Substring(2, 2));
            cutID++;
            int digits = 2;
            string prefix = "SE";

            // Convert the current ID to string with leading zeros
            string idString = cutID.ToString().PadLeft(digits, '0');
            result = prefix + idString;

            // Combine the prefix and the formatted ID
            return result;

        }
        //Get name from application and compare with database
        public List<Employee> GetName(string name)
        {
            var records = _employees.Where(entity => entity.FullNameEmp.Contains(name)).ToList();

            return records;
        }
        //Get username from application and compare with database
        //public List<Employee> Duplicated(string name)
        //{
        //    var records = _employees.Where(entity => entity.Username.Equals(name)).FirstOrDefault();
        //    return records;
            
        //}
    }
}
