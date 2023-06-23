using Microsoft.IdentityModel.Tokens;
using MiniStoreWinF.ManageSalary;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.DashBoard
{
    public partial class frmMain : Form
    {
        EmployeeService _employeeService = new EmployeeService();
        WorkSheetService _workSheetService = new WorkSheetService();
        SheetDetailService _sheetDetailService = new SheetDetailService();
        Utinity u = new Utinity();
        public bool check;
        public string user = "";
        public DateTime currentDate = DateTime.Now;
        public string SheetWork;
        public int SheetDetails;
        public string dataEmployeeInfor { set; get; }
        public frmMain()
        {
            InitializeComponent();
            checkRoles(check);
        }

        public void checkRoles(bool b)
        {
            ToolStripMenuItem menu = menuStrip.Items["mnuAdmin"] as ToolStripMenuItem;
            if (b == false)
            {
                menu.Enabled = false;
            }
            else
            {
                menu.Enabled = true;

            }
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmDashBoard(), pMain);
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Form form = new frmLogin();
            this.Hide();
            form.ShowDialog();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //txtUser.Text = user;
            var emp = ContextScope.currentEmployee;
            txtUser.Text = emp.FullNameEmp;
        }

        private void mnuStore_Click(object sender, EventArgs e)
        {
            OrdersProducts.OrderProducts _orderProductsPage = new OrdersProducts.OrderProducts();
            u.openChildForm(_orderProductsPage, pMain);
            _orderProductsPage.DataEmployee = user;
        }

        private void btCheckIn_Click(object sender, EventArgs e)
        {
            var check_employee = _employeeService.GetAll().Where(p => p.FullNameEmp.Equals(user)).FirstOrDefault();
            AutoWorkSheetID _autoWorkSheetID = new AutoWorkSheetID();
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(now.Hour, now.Minute, 0);
            var checked_check_in = _workSheetService.GetAll().Where(p => p.IdEmp == check_employee.IdEmp && p.Date == now.Date).FirstOrDefault();
            if (checked_check_in != null)
            {
                MessageBox.Show("You have checked in already", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btCheckIn.Enabled = false;
            }
            else
            {
                var check_in_Time_Sheet = _sheetDetailService.GetAll().Where(p => p.DescriptionS.Equals(check_employee.Roles) && timeSpan >= p.ShiftStartTime
                && timeSpan <= p.ShiftEndTime).FirstOrDefault();
                if (check_in_Time_Sheet != null)
                {
                    var Check_Worksheet = _workSheetService.GetAll().FirstOrDefault();
                    Check_Worksheet.IdEmp = check_employee.IdEmp;
                    Check_Worksheet.Sheet = check_in_Time_Sheet.Sheet;
                    Check_Worksheet.Date = currentDate.Date;
                    Check_Worksheet.TimeCheckIn = currentDate;
                    Check_Worksheet.TimeCheckOut = null;
                    _autoWorkSheetID.AddID(Check_Worksheet);
                    MessageBox.Show("Your check-in was successful" +currentDate, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SheetWork = Check_Worksheet.IdWorkSheet;
                    btCheckIn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Your check-in was unsuccessful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are you sure you want to check out?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var check_employee = _employeeService.GetAll().Where(p => p.FullNameEmp.Equals(user)).FirstOrDefault();
                var Check_Worksheet = _workSheetService.GetAll().Where(p => p.IdWorkSheet == SheetWork || p.IdEmp == check_employee.IdEmp && p.Date == currentDate.Date ).FirstOrDefault();
                Check_Worksheet.TimeCheckOut = currentDate;
                _workSheetService.Update(Check_Worksheet);
                MessageBox.Show("Your check-out was successful" +currentDate, "Notification");
                btCheckOut.Enabled = false;
            }
            else
            {
                return;
            } 
        }

        private void mnuDis_Click(object sender, EventArgs e)
        {

        }

        private void mnuMoMo_Click(object sender, EventArgs e)
        {
            Form form = new frmMoMo();
            form.ShowDialog();
        }
    }
}
