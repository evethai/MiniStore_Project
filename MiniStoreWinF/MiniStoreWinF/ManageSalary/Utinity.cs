
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MiniStoreWinF.ManageSalary
{
    public class Utinity
    {
        EmployeeService _employeeService;
        WorkSheetService _workSheetService;
        SalaryService _salaryService;
        public string GenerateAutoId(int currentCount,string headId)
        {
            int nextCount = currentCount + 1;
            string id = headId + nextCount.ToString("D4");
            return id;
        }
        
        public void numberOnly(KeyPressEventArgs e,string text)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' )
            {
                // Loại bỏ ký tự không hợp lệ
                e.Handled = true;
            }
            string text1 = text+e.KeyChar.ToString();
            if( text1.Length > 9)
            {
                e.Handled=true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled=false;
            }
        }
        public void showListEmp(ComboBox comboBox)
        {
            _employeeService = new EmployeeService();
            var list = _employeeService.GetAll().Where(p => p.IsActive == true && !p.Roles.Equals("Admin")).ToList();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            foreach (var item in list)
            {
                autoCompleteStringCollection.Add(item.FullNameEmp);
            }
            comboBox.AutoCompleteCustomSource = autoCompleteStringCollection;
            comboBox.ValueMember = "IdEmp";
            comboBox.DisplayMember = "FullNameEmp";
            comboBox.DataSource = list;
        }
        public void TaxOnly(KeyPressEventArgs e, string text)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự không hợp lệ
                e.Handled = true;
            }
            string text1 = text + e.KeyChar.ToString();
            if (text1.Length > 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
        public DateTime GetTime(DateTime currentTime)
        {
            return currentTime.AddMonths(-1);
        }

        public int sum(string id, DateTime time)
        {
            _workSheetService = new WorkSheetService();
            var sum1 = _workSheetService.GetAll().Count(p => p.IdEmp.Equals(id) && p.Date.Value.Month.Equals(time.Month));
            return sum1;
        }
        public DateTime GetLastDayOfMonth(DateTime time)
        {
            int daysInMonth = DateTime.DaysInMonth(time.Year, time.Month);
            DateTime lastDayOfMonth = new DateTime(time.Year, time.Month, daysInMonth);
            return lastDayOfMonth;
        }
        public DateTime GetFirstDayofMonth(DateTime time)
        {
            int daysInMonth = 1;
            DateTime lastDayOfMonth = new DateTime(time.Year, time.Month, daysInMonth);
            return lastDayOfMonth;
        }

        public Form currentFormChild;
        public void openChildForm(Form childForm,Panel p)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;//đặt thuộc tính cho form con không được hiển thị độc lập
            childForm.FormBorderStyle = FormBorderStyle.None;//tắt đường viền tắt các nút thu nhỏ mở rộng hay đóng form con
            childForm.Dock = DockStyle.Fill;//form con lấp đầy panel body
            p.Controls.Add(childForm);//thêm form con vào panel body
            p.Tag = childForm;//gán form con cho thuộc tính tag của panel để lưu trử thông tin form con
            childForm.BringToFront();//ĐƯA form con ra trước trong các điều khiển panel
            childForm.Show();//hiện thị nó 
        }

        public List<Salary> salary()
        {
            _salaryService = new SalaryService();
            _employeeService = new EmployeeService();
            var listSal = _salaryService.GetAll().Where(p => p.DateOmonth.Month.Equals(DateTime.Now.AddMonths(-1).Month)).ToList();
            var listEmp = _employeeService.GetAll().Where(p => p.IsActive == true && !p.Roles.Equals("Admin")).ToList();
            List<Salary> listTrue = new List<Salary>();
            foreach (var emp in listEmp)
            {
                foreach (var sa in listSal)
                {
                    if (sa.IdEmp.Equals(emp.IdEmp))
                    {
                        listTrue.Add(sa);
                    }
                }
            }
            return listTrue;
        }
    }
}
