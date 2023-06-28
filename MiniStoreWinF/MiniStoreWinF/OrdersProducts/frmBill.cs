﻿using Repository.Models;
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

namespace MiniStoreWinF.OrdersProducts
{
    
    public partial class frmBill : Form
    {
        OrderService _orderService = new OrderService();
        BillOrderService _billService = new BillOrderService();
        public frmBill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        public event ChildFormClosedEventHandler ChildFormClosed;
        public delegate void ChildFormClosedEventHandler(object sender, EventArgs e);
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            ChildFormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
           
        }
    }
}
