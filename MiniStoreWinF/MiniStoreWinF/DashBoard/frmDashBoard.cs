
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.WindowsForms;
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
using OxyPlot.Axes;
using OxyPlot.Annotations;
using System.Globalization;
using Repository.Models;
using MiniStoreWinF.ManageSalary;
using System.Net.WebSockets;
using MiniStoreWinF.ManageEmployees;

namespace MiniStoreWinF.DashBoard
{
    public partial class frmDashBoard : Form
    {
        ProductService _productService;
        OrderService _orderService;
        CatalogyService _catalogyService;
        MemberService _memberService;
        RevenueService _revenueService;
        VoucherService _voucherService;
        UnitService _unitService;
        Utinity u = new Utinity();
        public frmDashBoard()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _catalogyService = new CatalogyService();
            _memberService = new MemberService();
            _revenueService = new RevenueService();
            _voucherService = new VoucherService();
            _productService = new ProductService();
            _unitService = new UnitService();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            ChartMember(pbMember);
            ChartProduct(pbProduct);
            //ChartRevenue(pbRevenues);
            ChartVoucher();
            ChartRevenus();
        }

        public void ChartProduct(PictureBox p)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Dock = DockStyle.Fill;
            p.Controls.Add(pv);

            var series = new PieSeries();
            var ca = _catalogyService.GetAll().ToList();
            var pro = _productService.GetAll().Where(p => p.StatusP == true).ToList();
            var or = _orderService.GetAll().Where(p => p.DateOrders.Value.Month.Equals(DateTime.Now.AddMonths(-1).Month) && p.DateOrders.Value.Year.Equals(DateTime.Now.AddMonths(-1).Year)).ToList();
            pv.Model = new PlotModel { Title = "Revenue by product type " + DateTime.Now.AddMonths(-1).Month + "/" + DateTime.Now.AddMonths(-1).Year };
            var unit = _unitService.GetAll().ToList();
            var listSku = (from o in or join u in unit on o.IdUnit equals u.IdUnit select Tuple.Create(u.Sku, o.Total)).ToList();

            //var listType = (from o in or join pr in pro on o.Sku equals pr.Sku select Tuple.Create(pr.ProductType, o.Total)).ToList();
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
                series.Slices.Add(new PieSlice(c.ProductType, (double)total)
                {
                    IsExploded = true, // Có thể thiết lập để phần tử bị tách ra (hiển thị rời ra)

                });
            }

            //series.Slices.Add(new PieSlice(c.ProductType, ));
            pv.Model.Series.Add(series);
            pv.Model.PlotMargins = new OxyThickness(0, 20, 0, 10);

        }

        public void ChartMember(PictureBox p)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Dock = DockStyle.Fill;
            p.Controls.Add(pv);
            pv.Model = new PlotModel { Title = "Member" };

            var series = new BarSeries();
            var listMember = _memberService.GetAll().ToList();
            var lastCount = listMember.Count(p => p.TimeCreate.Value.Month < (DateTime.Now.Month) && p.TimeCreate.Value.Year <= (DateTime.Now.Year));//số lượng memeber 1 tháng trước
            var currentCount = listMember.Count();//số lượng member ở hiện tại 

            //trục hoành
            var c = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Month",
                Minimum = -0.5, // Giá trị nhỏ nhất trên trục hoành
                Maximum = 1.5, // Giá trị lớn nhất trên trục hoành
                MajorStep = 1,
                MaximumMargin = 0,
                GapWidth = 0.5,
            };
            //trục tung
            var v = new LinearAxis
            {
                Position = AxisPosition.Top,
                Title = "Number of member",
                Minimum = 0,
                Maximum = currentCount + 20,
                MajorStep = 10
            };

            var barSeries = new BarSeries()
            {
                ItemsSource = new List<BarItem>(new[]
                {
                    new BarItem{Value = lastCount,CategoryIndex=0},
                    new BarItem{Value = currentCount,CategoryIndex=1},
                }),
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:,00}",
                LabelMargin = 10,


            };
            c.Labels.Add(CultureInfo.GetCultureInfo("en-US").DateTimeFormat.GetMonthName(DateTime.Now.AddMonths(-1).Month));
            c.Labels.Add(CultureInfo.GetCultureInfo("en-US").DateTimeFormat.GetMonthName(DateTime.Now.Month));

            pv.Model.Series.Add(barSeries);
            pv.Model.Axes.Add(c);
            pv.Model.Axes.Add(v);
            pv.Model.Series.Add(series);
        }
        

        public void ChartVoucher()
        {
            var list = _voucherService.GetAll().Where(p => p.Quantity > 0).ToList();
            foreach (var voucher in list)
            {
                pbVouchers.Series["Quantity"].Points.AddXY(voucher.Name, voucher.Quantity);
            }
            // Tắt hiển thị lưới trục x
            pbVouchers.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Tắt hiển thị lưới trục y
            pbVouchers.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }
        public void ChartRevenus()
        {
            var listRevenues = _revenueService.GetAll().OrderByDescending(p => p.DateRevenue).Take(7).ToList();
            foreach (var item in listRevenues)
            {
                var point = pbRevenues.Series["Revenue"].Points.AddXY(item.DateRevenue, item.TotalRevenueOfDay);
            }
            pbRevenues.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            pbRevenues.ChartAreas[0].AxisY.LabelStyle.Format = "#,###,###";
            // Tắt hiển thị lưới trục y
            pbRevenues.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

    }
}
