using Microsoft.Office.Interop.Excel;
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
        public string idEmp { get; set; }
        public int Month { get; set; }
        public frmHistoryWorksheet(string id, int month)
        {
            InitializeComponent();
            dgvShowWorkSheet.DataSource = Loadrecord(pagenumber, numberRecord, id, month);  //end show worksheet tab 1
            idEmp = id;
            Month = month;
        }
        List<WorkSheet> Loadrecord(int page, int recordnumber, string id, int month)
        {
            List<WorkSheet> result = new List<WorkSheet>();
            using (MiniStoreContext db = new MiniStoreContext())
            {
                result = db.WorkSheets.Where(p => p.IdEmp.Equals(id) && p.Date.Value.Month == month).Skip((page - 1) * recordnumber).Take(recordnumber).ToList();
            }
            return result;
        }
        void loadData()
        {
            using (MiniStoreContext dt = new MiniStoreContext())
            {
                dgvShowWorkSheet.DataSource = dt.WorkSheets.Where(p => p.IdEmp.Equals(idEmp) && p.Date.Value.Month == Month).ToList();

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
            dgvShowWorkSheet.DataSource = Loadrecord(pagenumber, numberRecord, idEmp, Month);
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
            EmployeeService groupService = new EmployeeService();
            if (dgvShowWorkSheet.Columns[e.ColumnIndex].Name == "IdEmp")// key nay o columdata change in Name
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
