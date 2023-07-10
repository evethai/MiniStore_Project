using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.ManageWorkSheets
{
    public partial class frmRegisterWorksheet : Form
    {
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
        public frmRegisterWorksheet()
        {
            InitializeComponent();
            LoadDataManage();
            ShowNotification();
        }

        public void LoadDataManage()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-TableSheet.DateButtonMagin, 0) };
            for (int i = 0; i < TableSheet.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < TableSheet.DayOfWeek; j++)
                {
                    btMonday.Dock = DockStyle.Fill;

                    Button btn = new Button() { Width = btMonday.Width, Height = btMonday.Height };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + TableSheet.DateButtonMagin, oldBtn.Location.Y);
                    btn.Click += bnt_Click;
                    btn.AutoSize = true;
                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;

                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-TableSheet.DateButtonMagin, oldBtn.Location.Y + TableSheet.DateButtonHeight) };
            }
            setDefaultDate();
        }
        //Matric SheetManager
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
        private void bnt_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
            {
                return;
            }
            frmTableWork daily = new frmTableWork((sender as Button).Text, dtpkDate.Value);
            daily.ShowDialog();
        }
       public int DayOfMonth(DateTime date)
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

        private void dtpkDate_ValueChanged_1(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnNextMonth_Click_1(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnMonthBack_Click_1(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }
        public void ShowNotification()
        {
            WorkSheetService workSheetService = new WorkSheetService();
            var showNotification = workSheetService.GetAll().Where(p => p.Date.Value.Month == dtpkDate.Value.Month && p.Status.Value == false).ToList().Count;
            if (showNotification > 0)
            {
                nmbrNotification.Value = showNotification;
                chbNotification.Checked = true;
            }
            else 
            {
                chbNotification.Checked = false;            
            }
        }
        public int DayOfMonths(DateTime date , int month)
        {
            if(month>=1 && month <= 12) {
                switch (month)
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
            else
            {
                throw new ArgumentException();
            }
            
        }
    }

}
