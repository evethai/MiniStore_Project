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
using MiniStoreWinF.DashBoard;
using System.Text.RegularExpressions;

namespace MiniStoreWinF.OrdersProducts
{
    public partial class OrderProducts : Form
    {
        ProductService _productService = new ProductService();
        CatalogyService _catalogyService = new CatalogyService();
        MemberService _memberService = new MemberService();
        VoucherService _voucherService = new VoucherService();
        BillOrderService _showBillService = new BillOrderService();
        RevenueService _revenueService = new RevenueService();
        OrderService _orderService = new OrderService();
        CodeVoucherService _codeVoucherService = new CodeVoucherService();
        UnitService _unitService = new UnitService();
        RatePointService _ratePointService = new RatePointService();

        public string CheckMemberNewCreate;
        public string CheckMemberSuccessfully;
        public string SKU;
        public double TotalBill;
        private int rowIndex { get; set; } // craete row click
        public OrderProducts()
        {
            InitializeComponent();
            var showType = _catalogyService.GetAll();
            cbTypeProducts.DataSource = showType;
            cbTypeProducts.DisplayMember = "ProductType";
            cbSort.Items.Add("Ascending");
            cbSort.Items.Add("Decreasing");
        }
        private void OrderProducts_Load(object sender, EventArgs e)
        {
            var listProductsShow = _productService.GetAll().Select(p => new { p.Sku, p.NameProduct, p.Mfg, p.Exp, p.PictureProduct }).ToList();
            dgvShowListProducts.DataSource = new BindingSource()
            {
                //DataSource = listProductsShow
            };
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }//Load form => OK
        private void btSearch_Click(object sender, EventArgs e)
        {
            string txtSearch = txtSearchName.Text.ToLower();
            var valueSearch = _productService.GetAll().Where(p => p.NameProduct.ToLower().Contains(txtSearch)).ToList();
            if (txtSearch == "")
            {
                var listProductsShow = _productService.GetAll().Select(p => new { p.Sku, p.NameProduct, p.Mfg, p.Exp, p.PictureProduct }).ToList();
                dgvShowListProducts.DataSource = new BindingSource()
                {
                    //DataSource = listProductsShow
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
        public void ResetData()
        {
            listViewOrders.Items.Clear();
            CheckMemberNewCreate = "";
            CheckMemberSuccessfully = "";
            txtNameOrder.Text = "";
            txtQuantityOrder.Value = 1;
            txtTotalAllOrders.Text = "";
            txtPriceOrder.Text = "";
            pcPictureOrders.Image = null;
            txtScanVoucher.Text = "";
            txtScanVoucher.Enabled = true;
            txtProvidesCash.Text = "";
            txtReturnPayment.Text = "";
            txtDiscount.Text = "";
            txtLoyaltyPoint.Text = "";
            txtPointUsing.Text = "";
            btShowBill.Visible = false;
            txtPointUsing.Enabled = false;
        }
        private void cbTypeProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var compareType = cbTypeProducts.Text;
            var compareTypeShow = _productService.GetAll().Where(p => p.ProductType.Equals(compareType)).ToList();
            dgvShowListProducts.DataSource = new BindingSource()
            {
                DataSource = compareTypeShow
            };

        } // filter product by type  => OK
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        } // function translate base64 to image  => OK 
        public void CheckUnitComboBox(string SKU)
        {
            var checkUnit = _unitService.GetAll().Where(p => p.Sku.Equals(SKU)).ToList();
            if (checkUnit != null)
            {
                cbUnitQuantity.DataSource = checkUnit;
                cbUnitQuantity.DisplayMember = "UnitName";
            }
        }
        private void cbUnitQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var checkUnit = _unitService.GetAll().Where(p => p.UnitName.Equals(cbUnitQuantity.Text) && p.Sku == SKU).FirstOrDefault();
                if (checkUnit != null)
                {
                    txtPriceOrder.Text = checkUnit.PriceExport.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "BUG");
            }
        }
        private void dgvShowListProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string imageProducts = "";
                var RowOrder = dgvShowListProducts[0, e.RowIndex].Value;
                var OrderChoise = _productService.GetAll().Where(entity => entity.Sku.Equals(RowOrder)).FirstOrDefault();
                rowIndex = e.RowIndex;
                if (OrderChoise != null)
                {
                    SKU = OrderChoise.Sku;
                    txtNameOrder.Text = OrderChoise.NameProduct.ToString();
                    imageProducts = OrderChoise.PictureProduct.ToString();
                    pcPictureOrders.Image = Base64ToImage(imageProducts);
                    CheckUnitComboBox(OrderChoise.Sku);
                }
            }
            catch
            {
                return;
            }
        }
        private void btAddOrders_Click(object sender, EventArgs e)
        {
            AddItems();
            txtQuantityOrder.Value = 1;
        } // button add product => OK
        public void AddItems()
        {
            try
            {
                int columnIndex = 5; // Index của cột cần tính tổng (0 là cột đầu tiên)
                double total = 0;
                string NameOrder = txtNameOrder.Text;
                string UnitName = cbUnitQuantity.Text;
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
                    items.SubItems.Add(UnitName).ToString();
                    items.SubItems.Add(PriceOrder.ToString());
                    items.SubItems.Add(totals.ToString());
                    foreach (ListViewItem item in listViewOrders.Items)
                    {
                        if (item.SubItems[0].Text.Equals(items.SubItems[0].Text) && item.SubItems[3].Text.Equals(items.SubItems[3].Text)) // Kiểm tra theo cột đầu tiên, thay đổi chỉ mục nếu cần
                        {
                            checkItemsList = true;
                            int currentQuantity = int.Parse(item.SubItems[2].Text); // Giả sử cột thứ hai chứa giá trị cộng dồn
                            int newQuantity = int.Parse(items.SubItems[2].Text);
                            int TotalQuantity = Convert.ToInt32(item.SubItems[2].Text);

                            TotalQuantity = currentQuantity + newQuantity;
                            item.SubItems[2].Text = (currentQuantity + newQuantity).ToString();
                            int currentPrice = int.Parse(item.SubItems[4].Text);
                            item.SubItems[5].Text = (TotalQuantity * currentPrice).ToString();
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
                    TotalBill = total;
                }
            }
            catch
            {
                MessageBox.Show("You dont choise you items", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        } // function add to cart   ==> OK
        private void btUsingVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                string CheckCodeVoucher = txtScanVoucher.Text;
                var codeVouchers = _codeVoucherService.GetAll().Where(p => p.Id.Equals(CheckCodeVoucher) && p.StatusV == true).FirstOrDefault();
                if (codeVouchers == null || txtScanVoucher.TextLength <= 0)
                {
                    MessageBox.Show("Voucher is incorrect or used !", "Notification");
                }
                else
                {
                    var Voucher = _voucherService.GetAll().Where(p => p.IdVoucher.Equals(codeVouchers.IdVoucher)).FirstOrDefault();
                    if (Voucher.Exp < DateTime.Now)
                    {
                        MessageBox.Show("Voucher has expired !", "Notification");
                    }
                    else if (Voucher.Conditions > TotalBill)
                    {
                        MessageBox.Show("You are not eligible to use this voucher!", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("You use " + Voucher.Name + " Voucher Successfully !");
                        if (txtDiscount.TextLength <= 0)
                        {
                            txtDiscount.Text = Voucher.Price.ToString();
                            txtScanVoucher.Enabled = false;
                        }
                        else
                        {
                            txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) + Voucher.Price).ToString();
                            txtScanVoucher.Enabled = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BUG " + ex); ;
            }

        }
        private void btCheckMember_Click(object sender, EventArgs e)
        {
            frmMemberCheck memberCheckcs = new frmMemberCheck();
            memberCheckcs.ShowDialog();
            CheckMemberSuccessfully = memberCheckcs.TextBoxValue.ToString();
            CheckMemberNewCreate = memberCheckcs.TextBoxValueMemberNew.ToString();
            txtLoyaltyPoint.Text = memberCheckcs.PointHas.ToString();
            txtPointUsing.Enabled = true;
        } // button check member and create new member ==> OK 
        private void txtPointUsing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }
        }
        private void btUsingPoint_Click(object sender, EventArgs e)
        {
            try
            {
                var checkusingPoint = _ratePointService.GetAll().Where(p => p.StatusRp == true).FirstOrDefault();
                if (txtPointUsing.Text == "" || txtPointUsing.Text == null)
                {
                    MessageBox.Show("Point Using is empty");
                    txtPointUsing.Text = string.Empty;
                }
                else if (Convert.ToInt32(txtPointUsing.Text) <= Convert.ToInt32(txtLoyaltyPoint.Text) && checkusingPoint != null)
                {
                    if (txtDiscount.TextLength <= 0)
                    {
                        txtDiscount.Text = (Convert.ToDouble(txtPointUsing.Text) * checkusingPoint.RateUsing).ToString();
                        txtLoyaltyPoint.Text = (Convert.ToInt32(txtLoyaltyPoint.Text) - Convert.ToInt32(txtPointUsing.Text)).ToString();
                    }
                    else
                    {
                        txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) + (Convert.ToDouble(txtPointUsing.Text) * checkusingPoint.RateUsing)).ToString();
                        txtLoyaltyPoint.Text = (Convert.ToInt32(txtLoyaltyPoint.Text) - Convert.ToInt32(txtPointUsing.Text)).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Point Using is not enought");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BUG" + ex);
            }
        }
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

                if (total != 0)
                {
                    txtTotalAllOrders.Text = total.ToString();
                }
                else
                {
                    txtTotalAllOrders.Text = null;
                }
            }
            else
            {
                return;
            }
        }//Remove items in cart  ==> OK
        public void AddTimeRevenue()
        {
            Revenue revenueCurrent = new Revenue();
            DateTime currentDateTime = DateTime.Now.Date;
            revenueCurrent.DateRevenue = currentDateTime.Date;
            _revenueService.Create(revenueCurrent);
        } // function add DateRevenue of Revenue ==> OK
        private int RoundToInteger(double number)
        {
            return (int)Math.Round(number);
        }

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
                if (txtTotalAllOrders == null)
                {
                    MessageBox.Show("Order Bill is not items", "Notification", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    var checkCodeVoucher = _codeVoucherService.GetAll().Where(p => p.Id.Equals(txtScanVoucher.Text)).FirstOrDefault();
                    if (checkCodeVoucher == null || txtScanVoucher.Text == "")
                    {
                        billOrder.IdVoucher = null;
                    }
                    else
                    {
                        var checkVoucher = _voucherService.GetAll().Where(p => p.IdVoucher.Equals(checkCodeVoucher.IdVoucher)).FirstOrDefault();
                        billOrder.IdVoucher = checkCodeVoucher.IdVoucher;
                        checkCodeVoucher.StatusV = Convert.ToBoolean(0);
                        _codeVoucherService.Update(checkCodeVoucher);
                        checkVoucher.Quantity = checkVoucher.Quantity - 1;
                        _voucherService.Update(checkVoucher);
                    }

                    //  END Check voucher and update when using voucher successfully

                    var checkPhoneMemb = _memberService.GetAll().Where(p => p.PhoneMember == CheckMemberSuccessfully
                    || p.PhoneMember == CheckMemberNewCreate).FirstOrDefault();
                    if (checkPhoneMemb != null)
                    {
                        billOrder.PhoneMember = checkPhoneMemb.PhoneMember;

                        if (txtPointUsing.Text == null || txtPointUsing.Text == "")
                        {
                            checkPhoneMemb.Point = checkPhoneMemb.Point;
                            _memberService.Update(checkPhoneMemb);
                        }
                        else
                        {
                            checkPhoneMemb.Point = Convert.ToInt32(txtLoyaltyPoint.Text);
                            _memberService.Update(checkPhoneMemb);
                        }
                    }
                    else
                    {
                        billOrder.PhoneMember = null;
                    }
                    // END check member and update member when using point
                    if (txtDiscount.Text == null || txtDiscount.Text == "")
                    {
                        billOrder.DiscountPrice = null;
                        billOrder.TotalBill = Convert.ToDouble(txtTotalAllOrders.Text);
                    }
                    else
                    {
                        var checkDiscount = Convert.ToDouble(txtDiscount.Text);
                        billOrder.DiscountPrice = checkDiscount;
                        billOrder.TotalBill = Convert.ToDouble(txtTotalAllOrders.Text) - checkDiscount;
                    }
                    billOrder.DateOfBill = DateTime.Now.Date;
                    checkBill.AddBill(billOrder);
                    //Success to Add Bill in to Bill Orders
                    foreach (ListViewItem item in listViewOrders.Items)
                    {
                        string columnDataSKU = item.SubItems[0].Text;
                        string columnDataName = item.SubItems[1].Text;
                        string columnDataQuantity = item.SubItems[2].Text;
                        string columnDataUnit = item.SubItems[3].Text;
                        string columnDataPrice = item.SubItems[4].Text;
                        string columnDataTotal = item.SubItems[5].Text;
                        //------------------------------------// END take information in Cart
                        order.IdEmp = ContextScope.currentEmployee.IdEmp;
                        //------------------------------------//END Take information employee create order

                        //order.Sku = columnDataSKU.ToString();
                        order.Total = Convert.ToDouble(columnDataTotal.ToString());
                        order.QuantityOrders = Convert.ToInt32(columnDataQuantity.ToString());

                        var CheckUnit = _unitService.GetAll().Where(p => p.Sku.Equals(columnDataSKU) && p.UnitName.Equals(columnDataUnit)).FirstOrDefault();
                        order.IdUnit = CheckUnit.IdUnit;
                        //------------------------------------// END Take information of Products

                        var UpdateProductQuantity = _unitService.GetAll().Where(p => p.IdUnit.Equals(order.IdUnit)).FirstOrDefault();
                        UpdateProductQuantity.QuantityUnit = UpdateProductQuantity.QuantityUnit - order.QuantityOrders;
                        _unitService.Update(UpdateProductQuantity);

                        //------------------------------------// END Update Quantity of Products when successfully orders

                        var checkIdBills = _showBillService.GetAll().Where(p => p.IdBillOrder == billOrder.IdBillOrder).FirstOrDefault();
                        order.IdBillOrder = checkIdBills.IdBillOrder;

                        //------------------------------------// END take BillID in BillOrder

                        order.DateOrders = DateTime.Now;
                        //------------------------------------//END Take DateOrder of Orders

                        autoOrdersID.AddBill(order);
                        //------------------------------------// END add all information of all data 
                    }
                    ScopeBill.currentBill = billOrder;
                    // END Update TotalBill of BillOrders

                    var PointTaking = _ratePointService.GetAll().Where(p => p.StatusRp == true).FirstOrDefault();
                    if (checkPhoneMemb != null)
                    {
                        double TotalPointReceive = Convert.ToInt32(txtTotalAllOrders.Text) / PointTaking.RateTaking.Value;

                        checkPhoneMemb.Point = checkPhoneMemb.Point + RoundToInteger(TotalPointReceive);
                        _memberService.Update(checkPhoneMemb);
                    }
                    // END Update point when payment successfull
                    AutoRevenuelUpdateWhenBillOrderDone();
                    OpenChildForm();

                }
            }
        } // ADD TO CART SHOW BILL => MAYBE OK*/

        public void AutoRevenuelUpdateWhenBillOrderDone() // Update Total Revenue in one day  => OK
        {
            var TotalBillOrder = _showBillService.GetAll().Where(p => p.DateOfBill.Equals(DateTime.Now.Date)).Sum(p => p.TotalBill);
            var checkDateRevenue = _revenueService.GetAll().Where(p => p.DateRevenue.Equals(DateTime.Now.Date)).FirstOrDefault();
            checkDateRevenue.TotalRevenueOfDay = TotalBillOrder;
            _revenueService.Update(checkDateRevenue);
        }
        private void btCancelBill_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        //reset data when checkout success => OK
        private void OpenChildForm()
        {
            frmBill childForm = new frmBill();
            childForm.ChildFormClosed += ChildFormClosedHandler;
            childForm.ShowDialog();
        }// open Bill =>OK
        private void ChildFormClosedHandler(object sender, EventArgs e)
        {
            ResetData();
        } //Function clear data in form bill => OK
        private void rdMomopayment_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                MoMoService _moService = new MoMoService();
                total = Double.Parse(txtTotalAllOrders.Text);
                var list = _moService.GetAll().Where(p => p.Active == true).FirstOrDefault();
                if (txtTotalAllOrders.Text != null && list != null)
                {
                    rdMomopayment.Checked = false;
                    ContextScope.currentMoMo = list;
                    frmQRCode form = new frmQRCode();
                    form.total = total;
                    form.ShowDialog();
                    btShowBill.Visible = true;

                }
            }
            catch (Exception ex)
            {
                rdMomopayment.Checked = false;
                MessageBox.Show("Not find a bill ", "Messages", MessageBoxButtons.OK);
            }
        }
        private void rdCashpayment_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalAllOrders.Text != "")
                {
                    btShowBill.Visible = true;
                    rdCashpayment.Checked = false;
                }
                else
                {
                    MessageBox.Show("Not find a bill ", "Messages", MessageBoxButtons.OK);
                    rdCashpayment.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BUG" + ex);
            }

        }

        private void btReturnMoney_Click(object sender, EventArgs e)
        {
            double TotalBill;
            double TotalDiscount;
            double TotalProvide;
            if (txtDiscount.Text == null || txtDiscount.Text == "")
            {
                TotalBill = Convert.ToDouble(txtTotalAllOrders.Text);
                TotalDiscount = 0;
                TotalProvide = Convert.ToDouble(txtProvidesCash.Text);
                txtReturnPayment.Text = (TotalProvide - (TotalBill - TotalDiscount)).ToString();
            }
            else
            {
                TotalBill = Convert.ToDouble(txtTotalAllOrders.Text);
                TotalProvide = Convert.ToDouble(txtProvidesCash.Text);
                txtReturnPayment.Text = (TotalProvide - (TotalBill - Convert.ToDouble(txtDiscount.Text))).ToString();
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {
                var SortByDateEXP_ASC = _productService.GetAll().OrderBy(p => p.Exp).Select(p => new { p.Sku, p.NameProduct, p.Mfg, p.Exp, p.PictureProduct }).ToList();
                dgvShowListProducts.DataSource = new BindingSource()
                {
                    DataSource = SortByDateEXP_ASC
                };
            }
            else
            {
                var SortByDateEXP_DES = _productService.GetAll().OrderByDescending(p => p.Exp).Select(p => new { p.Sku, p.NameProduct, p.Mfg, p.Exp, p.PictureProduct }).ToList();
                dgvShowListProducts.DataSource = new BindingSource()
                {
                    DataSource = SortByDateEXP_DES
                };
            }
        }
    }
}


