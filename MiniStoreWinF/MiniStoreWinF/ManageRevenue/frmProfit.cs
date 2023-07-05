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

namespace MiniStoreWinF.ManageRevenue
{
    public partial class frmProfit : Form
    {
        ProductService _productService;
        RevenueService _revenueService;
        OrderService _orderService;
        BillOrderService _billOrderService;
        public frmProfit()
        {
            InitializeComponent();
        }

        private void frmProfit_Load(object sender, EventArgs e)
        {
        }

        private double RevenusOfMonth(DateTime time)
        {
            _revenueService = new RevenueService();
            var listRe = _revenueService.GetAll().Where(p => p.DateRevenue.Month.Equals(time.Month)).ToList();
            double? reInMonth = 0;
            foreach (var item in listRe)
            {
                reInMonth += item.TotalRevenueOfDay;
            }
            return (double)reInMonth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           label1.Text = RevenusOfMonth(dateTimePicker1.Value).ToString();
            
        }
    }
}
