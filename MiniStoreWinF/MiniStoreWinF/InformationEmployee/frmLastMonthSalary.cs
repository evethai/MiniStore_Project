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
    public partial class frmLastMonthSalary : Form
    {
        SalaryService _salaryService = new SalaryService();
        WorkSheetService _workSheetService = new WorkSheetService();
        public frmLastMonthSalary()
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

        private void frmLastMonthSalary_Load(object sender, EventArgs e)
        {
            string idEmp = ContextScope.currentEmployee.IdEmp;
            var countSheetAttended = _workSheetService.GetAll().Where(e => e.IdEmp.Equals(idEmp) && e.Date.Value.Month.Equals(dtpWorksheet.Value.Month.ToString()) && e.Status.Equals(1)).ToList().Count;
            lbAttended.Text = countSheetAttended.ToString();
            var countSheetAbsent = _workSheetService.GetAll().Where(e => e.IdEmp.Equals(idEmp) && e.Date.Value.Month.Equals(dtpWorksheet.Value.Month.ToString()) && e.Status.Equals(0)).ToList().Count;
            lbAbsent.Text = countSheetAbsent.ToString();
            if (dtpMonth.Value.Month == 1)
            {
                gbSalary.Text = "Salary of " + dtpMonth.Value.Month.ToString() + "st month" + " of " + dtpMonth.Value.Year;
            }
            else if (dtpMonth.Value.Month == 2)
            {
                gbSalary.Text = "Salary of " + dtpMonth.Value.Month.ToString() + "nd month" + " of " + dtpMonth.Value.Year;

            }
            else if (dtpMonth.Value.Day == 3)
            {
                gbSalary.Text = "Salary of " + dtpMonth.Value.Month.ToString() + "rd month" + " of " + dtpMonth.Value.Year;

            }
            else
            {
                gbSalary.Text = "Salary of " + dtpMonth.Value.Month.ToString() + "th month" + " of " + dtpMonth.Value.Year;

            }


            lbNameE.Text = "Employee " + ContextScope.currentEmployee.FullNameEmp;

            var salaryService = _salaryService.GetAll().Where(e => e.IdEmp.Equals(idEmp) && e.DateOmonth.Month.Equals(dtpMonth.Value.Month.ToString())).FirstOrDefault();
            if (salaryService != null)
            {
                txtBasicHours.Text = salaryService.BasicSalary.ToString();
                txtBeforeTax.Text = salaryService.TotalSalary.ToString();
                txtSalaryHours.Text = salaryService.SalaryHour.ToString();
                txtSumAdvanceSalary.Text = salaryService.SumAdvanceSalary.ToString();
                txtTax.Text = salaryService.Tax.ToString();
                txtSumSubSalary.Text = salaryService.SumSubSalary.ToString();
                txtTotal.Text = salaryService.SalaryAfterTax.ToString();
            }
            else
            {
                txtTotal.Text = "Salary of this month is not available!";
            }
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

        private void btSearch_Click(object sender, EventArgs e)
        {
            string idEmp = ContextScope.currentEmployee.IdEmp;

           
            if (dtpMonth.Value.Month == 1)
            {
                gbSalary.Text = "Salary of " + dtpMonth.Value.Month.ToString() + "st month" + " of " + dtpMonth.Value.Year;
            }
            else if (dtpMonth.Value.Month == 2)
            {
                gbSalary.Text = "Salary of " + dtpMonth.Value.Month.ToString() + "nd month" + " of " + dtpMonth.Value.Year;

            }
            else if (dtpMonth.Value.Day == 3)
            {
                gbSalary.Text = "Salary of " + dtpMonth.Value.Month.ToString() + "rd month" + " of " + dtpMonth.Value.Year;

            }
            else
            {
                gbSalary.Text = "Salary of " + dtpMonth.Value.Month.ToString() + "th month" + " of " + dtpMonth.Value.Year;

            }
           
            var salaryService = _salaryService.GetAll().Where(e => e.IdEmp.Equals(idEmp) && e.DateOmonth.Month.Equals(dtpMonth.Value.Month)).FirstOrDefault();
            if (salaryService != null)
            {
                txtBasicHours.Text = salaryService.BasicSalary.ToString();
                txtBeforeTax.Text = salaryService.TotalSalary.ToString();
                txtSalaryHours.Text = salaryService.SalaryHour.ToString();
                txtSumAdvanceSalary.Text = salaryService.SumAdvanceSalary.ToString();
                txtTax.Text = salaryService.Tax.ToString();
                txtSumSubSalary.Text = salaryService.SumSubSalary.ToString();
                txtTotal.Text = salaryService.SalaryAfterTax.ToString();
            }
            else
            {
                txtTotal.Text = "Salary of this month is not available!";
                txtBasicHours.Text = "";
                txtBeforeTax.Text = "";
                txtSalary.Text = "";
                txtSalaryHours.Text = "";
                txtSumAdvanceSalary.Text = "";
                txtTax.Text = "";
                txtSumSubSalary.Text = "";
            }
        }

        private void btSearchSheet_Click(object sender, EventArgs e)
        {
            string idEmp = ContextScope.currentEmployee.IdEmp;

            var countSheetAttended = _workSheetService.GetAll().Where(e => e.IdEmp.Equals(idEmp) && e.Date.Value.Month.Equals(dtpWorksheet.Value.Month.ToString()) && e.Status.Equals(1)).ToList().Count;
            lbAttended.Text = countSheetAttended.ToString();
            var countSheetAbsent = _workSheetService.GetAll().Where(e => e.IdEmp.Equals(idEmp) && e.Date.Value.Month.Equals(dtpWorksheet.Value.Month.ToString()) && e.Status.Equals(0)).ToList().Count;
            lbAbsent.Text = countSheetAbsent.ToString();
           
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

        private void dgvWorksheet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvWorksheet.Columns[e.ColumnIndex].Name == "Status" && e.Value is bool)
            {
                bool status = (bool)e.Value;


                if (status)
                {
                    e.Value = "Attended";
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.Value = "Absented";
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
    }

}
