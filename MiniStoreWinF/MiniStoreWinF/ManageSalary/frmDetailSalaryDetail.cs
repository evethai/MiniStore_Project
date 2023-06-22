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
    public partial class frmDetailSalaryDetail : Form
    {
        WorkSheetService _workSheetService;
        SalaryService _salaryService;
        public frmDetailSalaryDetail()
        {
            InitializeComponent();
        }
        public int sumday(string id)
        {
            _salaryService = new SalaryService();
            int n = 0;
            var list = _salaryService.GetAll().Where(p => p.IdSalary.Equals(id)).FirstOrDefault();
            if (list != null)
            {
                n = list.DateOmonth.Day - list.DateImonth.Day;
            }
            return n;
        }

        private void frmDetailSalaryDetail_Load(object sender, EventArgs e)
        {
            dataList("SE12", DateTime.Now.AddMonths(-1));
        }
        public void dataList(string id,DateTime date)
        {
            _salaryService = new SalaryService();
            _workSheetService = new WorkSheetService();
            var listSa = _salaryService.GetAll().ToList();
            var listWs = _workSheetService.GetAll().Where(p=>p.Date.Value.Month.Equals(date.Month)).ToList();



            var data = (from sa in listSa
                        join ws in listWs on sa.IdEmp equals ws.IdEmp
                        where sa.IdEmp.Equals(id)
                        select Tuple.Create(ws.TimeCheckIn, ws.TimeCheckOut)).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(string));
            DataRow newRow1 = dt.NewRow();
            newRow1["Date"] ="Time Check In";
            DataRow newRow2 = dt.NewRow();
            newRow2["Date"] = "Time Check Out";
            dt.Rows.Add(newRow1);
            dt.Rows.Add(newRow2);

            for (int i = 0; i < data.Count; i++)
            {
                string time = data[i].Item1.Value.Day.ToString();
                dt.Columns.Add(time, typeof(string));
                    newRow1[time] = data[i].Item1.Value.TimeOfDay;
                    newRow2[time] = data[i].Item2.Value.TimeOfDay;
            }

            dataGridView1.DataSource = dt;
        }

    }

}
