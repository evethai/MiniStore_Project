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

namespace MiniStoreWinF.ManageWorkSheets
{
    public partial class frmHistoryWorksheet : Form
    {
        WorkSheetService _workSheetService = new WorkSheetService();
        SheetDetailService _sheetDetailService = new SheetDetailService();
        EmployeeService _employeeService = new EmployeeService();

        private int rowIndex { get; set; } // create row click
        int loadrecord = 0;
        int numberRecord = 14;
        int pagenumber = 1;
        public frmHistoryWorksheet()
        {
            InitializeComponent();
            dgvShowWorkSheet.DataSource = Loadrecord(pagenumber, numberRecord);  //end show worksheet tab 1
            var sheetDetails = _sheetDetailService.GetAll();
            cbSheet.DataSource = sheetDetails;
            cbSheet.DisplayMember = "Sheet";//end code lấy sheet
            dtpkStart.Value = DateTime.Now;
            dtpkEnd.Value = DateTime.Now;
        }
        List<WorkSheet> Loadrecord(int page, int recordnumber)
        {
            List<WorkSheet> result = new List<WorkSheet>();
            using (MiniStoreContext db = new MiniStoreContext())
            {
                result = db.WorkSheets.Skip((page - 1) * recordnumber).Take(recordnumber).ToList();
            }
            return result;
        }
        void loadData()
        {
            using (MiniStoreContext dt = new MiniStoreContext())
            {
                dgvShowWorkSheet.DataSource = dt.WorkSheets.ToList();

            }
        }

        //private void btBackList_Click(object sender, EventArgs e)
        //{
        //    if (pagenumber - 1 > 0)
        //    {
        //        pagenumber--;
        //        dgvShowWorkSheet.DataSource = Loadrecord(pagenumber, numberRecord);
        //    }
        //}

        //private void btNextList_Click(object sender, EventArgs e)
        //{
        //    int totalRecord = 0;
        //    using (MiniStoreContext dt = new MiniStoreContext())
        //    {
        //        totalRecord = dt.WorkSheets.Count();
        //    }
        //    if (pagenumber - 1 < totalRecord / numberRecord)
        //    {
        //        pagenumber++;
        //        dgvShowWorkSheet.DataSource = Loadrecord(pagenumber, numberRecord);
        //    }
        //}

        private void btResetAllHistory_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void nbrPagination_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            int totalRecord = 0;
            using (MiniStoreContext dt = new MiniStoreContext())
            {
                totalRecord = dt.WorkSheets.Count();
            }
            num.Maximum = totalRecord / numberRecord + 1;
            pagenumber = (int)num.Value;
            dgvShowWorkSheet.DataSource = Loadrecord(pagenumber, numberRecord);
        }
        private void btLoad_Click(object sender, EventArgs e)
        {
            DateTime dateStarts = dtpkStart.Value;
            DateTime dateEnds = dtpkEnd.Value;
            try
            {
                var getFilterDayTime = _workSheetService.GetAll().Where(p => p.Date >= dateStarts && p.Date <= dateEnds);
                if (getFilterDayTime == null)
                {
                    MessageBox.Show("Time in valid", "Notification", MessageBoxButtons.OK);
                    getFilterDayTime = _workSheetService.GetAll();
                }
                else
                {
                    dgvShowWorkSheet.DataSource = new BindingSource { DataSource = getFilterDayTime };
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error day time ", "Confirm", MessageBoxButtons.OK);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string Empty = "";
            if (txtIDWorksheet.Text == Empty || txtIdEmp.Text == Empty ||
                txtDateWork.Text == Empty || txtDateWork.Text == Empty || txtTimeCheckOut.Text == Empty
                || txtTimeCheckIn.Text == Empty || txtHours.Text == Empty || nbrSunday.Text == Empty || chbStatus.Text == Empty)
            {
                MessageBox.Show("Insufficient information to update !! ", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var updateWorkSheet = _workSheetService.GetAll();
                updateWorkSheet[rowIndex].IdEmp = txtIdEmp.Text;
                updateWorkSheet[rowIndex].Date = DateTime.Parse(txtDateWork.Text);
                SheetDetail sheetDetail = cbSheet.SelectedItem as SheetDetail;
                updateWorkSheet[rowIndex].Sheet = sheetDetail.Sheet;
                var listUpdate = updateWorkSheet[rowIndex];
                _workSheetService.Update(listUpdate);
                MessageBox.Show("Successfully Update Worksheet History", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                Reset();
            }
        }

        private void dgvShowWorkSheet_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var rowWorkSheet = dgvShowWorkSheet[0, e.RowIndex].Value;
                var IdWorkSheet = _workSheetService.GetAll().Where(entity => entity.IdWorkSheet.Equals(rowWorkSheet)).FirstOrDefault(); // comapare row choise with table in data
                if (IdWorkSheet == null)
                { return; }
                rowIndex = e.RowIndex;
                var sheet = IdWorkSheet.Sheet;
                cbSheet.Text = IdWorkSheet.Sheet.ToString();
                txtIDWorksheet.Text = IdWorkSheet.IdWorkSheet.ToString();
                txtIdEmp.Text = IdWorkSheet.IdEmp.ToString();
                txtDateWork.Text = IdWorkSheet.Date.ToString();
                txtTimeCheckIn.Text = IdWorkSheet.TimeCheckIn.ToString();
                txtTimeCheckOut.Text = IdWorkSheet.TimeCheckOut.ToString();
                txtHours.Text = IdWorkSheet.TotalWorkingHours.ToString();
                chbStatus.Checked = IdWorkSheet.Status.Value;
                nbrSunday.Text = IdWorkSheet.SundayCoefficient.ToString();
            }
            catch
            {
                return;
            }
        }

        private void dgvShowWorkSheet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = value ? "Present" : "Absent";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            string Empty = "";
            txtIDWorksheet.Text = Empty;
            txtIdEmp.Text = Empty;
            txtDateWork.Text = Empty;
            txtTimeCheckOut.Text = Empty;
            txtTimeCheckIn.Text = Empty;
            txtHours.Text = Empty;
            chbStatus.Text = Empty;
            nbrSunday.Text = Empty;
        }
    }
}
