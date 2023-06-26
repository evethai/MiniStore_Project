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
        Utinity u = new Utinity();
        public frmSalarySetup()
        {
            InitializeComponent();
        }

        public void loadform()
        {
            permissionService = new PermissionService();
            employeeService = new EmployeeService();
            //
            var SaEmp = permissionService.GetAll().Where(p => p.Roles == 2).FirstOrDefault();
            if (SaEmp != null)
            {
                txtSaEmp.Text = u.formatDouble(SaEmp.BasicSalary); 
                txtTaxEmp.Text = u.formatDouble(SaEmp.Tax);
            }
            var SaGuard = permissionService.GetAll().Where(p => p.Roles == 3).FirstOrDefault();
            if (SaGuard != null)
            {
                txtSaGuard.Text = u.formatDouble(SaGuard.BasicSalary);
                txtTaxGua.Text = u.formatDouble(SaGuard.Tax);
            }
                //
            var nEmp = employeeService.GetAll().Count(p => p.Roles == 2 && p.IsActive == true);
            var nGuard = employeeService.GetAll().Count(p => p.Roles == 3 && p.IsActive == true);
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
