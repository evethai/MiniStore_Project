using Microsoft.VisualBasic.ApplicationServices;
using MiniStoreWinF.InformationEmployee;
using MiniStoreWinF.ManageSalary;
using MiniStoreWinF.ManageWorkSheets;
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

namespace MiniStoreWinF.DashBoard
{
    public partial class frmMainScreen : Form
    {
        Utinity u = new Utinity();
        WorkSheetService _workSheetService = new WorkSheetService();
        SheetDetailService _sheetDetailService = new SheetDetailService();
        public frmMainScreen()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            foreach (Control control in flowPanel.Controls)
            {
                if (control is Panel)
                {
                    foreach (var item in Authorization(ContextScope.currentEmployee))
                    {
                        if (item.ActionCode.Equals(control.Name))
                        {
                            control.Enabled = false;
                            control.Visible = false;
                        }
                    }
                }
            }
            txtUser.Text = ContextScope.currentEmployee.FullNameEmp;
            if (ContextScope.currentEmployee.Roles <= 1)
            {
                CheckColor(HOME);
                u.openChildForm(new frmDashBoard(), pnMain);

            }
            else
            {
                CheckColor(HOME);
                u.openChildForm(new OrdersProducts.OrderProducts(), pnMain);
                btCheckIn.Enabled = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtClock.Text = DateTime.Now.ToString("HH:mm dd/MM");
        }

        private List<PermissionDetail> Authorization(Employee emp)
        {
            List<PermissionDetail> listDetail = new List<PermissionDetail>();
            PermissionService _permissionService = new PermissionService();
            PermissionDetailService _permissionDetailService = new PermissionDetailService();
            var per = _permissionService.GetAll().Where(p => p.Roles == emp.Roles).FirstOrDefault();
            listDetail = _permissionDetailService.GetAll().Where(p => p.IdPer == per.Roles && p.CheckAction == false).ToList();
            return listDetail;

        }

        private void bntLogout_Click(object sender, EventArgs e)
        {
            Form form = new frmLogin();
            this.Hide();
            ContextScope.currentEmployee = null;
            form.ShowDialog();
        }

        private void CheckColor(Panel panel)
        {
            foreach (Control control in flowPanel.Controls)
            {
                if (control is Panel)
                {
                    if (control == panel)
                    {
                        control.BackColor = Color.PowderBlue;
                    }
                    else
                    {
                        control.BackColor = Color.White;
                    }
                }
            }
        }

        private void SALARY_Click(object sender, EventArgs e)
        {
            CheckColor(SALARY);
            u.openChildForm(new frmSalary(), pnMain);
        }

        private void REVENUE_Click(object sender, EventArgs e)
        {
            CheckColor(REVENUE);
            u.openChildForm(new ManageRevenue.frmRevenues(), pnMain);
        }

        private void ORDER_Click(object sender, EventArgs e)
        {
            CheckColor(ORDER);
            u.openChildForm(new OrdersProducts.OrderProducts(), pnMain);
        }

        private void PRODUCT_Click(object sender, EventArgs e)
        {
            CheckColor(PRODUCT);
            u.openChildForm(new ManageProducts.ManageAll(), pnMain);
        }

        private void EMPLOYEE_Click(object sender, EventArgs e)
        {
            CheckColor(EMPLOYEE);
            u.openChildForm(new ManageEmployees.frmShowEmployee(), pnMain);
        }

        private void SHEET_Click(object sender, EventArgs e)
        {
            CheckColor(SHEET);
            u.openChildForm(new ManageWorkSheet.frmManageWorkSheetPage(), pnMain);
        }

        private void VOUCHER_Click(object sender, EventArgs e)
        {
            CheckColor(VOUCHER);
            u.openChildForm(new Manage_Voucher.frmMemberVVoucher(), pnMain);

        }

        private void AUTHORIZATION_Click(object sender, EventArgs e)
        {
            CheckColor(AUTHORIZATION);
            u.openChildForm(new frmAdmin(), pnMain);
        }


        private void btCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                TimeSpan timeSpan = new TimeSpan(now.Hour, now.Minute, 0);
                var CheckEmp = ContextScope.currentEmployee.IdEmp;
                var CheckWorkSheet = _workSheetService.GetAll().Where(p => p.IdEmp.Equals(CheckEmp) && p.Date == now.Date).FirstOrDefault();
                if (CheckWorkSheet != null)
                {
                    var CheckTimeWork = _sheetDetailService.GetAll().Where(p => p.Sheet == CheckWorkSheet.Sheet && timeSpan >= p.ShiftStartTime
                    && timeSpan <= p.ShiftEndTime).ToList();
                    if (CheckWorkSheet.TimeCheckIn != null) // check Out
                    {
                        if (CheckTimeWork != null)
                        {
                            CheckWorkSheet.TimeCheckOut = now;
                            CheckWorkSheet.Status = true;
                            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                            {
                                CheckWorkSheet.SundayCoefficient = 0.5;
                            }
                            else
                            {
                                CheckWorkSheet.SundayCoefficient = 0;
                            }
                            _workSheetService.Update(CheckWorkSheet);
                            MessageBox.Show("You have successfully checked-out at " + now, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("You checked-out at " + now + " is Wrong Sheet", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else // Check in 
                    {
                        if (CheckTimeWork != null)
                        {
                            CheckWorkSheet.TimeCheckIn = now;
                            _workSheetService.Update(CheckWorkSheet);
                            MessageBox.Show("You have successfully checked-in at " + now, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("You checked-in at " + now + " is Wrong Sheet", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You don't have a timetable", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Cant not check in and out", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pnlPicture_DoubleClick(object sender, EventArgs e)
        {
            string Emp = ContextScope.currentEmployee.IdEmp;
            if (Emp != null)
            {
                frmInformationMain _frmInformationMain = new frmInformationMain();
                frmInformationEmp frmInformationEmp = new frmInformationEmp();

                frmInformationEmp.DataEmployee = Emp;
                _frmInformationMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not an employee", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }
        private void pbSetting_Click(object sender, EventArgs e)
        {
        }
    }
}