using Microsoft.IdentityModel.Tokens;
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
using MiniStoreWinF.ManageSalary;

namespace MiniStoreWinF.InformationEmployee
{
    public partial class frmLastMonthSalary : Form
    {
        SalaryService _salaryService = new SalaryService();
        WorkSheetService _workSheetService = new WorkSheetService();
        Utinity u = new Utinity();
        public frmLastMonthSalary()
        {
            InitializeComponent();
        }

        void loadData()
        {
            using (MiniStoreContext dt = new MiniStoreContext())
            {
                //dgvWorksheet.DataSource = dt.WorkSheets.ToList();
            }
        }

        private void frmLastMonthSalary_Load(object sender, EventArgs e)
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


            lbNameE.Text = "Last month Salary of  " + ContextScope.currentEmployee.FullNameEmp;

            var salaryService = _salaryService.GetAll().Where(e => e.IdEmp.Equals(idEmp) && e.DateOmonth.Month.Equals(dtpMonth.Value.Month.ToString())).FirstOrDefault();
            if (salaryService != null)
            {
                txtBasicHours.Text = u.formatDouble(salaryService.BasicSalary);
                txtBeforeTax.Text = u.formatDouble(salaryService.SalaryBeforTax);
                txtSalaryHours.Text = u.formatDouble(salaryService.SalaryByHour);
                txtSumAdvanceSalary.Text = u.formatDouble(salaryService.AdvSalary);
                txtTax.Text = u.formatDouble(salaryService.Tax);
                txtSumSubSalary.Text = u.formatDouble(salaryService.SubSalary);

                txtTotal.Text = u.formatDouble(salaryService.FinalSalary);
            }
            else
            {
                txtTotal.Text = "Salary of this month is not available!";
            }
            //if (dtpWorksheet.Value.Month == 1)
            //{
            //    gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "st month" + " of " + dtpWorksheet.Value.Year;
            //}
            //else if (dtpWorksheet.Value.Month == 2)
            //{
            //    gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "nd month" + " of " + dtpWorksheet.Value.Year;

            //}
            //else if (dtpWorksheet.Value.Day == 3)
            //{
            //    gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "rd month" + " of " + dtpWorksheet.Value.Year;

            //}
            //else
            //{
            //    gbWorksheet.Text = "Worksheet of " + dtpWorksheet.Value.Month.ToString() + "th month" + " of " + dtpWorksheet.Value.Year;

            //}


            //var worksheetService = _workSheetService.GetAll().Where(e => e.IdEmp.Equals(idEmp) && e.Date.Value.Month.Equals(dtpWorksheet.Value.Month)).ToList();
            //if (worksheetService != null)
            //{
            //    dgvWorksheet.DataSource = new BindingSource() { DataSource = worksheetService };
            //}


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
                txtBasicHours.Text = u.formatDouble(salaryService.BasicSalary);
                txtBeforeTax.Text = u.formatDouble(salaryService.SalaryBeforTax);
                txtSalaryHours.Text = u.formatDouble(salaryService.SalaryByHour);
                txtSumAdvanceSalary.Text = u.formatDouble(salaryService.AdvSalary);
                txtTax.Text = u.formatDouble(salaryService.Tax);
                txtSumSubSalary.Text = u.formatDouble(salaryService.SubSalary);

                txtTotal.Text = u.formatDouble(salaryService.FinalSalary);
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
        private int RoundToInteger(double number)
        {
            return (int)Math.Round(number);
        }

        private void btSearchSheet_Click(object sender, EventArgs e)
        {


        }




    }

}
