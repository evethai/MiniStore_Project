using MiniStoreWinF.ManageSalary;
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
                u.openChildForm(new frmDashBoard(), pnMain);
            }
            else
            {
                u.openChildForm(new OrdersProducts.OrderProducts(), pnMain);
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

        private void SALARY_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmSalary(), pnMain);
        }

        private void REVENUE_Click(object sender, EventArgs e)
        {
            u.openChildForm(new ManageRevenue.frmRevenues(), pnMain);
        }

        private void ORDER_Click(object sender, EventArgs e)
        {
            u.openChildForm(new OrdersProducts.OrderProducts(), pnMain);
        }

        private void PRODUCT_Click(object sender, EventArgs e)
        {

        }

        private void EMPLOYEE_Click(object sender, EventArgs e)
        {

        }

        private void SHEET_Click(object sender, EventArgs e)
        {

        }

        private void VOUCHER_Click(object sender, EventArgs e)
        {

        }

        private void AUTHORIZATION_Click(object sender, EventArgs e)
        {

        }
    }
}
