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

namespace MiniStoreWinF.ManageSalary
{
    public partial class frmSalarySetup : Form
    {
        EmployeeService employeeService;
        PermissionService permissionService;
        public frmSalarySetup()
        {
            InitializeComponent();
        }

        public void loadform()
        {
            permissionService = new PermissionService();
            employeeService = new EmployeeService();
            //
            var SaEmp = permissionService.GetAll().Where(p => p.Roles.Equals("Employee")).FirstOrDefault();
            if (SaEmp != null)
            {
                txtSaEmp.Text = SaEmp.BasicSalary.ToString();
                txtTaxEmp.Text = SaEmp.Tax.ToString();
            }
            var SaGuard = permissionService.GetAll().Where(p => p.Roles.Equals("Guard")).FirstOrDefault();
            if (SaGuard != null)
            {
                txtSaGuard.Text = SaGuard.BasicSalary.ToString();
                txtTaxGua.Text = SaGuard.Tax.ToString();
            }
            //
            var nEmp = employeeService.GetAll().Count(p => p.Roles.Equals("Employee")&& p.IsActive==true);
            var nGuard = employeeService.GetAll().Count(p => p.Roles.Equals("Guard") && p.IsActive == true);
            txtEmp.Text = nEmp.ToString();
            txtGuard.Text = nGuard.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new frmDetailSetup();
            form.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            frmEditEachSalary form = new frmEditEachSalary();
            form.oldEmpSalary = txtSaEmp.Text;
            form.oldGuardSalary = txtSaGuard.Text;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                loadform();
            }

        }

        private void frmSalarySetup_Load(object sender, EventArgs e)
        {
            loadform();

        }

        private void btEditTax_Click(object sender, EventArgs e)
        {
            frmEditEachTax form = new frmEditEachTax();
            form.oldTaxEmp = txtTaxEmp.Text;
            form.oldTaxGuard = txtTaxGua.Text;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                loadform();
            }
        }
    }
}
