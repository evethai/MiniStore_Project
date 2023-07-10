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
    public partial class frmDetailSalaryDetail : Form
    {
        WorkSheetService _workSheetService;
        SalaryService _salaryService;
        OrderService _orderService;
        EmployeeService _employeeService;
        public string id;
        public DateTime time;
        public frmDetailSalaryDetail()
        {
            InitializeComponent();
            _salaryService = new SalaryService();
            _workSheetService = new WorkSheetService();
            _employeeService = new EmployeeService();
            _orderService = new OrderService();
        }

        private void frmDetailSalaryDetail_Load(object sender, EventArgs e)
        {
            dataList(id, time);
            txtTime.Text = time.Month + "/" + time.Year;
            txtHour.Text = sumHourinMonth(time, id).ToString();
            txtRevenus.Text = sumOrdersInMonth(time, id).ToString();
            txtOrder.Text = countTotal(time, id).ToString();
            txtName.Text = name(id);
        }
        //Paging
        private int currentPage = 1;
        private int pageSize = 7;
        private DataTable dt;

        /*show list worktime in month of each specific employee*/
        public void dataList(string id, DateTime date)
        {

            var listSa = _salaryService.GetAll().ToList();
            var listWs = _workSheetService.GetAll().Where(p => p.Date.Value.Month.Equals(date.Month)&& p.Date.Value.Year.Equals(date.Year) && p.Status==true).ToList();

            var data = (from sa in listSa
                        join ws in listWs on sa.IdEmp equals ws.IdEmp
                        where sa.IdEmp.Equals(id)
                        select Tuple.Create(ws.TimeCheckIn, ws.TimeCheckOut)).ToList();

            dt = new DataTable();
            DataRow newRow1 = dt.NewRow();
            DataRow newRow2 = dt.NewRow();

            for (int i = 0; i < data.Count; i++)
            {
                string row = data[i].Item1.Value.Day.ToString();
                dt.Columns.Add(row, typeof(string));
                newRow1[row] = data[i].Item1.Value.TimeOfDay;
                newRow2[row] = data[i].Item2.Value.TimeOfDay;
            }
            //LoadDataByPage(currentPage);
            dt.Rows.Add(newRow1);
            dt.Rows.Add(newRow2);

            LoadDataByPage(currentPage);
        }

        /*Paging*/
        private void LoadDataByPage(int page)
        {
            int startIndex = (page - 1) * pageSize;
            int endIndex = startIndex + pageSize - 1;

            // Xóa các cột hiện tại trong DataGridView
            dataGridView1.Columns.Clear();

            // Tạo và thêm cột cho trang hiện tại
            for (int i = startIndex; i <= endIndex && i < dt.Columns.Count; i++)
            {
                string columnName = dt.Columns[i].ColumnName;
                dataGridView1.Columns.Add(columnName, columnName);
            }

            // Xóa các dòng hiện tại trong DataGridView
            dataGridView1.Rows.Clear();

            // Thêm dữ liệu vào các dòng của trang hiện tại
            for (int rowIndex = 0; rowIndex < 2; rowIndex++) // Số dòng cố định là 2
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                for (int i = startIndex; i <= endIndex && i < dt.Columns.Count; i++)
                {
                    string columnName = dt.Columns[i].ColumnName;
                    dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
                    {
                        Value = dt.Rows[rowIndex][columnName].ToString()
                    });
                }

                dataGridView1.Rows.Add(dataGridViewRow);
            }
        }

        private void btPre_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDataByPage(currentPage);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (currentPage < (int)Math.Ceiling((double)dt.Columns.Count / pageSize))
            {
                currentPage++;
                LoadDataByPage(currentPage);
            }
        }

        
        public double sumHourinMonth(DateTime time, string id)
        {
            double sum = 0;
            var list = _workSheetService.GetAll().Where(p => p.Date.Value.Month.Equals(time.Month) && p.Date.Value.Year.Equals(time.Year) && p.IdEmp.Equals(id)&&p.Status==true).ToList();
            foreach (var item in list)
            {
                sum += (item.TimeCheckOut.Value.TimeOfDay - item.TimeCheckIn.Value.TimeOfDay).TotalHours;
            }
            return sum;
        }
        public double? sumOrdersInMonth(DateTime time, string id)
        {

            double? total = 0;
            var list = _orderService.GetAll().Where(p => p.IdEmp.Equals(id) && p.DateOrders.Value.Month.Equals(time.Month) && p.DateOrders.Value.Year.Equals(time.Year)).ToList();
            foreach (var item in list)
            {
                total += item.Total;
            }
            return total;
        }
        public int countTotal(DateTime time, string id)
        {
            var count = _orderService.GetAll().Count(p => p.IdEmp.Equals(id) && p.DateOrders.Value.Month.Equals(time.Month) && p.DateOrders.Value.Year.Equals(time.Year));
            return count;
        }
        public string name(string id)
        {
            string emp = "";
            var list = _employeeService.GetAll().Where(p => p.IdEmp.Equals(id)).FirstOrDefault();
            if (list != null)
            {
                emp = list.FullNameEmp;
            }
            return emp;
        }
    }

}
