using MiniStoreWinF.ManageSalary;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.ManageRevenue
{
    public partial class frmProfit : Form
    {
        ProductService _productService;
        RevenueService _revenueService;
        UnitService _unitService;
        OrderService _orderService;
        BillOrderService _billOrderService;
        SalaryService _salaryService;
        Utinity u = new Utinity();
        public frmProfit()
        {
            InitializeComponent();
        }

        private void frmProfit_Load(object sender, EventArgs e)
        {
            ChartImport(new DateTime(2023, 04, 01));
            ChartSalary(new DateTime(2023, 04, 01));
            SumOfNumberOrderEachUnit();
        }

        private double RevenusOfMonth(DateTime time)
        {
            _revenueService = new RevenueService();
            var listRe = _revenueService.GetAll().Where(p => p.DateRevenue.Month.Equals(time.Month) && p.DateRevenue.Year.Equals(time.Year)).ToList();
            double? reInMonth = 0;
            foreach (var item in listRe)
            {
                reInMonth += item.TotalRevenueOfDay;
            }
            return (double)reInMonth;
        }

        //private double TotalSalaryNeedInMonth(DateTime time)
        //{
        //    //double total = 0;
        //    //_salaryService = new SalaryService();
        //    //var list = u.salary(time).ToList();
        //    //foreach (var item in list)
        //    //{
        //    //    total += item.SalaryAfterTax;
        //    //}
        //    //return total;
        //}

        private void ChartImport(DateTime time)
        {
            _productService = new ProductService();
            _unitService = new UnitService();
            var listPro = _productService.GetAll().Where(p => p.DateImport.Value.Year.Equals(time.Year)).ToList();
            var listUni = _unitService.GetAll().ToList();

            double money = 0;
            var list = (from p in listPro
                        join u in listUni on p.Sku equals u.Sku
                        select Tuple.Create(p.DateImport, u.PriceImport)).ToList();

            for (int i = 1; i < 12; i++)
            {
                foreach (var item in list)
                {
                    if (item.Item1.Value.Month == i)
                    {
                        money += item.Item2.Value;
                    }
                }
                chImport.Series["VND"].Points.AddXY(i, money);
                money = 0;
            }

            // Tắt hiển thị lưới trục x
            chImport.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            // Tắt hiển thị lưới trục y
            chImport.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void ChartSalary(DateTime time)
        {
            //double total = 0;
            //_salaryService = new SalaryService();
            //var list = _salaryService.GetAll().Where(p => p.DateOmonth.Year == time.Year).ToList();
            //for (int i = 1; i < 12; i++)
            //{
            //    foreach (var item in list)
            //    {
            //        if (item.DateImonth.Month == i)
            //        {
            //            total += item.SalaryAfterTax;
            //        }
            //    }
            //    chSalary.Series["VND"].Points.AddXY(i, total);
            //    total = 0;
            //}
            //// Tắt hiển thị lưới trục x
            //chImport.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //// Tắt hiển thị lưới trục y
            //chImport.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void SumOfNumberOrderEachUnit()
        {
            List<Unit> listOrderProduct = new List<Unit>();
            List<Unit> listAllProductImport = new List<Unit>();
            _orderService = new OrderService();
            _unitService = new UnitService();
            var listOr = _orderService.GetAll().ToList();
            var listUnit = _unitService.GetAll().ToList();
            int? quantity = 0;

            var listTrue = (from u in listUnit
                            join o in listOr on u.IdUnit equals o.IdUnit
                            select Tuple.Create(u.IdUnit, o.QuantityOrders)).ToList();


            //số lượng sản phẩm bán ra ngoài theo từng loại unit
            foreach (var item in listUnit)
            {
                Unit unit = new Unit();
                foreach (var item2 in listTrue)
                {
                    if (item.IdUnit.Equals(item2.Item1.ToString()))
                    {
                        quantity += item2.Item2;
                    }
                }
                unit.IdUnit = item.IdUnit;
                unit.QuantityUnit = quantity;
                unit.PriceImport = item.PriceImport;
                listOrderProduct.Add(unit);
                quantity = 0;
            }

            //số lượng sản phẩm nhập kho theo từng loại unit
            foreach (var item in listOrderProduct)
            {
                Unit unit = new Unit();
                foreach (var item2 in listUnit)
                {
                    if (item.IdUnit.Equals(item2.IdUnit))
                    {
                        quantity = item.QuantityUnit + item2.QuantityUnit;
                    }
                }
                unit.IdUnit = item.IdUnit;
                unit.QuantityUnit = quantity;
                unit.PriceImport = item.PriceImport;
                listAllProductImport.Add(unit);
                quantity = 0;
            }

            //tính tổng số tiền cần để nhập hàng từ khi nào ?

            double? price = 0;
            foreach (var item in listAllProductImport)
            {
                price += item.PriceImport*item.QuantityUnit; 
            }


            label1.Text = u.formatDouble(price);
            dataGridView1.DataSource = listOrderProduct;
            dataGridView2.DataSource = listAllProductImport;
            dataGridView3.DataSource = listUnit;


        }

    }
}
