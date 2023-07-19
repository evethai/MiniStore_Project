using Microsoft.IdentityModel.Tokens;
using Microsoft.Office.Interop.Excel;
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
using ZXing;
using static MiniStoreWinF.ManageWorkSheets.frmTimeKeepingDetails;

namespace MiniStoreWinF.ManageWorkSheets
{
    public partial class frmTimeKeepingDetails : Form
    {
        EmployeeService _employeeService = new EmployeeService();
        WorkSheetService _workSheetService = new WorkSheetService();
        Utinity Utinity = new Utinity();
        public frmTimeKeepingDetails()
        {
            InitializeComponent();
            ShowTimekeeping(dtpkMothTimeKeeping.Value);
        }
        public class Data
        {
            public string IdEmployee { get; set; }
            public string FullName { get; set; }
            public int CountWork { get; set; }
            public double TotalHour { get; set; }
        }
        public void ShowTimekeeping(DateTime date)
        {
            var checkEmp = _employeeService.GetAll().Where(p => p.Roles >= 2).ToList();
            List<Data> data = new List<Data>();
            foreach (var emp in checkEmp)
            {
                var checkWs = _workSheetService.GetAll().Where(p => p.Date.Value.Month == date.Month && p.IdEmp.Equals(emp.IdEmp)).ToList();
                data.Add(new Data
                {
                    IdEmployee = emp.IdEmp,
                    FullName = emp.FullNameEmp,
                    CountWork = checkWs.Count(),
                    TotalHour = checkWs.Sum(p => p.TotalWorkingHours.Value.TotalHours)
                });
            }
            dgvTimekeeping.DataSource = new BindingSource { DataSource = data.ToList() };
            dgvTimekeeping.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dtpkMothTimeKeeping_ValueChanged(object sender, EventArgs e)
        {
            ShowTimekeeping((sender as DateTimePicker).Value);
        }

        private void dgvTimekeeping_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = dgvTimekeeping[0, e.RowIndex].Value;
                var wsheet = _employeeService.GetAll().Where(p => p.IdEmp.Equals(id)).FirstOrDefault();
                if (wsheet != null)
                {
                    DialogResult result = MessageBox.Show("Would you like to see this Details Worksheet ?", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        frmHistoryWorksheet form = new frmHistoryWorksheet(wsheet.IdEmp, dtpkMothTimeKeeping.Value.Month);
                        form.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }

        }
    }
}
