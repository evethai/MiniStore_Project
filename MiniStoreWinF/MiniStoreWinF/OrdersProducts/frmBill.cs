using Accessibility;
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

namespace MiniStoreWinF.OrdersProducts
{

    public partial class frmBill : Form
    {
        OrderService _orderService = new OrderService();
        BillOrderService _billService = new BillOrderService();
        MemberService _memberService = new MemberService();
        ProductService _productService = new ProductService();
        UnitService _unitService = new UnitService();

        public string TotalBill { get; set; }
        public frmBill()
        {
            InitializeComponent();
            loadForm();
        }
        public event ChildFormClosedEventHandler ChildFormClosed;
        public delegate void ChildFormClosedEventHandler(object sender, EventArgs e);
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            ChildFormClosed?.Invoke(this, EventArgs.Empty);
        }

        public class CombinedData
        {
            public string Name{ get; set; }
            public string Quantity { get; set; }
            public double Price { get; set; }
            public string Unit { get; set; }
            public double Total { get; set; }
        }
        public void loadForm()
        {
            OrdersBill();
            txtIdBill.Text = ScopeBill.currentBill.IdBillOrder;
            if (ScopeBill.currentBill.PhoneMember != null)
            {
                var CheckMember = _memberService.GetAll().Where(p => p.PhoneMember.Equals(ScopeBill.currentBill.PhoneMember)).FirstOrDefault();
                if (CheckMember != null)
                {
                    txtPhoneMember.Text = CheckMember.Name;
                    txtLoyaltyPoint.Text = CheckMember.Point.ToString();
                }
                else
                {
                    txtLoyaltyPoint.Text = "";
                }
            }
            else
            {
                txtPhoneMember.Text = "";
                txtLoyaltyPoint.Text = "";
            }
            if (ScopeBill.currentBill.DiscountPrice != null)
            {
                txtDiscount.Text = ScopeBill.currentBill.DiscountPrice.ToString();
            }
            else
            {
                txtDiscount.Text = "";
            }
            if (ScopeBill.currentBill.TotalBill != null)
            {
                txtPayMent.Text = ScopeBill.currentBill.TotalBill.ToString();
                txtTotalBill.Text = (ScopeBill.currentBill.TotalBill + ScopeBill.currentBill.DiscountPrice).ToString();
            }
            else
            {
                txtPayMent.Text = "";
            }
            if (ScopeBill.currentBill.DateOfBill != null)
            {
                txtTimeCheckOut.Text = DateTime.Now.ToString();
            }
            else
            {
                txtTimeCheckOut.Text = "";
            }
        }
        public void OrdersBill()
        {
            var CheckBill = _orderService.GetAll().Where(p => p.IdBillOrder.Equals(ScopeBill.currentBill.IdBillOrder)).ToList();
            var combinedDataList = new List<CombinedData>();
            foreach(var order in CheckBill )
            {
                var InforProduct = _unitService.GetAll().Where(p => p.IdUnit.Equals(order.IdUnit)).FirstOrDefault();
                var InforUnit =_productService.GetAll().Where(p => p.Sku.Equals(InforProduct.Sku)).FirstOrDefault();
                var combineData = new CombinedData
                {
                    Name = InforUnit.NameProduct.ToString(),
                    Quantity = order.QuantityOrders.ToString(),
                    Price = InforProduct.PriceExport.Value,
                    Unit = InforProduct.UnitName,
                    Total = order.Total.Value
                };
                combinedDataList.Add(combineData);
            }
            dtgvListProduct.DataSource = combinedDataList;
            dtgvListProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
