using MiniStoreWinF.ManageSalary;
using OxyPlot.Series;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MiniStoreWinF.ManageRevenue
{
    public partial class frmRevenues : Form
    {
        RevenueService _revenueService;
        BillOrderService _billOrderService;
        ProductService _productService;
        CatalogyService _catalogyService;
        OrderService _orderService;
        UnitService _unitService;
        Utinity u = new Utinity();
        public frmRevenues()
        {
            InitializeComponent();
            _revenueService = new RevenueService();
            _billOrderService = new BillOrderService();
            _orderService = new OrderService();
            _catalogyService = new CatalogyService();
            _productService = new ProductService();
            _unitService = new UnitService();
        }

        public void chartRevenues(DateTime time)
        {
            var listRe = _revenueService.GetAll().Where(p => p.DateRevenue.Month.Equals(time.Month)&& p.DateRevenue.Year.Equals(time.Year)).ToList();
            var listBill = _billOrderService.GetAll().Where(p => p.DateOfBill.Value.Month.Equals(time.Month)&& p.DateOfBill.Value.Year.Equals(time.Year)).ToList();
            double? reInMonth = 0;
            foreach (var item in listRe)
            {
                var count = listBill.Count(p => p.DateOfBill.Equals(item.DateRevenue));
                cRevenues.Series["Revenues"].Points.AddXY(item.DateRevenue.Date, item.TotalRevenueOfDay);
                cRevenues.Series["Number Orders"].Points.AddXY(item.DateRevenue, count);
                reInMonth += item.TotalRevenueOfDay;
            }

            // Tắt hiển thị lưới trục x
            cRevenues.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //format trục y 
            cRevenues.ChartAreas[0].AxisY.LabelStyle.Format = "#,###,###";

            // Tắt hiển thị lưới trục y
            cRevenues.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            // Tắt lưới trục phụ y
            cRevenues.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;

            //
            //----- detail----------
            //
            var orderInMonth = listBill.Count();
            txtNumOrMonth.Text = orderInMonth.ToString();
            txtReMonth.Text = u.formatDouble(reInMonth);
            //
            //----------increase------
            //
            //lấy số ngày của tháng này để so sánh nếu trường hợp chưa hết 1 tháng 
            var n = _revenueService.GetAll().Where(p => p.DateRevenue.Month.Equals(time.Month) && p.DateRevenue.Year.Equals(time.Year)).Count();

            //tính danh thu tháng trước theo số lượng ngày đã tính tháng này
            var listlastMonth = _revenueService.GetAll().Where(p => p.DateRevenue.Month.Equals(time.AddMonths(-1).Month) && p.DateRevenue.Year.Equals(time.AddMonths(-1).Year)).ToList();
            double? totalLast = 0;
            foreach (var item in listlastMonth)
            {
                if (n > 0)
                {
                    totalLast += item.TotalRevenueOfDay;
                    n--;
                }
                else
                {
                    break;
                }
            }

            //calculate % is increase:
            //công thức tính tăng trưởng (%) giữa 2 tháng: 
            double percent = (double)((reInMonth - totalLast) / totalLast) * 100;
            if (percent > 0)
            {
                txtIncrease.ForeColor = Color.Blue;
            }
            else
            {
                txtIncrease.ForeColor = Color.Red;
            }
            double? r = Math.Round(percent, 1);
            txtIncrease.Text = r.ToString() + "%";

        }
        public void sumDetail()
        {
            var listRe = _revenueService.GetAll().ToList();
            var listBill = _billOrderService.GetAll().Count();
            double? totalRevenue = 0;
            foreach (var item in listRe)
            {
                totalRevenue += item.TotalRevenueOfDay;
            }
            txtSumRe.Text = u.formatDouble(totalRevenue);
            txtSumOr.Text = listBill.ToString();
        }
        public void chartReTypeProduct(DateTime time)
        {

            var ca = _catalogyService.GetAll().ToList();
            var pro = _productService.GetAll().Where(p => p.StatusP == true).ToList();
            var or = _orderService.GetAll().Where(p => p.DateOrders.Value.Month.Equals(time.Month) && p.DateOrders.Value.Year.Equals(time.Year)).ToList();
            var unit = _unitService.GetAll().ToList();

            var listSku = (from o in or join u in unit on o.IdUnit equals u.IdUnit select Tuple.Create(u.Sku,o.Total)).ToList();

            var listType = (from lk in listSku join pr in pro on lk.Item1 equals pr.Sku select Tuple.Create(pr.ProductType, lk.Item2)).ToList();

            foreach (var c in ca)
            {
                double? total = 0;
                foreach (var t in listType)
                {
                    if (c.ProductType.Equals(t.Item1))
                    {
                        total += t.Item2;
                    }
                }
                cProduct.Series["Revenue"].Points.AddXY(c.ProductType, total);
            }

            cProduct.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            cProduct.ChartAreas[0].AxisY.LabelStyle.Format = "#,###,###";
            cProduct.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void frmRevenues_Load(object sender, EventArgs e)
        {
            chartRevenues(dtpRe.Value);
            chartReTypeProduct(dtpRe.Value);
            sumDetail();
            txtTime.Text = CultureInfo.GetCultureInfo("en-US").DateTimeFormat.GetMonthName(dtpRe.Value.Month) + " - " + dtpRe.Value.Year;
        }

        private void dtpRe_ValueChanged(object sender, EventArgs e)
        {
            var first = _revenueService.GetAll().FirstOrDefault();
            var last = _revenueService.GetAll().LastOrDefault();
            if ((dtpRe.Value.Month < first.DateRevenue.Month || dtpRe.Value.Month > last.DateRevenue.Month) && dtpRe.Value.Year == first.DateRevenue.Year && dtpRe.Value.Year == last.DateRevenue.Year)
            {
                MessageBox.Show("No sales this month", "Messages", MessageBoxButtons.OK);
                dtpRe.Value = DateTime.Now;
            }
            else
            {
                cProduct.Series["Revenue"].Points.Clear();
                cRevenues.Series["Number Orders"].Points.Clear();
                cRevenues.Series["Revenues"].Points.Clear();
                chartRevenues(dtpRe.Value);
                chartReTypeProduct(dtpRe.Value);
                sumDetail();
                txtTime.Text = CultureInfo.GetCultureInfo("en-US").DateTimeFormat.GetMonthName(dtpRe.Value.Month) + " - " + dtpRe.Value.Year;
            }
        }
    }
}
