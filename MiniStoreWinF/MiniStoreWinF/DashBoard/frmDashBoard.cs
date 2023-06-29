
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

        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            ChartMember(pbMember);
            ChartProduct(pbProduct);
            ChartRevenue(pbRevenues);
            ChartVoucher();
        }

        public void ChartProduct(PictureBox p)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Dock = DockStyle.Fill;
            p.Controls.Add(pv);

            var series = new PieSeries();
            var ca = _catalogyService.GetAll().ToList();
            var pro = _productService.GetAll().Where(p => p.StatusP == true).ToList();
            var or = _orderService.GetAll().Where(p => p.DateOrders.Value.Month.Equals(DateTime.Now.AddMonths(-1).Month)).ToList();
            pv.Model = new PlotModel { Title = "Revenue by product type " + DateTime.Now.AddMonths(-1).Month + "/" + DateTime.Now.AddMonths(-1).Year };

            var listType = (from o in or join pr in pro on o.Sku equals pr.Sku select Tuple.Create(pr.ProductType, o.Total)).ToList();

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
            var listMember = _memberService.GetAll().ToList();//2 tháng gần nhất 
            var lastCount = listMember.Count(p => p.TimeCreate.Value.Month < (DateTime.Now.Month));//số lượng memeber 1 tháng trước
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
        public void ChartRevenue(PictureBox p)
        {

            try

            {
                var listRevenues = _revenueService.GetAll().OrderByDescending(p => p.DateRevenue).Take(7).ToList();//7 ngày gần nhất 

                // Tạo danh sách dataPoints cho biểu đồ
                var dataPoints = new List<DataPoint>();
                foreach (var revenue in listRevenues)
                {
                    var dataPoint = new DataPoint(revenue.DateRevenue.Date.Day, (double)revenue.TotalRevenueOfDay);
                    dataPoints.Add(dataPoint);
                }
                // Tạo đối tượng LineSeries
                var revenueSeries = new LineSeries
                {
                    ItemsSource = dataPoints,
                    StrokeThickness = 4
                };

                // Tạo đối tượng PlotModel cho biểu đồ
                var plotModel = new PlotModel { Title = "Revenue fluctuations in the past 7 days" };
                foreach (var dataPoint in dataPoints)
                {
                    double value = dataPoint.Y;
                    string formattedValue = FormatValue(value); // Hàm để định dạng giá trị
                    string label = $"{formattedValue}";
                    var annotation = new OxyPlot.Annotations.TextAnnotation
                    {
                        Text = label,
                        TextPosition = new DataPoint(dataPoint.X, dataPoint.Y + 300),
                        StrokeThickness = 0
                    };
                    plotModel.Annotations.Add(annotation);
                }

                // Cấu hình trục x
                double maxXValue = dataPoints.Max(dp => dp.X);//điểm cao nhất
                double minXValue = dataPoints.Min(dp => dp.X);//điểm cao nhất
                double maxXWithMargin = maxXValue + 0.2;//tăng thêm khoản cách
                double minXWithMargin = minXValue - 0.3;//tăng thêm khoản cách
                var xAxis = new OxyPlot.Axes.LinearAxis
                {
                    Position = OxyPlot.Axes.AxisPosition.Bottom,
                    Maximum = maxXWithMargin,
                    Minimum = minXWithMargin,
                    Title = "Day",
                    MajorStep = 1 // Khoảng cách giữa các đánh dấu chính trên trục x
                };

                //cấu hình trục Y
                double maxYValue = dataPoints.Max(dp => dp.Y);//điểm cao nhất
                double maxYWithMargin = maxYValue * 1.1;//tăng thêm khoản cách
                var yAxis = new OxyPlot.Axes.LinearAxis
                {
                    Position = OxyPlot.Axes.AxisPosition.Left,
                    Title = "Revenues",
                    Maximum = maxYWithMargin,
                    MajorStep = 1000000,
                    StringFormat = "#,#.##"
                };

                //add trục x và y vào
                plotModel.Axes.Add(xAxis);
                plotModel.Axes.Add(yAxis);

                // Thêm chuỗi dữ liệu vào Model.Series
                plotModel.Series.Add(revenueSeries);

                // Tạo đối tượng PlotView và thêm vào pictureBox3
                var plotView = new PlotView
                {
                    Dock = DockStyle.Fill,
                    Model = plotModel
                };

                p.Controls.Add(plotView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " not have data revenues", "Messages", MessageBoxButtons.OK);
            }
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

        string FormatValue(double value)
        {
            if (value < 1000000)
            {

                return value.ToString("#,#");
            }
            else
            {
                double formattedValue = value / 1000000;
                return formattedValue.ToString("#,#.##" + "M");
            }
        }


        private void btSalary_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmSalary(), pMain);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            u.openChildForm(new ManageProducts.ManageAllProduct(), pMain);
        }

        private void pbVouchers_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to open Voucher Management window", "MS Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == DialogResult.Yes)
            {
                Form form = new Manage_Voucher.frmShowVoucher();
                form.ShowDialog();
            }
            else
            {

            }
        }

        private void bntRevenues_Click(object sender, EventArgs e)
        {
            u.openChildForm(new ManageRevenue.frmRevenues(), pMain);
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmShowEmployee(), pMain);
        }
    }
}
