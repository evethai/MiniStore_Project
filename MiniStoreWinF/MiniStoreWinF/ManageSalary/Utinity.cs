
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

        /*Generate Id auto of object with template: CCxxxx(C: character, x: number) can identity */
        public string GenerateAutoId(int currentCount,string headId)
        {
            int nextCount = currentCount + 1;
            string id = headId + nextCount.ToString("D4");
            return id;
        }
        
        /* Constraint the textbox in form only input number with max has n number*/
        public void numberOnly(KeyPressEventArgs e,string text,int num)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' )
            {
                // Loại bỏ ký tự không hợp lệ
                e.Handled = true;
            }
            string text1 = text+e.KeyChar.ToString();
            if( text1.Length > num)
            {
                e.Handled=true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled=false;
            }
        }

        /*Show list combobox with display is name of employee anh valueSeleted is id employee
         * except Admin and help search on combobox by input text*/
        public void showListEmp_ALL(ComboBox comboBox)
        {
            _employeeService = new EmployeeService();
            var list = _employeeService.GetAll().Where(p => p.IsActive == true && p.Roles != 0 && p.Roles != 1).ToList();
            List<Employee>listTrue = new List<Employee>();
            listTrue.Insert(0, new Employee { IdEmp = "-1", FullNameEmp = "ALL" });
            foreach (Employee emp in list)
            {
                listTrue.Add(emp);
            }
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            foreach (var item in listTrue)
            {
                autoCompleteStringCollection.Add(item.FullNameEmp);
            }
            comboBox.AutoCompleteCustomSource = autoCompleteStringCollection;
            comboBox.ValueMember = "IdEmp";
            comboBox.DisplayMember = "FullNameEmp";
            comboBox.DataSource = listTrue;
        }
        /*Same showListEmp_ALL but not have ALL */
        public void showlistEmp(ComboBox comboBox)
        {
            _employeeService = new EmployeeService();
            var list = _employeeService.GetAll().Where(p => p.IsActive == true && p.Roles != 0 && p.Roles != 1).ToList();
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

        /*Combobox can show list number with max has n number*/
        public void comboxGeneration(ComboBox comboBox,int n)
        {
            List<int> num = new List<int>();
            for (int i = 0; i <= n; i++)
            {
                num.Add(i);
            }
            comboBox.DataSource = num;
        }

        /*Can take last month of the time*/
        public DateTime GetTime(DateTime currentTime)
        {
            return currentTime.AddMonths(-1);
        }

        /*Method return the number worksheet of a employee in specifically month*/
        public int sum(string id, DateTime time)
        {
            _workSheetService = new WorkSheetService();
            var sum1 = _workSheetService.GetAll().Count(p => p.IdEmp.Equals(id) && p.Date.Value.Month.Equals(time.Month) && p.Date.Value.Year.Equals(time.Year) && p.Status==true);
            return sum1;
        }

        /*Get final day in specifically month*/
        public DateTime GetLastDayOfMonth(DateTime time)
        {
            int daysInMonth = DateTime.DaysInMonth(time.Year, time.Month);
            DateTime lastDayOfMonth = new DateTime(time.Year, time.Month, daysInMonth);
            return lastDayOfMonth;
        }

        /*Get first day in specifically month*/
        public DateTime GetFirstDayofMonth(DateTime time)
        {
            int daysInMonth = 1;
            DateTime lastDayOfMonth = new DateTime(time.Year, time.Month, daysInMonth);
            return lastDayOfMonth;
        }

        /*Can open child form in panel help design display*/
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

        /*show list salary with specifically month and not have admin*/
        public List<Salary> listSalaryByTime(DateTime time)
        {
            _salaryService = new SalaryService();
            _employeeService = new EmployeeService();
            var listSal = _salaryService.GetAll().Where(p => p.DateOmonth.Month.Equals(time.Month) && p.DateOmonth.Year.Equals(time.Year)).ToList();
            var listEmp = _employeeService.GetAll().Where(p =>  p.Roles!=0 && p.Roles!=1 && p.IsActive == true).ToList();
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
        /*format the doubel to string when show in form */
        public string formatDouble (double? d)
        {
            return d?.ToString("#,###,###");
        }
    }
}
