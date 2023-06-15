using Microsoft.Identity.Client;
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

namespace MiniStoreWinF.ManageSalary
{
    public partial class frmAdvSalary : Form
    {
        DetailAdvanceSalaryService _detailAdvanceSalaryService;
        EmployeeService _employeeService;
        public List<DetailAdvanceSalaryService> listAdv;
        public frmAdvSalary()
        {
            InitializeComponent();
        }
        public void showAdvanceSalary()
        {
            _detailAdvanceSalaryService = new DetailAdvanceSalaryService();
            var list = _detailAdvanceSalaryService.GetAll().ToList();
            dgvAdv.DataSource = list;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Form form = new frmAddNewAdvSalary();
            if (form.ShowDialog() == DialogResult.OK)
            {
                showAdvanceSalary();
            }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            _detailAdvanceSalaryService = new DetailAdvanceSalaryService();
            var list = _detailAdvanceSalaryService.GetAll().Where(p => (p.DateAs >= dtpFrom.Value && p.DateAs <= dtpTo.Value)).ToList();
            if (list != null)
            {
                dgvAdv.DataSource = list;
            }
            else
            {
                dgvAdv = null;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            _employeeService = new EmployeeService();
            _detailAdvanceSalaryService = new DetailAdvanceSalaryService();
            var listAdv = _detailAdvanceSalaryService.GetAll().ToList();
            var listEmp = _employeeService.GetAll().Where(p => p.FullNameEmp.Contains(cbSearch.Text) && p.IsActive==true).ToList();

            //
            BindingSource bindingSource = new BindingSource();
            var resultList = from adv in listAdv
                             join emp in listEmp on adv.IdEmp equals emp.IdEmp
                             select adv;
            bindingSource.DataSource = resultList;
            dgvAdv.DataSource = bindingSource;
        }

        private void frmAdvSalary_Load(object sender, EventArgs e)
        {
            Utinity u = new Utinity();
            u.showListEmp(cbSearch);
            showAdvanceSalary();
        }
    }
}
