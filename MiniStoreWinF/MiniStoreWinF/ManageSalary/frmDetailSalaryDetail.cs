using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MiniStoreWinF.ManageSalary
{
    public partial class frmDetailSalaryDetail : Form
    {
        WorkSheetService _workSheetService;
        SalaryService _salaryService;
        OrderService _orderService;
        EmployeeService _employeeService;

        public frmDetailSalaryDetail()
        {
            InitializeComponent();
            _salaryService = new SalaryService();
            _workSheetService = new WorkSheetService();
            _employeeService = new EmployeeService();
            _orderService = new OrderService();

        }

        private void frmDetailSalaryDetail_Load(object sender, EventArgs e)
        {
            string id = ContextScope.currentSalary.IdEmp;
            DateTime time = ContextScope.currentSalary.DateImonth;
            txtTime.Text = time.Month + "/" + time.Year;
            txtHour.Text = u.formatDouble(sumHourinMonth(time, id));
            txtRevenus.Text = u.formatDouble(sumOrdersInMonth(time, id));
            txtOrder.Text = countTotal(time, id).ToString();
            txtName.Text = name(id)+"  ("+role(id)+")";
            Info_DeTail_Salary(id, time);
        }


        public double sumHourinMonth(DateTime time, string id)
        {
            double sum = 0;
            var list = _workSheetService.GetAll().Where(p => p.Date.Value.Month.Equals(time.Month) && p.Date.Value.Year.Equals(time.Year) && p.IdEmp.Equals(id) && p.Status == true).ToList();
            foreach (var item in list)
            {
                sum += (item.TimeCheckOut.Value.TimeOfDay - item.TimeCheckIn.Value.TimeOfDay).TotalHours;
            }
            return sum;
        }
        public double? sumOrdersInMonth(DateTime time, string id)
        {

            double? total = 0;
            var list = _orderService.GetAll().Where(p => p.IdEmp.Equals(id) && p.DateOrders.Value.Month.Equals(time.Month) && p.DateOrders.Value.Year.Equals(time.Year)).ToList();
            foreach (var item in list)
            {
                total += item.Total;
            }
            return total;
        }
        public int countTotal(DateTime time, string id)
        {
            var count = _orderService.GetAll().Count(p => p.IdEmp.Equals(id) && p.DateOrders.Value.Month.Equals(time.Month) && p.DateOrders.Value.Year.Equals(time.Year));
            return count;
        }
        public string name(string id)
        {
            string emp = "";
            var list = _employeeService.GetAll().Where(p => p.IdEmp.Equals(id)).FirstOrDefault();
            if (list != null)
            {
                emp = list.FullNameEmp;
            }
            return emp;
        }

        public string role(string id)
        {
            PermissionService _permissionService = new PermissionService();
            string role = "";
            var emp = _employeeService.GetAll().Where(p => p.IdEmp.Equals(id)).FirstOrDefault();
            var nameRole = _permissionService.GetAll().Where(p=>p.Roles == emp.Roles).FirstOrDefault();
            role = nameRole.Permission1.ToLowerInvariant();
            return role;
        }

        ////////////////////////////

        Utinity u = new Utinity();
        public void Info_DeTail_Salary(string id, DateTime time)
        {
            var emp = _employeeService.GetAll().Where(p => p.IdEmp.Equals(id)).FirstOrDefault();

            HeSoTinhLuongService _heSoTinhLuongService = new HeSoTinhLuongService();
            var hstl = _heSoTinhLuongService.GetAll().FirstOrDefault();

            bhxh.Text = bhxh.Text + "(" + hstl.Bhxh * 100 + "%)";
            bhyt.Text = bhyt.Text + "(" + hstl.Bhyt * 100 + "%)";
            bhtn.Text = bhtn.Text + "(" + hstl.Bhtn * 100 + "%)";
            gtgcnpt.Text = gtgcnpt.Text + "(" + emp.Snpt + ")";

            SalaryService _salaryService = new SalaryService();
            var salary = _salaryService.GetAll().Where(p => p.IdEmp.Equals(id) && p.DateImonth.Month.Equals(time.Month) && p.DateImonth.Year.Equals(time.Year)).FirstOrDefault();


            _luongcb.Text = u.formatDouble(salary.BasicSalary);
            if (salary.BasicSalary >= hstl.MucBhToiDa)
            {
                _bhxh.Text = "(deduct) " + u.formatDouble(hstl.MucBhToiDa * hstl.Bhxh);
                _bhyt.Text = "(deduct) " + u.formatDouble(hstl.MucBhToiDa * hstl.Bhyt);
                _bhtn.Text = "(deduct) " + u.formatDouble(salary.BasicSalary * hstl.Bhtn);
                _tntt.Text = u.formatDouble(salary.BasicSalary - (hstl.MucBhToiDa * hstl.Bhxh) - (hstl.MucBhToiDa * hstl.Bhyt) - (salary.BasicSalary * hstl.Bhtn));
                _gtgccn.Text = "(deduct) " + u.formatDouble(hstl.GtgcBanthan);

                _gtgcnpt.Text = "(deduct) " + (emp.Snpt * hstl.GtgcNpt).ToString();

                if (salary.SalaryBeforTax - hstl.GtgcBanthan - (emp.Snpt * hstl.GtgcNpt) < 0)
                {
                    _tnct.Text = "0";
                }
                else
                {
                    _tnct.Text = u.formatDouble(salary.SalaryBeforTax - hstl.GtgcBanthan - (emp.Snpt * hstl.GtgcNpt));
                }

                _ttncn.Text = "(deduct) " + (salary.Tax).ToString();
                _luong.Text = u.formatDouble(salary.FinalSalary);
            }
            else
            {
                _bhxh.Text = "(deduct) " + u.formatDouble(salary.BasicSalary * hstl.Bhxh);
                _bhyt.Text = "(deduct) " + u.formatDouble(salary.BasicSalary * hstl.Bhyt);
                _bhtn.Text = "(deduct) " + u.formatDouble(salary.BasicSalary * hstl.Bhtn);
                _tntt.Text = u.formatDouble(salary.BasicSalary - (salary.BasicSalary * hstl.Bhxh) - (salary.BasicSalary * hstl.Bhyt) - (salary.BasicSalary * hstl.Bhtn));
                _gtgccn.Text = "(deduct) " + u.formatDouble(hstl.GtgcBanthan);

                _gtgcnpt.Text = "(deduct) " + (emp.Snpt * hstl.GtgcNpt).ToString();

                if (salary.SalaryBeforTax - hstl.GtgcBanthan - (emp.Snpt * hstl.GtgcNpt) < 0)
                {
                    _tnct.Text = "0";
                }
                else
                {
                    _tnct.Text = u.formatDouble(salary.SalaryBeforTax - hstl.GtgcBanthan - (emp.Snpt * hstl.GtgcNpt));
                }

                _ttncn.Text = "(deduct) " + (salary.Tax).ToString();
                _luong.Text = u.formatDouble(salary.FinalSalary);
            }
            double? thu_nhap_chiu_thue = salary.SalaryBeforTax - hstl.GtgcBanthan - (emp.Snpt * hstl.GtgcNpt);
            if (thu_nhap_chiu_thue > 0 && thu_nhap_chiu_thue <= 5000000)
            {
                lbl5p.Text = u.formatDouble(thu_nhap_chiu_thue * 5 / 100);
            }
            else if (thu_nhap_chiu_thue > 5000000 && thu_nhap_chiu_thue <= 10000000)
            {
                lbl5p.Text = u.formatDouble(250000);
                thu_nhap_chiu_thue = thu_nhap_chiu_thue - 5000000;
                lbl10p.Text = u.formatDouble(thu_nhap_chiu_thue * 10 / 100);
            }
            else if (thu_nhap_chiu_thue > 10000000 && thu_nhap_chiu_thue <= 18000000)
            {
                lbl5p.Text = u.formatDouble(250000);
                lbl10p.Text = u.formatDouble(500000);
                thu_nhap_chiu_thue = thu_nhap_chiu_thue - 10000000;
                lbl15p.Text = u.formatDouble(thu_nhap_chiu_thue * 15 / 100);
            }
            else if (thu_nhap_chiu_thue > 18000000 && thu_nhap_chiu_thue <= 32000000)
            {
                lbl5p.Text = u.formatDouble(250000);
                lbl10p.Text = u.formatDouble(500000);
                lbl15p.Text = u.formatDouble(1200000);
                thu_nhap_chiu_thue = thu_nhap_chiu_thue - 18000000;
                lbl20p.Text = u.formatDouble(thu_nhap_chiu_thue * 20 / 100);
            }
            else if (thu_nhap_chiu_thue > 32000000 && thu_nhap_chiu_thue <= 52000000)
            {
                lbl5p.Text = u.formatDouble(250000);
                lbl10p.Text = u.formatDouble(500000);
                lbl15p.Text = u.formatDouble(1200000);
                lbl20p.Text = u.formatDouble(2800000);
                thu_nhap_chiu_thue = thu_nhap_chiu_thue - 32000000;
                lbl25p.Text = u.formatDouble(thu_nhap_chiu_thue * 25 / 100);
            }
            else if (thu_nhap_chiu_thue > 52000000 && thu_nhap_chiu_thue < 80000000)
            {
                lbl5p.Text = u.formatDouble(250000);
                lbl10p.Text = u.formatDouble(500000);
                lbl15p.Text = u.formatDouble(1200000);
                lbl20p.Text = u.formatDouble(2800000);
                lbl25p.Text = u.formatDouble(5000000);
                thu_nhap_chiu_thue = thu_nhap_chiu_thue - 52000000;
                lbl30p.Text = u.formatDouble(thu_nhap_chiu_thue * 30 / 100);
            }
            else if (thu_nhap_chiu_thue > 80000000)
            {
                lbl5p.Text = u.formatDouble(250000);
                lbl10p.Text = u.formatDouble(500000);
                lbl15p.Text = u.formatDouble(1200000);
                lbl20p.Text = u.formatDouble(2800000);
                lbl25p.Text = u.formatDouble(5000000);
                lbl30p.Text = u.formatDouble(8400000);
                thu_nhap_chiu_thue = thu_nhap_chiu_thue - 80000000;
                lbl35p.Text = u.formatDouble(thu_nhap_chiu_thue * 35 / 100);
            }

        }
        CalculationAuto ca = new CalculationAuto();
        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Only for excel Microsoft offical!", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string id = ContextScope.currentSalary.IdEmp;
                    double salary = ca.HourSalary(id);
                    DateTime time = ContextScope.currentSalary.DateImonth;
                    double hour = sumHourinMonth(time, id);

                    _salaryService = new SalaryService();
                    var sa = _salaryService.GetAll().Where(p => p.IdEmp.Equals(id)).FirstOrDefault();
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbook xlWbook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWsheet, xlWsheet2;
                    object data = System.Reflection.Missing.Value;
                    xlWbook = excel.Workbooks.Add(data);

                    //
                    xlWsheet2 = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.Add();
                    xlWsheet2.Name = "Detail";
                    xlWsheet2.Cells[1, 1].Value = "Basic salary";
                    xlWsheet2.Cells[1, 2].Value = "Social insurace";
                    xlWsheet2.Cells[1, 3].Value = "Health insurace";
                    xlWsheet2.Cells[1, 4].Value = "Unemployment insurace";
                    xlWsheet2.Cells[1, 5].Value = "Befor tax";
                    xlWsheet2.Cells[1, 6].Value = "Reduce your family situation";
                    xlWsheet2.Cells[1, 7].Value = "Reducing dependents' family circumstances";
                    xlWsheet2.Cells[1, 8].Value = "Income tax";
                    xlWsheet2.Cells[1, 9].Value = "Personal income tax";
                    xlWsheet2.Cells[1, 9].Value = "Final salary";
                    //
                    xlWsheet2.Cells[2, 1].Value = sa.BasicSalary;
                    xlWsheet2.Cells[2, 2].Value = _bhxh.Text;
                    xlWsheet2.Cells[2, 3].Value = _bhyt.Text;
                    xlWsheet2.Cells[2, 4].Value = _bhtn.Text;
                    xlWsheet2.Cells[2, 5].Value = _tntt.Text;
                    xlWsheet2.Cells[2, 6].Value = _gtgccn.Text;
                    xlWsheet2.Cells[2, 7].Value = _gtgcnpt.Text;
                    xlWsheet2.Cells[2, 8].Value = _tnct.Text;
                    xlWsheet2.Cells[2, 9].Value = _ttncn.Text;
                    xlWsheet2.Cells[2, 9].Value = _luong.Text;
                    //


                    xlWsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.Add();
                    xlWsheet.Name = "Salary";
                    xlWsheet.Cells[1, 1].Value = "Name";
                    xlWsheet.Cells[1, 2].Value = "Number hour";
                    xlWsheet.Cells[1, 3].Value = "Money of each(hour)";
                    xlWsheet.Cells[1, 4].Value = "Salary by hour";
                    xlWsheet.Cells[1, 5].Value = "Sub salary";
                    xlWsheet.Cells[1, 6].Value = "Basic salary";
                    xlWsheet.Cells[1, 7].Value = "Salary befor tax";
                    xlWsheet.Cells[1, 8].Value = "Income tax";
                    xlWsheet.Cells[1, 9].Value = "Advance salary";
                    xlWsheet.Cells[1, 10].Value = "Final salary";
                    xlWsheet.Cells[1, 11].Value = "Time";
                    //
                    xlWsheet.Cells[2, 1].Value = sa.IdEmp;
                    xlWsheet.Cells[2, 2].Value = hour;
                    xlWsheet.Cells[2, 3].Value = salary.ToString();
                    xlWsheet.Cells[2, 4].Value = sa.SalaryByHour;
                    xlWsheet.Cells[2, 5].Value = sa.SubSalary;
                    xlWsheet.Cells[2, 6].Value = sa.BasicSalary;
                    xlWsheet.Cells[2, 7].Value = sa.SalaryBeforTax;
                    xlWsheet.Cells[2, 8].Value = sa.Tax;
                    xlWsheet.Cells[2, 9].Value = sa.AdvSalary;
                    xlWsheet.Cells[2, 10].Value = sa.FinalSalary;
                    xlWsheet.Cells[2, 10].Value = sa.DateImonth.Month;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Can not find Microsoft offical in you device!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                return;
            }
        }

    }

}
