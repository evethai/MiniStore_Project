using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
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
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniStoreWinF.ManageWorkSheets
{
    public partial class frmTableWork : Form
    {
        WorkSheetService _workSheetService = new WorkSheetService();
        SheetDetailService _sheetDetailService = new SheetDetailService();
        EmployeeService _employeeService = new EmployeeService();
        PermissionService _permissionService = new PermissionService();
        public frmTableWork()
        {
            InitializeComponent();
            reset();
            cbSheetWork.DataSource = _sheetDetailService.GetAll().Where(p => p.Sheet >= 1).ToList();
            cbSheetWork.DisplayMember = "Sheet";
            cbSheetWork.SelectedIndex = -1;
            cbFullNameEmp.DataSource = _employeeService.GetAll().Where(p => p.Roles >= 2).ToList();
            cbFullNameEmp.DisplayMember = "FullNameEmp";
            cbFullNameEmp.ValueMember = "IdEmp";
            cbFullNameEmp.SelectedIndex = -1;
        }
        private void dtgvListWorkDate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var RowOrder = dtgvListWorkDate[0, e.RowIndex].Value;
                var ListChoise = _workSheetService.GetAll().Where(entity => entity.IdWorkSheet.Equals(RowOrder)).FirstOrDefault();
                if (ListChoise != null)
                {
                    cbFullNameEmp.SelectedValue = ListChoise.IdEmp;
                    cbSheetWork.Text = ListChoise.Sheet.ToString();
                    txtIdWsheet.Text = ListChoise.IdWorkSheet;
                }
            }
            catch
            {
                return;
            }
        }
        public string GenerateAutoId(int currentCount, string headId)
        {
            int nextCount = currentCount + 1;
            string id = headId + nextCount.ToString("D4");
            return id;
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            var checkEmp = _employeeService.GetAll().Where(p => p.IdEmp.Equals(cbFullNameEmp.SelectedValue) && p.Roles >= 2).FirstOrDefault();
            var worksheetOfNows = _workSheetService.GetAll().Count();
            if (checkEmp != null)
            {
                var worksheetOfNow = _workSheetService.GetAll().FirstOrDefault();
                worksheetOfNow.IdWorkSheet = GenerateAutoId(worksheetOfNows, "Ws");
                worksheetOfNow.Sheet = Convert.ToInt32(cbSheetWork.Text);
                worksheetOfNow.IdEmp = checkEmp.IdEmp;
                worksheetOfNow.Date = Convert.ToDateTime(ContextScope.current);
                var checksheet = _sheetDetailService.GetAll().Where(p => p.Sheet == worksheetOfNow.Sheet).FirstOrDefault();
                worksheetOfNow.DefaultCoefficient = checksheet.CoefficientsSalary;
                worksheetOfNow.TimeCheckIn = null;
                worksheetOfNow.TimeCheckOut = null;
                worksheetOfNow.Status = false;
                _workSheetService.Create(worksheetOfNow);
                MessageBox.Show("Create Successful!");
                reset();
            }
            else
            {
                MessageBox.Show("Insufficient information to Create");
            }
        }
        public void reset()
        {
            var checkWs = _workSheetService.GetAll().Where(p => p.Date == Convert.ToDateTime(ContextScope.current)).ToList();
            dtgvListWorkDate.DataSource = new BindingSource { DataSource = checkWs };
        }

        private void btRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                var WsheetCheck = _workSheetService.GetAll().Where(p => p.IdWorkSheet.Equals(txtIdWsheet.Text)).FirstOrDefault();
                if (WsheetCheck != null)
                {
                    _workSheetService.Delete(WsheetCheck);
                    txtIdWsheet.Text = "";
                    cbFullNameEmp.SelectedIndex = 0;
                    cbSheetWork.SelectedIndex = 0;
                    reset();
                }
                else
                {
                    MessageBox.Show("Can not Remove Insufficient information ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can not Remove when news create");
            }

        }

        private void cbFullNameEmp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var employee = _employeeService.GetAll().Where(p => p.FullNameEmp.Equals(cbFullNameEmp.Text) && p.Roles == 2).FirstOrDefault();
            if (employee != null)
            {
                cbSheetWork.DataSource = _sheetDetailService.GetAll().Where(p => p.Roles == 2).ToList();
                cbSheetWork.DisplayMember = "Sheet";
            }
            else
            {
                cbSheetWork.DataSource = _sheetDetailService.GetAll().Where(p => p.Roles == 3).ToList();
                cbSheetWork.DisplayMember = "Sheet";
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var WsheetCheck = _workSheetService.GetAll().Where(p => p.IdWorkSheet.Equals(txtIdWsheet.Text)).FirstOrDefault();
                if (WsheetCheck != null)
                {
                    var employee = _employeeService.GetAll().Where(p => p.FullNameEmp.Equals(cbFullNameEmp.Text)).FirstOrDefault();
                    WsheetCheck.Sheet = Convert.ToInt32(cbSheetWork.Text);
                    WsheetCheck.IdEmp = employee.IdEmp;
                    _workSheetService.Update(WsheetCheck);
                    txtIdWsheet.Text = "";
                    cbFullNameEmp.SelectedIndex = 0;
                    cbSheetWork.SelectedIndex = 0;
                    reset();
                }
                else
                {
                    MessageBox.Show("Can not Update by Insufficient information ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Update when you new create");
            }
        }

        private void dtgvListWorkDate_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            EmployeeService groupService = new EmployeeService();
            if (dtgvListWorkDate.Columns[e.ColumnIndex].Name == "IdEmp")// key nay o columdata change in Name
            {

                if (e.Value != null)
                {
                    string idGroup = e.Value.ToString();
                    var nameGroup = _employeeService.GetAll().Where(p => p.IdEmp.Equals(idGroup)).FirstOrDefault();
                    string name = nameGroup.FullNameEmp;
                    e.Value = name;
                    e.FormattingApplied = true;
                }
            }

        }
    }
}
