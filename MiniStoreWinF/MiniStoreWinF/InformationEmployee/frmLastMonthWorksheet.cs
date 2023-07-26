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

namespace MiniStoreWinF.InformationEmployee
{
    public partial class frmLastMonthWorksheet : Form
    {
        WorkSheetService _workSheetService = new WorkSheetService();
        Utinity u = new Utinity();
        public frmLastMonthWorksheet()
        {
            InitializeComponent();
        }
        void loadData()
        {
            using (MiniStoreContext dt = new MiniStoreContext())
            {
                dgvWorksheet.DataSource = dt.WorkSheets.ToList();
            }
        }

        private void btSearchSheet_Click(object sender, EventArgs e)
        {
            string idEmp = ContextScope.currentEmployee.IdEmp;



            if (dtpWorksheet.Value.Month == 1)
            {
                gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "st month" + " of " + dtpWorksheet.Value.Year;
            }
            else if (dtpWorksheet.Value.Month == 2)
            {
                gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "nd month" + " of " + dtpWorksheet.Value.Year;

            }
            else if (dtpWorksheet.Value.Day == 3)
            {
                gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "rd month" + " of " + dtpWorksheet.Value.Year;

            }
            else
            {
                gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "th month" + " of " + dtpWorksheet.Value.Year;
            }


            var worksheetService = _workSheetService.GetAll().Where(e => e.IdEmp.Equals(idEmp) && e.Date.Value.Month.Equals(dtpWorksheet.Value.Month)).ToList();
            if (worksheetService != null)
            {
                dgvWorksheet.DataSource = new BindingSource() { DataSource = worksheetService };
            }
            else
            {
                return;
            }
        }

        private void frmLastMonthWorksheet_Load(object sender, EventArgs e)
        {
            label1.Text = "Last month worksheet of " + ContextScope.currentEmployee.FullNameEmp;
            string idEmp = ContextScope.currentEmployee.IdEmp;

            if (dtpWorksheet.Value.Month == 1)
            {
                gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "st month" + " of " + dtpWorksheet.Value.Year;
            }
            else if (dtpWorksheet.Value.Month == 2)
            {
                gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "nd month" + " of " + dtpWorksheet.Value.Year;

            }
            else if (dtpWorksheet.Value.Day == 3)
            {
                gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "rd month" + " of " + dtpWorksheet.Value.Year;

            }
            else
            {
                gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "th month" + " of " + dtpWorksheet.Value.Year;

            }


            var worksheetService = _workSheetService.GetAll().Where(e => e.IdEmp.Equals(idEmp) && e.Date.Value.Month.Equals(dtpWorksheet.Value.Month)).ToList();
            if (worksheetService != null)
            {
                dgvWorksheet.DataSource = new BindingSource() { DataSource = worksheetService };
            }

        }

        private void dgvWorksheet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvWorksheet.Columns[e.ColumnIndex].Name == "Status" && e.Value is bool)
            {
                bool status = (bool)e.Value;


                if (status)
                {
                    e.Value = "Attended";
                    e.CellStyle.ForeColor = Color.Green;

                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    e.Value = "Absented";
                    e.CellStyle.ForeColor = Color.Red;

                    e.CellStyle.BackColor = Color.LightPink;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
