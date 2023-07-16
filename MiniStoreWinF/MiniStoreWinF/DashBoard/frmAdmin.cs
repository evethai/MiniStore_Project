using Azure;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniStoreWinF.DashBoard
{
    public partial class frmAdmin : Form
    {
        PermissionDetailService _permissionDetailService;
        PermissionService _permissionService;
        EmployeeService _employeeService;
        public frmAdmin()
        {
            InitializeComponent();
            _permissionService = new PermissionService();
            _employeeService = new EmployeeService();
            _permissionDetailService = new PermissionDetailService();

            loadRole();
            numberOfRole();
        }

        private void Authorization(string id)
        {
            var list = _permissionDetailService.GetAll().Where(p => p.IdPer == Int32.Parse(id)).ToList();
            dgvAuthorization.Rows.Clear();
            foreach (var item in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvAuthorization);

                row.Cells[dgvAuthorization.Columns["id"].Index].Value = item.Id.ToString();
                row.Cells[dgvAuthorization.Columns["name"].Index].Value = item.ActionName.ToUpper();


                if (item.CheckAction == true)
                {
                    row.Cells[dgvAuthorization.Columns["check"].Index].Value = true; // Set the checkbox value to true
                }
                else
                {
                    row.Cells[dgvAuthorization.Columns["check"].Index].Value = false; // Set the checkbox value to false
                }

                dgvAuthorization.Columns["id"].Visible = false;

                dgvAuthorization.Rows.Add(row);
                dgvAuthorization.AllowUserToAddRows = false;

            }

        }

        private void numberOfRole()
        {
            var list = _permissionService.GetAll().Where(p => p.Roles != 0).ToList();
            dgvPer.Rows.Clear();
            foreach (var item in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPer);
                row.Cells[dgvPer.Columns["role"].Index].Value = item.Permission1.ToString();

                var num = _employeeService.GetAll().Count(p => p.Roles == item.Roles);
                if (num >= 0)
                {
                    row.Cells[dgvPer.Columns["num"].Index].Value = num.ToString();
                }
                dgvPer.Rows.Add(row);
                dgvPer.AllowUserToAddRows = false;
            }
        }

        private void loadRole()
        {
            var list = _permissionService.GetAll().Where(p => p.Roles != 0).ToList();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            foreach (var item in list)
            {
                autoCompleteStringCollection.Add(item.Permission1);
            }
            cbRoles.AutoCompleteCustomSource = autoCompleteStringCollection;
            cbRoles.ValueMember = "Roles";
            cbRoles.DisplayMember = "Permission1";
            cbRoles.DataSource = list;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            Authorization(cbRoles.SelectedValue.ToString());

        }


        private void dgvAuthorization_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var id = dgvAuthorization[0, e.RowIndex].Value;
            bool isChecked = (bool)dgvAuthorization.Rows[e.RowIndex].Cells["check"].Value;

            DialogResult result = MessageBox.Show("Update the authorization", "Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (isChecked == true)
                    {
                        var au = _permissionDetailService.GetAll().Where(p => p.Id.ToString().Equals((string)id)).FirstOrDefault();

                        if (au != null)
                        {
                            au.CheckAction = false;
                            _permissionDetailService.Update(au);

                            var per = _permissionService.GetAll().Where(p => p.Roles == au.IdPer).FirstOrDefault();
                            MessageBox.Show("Role " + per.Permission1 + " no access to " + au.ActionName, "Messages");
                        }
                    }
                    else
                    {
                        var au = _permissionDetailService.GetAll().Where(p => p.Id.ToString().Equals((string)id)).FirstOrDefault();
                        if (au != null)
                        {
                            au.CheckAction = true;
                            _permissionDetailService.Update(au);

                            var per = _permissionService.GetAll().Where(p => p.Roles == au.IdPer).FirstOrDefault();
                            MessageBox.Show("Role " + per.Permission1 + " get access to " + au.ActionName, "Messages");
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(" Can not change status" + ex);
                }
            }
            else
            {
                return;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want add new Role ?", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmNewRole form = new frmNewRole();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    loadRole();
                    numberOfRole();
                    cbRoles.SelectedValue = ContextScope.newPermission.Roles;
                }
            }
            else
            {
                return;
            }
        }

        private void btMoMo_Click(object sender, EventArgs e)
        {
            Form form = new frmMoMo();
            form.ShowDialog();
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Authorization(cbRoles.SelectedValue.ToString());
        }
    }
}
