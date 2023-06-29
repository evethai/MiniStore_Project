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

namespace MiniStoreWinF.ManageWorkSheets
{
    public partial class frmTableWork : Form
    {
        WorkSheetService _workSheetService = new WorkSheetService();
        SheetDetailService _sheetDetailService = new SheetDetailService();
        EmployeeService _employeeService = new EmployeeService();
        PermissionService _permissionService = new PermissionService();

        public DateTime dateTime { get; set; }


        public frmTableWork(string Date, DateTime timer)
        {
            InitializeComponent();
            string DateButton = Date;
            string Year = timer.Year.ToString();
            string Month = timer.Month.ToString();
            var OneDay = (DateButton + "/" + Month + "/" + Year).ToString();
            dtpkDate.Value = Convert.ToDateTime(OneDay);
            dateTime = dtpkDate.Value;
            ShowJobByDate(Convert.ToDateTime(OneDay));
            LoadCombobox();

        }
        public class CombinedData
        {
            public string IdWorksheet { get; set; }
            public bool Status { get; set; }
            public int Sheet { get; set; }
            public string EmployeeName { get; set; }
        }
        public void ShowJobByDate(DateTime date)
        {
            var WorksheetByDate = _workSheetService.GetAll().Where(p => p.Date == date).ToList();
            var combinedDataList = new List<CombinedData>();
            foreach (var worksheet in WorksheetByDate)
            {
                var Emp = _employeeService.GetAll().Where(p => p.IdEmp == worksheet.IdEmp).FirstOrDefault();

                var combinedData = new CombinedData
                {
                    IdWorksheet = worksheet.IdWorkSheet,
                    Status = worksheet.Status.Value,
                    Sheet = worksheet.Sheet.Value,
                    EmployeeName = Emp?.FullNameEmp
                };

                combinedDataList.Add(combinedData);
            }
            dtgvListWorkDate.DataSource = combinedDataList;
            dtgvListWorkDate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (date >= DateTime.Now)
            {
                btCreate.Enabled = true;

                btRemove.Enabled = true;
            }
            else
            {
                btCreate.Enabled = false;

                btRemove.Enabled = false;
            }
        }

        public void LoadCombobox()
        {
            cbSheetWork.DataSource = _sheetDetailService.GetAll().Where(p => p.Sheet >= 1).ToList();
            cbSheetWork.DisplayMember = "Sheet";
            cbSheetWork.SelectedIndex = -1;
            cbFullNameEmp.DataSource = _employeeService.GetAll().Where(p => p.Roles >= 2).ToList();
            cbFullNameEmp.DisplayMember = "FullNameEmp";
            cbFullNameEmp.SelectedIndex = -1;
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btLastday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }
        private void btNextday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void dtgvListWorkDate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var RowOrder = dtgvListWorkDate[0, e.RowIndex].Value;
                var ListChoise = _workSheetService.GetAll().Where(entity => entity.IdWorkSheet.Equals(RowOrder)).FirstOrDefault();
                if (ListChoise != null)
                {
                    var CheckEmployee = _employeeService.GetAll().Where(entity => entity.IdEmp.Equals(ListChoise.IdEmp)).FirstOrDefault();
                    cbFullNameEmp.Text = CheckEmployee.FullNameEmp;
                    cbSheetWork.Text = ListChoise.Sheet.ToString();
                    txtIdWsheet.Text = ListChoise.IdWorkSheet;
                }
            }
            catch
            {
                return;
            }

        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            AutoWorkSheetID autoID = new AutoWorkSheetID();
            var worksheetOfNow = _workSheetService.GetAll().FirstOrDefault();
            var checkEmp = _employeeService.GetAll().Where(p => p.FullNameEmp.Equals(cbFullNameEmp.Text) && p.Roles >= 2).FirstOrDefault();
            if (checkEmp != null)
            {
                worksheetOfNow.Sheet = Convert.ToInt32(cbSheetWork.Text);
                worksheetOfNow.IdEmp = checkEmp.IdEmp;
                worksheetOfNow.Date = dtpkDate.Value;
                worksheetOfNow.TimeCheckIn = null;
                worksheetOfNow.TimeCheckOut = null;
                worksheetOfNow.Status = false;
                autoID.AddID(worksheetOfNow);
                MessageBox.Show("Add Emp in sheet to date is Successfull");

            }
            else
            {
                MessageBox.Show("BUG");
            }
        }

        private void btRemove_Click_1(object sender, EventArgs e)
        {
            var WsheetCheck = _workSheetService.GetAll().Where(p => p.IdWorkSheet.Equals(txtIdWsheet.Text)).FirstOrDefault();
            if (WsheetCheck != null)
            {
                _workSheetService.Delete(WsheetCheck);
                txtIdWsheet.Text = "";
                cbFullNameEmp.SelectedIndex = 0;
                cbSheetWork.SelectedIndex = 0;
                MessageBox.Show("Remove Successfull");

            }
            else
            {
                MessageBox.Show("Can not Remove");
            }
        }

        private void cbFullNameEmp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var employee = _employeeService.GetAll().Where(p => p.FullNameEmp.Equals(cbFullNameEmp.Text) && p.Roles == 2).FirstOrDefault();
            if (employee != null)
            {
                cbSheetWork.DataSource = _sheetDetailService.GetAll().Where(p => p.Sheet <= 4).ToList();
                cbSheetWork.DisplayMember = "Sheet";
            }
            else
            {
                cbSheetWork.DataSource = _sheetDetailService.GetAll().Where(p => p.Sheet > 4 && p.Sheet <= 7).ToList();
                cbSheetWork.DisplayMember = "Sheet";
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
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
                MessageBox.Show("Update Successfull");
            }
            else
            {
                MessageBox.Show("Can not Remove");
            }
        }
    }
}
