
using Microsoft.Office.Interop.Excel;
using Repository.Models;
using Repository.Service;
using System.Collections.Generic;
using System.Data;


namespace MiniStoreWinF.ManageSalary
{
    public partial class frmSubSalary : Form
    {
        DetailSubSalaryService _detailSubSalaryService;
        EmployeeService _employeeService;
        SubSalaryService _subSalaryService;
        DetailAdvanceSalaryService _detailAdvanceSalaryService;

        Utinity u = new Utinity();
        CalculationAuto ca = new CalculationAuto();
        List<SubSalary> _list = null;
        int pageNumber = 1;
        int numberRecord = 7;

        public frmSubSalary()
        {
            InitializeComponent();
            _detailSubSalaryService = new DetailSubSalaryService();
            _employeeService = new EmployeeService();
            _subSalaryService = new SubSalaryService();
            _detailAdvanceSalaryService = new DetailAdvanceSalaryService();
        }

        private void frmSubSalary_Load(object sender, EventArgs e)
        {
            //Show list SubSalary of MiniStore by Admin create create
            showListSub();

            //Show combobox
            u.showListEmp_ALL(cbName);

            //Show list Sub Salary  last month
            showListEmployeHasSubSalary(DateTime.Now.AddMonths(-1));

            //Show list Advance Salary  last month
            dgvAdv.DataSource = showAdvanceSalary(DateTime.Now.AddMonths(-1)).ToList();

            dtpList.Value = DateTime.Now.AddMonths(-1);

        }

        //Show list Sub Salary  last month
        public void showListEmployeHasSubSalary(DateTime time)
        {
            var list = _subSalaryService.GetAll().Where(p => p.Time.Value.Month.Equals(time.Month)).ToList();
            dgvTotalSub.DataSource = LoadRecord(pageNumber, numberRecord, list);
            _list = list;
        }

        //Show list SubSalary of MiniStore by Admin create create
        public void showListSub()
        {
            var listSub = _detailSubSalaryService.GetAll().Where(p => p.ActiveSub == true).ToList();
            dgvSub.DataSource = listSub;
        }

        //Edit subSalary if this active
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtSaveID.Text == null)
            {
                MessageBox.Show("Please choise!", "Messages", MessageBoxButtons.OK);
            }
            else
            {
                var sub_salary = _detailSubSalaryService.GetAll().Where(p => p.IdDetailSubSalary.Equals(txtSaveID.Text) && p.ActiveSub == true).FirstOrDefault();
                if (sub_salary != null)
                {
                    frmEditSubSalary form = new frmEditSubSalary();
                    ContextScope.currentSubSalary = sub_salary;
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.OK)
                    {
                        showListSub();
                    }
                }
            }
        }

        private void dgvSub_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var id = dgvSub[0, e.RowIndex].Value;
                var s_salary = _detailSubSalaryService.GetAll().Where(p => p.IdDetailSubSalary.Equals(id) && p.ActiveSub == true).FirstOrDefault();
                if (s_salary != null)
                {
                    txtSaveID.Text = s_salary.IdDetailSubSalary.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        //add new Sub salary by admin
        private void btAdd_Click(object sender, EventArgs e)
        {
            Form form = new frmAddNewSubSalary();
            if (form.ShowDialog() == DialogResult.OK)
            {
                showListSub();
            }
        }

        //Paging
        private void nmPaging_ValueChanged(object sender, EventArgs e)
        {
            if (_list != null)
            {
                NumericUpDown num = sender as NumericUpDown;
                List<SubSalary> list = _list;
                int total = list.Count();
                num.Maximum = total / numberRecord + 1;
                pageNumber = (int)num.Value;
                dgvTotalSub.DataSource = LoadRecord(pageNumber, numberRecord, list);
            }

        }
        //Paging
        List<SubSalary> LoadRecord(int page, int numberRe, List<SubSalary> list)
        {
            List<SubSalary> result = new List<SubSalary>();
            result = list.Skip((page - 1) * numberRe).Take(numberRecord).ToList();
            return result;
        }


        //------------------------------------------------------------------------------
        //------Code Advance Salary-----------------------------------------------------
        //------------------------------------------------------------------------------

        //Add new Advance salary 
        private void btAddnew_Adv_Click(object sender, EventArgs e)
        {
            frmAddNewAdvSalary form = new frmAddNewAdvSalary();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvAdv.DataSource = showAdvanceSalary(DateTime.Now.AddMonths(-1));
            }
        }

        //Show list Advance Salary last month
        public List<DetailAdvanceSalary> showAdvanceSalary(DateTime time)
        {
            _detailAdvanceSalaryService = new DetailAdvanceSalaryService();
            var list = _detailAdvanceSalaryService.GetAll().Where(p => p.DateAs.Value.Month.Equals(time.Month)).ToList();
            return list;
        }

        //Search Advance salary by name
        public void searchAdvByName(string id)
        {
            var listAdv = _detailAdvanceSalaryService.GetAll().Where(p => p.DateAs.Value.Month.Equals(dtpList.Value.Month)).ToList();
            var listEmp = _employeeService.GetAll().Where(p => p.IdEmp.Equals(id) && p.IsActive == true).ToList();

            //
            BindingSource bindingSource = new BindingSource();
            var resultList = from adv in listAdv
                             join emp in listEmp on adv.IdEmp equals emp.IdEmp
                             select adv;
            bindingSource.DataSource = resultList;
            dgvAdv.DataSource = bindingSource;
        }

        //Search Sub salary by name
        public void searchSubByName(string id)
        {
            DateTime time = dtpList.Value;
            double total = ca.SubSalary(id, time);
            txtTotal.Text = u.formatDouble(total);
            var list = _subSalaryService.GetAll().Where(p => p.IdEmp.Equals(id) && p.Time.Value.Month.Equals(time.Month)).ToList();
            dgvTotalSub.DataSource = LoadRecord(pageNumber, numberRecord, list);
        }


        //filter
        private void btFilter_Click(object sender, EventArgs e)
        {
            string id = cbName.SelectedValue.ToString();
            if (cbOrderby.Text == "Descending" && id == "-1")
            {
                showListEmployeHasSubSalary(dtpList.Value);
                dgvAdv.DataSource = showAdvanceSalary(dtpList.Value).OrderByDescending(p => p.AdvanceSalary).ToList();
                txtTotal.Text = "";

            }
            else if (cbOrderby.Text != "Descending" && id == "-1")
            {
                showListEmployeHasSubSalary(dtpList.Value);
                dgvAdv.DataSource = showAdvanceSalary(dtpList.Value).OrderBy(p => p.AdvanceSalary).ToList();
                txtTotal.Text = "";

            }
            else
            {
                searchAdvByName(id);
                searchSubByName(id);
            }
        }
    }
}
