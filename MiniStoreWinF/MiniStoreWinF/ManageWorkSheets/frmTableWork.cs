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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniStoreWinF.ManageWorkSheets
{
    public partial class frmTableWork : Form
    {
        WorkSheetService _workSheetService = new WorkSheetService();
        SheetDetailService _sheetDetailService = new SheetDetailService();
        EmployeeService _employeeService = new EmployeeService();
        PermissionService _permissionService = new PermissionService();
        public DateTime dateTime { get; set; }
        public frmTableWork(int Date, DateTime timer)
        {
            InitializeComponent();
            int DateButton = Date;
            string Year = timer.Year.ToString();
            string Month = timer.Month.ToString();
            var OneDay = (DateButton + "/" + Month + "/" + Year).ToString();
            dtpkDate.Value = Convert.ToDateTime(OneDay);
            dateTime = dtpkDate.Value;
            loadData(dateTime);
            LoadCombobox();

        }
        public void loadData(DateTime dateTime)
        {
            using (MiniStoreContext dt = new MiniStoreContext())
            {
                DateTime desiredDate = dateTime;
                var query = dt.WorkSheets
                    .Join(dt.Employees,
                        ws => ws.IdEmp,
                        e => e.IdEmp,
                        (ws, e) => new { WorkSheet = ws, Employee = e })
                    .Where(result => result.WorkSheet.Date == desiredDate)
                    .Select(result => new
                    {
                        result.WorkSheet.IdWorkSheet,
                        result.Employee.FullNameEmp,
                        result.WorkSheet.Sheet,
                    });
                var results = query.ToList();
                dtgvListWorkDate.DataSource = new BindingSource { DataSource = results };
                dtgvListWorkDate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private void dtgvListWorkDate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var RowOrder = dtgvListWorkDate[0, e.RowIndex].Value;
                var ListChoise = _workSheetService.GetAll().Where(entity => entity.IdWorkSheet.Equals(RowOrder)).FirstOrDefault();
                if (ListChoise != null)
                {
                    var checkemp = _employeeService.GetAll().Where(_emp => _emp.IdEmp.Equals(ListChoise.IdEmp)).FirstOrDefault();
                    cbFullNameEmp.Text = checkemp.FullNameEmp;
                    cbSheetWork.Text = ListChoise.Sheet.ToString();
                    txtIdWsheet.Text = ListChoise.IdWorkSheet;
                }
            }
            catch
            {
                return;
            }


        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            loadData((sender as DateTimePicker).Value);
        }

        private void btLastday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }
        private void btNextday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            var checkEmp = _employeeService.GetAll().Where(p => p.FullNameEmp.Equals(cbFullNameEmp.Text) && p.Roles >= 2).FirstOrDefault();
            if (checkEmp != null)
            {
                
                AutoWorkSheetID news = new AutoWorkSheetID();
                var worksheetOfNow = _workSheetService.GetAll().FirstOrDefault();
                worksheetOfNow.Sheet = Convert.ToInt32(cbSheetWork.Text);
                worksheetOfNow.IdEmp = checkEmp.IdEmp;
                worksheetOfNow.Date = dtpkDate.Value;
                var checksheet = _sheetDetailService.GetAll().Where(p => p.Sheet == worksheetOfNow.Sheet).FirstOrDefault();
                worksheetOfNow.DefaultCoefficient = checksheet.CoefficientsSalary;
                worksheetOfNow.TimeCheckIn = null;
                worksheetOfNow.TimeCheckOut = null;
                worksheetOfNow.Status = false;
                news.AddID(worksheetOfNow);
                MessageBox.Show("Create Successful!");
                loadData(dtpkDate.Value);
            }
            else
            {
                MessageBox.Show("Insufficient information to Create");
            }
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
                    loadData(dtpkDate.Value);
                }
                else
                {
                    MessageBox.Show("Can not Remove Insufficient information ");
                }
            }
            catch(Exception)
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
                    loadData(dtpkDate.Value);
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
    }
}
