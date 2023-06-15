using Repository.Models;
using Repository.Service;
using System.Data;


namespace MiniStoreWinF.ManageSalary
{
    public partial class frmSalaryDetail : Form
    {
        SalaryService _salaryService;
        EmployeeService _employeeService;
        Utinity u = new Utinity();
        //Phân trang
        int pageNumber = 1;
        int numberRecord = 5;
        List<Salary> listSa = null;
        //reset
        DateTime time = DateTime.Now;

        public frmSalaryDetail()
        {
            InitializeComponent();
        }

        List<Salary> LoadRecord(int page, int numberRe, List<Salary> list)
        {
            _salaryService = new SalaryService();
            List<Salary> result = new List<Salary>();
            result = list.Skip((page - 1) * numberRe).Take(numberRecord).ToList();
            return result;
        }

        private void frmSalaryDetail_Load(object sender, EventArgs e)
        {
            ShowListSalary();
            _employeeService = new EmployeeService();
            var listEmp = _employeeService.GetAll().Where(p => p.IsActive == true).ToList();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            foreach (var item in listEmp)
            {
                autoCompleteStringCollection.Add(item.FullNameEmp);
            }
            cbName.AutoCompleteCustomSource = autoCompleteStringCollection;
            cbName.ValueMember = "IdEmp";
            cbName.DisplayMember = "FullNameEmp";
            cbName.DataSource = listEmp;
        }
        public void ShowListSalary()
        {
            _salaryService = new SalaryService();
            var list = _salaryService.GetAll().ToList();
            dgvSalary.DataSource = LoadRecord(pageNumber, numberRecord, list);
            listSa = list;
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            _salaryService = new SalaryService();
            DateTime time = dtpTime.Value;
            var list = _salaryService.GetAll().Where(p => p.DateImonth.Month.Equals(time.Month)).ToList();
            dgvSalary.DataSource = LoadRecord(pageNumber, numberRecord, list);
            listSa = list;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            _salaryService = new SalaryService();
            string id = cbName.SelectedValue.ToString();
            DateTime time = dtpTime.Value;
            var list = _salaryService.GetAll().Where(p => p.IdEmp.Equals(id) && p.DateImonth.Month.Equals(time.Month)).ToList();
            dgvSalary.DataSource = LoadRecord(pageNumber, numberRecord, list);
            listSa = list;
        }

        private void dgvSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _salaryService = new SalaryService();
            var id = dgvSalary[0, e.RowIndex].Value;
            var s_salary = _salaryService.GetAll().Where(p => p.IdSalary.Equals(id)).FirstOrDefault();
            if (s_salary != null)
            {
                txtSave.Text = s_salary.IdEmp.ToString();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            DialogResult result =
    MessageBox.Show("Warning: Please make sure you have updated all the new salary parameters before recalculating the salary to ensure accurate results.", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Form form = new frmResetSalaryCheck();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.Yes)
                {
                    ShowListSalary();
                }
            }
            else
            {
                return;
            }
        }

        private void nmPaging_ValueChanged(object sender, EventArgs e)
        {
            if (listSa.Count > 0)
            {
                NumericUpDown num = sender as NumericUpDown;
                List<Salary> list = listSa;
                int total = list.Count();
                num.Maximum = total / numberRecord + 1;
                pageNumber = (int)num.Value;
                dgvSalary.DataSource = LoadRecord(pageNumber, numberRecord, list);
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Only for excel Microsoft offical!", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dgvSalary.SelectAll();
                    DataObject copyDate = dgvSalary.GetClipboardContent();
                    if (copyDate != null)
                    {
                        Clipboard.SetDataObject(copyDate);
                    }
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbook xlWbook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWsheet;
                    object data = System.Reflection.Missing.Value;
                    xlWbook = excel.Workbooks.Add(data);
                    xlWsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlWsheet.Cells[1, 1];
                    xlr.Select();
                    xlWsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Can not find Microsoft offical in you device!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                return;
            }
        }
    }
}
