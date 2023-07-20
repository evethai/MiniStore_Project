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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            if (ContextScope.currentSearchSubSalary == null)
            {
                MessageBox.Show("Please choose an employee!");

            }
            else
            {
                idEmp.Text = ContextScope.currentSearchSubSalary.IdEmp.ToString();
                var checkSub = _subDetailService.GetAll().Where(e => e.IdEmp.Equals(ContextScope.currentSearchSubSalary.IdEmp)).ToList();
                if (checkSub != null)
                {
                    var subSalary = _salaryService.GetAll().Where(e => e.IsActive == true && !checkSub.Any(cs => cs.IdSub == e.IdSub)).ToList();

                    cbTypeSub.DataSource = subSalary;
                    cbTypeSub.DisplayMember = "idSub";

                }

            }

        }



        private void btAddSub_Click(object sender, EventArgs e)
        {
            if (ContextScope.currentSearchSubSalary == null)
            {
                MessageBox.Show("Please choose an employee!");

            }
            else if (cbTypeSub.Text == "")
            {
                MessageBox.Show("This Employee already had all types of sub salary");

            }
            else
            {
                var subDetail = new SubDetail();
                Boolean checkDuplicated = false;

                var checkSub = _subDetailService.GetAll().Where(e => e.IdEmp.Equals(ContextScope.currentSearchSubSalary.IdEmp)).ToList();
                if (cbTypeSub.Text == null)
                {
                    MessageBox.Show("This Employee already had all types of sub salary");
                }
                else
                {
                    subDetail.IdSub = cbTypeSub.Text;
                    subDetail.IdEmp = idEmp.Text;
                    subDetail.TimeBegin = dtpTimeStart.Value;
                    subDetail.TimeEnd = dtpTimeEnd.Value;
                    subDetail.Check = false;
                    Validation val = new Validation();
                    val.AddSub(subDetail, "idDeS");
                    this.Close();
                }

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
