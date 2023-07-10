using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.ManageWorkSheets
{

    public partial class frmSheetDetails : Form
    {
        WorkSheetService _workSheetService = new WorkSheetService();
        SheetDetailService _sheetDetailService = new SheetDetailService();
        EmployeeService _employeeService = new EmployeeService();
        PermissionService _permissionService = new PermissionService();
        private int rowIndex { get; set; } // create row click
        public frmSheetDetails()
        {
            InitializeComponent();
            var showDetails = _sheetDetailService.GetAll()/*.Where(p => p.Roles != null)*/; // take table
            dgvDetailWorksheet.DataSource = new BindingSource() { DataSource = showDetails }; //end show sheet details tab 5
            var showRole = _permissionService.GetAll().Where(x => x.Roles >= 2).ToList();
            cbRoles.DataSource = showRole;
            cbRoles.DisplayMember = "Permission1";
        }

        private void dgvDetailWorksheet_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var ShowDetail = dgvDetailWorksheet[0, e.RowIndex].Value;
                var Details = _sheetDetailService.GetAll().Where(entity => entity.Sheet.Equals(ShowDetail)).FirstOrDefault();
                if (Details == null)
                {
                    return;
                }
                rowIndex = e.RowIndex;
                var sheetDetail = Details.Sheet;
                var sheetDetails = _sheetDetailService.GetAll().Where(p => p.Sheet.Equals(sheetDetail)).FirstOrDefault();
                var RolesCheck = _permissionService.GetAll().Where(p => p.Roles == sheetDetails.Roles).FirstOrDefault();
                if (RolesCheck == null)
                {
                    cbRoles.Text = string.Empty;
                }
                else
                {
                    cbRoles.Text = RolesCheck.Permission1;
                }
                chbWorkNight.Checked = sheetDetails.CheckNight.Value;
                txtSheetDetail.Text = sheetDetails.Sheet.ToString();
                txtStartDetails.Text = sheetDetails.ShiftStartTime.ToString();
                txtEndDetails.Text = sheetDetails.ShiftEndTime.ToString();
                txtDescriptionsDetails.Text = sheetDetails.DescriptionS.ToString();
                txtCoefficientsSalaryDetails.Text = sheetDetails.CoefficientsSalary.ToString();
                if (sheetDetails != null)
                {
                    txtSheetDetail.Text = sheetDetails.Sheet.ToString();
                }
                else { txtSheetDetail.Text = "None"; }
            }
            catch
            {
                return;
            }
        }

        void loadData()
        {
            using (MiniStoreContext dt = new MiniStoreContext())
            {
                dgvDetailWorksheet.DataSource = dt.SheetDetails.ToList();

            }
        }
        public int GenerateAutoId(int currentCount)
        {
            int nextCount = currentCount + 1;
            int id = nextCount;
            return id;
        }

        private void btUpdateDetailsWorkSheet_Click(object sender, EventArgs e)
        {
            string Empty = "";
            if (txtSheetDetail.Text == Empty || txtStartDetails.Text == Empty ||
                txtEndDetails.Text == Empty || txtDescriptionsDetails.Text == Empty || txtCoefficientsSalaryDetails.Text == Empty)
            {
                MessageBox.Show("Cant Not Update when you dont choise !! ", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var updateDetailsSheet = _sheetDetailService.GetAll();
                updateDetailsSheet[rowIndex].Sheet = Int32.Parse(txtSheetDetail.Text);
                updateDetailsSheet[rowIndex].ShiftStartTime = TimeSpan.Parse(txtStartDetails.Text);
                updateDetailsSheet[rowIndex].ShiftEndTime = TimeSpan.Parse(txtEndDetails.Text);
                updateDetailsSheet[rowIndex].DescriptionS = txtDescriptionsDetails.Text;
                updateDetailsSheet[rowIndex].CoefficientsSalary = float.Parse(txtCoefficientsSalaryDetails.Text);
                var listUpdate = updateDetailsSheet[rowIndex];
                _sheetDetailService.Update(listUpdate);
                MessageBox.Show("Successfully Update Worksheet Detail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                ResetData();
            }

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            string Empty = "";
            if (txtSheetDetail.Text == Empty ||
                txtStartDetails.Text == Empty || txtEndDetails.Text == Empty || txtDescriptionsDetails.Text == Empty
                || txtCoefficientsSalaryDetails.Text == Empty)
            {
                MessageBox.Show("Can't Create when empty ", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCoefficientsSalaryDetails.Value <= 0)
            {
                MessageBox.Show("Coefficients Salary can't 0 !! ", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var Count = _sheetDetailService.GetAll().Count();
                var CreateNewSheet = _sheetDetailService.GetAll().FirstOrDefault();
                CreateNewSheet.Sheet = GenerateAutoId(Count);
                CreateNewSheet.ShiftStartTime = TimeSpan.Parse(txtStartDetails.Text);
                CreateNewSheet.ShiftEndTime = TimeSpan.Parse(txtEndDetails.Text);
                CreateNewSheet.CoefficientsSalary = float.Parse(txtCoefficientsSalaryDetails.Text);
                CreateNewSheet.DescriptionS = txtDescriptionsDetails.Text;
                CreateNewSheet.CheckNight = chbWorkNight.Checked;
                _sheetDetailService.Create(CreateNewSheet);
                MessageBox.Show("Successfully Create Sheet", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                ResetData();
            }
        }

        public void ResetData()
        {
            string Empty = "";
            txtSheetDetail.Text = Empty;
            txtStartDetails.Text = Empty;
            txtEndDetails.Text = Empty;
            txtDescriptionsDetails.Text = Empty;
            txtCoefficientsSalaryDetails.Text = Empty;
        }
        private void txtSheetDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }
        }

        private void txtStartDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ':' || e.KeyChar == '\b')
            {
                // Cho phép người dùng nhập giá trị
                e.Handled = false;
            }
            else
            {
                // Không cho phép người dùng nhập giá trị
                e.Handled = true;
            }
        }

        private void txtEndDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ':' || e.KeyChar == '\b')
            {
                // Cho phép người dùng nhập giá trị
                e.Handled = false;
            }
            else
            {
                // Không cho phép người dùng nhập giá trị
                e.Handled = true;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void dgvDetailWorksheet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = value ? "Yes" : "No";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
