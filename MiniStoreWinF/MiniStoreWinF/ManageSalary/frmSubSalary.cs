
using Microsoft.Office.Interop.Excel;
using Repository.Models;
using Repository.Service;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MiniStoreWinF.ManageSalary
{
    public partial class frmSubSalary : Form
    {

        SubDetailService _subDetailService;
        EmployeeService _employeeService;
        SubSalaryService _subSalaryService;
        DetailAdvanceSalaryService _detailAdvanceSalaryService;

        Utinity u = new Utinity();
        CalculationAuto ca = new CalculationAuto();
        List<SubDetail> _list = null;
        int pageNumber = 1;
        int numberRecord = 7;

        public frmSubSalary()
        {
            InitializeComponent();
        }

        private void frmSubSalary_Load(object sender, EventArgs e)
        {
            //Show list SubSalary of MiniStore by Admin create create
            showListSub();

            //Show combobox
            u.showListEmp_ALL(cbName);

            //Show list Sub Salary  last month
            showListEmployeHasSubSalary();

            //Show list Advance Salary  last month
            dgvAdv.DataSource = showAdvanceSalary(DateTime.Now.AddMonths(-1)).ToList();

            dtpList.Value = DateTime.Now.AddMonths(-1);

        }


        public void showListEmployeHasSubSalary()
        {
            _subDetailService = new SubDetailService();
            var list = _subDetailService.GetAll().Where(p => p.Check == true).ToList();

            dgvSubDetail.DataSource = LoadRecord(pageNumber, numberRecord, list);
            _list = list;

        }

        //Show list SubSalary of MiniStore by Admin create create
        public void showListSub()
        {
            _subSalaryService = new SubSalaryService();
            var listSub = _subSalaryService.GetAll().Where(p => p.IsActive == true).ToList();
            dgvSub.DataSource = listSub;

        }


        //Edit subSalary if this active
        private void btEdit_Click(object sender, EventArgs e)
        {
            _subSalaryService = new SubSalaryService();
            if (txtSaveID.Text == "")
            {
                MessageBox.Show("Please choise!", "Messages", MessageBoxButtons.OK);
            }
            else
            {
                var sub_salary = _subSalaryService.GetAll().Where(p => p.IdSub.Equals(txtSaveID.Text)).FirstOrDefault();
                if (sub_salary != null)
                {
                    Form form = new frmEditSubSalary();
                    ContextScope.currentSubSalary = sub_salary;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        showListSub();
                    }
                }
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
                List<SubDetail> list = _list;
                int total = list.Count();
                num.Maximum = total / numberRecord + 1;
                pageNumber = (int)num.Value;
                dgvSubDetail.DataSource = LoadRecord(pageNumber, numberRecord, list);
            }

        }
        //Paging
        List<SubDetail> LoadRecord(int page, int numberRe, List<SubDetail> list)
        {
            List<SubDetail> result = new List<SubDetail>();
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
            var list = _detailAdvanceSalaryService.GetAll().Where(p => p.DateAs.Value.Month.Equals(time.Month) && p.DateAs.Value.Year.Equals(time.Year)).ToList();
            return list;
        }

        //Search Advance salary by name
        public void searchAdvByName(string id)
        {
            var listAdv = _detailAdvanceSalaryService.GetAll().Where(p => p.DateAs.Value.Month.Equals(dtpList.Value.Month) && p.DateAs.Value.Year.Equals(dtpList.Value.Year)).ToList();
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
            _subDetailService = new SubDetailService();
            var list = _subDetailService.GetAll().Where(p => p.IdEmp.Equals(id)).ToList();
            dgvSubDetail.DataSource = LoadRecord(pageNumber, numberRecord, list);
        }


        //filter
        private void btFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbName.SelectedValue == null)
                {
                    MessageBox.Show("Not match data name employee");
                }
                else
                {
                    string id = cbName.SelectedValue.ToString();
                    if (cbOrderby.Text == "Descending" && id == "-1")
                    {
                        showListEmployeHasSubSalary();
                        dgvAdv.DataSource = showAdvanceSalary(dtpList.Value).OrderByDescending(p => p.AdvanceSalary).ToList();
                    }
                    else if (cbOrderby.Text != "Descending" && id == "-1")
                    {
                        showListEmployeHasSubSalary();
                        dgvAdv.DataSource = showAdvanceSalary(dtpList.Value).OrderBy(p => p.AdvanceSalary).ToList();
                    }
                    else
                    {
                        searchAdvByName(id);
                        searchSubByName(id);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not match data name employee" + ex.Message, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSub_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSub.Rows.Count)
            {
                SubSalary item = dgvSub.Rows[e.RowIndex].DataBoundItem as SubSalary;

                if (item != null && item.TimeEnd < DateTime.Now)
                {
                    DataGridViewRow row = dgvSub.Rows[e.RowIndex];
                    row.DefaultCellStyle.BackColor = Color.Brown;
                }
            }
        }

        private void dgvAdv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _employeeService = new EmployeeService();
            if (dgvAdv.Columns[e.ColumnIndex].Name == "IdEmp")
            {

                if (e.Value != null)
                {
                    string idEmp = e.Value.ToString();
                    var nameEmp = _employeeService.GetAll().Where(p => p.IdEmp.Equals(idEmp)).FirstOrDefault();
                    string name = nameEmp.FullNameEmp;
                    e.Value = name;
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvSubDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _employeeService = new EmployeeService();
            if (dgvSubDetail.Columns[e.ColumnIndex].Name == "IdEmpSub")
            {

                if (e.Value != null)
                {
                    string idEmp = e.Value.ToString();
                    var nameEmp = _employeeService.GetAll().Where(p => p.IdEmp.Equals(idEmp)).FirstOrDefault();
                    string name = nameEmp.FullNameEmp;
                    e.Value = name;
                    e.FormattingApplied = true;
                }
            }
            _subSalaryService = new SubSalaryService();
            if (dgvSubDetail.Columns[e.ColumnIndex].Name == "Sub")
            {

                if (e.Value != null)
                {
                    string sub = e.Value.ToString();
                    var nameSub = _subSalaryService.GetAll().Where(p => p.IdSub.Equals(sub)).FirstOrDefault();
                    string name = nameSub.Describe;
                    e.Value = name;
                    e.FormattingApplied = true;
                }
            }

        }

        private void dgvSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvSub[0, e.RowIndex].Value;
            txtSaveID.Text = id.ToString();
        }
    }
}
