
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
        Utinity u = new Utinity();
        CalculationAuto ca = new CalculationAuto();
        List<SubSalary> _list =null;
        int pageNumber = 1;
        int numberRecord = 3;

        public frmSubSalary()
        {
            InitializeComponent();

        }

        private void frmSubSalary_Load(object sender, EventArgs e)
        {
            showlvSub();
            //
            u.showListEmp(cbName);
            //
            showListEmployeHasSubSalary();
        }
        public void showListEmployeHasSubSalary()
        {
            _subSalaryService = new SubSalaryService();
            var list = _subSalaryService.GetAll().ToList();
            dgvTotalSub.DataSource = LoadRecord(pageNumber, numberRecord, list);
            _list = list;
        }

        public void showlvSub()
        {
            _detailSubSalaryService = new DetailSubSalaryService();
            var listSub = _detailSubSalaryService.GetAll().Where(p => p.ActiveSub == true).ToList();
            dgvSub.DataSource = listSub;
        }

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
                    form.idForm = txtSaveID.Text;
                    form.disForm = sub_salary.DescriptionA;
                    form.saForm = sub_salary.SubsidiesSalary.ToString();
                    form.conForm = sub_salary.Condition.ToString();
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.OK)
                    {
                        showlvSub();
                    }
                }
            }
        }

        private void dgvSub_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dgvSub[0, e.RowIndex].Value;
            var s_salary = _detailSubSalaryService.GetAll().Where(p => p.IdDetailSubSalary.Equals(id) && p.ActiveSub == true).FirstOrDefault();
            if (s_salary != null)
            {
                txtSaveID.Text = s_salary.IdDetailSubSalary.ToString();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form form = new frmAddNewSubSalary();
            if (form.ShowDialog() == DialogResult.OK)
            {
                showlvSub();
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            DateTime time = dtpList.Value;
            _subSalaryService = new SubSalaryService();
            var list = _subSalaryService.GetAll().Where(p => p.Time.Value.Month.Equals(time.Month)).ToList();
            dgvTotalSub.DataSource = LoadRecord(pageNumber,numberRecord,list);

            _list=list;
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            _subSalaryService = new SubSalaryService();
            DateTime time = dtpList.Value;
            string id = cbName.SelectedValue.ToString();
            double total = ca.SubSalary(id, time);
            txtTotal.Text = total.ToString();  
            var list = _subSalaryService.GetAll().Where(p=>p.IdEmp.Equals(id) && p.Time.Value.Month.Equals(time.Month)).ToList();
            dgvTotalSub.DataSource = LoadRecord(pageNumber, numberRecord, list);
            _list = list;

        }

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

        List<SubSalary> LoadRecord(int page, int numberRe,List<SubSalary>list)
        {
            _subSalaryService = new SubSalaryService();
            List<SubSalary> result = new List<SubSalary>();
            result = list.Skip((page - 1) * numberRe).Take(numberRecord).ToList();
            return result;
        }
    }
}
