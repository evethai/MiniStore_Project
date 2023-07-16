using Repository.Models;
using Repository.Service;
using System.Data;
using System.Windows.Forms;


namespace MiniStoreWinF.ManageSalary
{
    public partial class frmSalaryDetail : Form
    {
        SalaryService _salaryService;
        //EmployeeService _employeeService;
        Utinity u = new Utinity();
        //Paging
        int pageNumber = 1;
        int numberRecord = 10;
        List<Salary> listSa = null;

        public frmSalaryDetail()
        {
            InitializeComponent();
            _salaryService = new SalaryService();

        }
        private void frmSalaryDetail_Load(object sender, EventArgs e)
        {
            ShowListSalary(DateTime.Now.AddMonths(-1));
            dtpTime.Value = DateTime.Now.AddMonths(-1);
            u.showListEmp_ALL(cbName);

        }

        List<Salary> LoadRecord(int page, int numberRe, List<Salary> list)
        {
            _salaryService = new SalaryService();
            List<Salary> result = new List<Salary>();
            result = list.Skip((page - 1) * numberRe).Take(numberRe).ToList();
            return result;
        }


        public void ShowListSalary(DateTime time)
        {
            var list = u.listSalaryByTime(time).OrderByDescending(p => p.FinalSalary).ToList();
            dgvSalary.DataSource = LoadRecord(pageNumber, numberRecord, list);
            listSa = list;
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            _salaryService = new SalaryService();
            string id = cbName.SelectedValue.ToString();
            DateTime time = dtpTime.Value;
            if (cbOrderby.Text == "Descending" && id == "-1")
            {
                var list = u.listSalaryByTime(time).OrderByDescending(p => p.FinalSalary).ToList();
                dgvSalary.DataSource = LoadRecord(pageNumber, numberRecord, list);
                listSa = list;
            }
            else if (cbOrderby.Text != "Descending" && id == "-1")
            {
                var list = u.listSalaryByTime(time).OrderBy(p => p.FinalSalary).ToList();
                dgvSalary.DataSource = LoadRecord(pageNumber, numberRecord, list);
                listSa = list;
            }
            else
            {
                var list = _salaryService.GetAll().Where(p => p.IdEmp.Equals(id) && p.DateImonth.Month.Equals(time.Month) && p.DateImonth.Year.Equals(time.Year)).ToList();
                dgvSalary.DataSource = LoadRecord(pageNumber, numberRecord, list);
                listSa = list;
            }
        }

        private double TotalSalaryNeedInMonth(DateTime time)
        {
            double total = 0;
            _salaryService = new SalaryService();
            var list = u.listSalaryByTime(time).ToList();
            foreach (var item in list)
            {
                //total += item.SalaryAfterTax;
            }
            return total;
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
                    ShowListSalary(ContextScope.currentDate);
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


        private void dgvSalary_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dgvSalary[0, e.RowIndex].Value;
            var s_salary = _salaryService.GetAll().Where(p => p.IdSalary.Equals(id)).FirstOrDefault();
            if (s_salary != null)
            {
                DialogResult result = MessageBox.Show("Would you like to see this salary details?", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmDetailSalaryDetail form = new frmDetailSalaryDetail();
                    ContextScope.currentSalary = s_salary;
                    form.ShowDialog();
                }
            }

        }

        private void dgvSalary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EmployeeService _employeeService = new EmployeeService();
            if (dgvSalary.Columns[e.ColumnIndex].Name == "idEmp")
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
    }
}
