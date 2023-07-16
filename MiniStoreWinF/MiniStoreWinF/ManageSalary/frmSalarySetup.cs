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
        EmployeeService _employeeService;
        PermissionService _permissionService;
        HeSoTinhLuongService _heSoTinhLuongService;
        Utinity u = new Utinity();
        public frmSalarySetup()
        {
            InitializeComponent();


        }

        public void loadform()
        {

            _permissionService = new PermissionService();
            _employeeService = new EmployeeService();
            var SaEmp = _permissionService.GetAll().Where(p => p.Roles != 0).ToList();
            dgvPer.DataSource = SaEmp;

            var nEmp = _employeeService.GetAll().Count(p => p.Roles == 2 && p.IsActive == true);
            var nGuard = _employeeService.GetAll().Count(p => p.Roles == 3 && p.IsActive == true);
            txtEmp.Text = nEmp.ToString();
            txtGuard.Text = nGuard.ToString();
            //
            _heSoTinhLuongService = new HeSoTinhLuongService();
            var hstl = _heSoTinhLuongService.GetAll().ToList();
            dgvHstl.DataSource = hstl;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new frmDetailSetup();
            form.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtSave.Text == "")
            {
                MessageBox.Show("Plase choise Role for edit salary");
            }
            else
            {
                frmEditEachSalary form = new frmEditEachSalary();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    loadform();
                }
            }
        }

        private void frmSalarySetup_Load(object sender, EventArgs e)
        {
            loadform();
        }




        private void dgvPer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var per = dgvPer[0, e.RowIndex].Value;
                var permission = _permissionService.GetAll().Where(p => p.Permission1.Equals(per)).FirstOrDefault();
                if (permission != null)
                {
                    txtSave.Text = permission.Roles.ToString();
                    ContextScope.saPer = permission;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEditHstl_Click(object sender, EventArgs e)
        {
            Form form = new frmHstl();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                loadform();
            }
        }
    }
}
