using Microsoft.IdentityModel.Tokens;
using MiniStoreWinF.ManageSalary;
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
    public partial class frmMain : Form
    {
        EmployeeService _employeeService = new EmployeeService();
        Utinity u = new Utinity();
        public string dataAccountLogin { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuAdminDB_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmDashBoard(), pMain);
        }

        private void sTOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersProducts.OrderProducts _orderProducts = new OrdersProducts.OrderProducts();
            u.openChildForm(_orderProducts, pMain);
            _orderProducts.DataEmployee = dataAccountLogin;
        }
        public void LoadDataForm()
        {
            var checkFullName = _employeeService.GetAll().Where(p => p.Username == dataAccountLogin).FirstOrDefault();
            if (checkFullName != null)
            {
                txtAccountLogin.Text = "Hello " + checkFullName.FullNameEmp.ToString();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDataForm();
        }
    }
}
