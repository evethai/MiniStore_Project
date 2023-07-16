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

    public partial class frmShowSubSalary : Form
    {
        EmployeeService _employeeService = new EmployeeService();
        SubDetailService _subDetailService = new SubDetailService();
        SubSalaryService _subSalaryService = new SubSalaryService();
        public frmShowSubSalary()
        {
            InitializeComponent();
            var employeeList = _employeeService.GetAll().Where(e => e.Roles >= 1).ToList();
            cbListEmployee.DataSource = employeeList;
            cbListEmployee.DisplayMember = "FullNameEmp";

        }

        private void btAddSub_Click(object sender, EventArgs e)
        {
            Form form = new frmAddSubForEmployee();
            form.ShowDialog();


        }

        private void frmShowSubSalary_Load(object sender, EventArgs e)
        {

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            var employeeList = _employeeService.GetAll().Where(e => e.FullNameEmp.Equals(cbListEmployee.Text)).FirstOrDefault();
            var subDetailList = _subDetailService.GetAll().Where(e => e.IdDetail.Equals(txtId.Text)).FirstOrDefault();
            if (cbCheck.Text.Equals("True"))
            {
                subDetailList.Check = true;
                var update = subDetailList;
                _subDetailService.Update(update);
                MessageBox.Show("Update successfully");
                var employeeList1 = _employeeService.GetAll().Where(e => e.FullNameEmp.Equals(cbListEmployee.Text)).FirstOrDefault();
                if (employeeList1 != null)
                {
                    var subDetailList1 = _subDetailService.GetAll().Where(e => e.IdEmp.Equals(employeeList1.IdEmp));
                    dgvSubDetail.DataSource = new BindingSource() { DataSource = subDetailList1 };
                    ContextScope.currentSearchSubSalary = employeeList1;
                }
                else
                {
                    return;
                }
            }
            else
            {
                subDetailList.Check = false;
                var update = subDetailList;
                _subDetailService.Update(update);
                MessageBox.Show("Update successfully");
                var employeeList1 = _employeeService.GetAll().Where(e => e.FullNameEmp.Equals(cbListEmployee.Text)).FirstOrDefault();
                if (employeeList1 != null)
                {
                    var subDetailList1 = _subDetailService.GetAll().Where(e => e.IdEmp.Equals(employeeList1.IdEmp));
                    dgvSubDetail.DataSource = new BindingSource() { DataSource = subDetailList1 };
                    ContextScope.currentSearchSubSalary = employeeList1;
                }
                else
                {
                    return;
                }
            }


        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var employeeList = _employeeService.GetAll().Where(e => e.FullNameEmp.Equals(cbListEmployee.Text)).FirstOrDefault();
            if (employeeList != null)
            {
                var subDetailList = _subDetailService.GetAll().Where(e => e.IdEmp.Equals(employeeList.IdEmp));
                dgvSubDetail.DataSource = new BindingSource() { DataSource = subDetailList };
                ContextScope.currentSearchSubSalary = employeeList;
            }
            else
            {
                return;
            }
        }

        private void dgvSubDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                var id = dgvSubDetail[0, e.RowIndex].Value;
                var subDetail = _subDetailService.GetAll().Where(e => e.IdDetail.Equals(id)).FirstOrDefault();
                if (subDetail != null)
                {
                    txtId.Text = subDetail.IdDetail.ToString();
                    cbCheck.Text = subDetail.Check.ToString();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
