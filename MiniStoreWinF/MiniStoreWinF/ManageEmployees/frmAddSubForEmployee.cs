using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Models;
using Repository.Service;
namespace MiniStoreWinF.ManageEmployees
{
    public partial class frmAddSubForEmployee : Form
    {
        EmployeeService _employeeService = new EmployeeService();
        SubDetailService _subDetailService = new SubDetailService();
        SubSalaryService _salaryService = new SubSalaryService();
        public frmAddSubForEmployee()
        {
            InitializeComponent();
            var employeeList = _employeeService.GetAll();
            //var subDetail = _subDetailService.GetAll().Where(e => e.IdEmp.Equals(ContextScope.currentSearchSubSalary.IdEmp));
            var subSalary = _salaryService.GetAll();
            cbTypeSub.DataSource = subSalary;
            cbTypeSub.DisplayMember = "idSub";

         


        }

        private void btAddSub_Click(object sender, EventArgs e)
        {
            var subDetail = new SubDetail();

            subDetail.IdSub = cbTypeSub.Text;
            var checkSub = _subDetailService.GetAll().Where(e => e.IdEmp.Equals(ContextScope.currentSearchSubSalary.IdEmp) && e.IdSub.Equals(cbTypeSub.Text)).ToList();
            //if(checkSub != null)
            //{
            //    MessageBox.Show("This employee already have this sub salary type!");
            //}
            //else if (checkSub == null) 
            //{
                subDetail.IdEmp = idEmp.Text;
                subDetail.TimeBegin = dtpTimeStart.Value;
                subDetail.TimeEnd = dtpTimeEnd.Value;
                subDetail.Check = false;
                Validation val = new Validation();
                val.AddSub(subDetail, "idDeS");
                this.Close();
            //}
           
        }

        private void cbTypeSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContextScope.currentSearchSubSalary == null)
            {
                MessageBox.Show("Please choose an employee!");
            }
            else
            {
                idEmp.Text = ContextScope.currentSearchSubSalary.IdEmp.ToString();

            }
        }
    }
}
