using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore;

namespace MiniStoreWinF.OrdersProducts
{
    public partial class OrderProducts : Form
    {
        ProductService _productService = new ProductService();
        CatalogyService _catalogyService = new CatalogyService();
        MemberService _memberService = new MemberService();
        VoucherService _voucherService = new VoucherService();
        EmployeeService _employeeService = new EmployeeService();
        BillOrderService _showBillService = new BillOrderService();
        RevenueService _revenueService = new RevenueService();
        OrderService _orderService = new OrderService();
        public string CheckMemberNew;
        public string CheckMember;
        public string SKU;
        public string Data { get; set; }
        private int rowIndex { get; set; } // craete row click
        public OrderProducts()
        {
            InitializeComponent();
            var showType = _catalogyService.GetAll();
            cbTypeProducts.DataSource = showType;
            cbTypeProducts.DisplayMember = "ProductType";
            var showVoucher = _voucherService.GetAll();
            cbVourcherOrder.DataSource = showVoucher;
            cbVourcherOrder.DisplayMember = "Name";
            int NoType = 0;
            int Type200 = 200;
            int Type500 = 500;
            int Type1000 = 1000;
            cbPointUsing.Items.Add(NoType);
            cbPointUsing.Items.Add(Type200);
            cbPointUsing.Items.Add(Type500);
            cbPointUsing.Items.Add(Type1000);
        }
        private void OrderProducts_Load(object sender, EventArgs e)
        {
            TakeInfoEmployee();
            LoadData(); ;
        }
        void LoadData()
        {
            var listProductsShow = _productService.GetAll().Select(p => new { p.Sku, p.NameProduct, p.QuantityProduct, p.PriceProduct, p.Nxx, p.Hsd, p.PictureProduct }).ToList();
            dgvShowListProducts.DataSource = new BindingSource()
            {
                DataSource = listProductsShow
            };

        }//LOAD FORM ORDERS => OK
        private void btSearch_Click(object sender, EventArgs e)
        {
            string txtSearch = txtSearchName.Text;
            var valueSearch = _productService.GetAll().Where(p => p.NameProduct.Contains(txtSearch)).ToList();
            if (txtSearch == "")
            {
                LoadData();
            }
            else
            {
                dgvShowListProducts.DataSource = new BindingSource()
                {
                    DataSource = valueSearch
                };
            }
        } // BUTTON SEARCH BY NAME => OK
        private void cbTypeProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var compareType = cbTypeProducts.Text;
            var compareTypeShow = _productService.GetAll().Where(p => p.ProductType.Equals(compareType)).ToList();
            dgvShowListProducts.DataSource = new BindingSource()
            {
                DataSource = compareTypeShow
            };

        } // FILTER BY TYPE PRODUCTS => OK
        private void dgvShowListProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string imageProducts = "";
                var RowOrder = dgvShowListProducts[0, e.RowIndex].Value;
                var OrderChoise = _productService.GetAll().Where(entity => entity.Sku.Equals(RowOrder)).FirstOrDefault();
                rowIndex = e.RowIndex;
                if (OrderChoise != null)
                {
                    SKU = OrderChoise.Sku.ToString();
                    txtNameOrder.Text = OrderChoise.NameProduct.ToString();
                    txtPriceOrder.Text = OrderChoise.PriceProduct.ToString();
                    imageProducts = OrderChoise.PictureProduct.ToString();
                    pcPictureOrders.Image = Base64ToImage(imageProducts);
                }
            }
            catch (Exception ex)
            {
            }

        }  // CLICK CHOISE PRODUCTS => OK 
        private void btAddOrders_Click(object sender, EventArgs e)
        {
            AddItems();

        } // BUTTON ADD PRODUCTS => OK
        public void AddItems()
        {
            int columnIndex = 4; // Index của cột cần tính tổng (0 là cột đầu tiên)
            double total = 0;
            string NameOrder = txtNameOrder.Text;
            float PriceOrder = float.Parse(txtPriceOrder.Text);
            if (NameOrder.Length <= 0 || PriceOrder <= 0)
            {
                MessageBox.Show("Place choise Products", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtQuantityOrder.Text == "" || txtQuantityOrder.Text == "0")
            {
                MessageBox.Show("Error Enter Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(txtQuantityOrder.Text, out int result))
            {
                int QuantityOrder = result;
                float totals = QuantityOrder * PriceOrder;
                ListViewItem items = new ListViewItem(SKU);
                items.SubItems.Add(NameOrder).ToString();
                items.SubItems.Add(QuantityOrder.ToString());
                items.SubItems.Add(PriceOrder.ToString());
                items.SubItems.Add(totals.ToString());
                listViewOrders.Items.Add(items);
                foreach (ListViewItem item in listViewOrders.Items)
                {
                    int value = int.Parse(item.SubItems[columnIndex].Text);
                    total += value;
                }
                txtTotalAllOrders.Text = total.ToString();
            }
        } // ADD FUNCTION ==> OK
        private void btCheckMember_Click(object sender, EventArgs e)
        {
            MemberCheck memberCheckcs = new MemberCheck();
            memberCheckcs.ShowDialog();
            CheckMember = memberCheckcs.TextBoxValue.ToString();
            CheckMemberNew = memberCheckcs.TextBoxValueMemberNew.ToString();
            cbPointUsing.Enabled = true;
        } // BUTTON NEXT PAGE MEMBER CHECK_CREATE ==> OK 
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        } //IMAGE IMPORT => OK 
        private void btUsingVoucher_Click(object sender, EventArgs e)
        {
            cbVourcherOrder.Enabled = true;
        }//BUTTON to using voucher => OK
        private void cbVourcherOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkEXP = DateTime.Now;
            var checkName = cbVourcherOrder.Text;
            var checkVoucher = _voucherService.GetAll().Where(p => p.Name.Equals(checkName)).FirstOrDefault();
            if (checkVoucher != null)
            {
                if (checkVoucher.Exp < checkEXP || checkVoucher.Quantity <= 0 || Convert.ToInt32(txtTotalAllOrders.Text) <= 0)
                {
                    MessageBox.Show("The Voucher EXP or Quantity is 0", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    var TotalUseVoucher = double.Parse(txtTotalAllOrders.Text) - (checkVoucher.Price * 10);
                    txtTotalAllOrders.Text = TotalUseVoucher.ToString();
                    MessageBox.Show("Using voucher Successfully", "Notification", MessageBoxButtons.OK);
                    cbVourcherOrder.Enabled = false;
                }
            }
        }//Use Voucher ==> OK
        private void cbPointUsing_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CheckPoint = Convert.ToInt32(cbPointUsing.SelectedItem);
            var Member = _memberService.GetAll().Where(p => p.PhoneMember.Equals(CheckMember) || p.PhoneMember.Equals(CheckMemberNew)).FirstOrDefault();
            if (Member != null)
            {
                if (Member.Point >= CheckPoint)
                {
                    var TotalUserPoint = double.Parse(txtTotalAllOrders.Text) - (CheckPoint * 10);
                    txtTotalAllOrders.Text = TotalUserPoint.ToString();
                }
                else
                {
                    MessageBox.Show("You don't have enough points", "Notification", MessageBoxButtons.OK);
                    cbPointUsing.SelectedIndex = 0;
                    cbPointUsing.Enabled = false;
                }
            }
        } //USING point => OK
        private void listViewOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult remove = MessageBox.Show("Do you sure Remove Items", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (remove == DialogResult.OK)
            {
                listViewOrders.Items.Remove(listViewOrders.SelectedItems[0]);
                int columnIndex = 4; // Index của cột cần tính tổng (0 là cột đầu tiên)
                double total = 0;
                ListViewItem items = new ListViewItem(SKU);
                foreach (ListViewItem item in listViewOrders.Items)
                {
                    int value = int.Parse(item.SubItems[columnIndex].Text);
                    total += value;
                }
                txtTotalAllOrders.Text = total.ToString();
            }
            else
            {
                return;
            }
        }//Remove Cart ==> OK
        public void TakeInfoEmployee()
        {
            Login employeeLogin = new Login();
            var TakeInforEmployee = _employeeService.GetAll().Where(p => p.Username == Data).FirstOrDefault();
            if (TakeInforEmployee != null)
            {
                txtEmployee.Text = "Hello " + TakeInforEmployee.FullNameEmp.ToString();
            }
        } // Take INFOR Employee ==>OK
        public void AddTimeNowRevenue() //Add DateOrder of Revenue ==> OK
        {
            Revenue revenueCurrent = new Revenue();
            DateTime currentDateTime = DateTime.Now;
            revenueCurrent.DateOrders = currentDateTime.Date;
            _revenueService.Create(revenueCurrent);
        }
        private void btShowBill_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            AutoOrdersID autoOrdersID = new AutoOrdersID();
            //---------------------------------------//
            
            DateTime DateNow = DateTime.Now.Date;
            var DateOrder = _revenueService.GetAll().Where(p => p.DateOrders.Equals(DateNow)).FirstOrDefault();
            if (DateOrder != null)
            {
                DateNow = DateOrder.DateOrders; 
            }
            else
            {
                AddTimeNowRevenue();
            }
            //------------------------------------// END Take Date Orders in Revenue 
            DialogResult show = MessageBox.Show("Do you sure Show Bill !", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
                //------------------------------------// END Take each product choise
            if (show == DialogResult.OK)
                {
                BillOrder billOrder = new BillOrder();
                CheckValid checkBill = new CheckValid();
                int total = 0;
                billOrder.Total = total;
                checkBill.AddBill(billOrder);// END Create new Bill order 
                var checkVoucher = _voucherService.GetAll().Where(p => p.Name.Equals(cbVourcherOrder.Text)).FirstOrDefault();
                if (checkVoucher != null)
                {
                    order.IdVoucher = checkVoucher.IdVoucher;
                    checkVoucher.Quantity = checkVoucher.Quantity - 1;
                    _voucherService.Update(checkVoucher);
                }
                else
                {
                    order.IdVoucher = null;
                }
                var checkPhoneMemb = _memberService.GetAll().Where(p => p.PhoneMember == CheckMember || p.PhoneMember == CheckMemberNew).FirstOrDefault();
                if (checkPhoneMemb != null)
                {
                    order.PhoneMember = checkPhoneMemb.PhoneMember; //Take Member
                    if (cbPointUsing.SelectedItem != null)
                    {
                        checkPhoneMemb.Point = checkPhoneMemb.Point - Convert.ToInt32(cbPointUsing.SelectedItem);
                        _memberService.Update(checkPhoneMemb);
                    }
                }
                else
                {
                    order.PhoneMember = null; //Take Member 
                }
                //------------------------------------// END take using voucher//------------------------------------//
                foreach (ListViewItem item in listViewOrders.Items)
                {
                    string columnDataSKU = item.SubItems[0].Text;
                    string columnDataName = item.SubItems[1].Text;
                    string columnDataQuantity = item.SubItems[2].Text;
                    string columnDataPrice = item.SubItems[3].Text;
                    string columnDataTotal = item.SubItems[4].Text;
                    
                    //------------------------------------// END check Member in Orders
                    var checkIdEmployee = _employeeService.GetAll().Where(p => p.Username == Data).FirstOrDefault();
                    order.IdEmp = checkIdEmployee.IdEmp;
                    //------------------------------------//END Take information employee create order
                    order.Sku = columnDataSKU.ToString(); 
                    order.NameProduct = columnDataName.ToString(); 
                    order.PriceProduct = Convert.ToDouble(columnDataPrice.ToString()); 
                    order.Total = Convert.ToDouble(columnDataTotal.ToString()); 
                    order.QuantityOrders = Convert.ToInt32(columnDataQuantity.ToString());
                    //------------------------------------// END Take information of Products
                    var UpdateProduct = _productService.GetAll().Where(p => p.Sku == order.Sku).FirstOrDefault();
                    UpdateProduct.QuantityProduct = UpdateProduct.QuantityProduct - order.QuantityOrders;
                    _productService.Update(UpdateProduct);
                    //------------------------------------// END Update of Products
                    var checkIdBill = _showBillService.GetAll().Where(p => p.IdBill == billOrder.IdBill).FirstOrDefault();
                    order.IdBill = checkIdBill.IdBill;
                    //------------------------------------// END take BillID in BillOrder
                    order.DateOrders = DateNow;
                    //------------------------------------//END Take DateOrder of Orders
                    autoOrdersID.AddBill(order);
                    //------------------------------------// END add all infor of all field
                    var TotalBuil = Convert.ToDouble(txtTotalAllOrders.Text);
                    var UpdateBill = _showBillService.GetAll().Where(p => p.IdBill == billOrder.IdBill).FirstOrDefault();
                    UpdateBill.Total = TotalBuil;
                    _showBillService.Update(UpdateBill);
                    //------------------------------------//END Update ToTal of BillOrders
                }
                
            }
            AutoRevenuelUpdate();//------------------------------------// END Update Revenue
            Bill bill = new Bill();
            bill.Show();
            //------------------------------------// END SHOW BILL
        } // ADD TO CART SHOW BILL => MAYBE OK
        public void AutoRevenuelUpdate() // Update Total Revenue => OK
        {
            var TotalBill = _orderService.GetAll().Where(p => p.DateOrders.Equals(DateTime.Now.Date)).Sum(p => p.Total);       
            var checkDate = _revenueService.GetAll().Where(p => p.DateOrders.Equals(DateTime.Now.Date)).FirstOrDefault();
            checkDate.TotalRevenueOfDay = TotalBill;
            _revenueService.Update(checkDate);
        }
    }
}
