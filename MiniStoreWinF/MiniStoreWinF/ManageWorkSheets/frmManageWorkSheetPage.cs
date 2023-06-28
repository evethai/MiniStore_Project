using MiniStoreWinF.ManageWorkSheets;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace MiniStoreWinF.ManageWorkSheet
{
    public partial class frmManageWorkSheetPage : Form
    {
        WorkSheetService _workSheetService = new WorkSheetService();
        SheetDetailService _sheetDetailService = new SheetDetailService();
        EmployeeService _employeeService = new EmployeeService();

        private int rowIndex { get; set; } // create row click
        int loadrecord = 0;
        int numberRecord = 7;
        int pagenumber = 1;
        #region Properties
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private List<string> _dateOfWeek = new List<string>()
        { "Monday", "Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday" };
        #endregion

        public frmManageWorkSheetPage()
        {
            InitializeComponent();
            dgvShowWorkSheet.DataSource = Loadrecord(pagenumber, numberRecord);  //end show worksheet tab 1
            var sheetDetails = _sheetDetailService.GetAll();
            cbSheet.DataSource = sheetDetails;
            cbSheet.DisplayMember = "Sheet";//end code lấy sheet
            var showDetails = _sheetDetailService.GetAll(); // take table
            dgvDetailWorksheet.DataSource = new BindingSource() { DataSource = showDetails }; //end show sheet details tab 5
            LoadDataManage();

        }
        List<WorkSheet> Loadrecord(int page, int recordnumber)
        {
            List<WorkSheet> result = new List<WorkSheet>();
            using (MiniStoreContext db = new MiniStoreContext())
            {
                result = db.WorkSheets.Skip((page - 1) * recordnumber).Take(recordnumber).ToList();
            }
            return result;
        }
        void loadData()
        {
            using (MiniStoreContext dt = new MiniStoreContext())
            {
                dgvShowWorkSheet.DataSource = dt.WorkSheets.ToList();
                dgvDetailWorksheet.DataSource = dt.SheetDetails.ToList();
            }
        }
        private void btNextList_Click(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using (MiniStoreContext dt = new MiniStoreContext())
            {
                totalRecord = dt.WorkSheets.Count();
            }
            if (pagenumber < totalRecord / numberRecord)
            {
                pagenumber++;
                dgvShowWorkSheet.DataSource = Loadrecord(pagenumber, numberRecord);
            }
        }
        private void btBackList_Click(object sender, EventArgs e)
        {
            if (pagenumber - 1 > 0)
            {
                pagenumber--;
                dgvShowWorkSheet.DataSource = Loadrecord(pagenumber, numberRecord);
            }
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void btLoad_Click(object sender, EventArgs e)
        {
            DateTime dateStarts = dateStart.Value;
            DateTime dateEnds = dateEnd.Value;
            try
            {
                var getFilterDayTime = _workSheetService.GetAll().Where(p => p.Date >= dateStarts && p.Date <= dateEnds);
                if (getFilterDayTime == null)
                {
                    MessageBox.Show("Time in valid", "Notification", MessageBoxButtons.OK);
                    getFilterDayTime = _workSheetService.GetAll();
                }
                else
                {
                    dgvShowWorkSheet.DataSource = new BindingSource { DataSource = getFilterDayTime };
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error day time ", "Confirm", MessageBoxButtons.OK);
            }
        }
        private void btUpdateWorkSheet_Click(object sender, EventArgs e)
        {
            string Empty = "";
            if (txtIdWorkSheet.Text == Empty || txtIdEmployees.Text == Empty ||
                txtDateWorkSheet.Text == Empty || txtDateWorkSheet.Text == Empty || txtTimeCheckOut.Text == Empty
                || txtTimeCheckIn.Text == Empty)
            {
                MessageBox.Show("Cant Not Update when you dont choise !! ", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var updateWorkSheet = _workSheetService.GetAll();
                updateWorkSheet[rowIndex].IdEmp = txtIdEmployees.Text;
                updateWorkSheet[rowIndex].Date = DateTime.Parse(txtDateWorkSheet.Text);
                SheetDetail sheetDetail = cbSheet.SelectedItem as SheetDetail;
                updateWorkSheet[rowIndex].Sheet = sheetDetail.Sheet;
                var listUpdate = updateWorkSheet[rowIndex];
                _workSheetService.Update(listUpdate);
                MessageBox.Show("Successfully Update Worksheet History", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                txtIdWorkSheet.Text = Empty;
                txtIdEmployees.Text = Empty;
                txtDateWorkSheet.Text = Empty;
                txtDateWorkSheet.Text = Empty;
                txtTimeCheckOut.Text = Empty;
                txtTimeCheckIn.Text = Empty;
            }

        }
        private void dgvShowWorkSheet_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var rowWorkSheet = dgvShowWorkSheet[0, e.RowIndex].Value;

                var IdWorkSheet = _workSheetService.GetAll().Where(entity => entity.IdWorkSheet.Equals(rowWorkSheet)).FirstOrDefault(); // comapare row choise with table in data
                if (IdWorkSheet == null)
                { return; }
                rowIndex = e.RowIndex;
                var sheet = IdWorkSheet.Sheet;
                cbSheet.Text = IdWorkSheet.Sheet.ToString();
                txtIdWorkSheet.Text = IdWorkSheet.IdWorkSheet.ToString();
                txtIdEmployees.Text = IdWorkSheet.IdEmp.ToString();
                txtDateWorkSheet.Text = IdWorkSheet.Date.ToString();
                txtTimeCheckIn.Text = IdWorkSheet.TimeCheckIn.ToString();
                txtTimeCheckOut.Text = IdWorkSheet.TimeCheckOut.ToString();
            }
            catch
            {
                return;
            }
        }
        private void dgvDetailWorksheet_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var ShowDetail = dgvDetailWorksheet[0, e.RowIndex].Value;
                var Details = _sheetDetailService.GetAll().Where(entity => entity.Sheet.Equals(ShowDetail)).FirstOrDefault();
                if (Details == null)
                {
                    return;
                }
                rowIndex = e.RowIndex;
                var sheetDetail = Details.Sheet;
                var sheetDetails = _sheetDetailService.GetAll().Where(p => p.Sheet.Equals(sheetDetail)).FirstOrDefault();
                txtSheetDetail.Text = sheetDetails.Sheet.ToString();
                txtStartDetails.Text = sheetDetails.ShiftStartTime.ToString();
                txtEndDetails.Text = sheetDetails.ShiftEndTime.ToString();
                txtDescriptionsDetails.Text = sheetDetails.DescriptionS.ToString();
                txtCoefficientsSalaryDetails.Text = sheetDetails.CoefficientsSalary.ToString();
                if (sheetDetails != null)
                {
                    txtSheetDetail.Text = sheetDetails.Sheet.ToString();
                }
                else { txtSheetDetail.Text = "None"; }
            }
            catch
            {
                return;
            }
        }
        private void btUpdateDetailsWorkSheet_Click_1(object sender, EventArgs e)
        {
            string Empty = "";
            if (txtSheetDetail.Text == Empty || txtStartDetails.Text == Empty ||
                txtEndDetails.Text == Empty || txtDescriptionsDetails.Text == Empty || txtCoefficientsSalaryDetails.Text == Empty)
            {
                MessageBox.Show("Cant Not Update when you dont choise !! ", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var updateDetailsSheet = _sheetDetailService.GetAll();
                updateDetailsSheet[rowIndex].Sheet = Int32.Parse(txtSheetDetail.Text);
                updateDetailsSheet[rowIndex].ShiftStartTime = TimeSpan.Parse(txtStartDetails.Text);
                updateDetailsSheet[rowIndex].ShiftEndTime = TimeSpan.Parse(txtEndDetails.Text);
                updateDetailsSheet[rowIndex].DescriptionS = txtDescriptionsDetails.Text;
                updateDetailsSheet[rowIndex].CoefficientsSalary = float.Parse(txtCoefficientsSalaryDetails.Text);
                var listUpdate = updateDetailsSheet[rowIndex];
                _sheetDetailService.Update(listUpdate);
                MessageBox.Show("Successfully Update Worksheet Detail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                txtSheetDetail.Text = Empty;
                txtStartDetails.Text = Empty;
                txtEndDetails.Text = Empty;
                txtDescriptionsDetails.Text = Empty;
                txtCoefficientsSalaryDetails.Text = Empty;
            }

        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            string Empty = "";
            int SheetDetails = Convert.ToInt32(txtSheetDetail.Text);
            var CheckSheet = _sheetDetailService.GetAll().Where(p => p.Sheet == SheetDetails);
            if (txtSheetDetail.Text == Empty ||
                txtStartDetails.Text == Empty || txtEndDetails.Text == Empty || txtDescriptionsDetails.Text == Empty
                || txtCoefficientsSalaryDetails.Text == Empty)
            {
                MessageBox.Show("Can't Create when empty ", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCoefficientsSalaryDetails.Value <= 0)
            {
                MessageBox.Show("Coefficients Salary can't 0 !! ", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckSheet != null)
            {
                MessageBox.Show("Sheet is valid !! ", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var CreateNewSheet = _sheetDetailService.GetAll().FirstOrDefault();
                CreateNewSheet.Sheet = Convert.ToInt32(txtSheetDetail.Text);
                CreateNewSheet.ShiftStartTime = TimeSpan.Parse(txtStartDetails.Text);
                CreateNewSheet.ShiftEndTime = TimeSpan.Parse(txtEndDetails.Text);
                CreateNewSheet.CoefficientsSalary = float.Parse(txtCoefficientsSalaryDetails.Text);
                CreateNewSheet.DescriptionS = txtDescriptionsDetails.Text;
                _sheetDetailService.Create(CreateNewSheet);
                MessageBox.Show("Successfully Create Sheet", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                txtSheetDetail.Text = Empty;
                txtStartDetails.Text = Empty;
                txtEndDetails.Text = Empty;
                txtDescriptionsDetails.Text = Empty;
                txtCoefficientsSalaryDetails.Text = Empty;
            }
        }
        private void txtSheetDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }
        }
        private void txtStartDetails_Leave(object sender, EventArgs e)
        {
            TextBoxBase textBox = (TextBoxBase)sender;
            string input = textBox.Text;
            // Kiểm tra định dạng hh:mm:ss
            TimeSpan timeSpan;
            if (!TimeSpan.TryParseExact(input, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out timeSpan))
            {
                // Nếu không đúng định dạng, thông báo lỗi cho người dùng
                MessageBox.Show("Định dạng thời gian không hợp lệ. Vui lòng nhập lại theo định dạng hh:mm:ss.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus(); // Đưa con trỏ về TextBox để người dùng nhập lại
            }
        }
        private void txtEndDetails_Leave(object sender, EventArgs e)
        {
            TextBoxBase textBox = (TextBoxBase)sender;
            string input = textBox.Text;
            // Kiểm tra định dạng hh:mm:ss
            TimeSpan timeSpan;
            if (!TimeSpan.TryParseExact(input, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out timeSpan))
            {
                // Nếu không đúng định dạng, thông báo lỗi cho người dùng
                MessageBox.Show("Định dạng thời gian không hợp lệ. Vui lòng nhập lại theo định dạng hh:mm:ss.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus(); // Đưa con trỏ về TextBox để người dùng nhập lại
            }
        }
        //======================================================================
        public void LoadDataManage()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-TableSheet.DateButtonMagin, 0) };
            for (int i = 0; i < TableSheet.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < TableSheet.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = TableSheet.DateButtonWidth, Height = TableSheet.DateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + TableSheet.DateButtonMagin, oldBtn.Location.Y);
                    btn.Click += bnt_Click;


                    pnlMatricDate.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-TableSheet.DateButtonMagin, oldBtn.Location.Y + TableSheet.DateButtonHeight) };
            }
            setDefaultDate();
        } //Matric SheetManager
        private void bnt_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
            {
                return;
            }
            frmTableWork daily = new frmTableWork((sender as Button).Text, dtpkDate.Value);
            daily.ShowDialog();
        }
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }
        public void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);

            int row = 0;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = _dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[row][column];
                btn.Text = i.ToString();
                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }
                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Red;
                }
                if (column >= 6)
                    row++;
                useDate = useDate.AddDays(1);

            }
        }
        public bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month
                && dateA.Day == dateB.Day;
        }
        public void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }
        void setDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnMonthBack_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btDateNow_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }
    }
}
