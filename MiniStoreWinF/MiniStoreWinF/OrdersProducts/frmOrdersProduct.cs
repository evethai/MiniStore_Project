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
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

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
        CodeVoucherService _codeVoucherService = new CodeVoucherService();

        public string CheckMemberNewCreate;
        public string CheckMemberSuccessfully;
        public string SKU;
        public string DataEmployee { get; set; }
        private int rowIndex { get; set; } // craete row click
        public OrderProducts()
        {
            InitializeComponent();
            var showType = _catalogyService.GetAll();
            cbTypeProducts.DataSource = showType;
            cbTypeProducts.DisplayMember = "ProductType";
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
            var listProductsShow = _productService.GetAll().Select(p => new { p.Sku, p.NameProduct, p.QuantityProduct, p.PriceProduct, p.Mfg, p.Exp, p.PictureProduct }).ToList();
            dgvShowListProducts.DataSource = new BindingSource()
            {
                DataSource = listProductsShow
            };
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }//Load form => OK
        private void btSearch_Click(object sender, EventArgs e)
        {
            string txtSearch = txtSearchName.Text.ToLower();
            var valueSearch = _productService.GetAll().Where(p => p.NameProduct.ToLower().Contains(txtSearch)).ToList();
            if (txtSearch == "")
            {
                var listProductsShow = _productService.GetAll().Select(p => new { p.Sku, p.NameProduct, p.QuantityProduct, p.PriceProduct, p.Mfg, p.Exp, p.PictureProduct }).ToList();
                dgvShowListProducts.DataSource = new BindingSource()
                {
                    DataSource = listProductsShow
                };
            }
            else
            {
                dgvShowListProducts.DataSource = new BindingSource()
                {
                    DataSource = valueSearch
                };
            }
        } // button search product  => OK
        private void cbTypeProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var compareType = cbTypeProducts.Text;
            var compareTypeShow = _productService.GetAll().Where(p => p.ProductType.Equals(compareType)).ToList();
            dgvShowListProducts.DataSource = new BindingSource()
            {
                DataSource = compareTypeShow
            };

        } // filter product by type  => OK
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

        }  // click data to choise product => OK 
        private void btAddOrders_Click(object sender, EventArgs e)
        {
            AddItems();



            txtQuantityOrder.Value = 0;

        } // button add product => OK
        public void AddItems()
        {
            int columnIndex = 4; // Index của cột cần tính tổng (0 là cột đầu tiên)
            double total = 0;
            string NameOrder = txtNameOrder.Text;
            float PriceOrder = float.Parse(txtPriceOrder.Text);
            var checkItemsList = false;
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
                foreach (ListViewItem item in listViewOrders.Items)
                {
                    if (item.SubItems[0].Text.Equals(items.SubItems[0].Text)) // Kiểm tra theo cột đầu tiên, thay đổi chỉ mục nếu cần
                    {
                        checkItemsList = true;
                        int currentQuantity = int.Parse(item.SubItems[2].Text); // Giả sử cột thứ hai chứa giá trị cộng dồn
                        int newQuantity = int.Parse(items.SubItems[2].Text);
                        int TotalQuantity = Convert.ToInt32(item.SubItems[2].Text);

                        TotalQuantity = currentQuantity + newQuantity;
                        item.SubItems[2].Text = (currentQuantity + newQuantity).ToString();
                        int currentPrice = int.Parse(item.SubItems[3].Text);
                        item.SubItems[4].Text = (TotalQuantity * currentPrice).ToString();
                        break;
                    }
                }
                if (checkItemsList == false)
                {
                    listViewOrders.Items.Add(items);
                }
                foreach (ListViewItem item in listViewOrders.Items)
                {
                    int value = int.Parse(item.SubItems[columnIndex].Text);
                    total += value;
                }
                txtTotalAllOrders.Text = total.ToString();
            }
        } // function add to cart   ==> OK
        private void btCheckMember_Click(object sender, EventArgs e)
        {
            frmMemberCheck memberCheckcs = new frmMemberCheck();
            memberCheckcs.ShowDialog();
            CheckMemberSuccessfully = memberCheckcs.TextBoxValue.ToString();
            CheckMemberNewCreate = memberCheckcs.TextBoxValueMemberNew.ToString();
            cbPointUsing.Enabled = true;
        } // button check member and create new member ==> OK 
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        } // function translate base64 to image  => OK 
        private void btUsingVoucher_Click(object sender, EventArgs e)
        {
            string CheckCodeVoucher = txtScanVoucher.Text;
            var codeVouchers = _codeVoucherService.GetAll().Where(p => p.Id.Equals(CheckCodeVoucher) && p.StatusV == true).FirstOrDefault();
            if (codeVouchers == null || txtScanVoucher.Text == "")
            {
                MessageBox.Show("Voucher is incorrect or used !", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                var Voucher = _voucherService.GetAll().Where(p => p.IdVoucher.Equals(codeVouchers.IdVoucher)).FirstOrDefault();
                if (Voucher.Exp < DateTime.Now)
                {
                    MessageBox.Show("Voucher has expired !", "Notification", MessageBoxButtons.OK);
                }
                else if (Voucher.Conditions > Convert.ToDouble(txtTotalAllOrders.Text))
                {
                    MessageBox.Show("You are not eligible to use this voucher!", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You use " + Voucher.Name + " Voucher Successfully !");
                    txtTotalAllOrders.Text = (Convert.ToDouble(txtTotalAllOrders.Text) - Voucher.Price).ToString();
                    txtScanVoucher.Enabled = false;
                }
            }

        }
        private void cbPointUsing_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CheckPoint = Convert.ToInt32(cbPointUsing.SelectedItem);
            var CheckMember = _memberService.GetAll().Where(p => p.PhoneMember.Equals(CheckMemberSuccessfully) || p.PhoneMember.Equals(CheckMemberNewCreate)).FirstOrDefault();
            if (CheckMember != null)
            {
                if (CheckMember.Point >= CheckPoint)
                {
                    var TotalUserPoint = double.Parse(txtTotalAllOrders.Text) - (CheckPoint * 10);
                    txtTotalAllOrders.Text = TotalUserPoint.ToString();
                    cbPointUsing.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You don't have enough points", "Notification", MessageBoxButtons.OK);
                    cbPointUsing.SelectedIndex = -1;
                    cbPointUsing.Enabled = false;
                }
            }
        } //combo box using the Point when you has Member => OK
        private void listViewOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult remove = MessageBox.Show("Do you sure Remove Items", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (remove == DialogResult.OK)
            {
                listViewOrders.Items.Remove(listViewOrders.SelectedItems[0]);
                int columnIndex = 4;
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
        }//Remove items in cart  ==> OK
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin CheckOut = new frmLogin();
            CheckOut.Show();
        }//check out when employee logout Order Page => Maybe 
        public void AddTimeRevenue()
        {
            Revenue revenueCurrent = new Revenue();
            DateTime currentDateTime = DateTime.Now.Date;
            revenueCurrent.DateRevenue = currentDateTime.Date;
            _revenueService.Create(revenueCurrent);
        } // function add DateRevenue of Revenue ==> OK
        private void btShowBill_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            AutoOrdersID autoOrdersID = new AutoOrdersID();
            //---------------------------------------// 

            DateTime DateTimeCreateOrders = DateTime.Now.Date;
            var CheckDateRevenue = _revenueService.GetAll().Where(p => p.DateRevenue.Equals(DateTimeCreateOrders)).FirstOrDefault();
            if (CheckDateRevenue != null)
            {
                DateTimeCreateOrders = CheckDateRevenue.DateRevenue;
            }
            else
            {
                AddTimeRevenue();
            }
            //------------------------------------// END Take Date Orders in Revenue 

            DialogResult show = MessageBox.Show("Do you sure Show Bill !", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //------------------------------------// END Take each product choise
            if (show == DialogResult.OK)
            {
                BillOrder billOrder = new BillOrder();
                AutoBillsID checkBill = new AutoBillsID();
                double totalBill = 0;
                billOrder.TotalBill = totalBill;
                checkBill.AddBill(billOrder);
                //------------------------------------//  END Create new Bill order                      

                var checkCodeVoucher = _codeVoucherService.GetAll().Where(p => p.Id.Equals(txtScanVoucher.Text)).FirstOrDefault();

                if (checkCodeVoucher == null || txtScanVoucher.Text == "")
                {
                    order.IdVoucher = null;
                }
                else
                {
                    var checkVoucher = _voucherService.GetAll().Where(p => p.IdVoucher.Equals(checkCodeVoucher.IdVoucher)).FirstOrDefault();
                    order.IdVoucher = checkCodeVoucher.IdVoucher;
                    checkCodeVoucher.StatusV = Convert.ToBoolean(0);
                    _codeVoucherService.Update(checkCodeVoucher);
                    checkVoucher.Quantity = checkVoucher.Quantity - 1;
                    _voucherService.Update(checkVoucher);
                }
                //------------------------------------//  END Check voucher and update when using voucher successfully

                var checkPhoneMemb = _memberService.GetAll().Where(p => p.PhoneMember == CheckMemberSuccessfully || p.PhoneMember == CheckMemberNewCreate).FirstOrDefault();
                if (checkPhoneMemb != null)
                {
                    order.PhoneMember = checkPhoneMemb.PhoneMember;
                    if (cbPointUsing.SelectedItem != null)
                    {
                        checkPhoneMemb.Point = checkPhoneMemb.Point - Convert.ToInt32(cbPointUsing.SelectedItem);
                        _memberService.Update(checkPhoneMemb);
                    }
                }
                else
                {
                    order.PhoneMember = null;
                }
                //------------------------------------// END check member and update member when using point

                foreach (ListViewItem item in listViewOrders.Items)
                {
                    string columnDataSKU = item.SubItems[0].Text;
                    string columnDataName = item.SubItems[1].Text;
                    string columnDataQuantity = item.SubItems[2].Text;
                    string columnDataPrice = item.SubItems[3].Text;
                    string columnDataTotal = item.SubItems[4].Text;
                    //------------------------------------// END take information in Cart

                    var checkIdEmployee = _employeeService.GetAll().Where(p => p.FullNameEmp == DataEmployee).FirstOrDefault();
                    order.IdEmp = checkIdEmployee.IdEmp;
                    //------------------------------------//END Take information employee create order

                    order.Sku = columnDataSKU.ToString();
                    order.NameProduct = columnDataName.ToString();
                    order.PriceProduct = Convert.ToDouble(columnDataPrice.ToString());
                    order.Total = Convert.ToDouble(columnDataTotal.ToString());
                    order.QuantityOrders = Convert.ToInt32(columnDataQuantity.ToString());
                    //------------------------------------// END Take information of Products

                    var UpdateProductQuantity = _productService.GetAll().Where(p => p.Sku == order.Sku).FirstOrDefault();
                    UpdateProductQuantity.QuantityProduct = UpdateProductQuantity.QuantityProduct - order.QuantityOrders;
                    _productService.Update(UpdateProductQuantity);
                    //------------------------------------// END Update Quantity of Products when successfully orders

                    var checkIdBills = _showBillService.GetAll().Where(p => p.IdBillOrder == billOrder.IdBillOrder).FirstOrDefault();
                    order.IdBillOrder = checkIdBills.IdBillOrder;
                    //------------------------------------// END take BillID in BillOrder

                    order.DateOrders = DateTime.Now;
                    //------------------------------------//END Take DateOrder of Orders

                    autoOrdersID.AddBill(order);
                    //------------------------------------// END add all information of all data 

                }
                var checkIdBill = _showBillService.GetAll().Where(p => p.IdBillOrder == billOrder.IdBillOrder).FirstOrDefault();
                checkIdBill.TotalBill = Convert.ToDouble(txtTotalAllOrders.Text);
                checkIdBill.DateOfBill = DateTime.Now.Date;
                _showBillService.Update(checkIdBill);
                //------------------------------------// END Update TotalBill of BillOrders
                if (checkPhoneMemb != null)
                {
                    checkPhoneMemb.Point = Convert.ToInt32(txtTotalAllOrders.Text) / 1000;
                    _memberService.Update(checkPhoneMemb);
                }
                //------------------------------------// END Update point when payment successfull
                AutoRevenuelUpdateWhenBillOrderDone();
                OpenChildForm();
            }
            else if (listViewOrders.Items == null)
            {
                MessageBox.Show("Can not show Bill !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                return;
            }
        } // ADD TO CART SHOW BILL => MAYBE OK
        public void AutoRevenuelUpdateWhenBillOrderDone() // Update Total Revenue in one day  => OK
        {
            var TotalBillOrder = _showBillService.GetAll().Where(p => p.DateOfBill.Equals(DateTime.Now.Date)).Sum(p => p.TotalBill);
            var checkDateRevenue = _revenueService.GetAll().Where(p => p.DateRevenue.Equals(DateTime.Now.Date)).FirstOrDefault();
            checkDateRevenue.TotalRevenueOfDay = TotalBillOrder;
            _revenueService.Update(checkDateRevenue);
        }
        public void ResetData()
        {
            listViewOrders.Items.Clear();
            CheckMemberNewCreate = "";
            CheckMemberSuccessfully = "";
            txtNameOrder.Text = "";
            txtQuantityOrder.Value = 0;
            txtTotalAllOrders.Text = "";
            txtPriceOrder.Text = "";
            pcPictureOrders.Image = null;
            txtScanVoucher.Text = "";
            txtScanVoucher.Enabled = true;
            if (cbPointUsing.Enabled == false)
            {
                cbPointUsing.SelectedIndex = -1;
            }
            else
            {
                return;
            }
        }//reset data when checkout success => OK
        private void OpenChildForm()
        {
            frmBill childForm = new frmBill();
            childForm.ChildFormClosed += ChildFormClosedHandler;
            childForm.Show();
        }// open Bill =>OK
        private void ChildFormClosedHandler(object sender, EventArgs e)
        {
            ResetData();
        } //Function clear data in form bill => OK
    }
}
