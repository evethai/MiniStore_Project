using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OxyPlot;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Microsoft.Office.Interop.Excel;
using Azure;
using System.Drawing.Printing;

namespace MiniStoreWinF.ManageProducts
{
    public partial class ManageAllProduct : Form
    {
        private int rowindex { get; set; }
        string url = "";
        ProductService _productList;
        CatalogyService _comboType;
        CatalogyService _updateType;
        CatalogyService _catalogyList;
        ProductService _SearchName;
        ProductService productService;
        ProductService productService1;
        string _status = "Availability";

        public ManageAllProduct()
        {
            InitializeComponent();
            _productList = new ProductService();
            _catalogyList = new CatalogyService();
            productService = new ProductService();
            // Show List Product
            var listProduct = _productList.GetAll().ToList().Select(p => new
            {
                p.Sku,
                p.ProductType,
                p.NameProduct,
                //p.QuantityProduct,
                //p.PriceProduct,
                p.Mfg,
                p.Exp,
                p.StatusP,
            }).Where(p => p.StatusP == true);
            DgvListProduct.DataSource = new BindingSource() { DataSource = listProduct };



            // suggest name product for search
            var productNameList = productService.GetAll().Select(p => p.NameProduct).ToList();
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(productNameList.ToArray());
            txtName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtName.AutoCompleteCustomSource = autoCompleteCollection;


            //Show List Type Product
            var test = productService.GetAll().Where(p => p.StatusP == true).ToList().GroupBy(p => p.ProductType);
            var ListCatalogy = _catalogyList.GetAll().ToList().OrderBy(o => o.IdCa);

            foreach (var item in test)
            {
                foreach (var item2 in ListCatalogy)
                {
                    if (item2.ProductType == item.Key)
                    {
                        //item2.IdCa = item.Sum(p=>p.QuantityProduct).Value;


                    }
                }
            }

            DgvTypeProduct.DataSource = new BindingSource() { DataSource = ListCatalogy };




            //Show ComboBox Type Product
            _comboType = new CatalogyService();
            var _listComboProduct = _comboType.GetAll()
                .Select(c => new { c.IdCa, c.ProductType }).ToList();
            txtTypeProductList.ValueMember = "IdCa";
            txtTypeProductList.DisplayMember = "ProductType";
            txtTypeProductList.DataSource = _listComboProduct;
            txtComboType.ValueMember = "IdCa";
            txtComboType.DisplayMember = "ProductType";
            txtComboType.DataSource = _listComboProduct;



        }

        //public int sum(string type)
        //{
        //    productService = new ProductService();
        //    var sum1 = productService.GetAll().Count(p => p.ProductType.Equals(type));

        //    return sum1;
        //}
        //Change Base64 To Image
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        // Click to show detail product
        private void DgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _productList = new ProductService();
                var id = DgvListProduct[0, e.RowIndex].Value;
                var showPro = _productList.GetAll().Where(p => p.Sku.Trim().Equals(id)).FirstOrDefault();
                rowindex = e.RowIndex;
                if (showPro != null)
                {
                    txtIDProduct.Text = showPro.Sku.ToString();
                    txtNameProduct.Text = showPro.NameProduct.ToString();
                    //NumberQuantityProduct.Text = showPro.QuantityProduct.ToString();

                    //txtPriceProduct.Text = showPro.PriceProduct.ToString();
                    //double temp = Convert.ToDouble(txtPriceProduct.Text);
                    //txtPriceProduct.Text = temp.ToString("#,###");

                    dateTimeNXSProduct.Value = showPro.Mfg.Value;
                    dateTimeHSDProduct.Value = showPro.Exp.Value;
                    txtTypeProductList.Text = showPro.ProductType.ToString();
                    //txtStatusProduct.Text = showPro.StatusP.ToString();
                    if (showPro.StatusP == true)
                    {
                        txtStatusProduct.Text = "Availability";
                    }
                    else
                    {
                        txtStatusProduct.Text = "Sold Out";
                    }
                    txtPathPictureProduct.Text = showPro.PictureProduct;
                    pictureProduct.Image = Base64ToImage(showPro.PictureProduct);
                }
            }
            catch (Exception ex)
            {

            }

        }
        //Change Image to Base64
        public string ImageToBase64(string path)
        {
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
        // Import url of picture
        private void btImportPictureProduct_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPathPictureProduct.Text = dlg.FileName;
                    pictureProduct.Image = new Bitmap(dlg.FileName);
                    url = dlg.FileName;
                }
            }
        }
        // auto Id for product
        public string autoID(string id)
        {
            string result = "";
            int cutID = int.Parse(id.Substring(2, 2));
            cutID++;
            int digit = 2;
            string predix = "S";

            string idstring = cutID.ToString().PadLeft(digit, '0');
            result = predix + idstring;
            return result;
        }
        // auto id for type product
        public string autoIDType(int id)
        {
            string result = "";
            int cutID = id;
            cutID++;

            string IdInt = cutID.ToString().PadLeft('0');
            result = IdInt;
            return result;
        }

        //Click to show detail type product
        private void DgvTypeProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _catalogyList = new CatalogyService();
                var id = DgvTypeProduct[0, e.RowIndex].Value;
                var showProType = _catalogyList.GetAll()
                    .Where(p => p.IdCa.Equals(id))
                    .FirstOrDefault();
                rowindex = e.RowIndex;
                if (showProType != null)
                {
                    txtIDTypeProduct.Text = showProType.IdCa.ToString();
                    txtTypeProductCategory.Text = showProType.ProductType.ToString();

                }
            }
            catch (Exception ex)
            {

            }

        }
        //Search Product
        private void txtSearchName_Click(object sender, EventArgs e)
        {
            if (txtCheckName.Checked == true && txtCheckType.Checked == false)
            {
                _SearchName = new ProductService();
                string _nam = txtName.Text;
                var nameS = _SearchName.GetAll().ToList().Where(entity => entity.NameProduct.ToLower().StartsWith(_nam.ToLower()));
                if (nameS != null)
                {

                    DgvListProduct.DataSource = new BindingSource() { DataSource = nameS };
                }
            }
            else if (txtCheckName.Checked == false && txtCheckType.Checked == true)
            {
                _SearchName = new ProductService();
                string _type = txtComboType.Text;
                var typeProduct = _SearchName.GetAll().ToList().Where(e => e.ProductType == _type);
                if (typeProduct != null)
                {
                    DgvListProduct.DataSource = new BindingSource() { DataSource = typeProduct };
                }


            }
            else if (txtCheckName.Checked == true && txtCheckName.Checked == true)
            {
                _SearchName = new ProductService();
                string _TypePro = txtComboType.Text;
                string _NamePro = txtName.Text;
                var TypeAndName = _SearchName.GetAll().ToList().Where(e => e.ProductType == _TypePro && e.NameProduct.ToLower().StartsWith(_NamePro.ToLower()));
                if (TypeAndName != null)
                {
                    DgvListProduct.DataSource = new BindingSource() { DataSource = TypeAndName };
                }
            }
            else
            {
                MessageBox.Show("Ko Bo Trong check");
            }


        }
        // Load DgvProduct
        private void txtLoadPro_Click(object sender, EventArgs e)
        {
            _productList = new ProductService();
            var listproduct = _productList.GetAll().ToList().Where(p => p.StatusP == true);
            DgvListProduct.DataSource = new BindingSource { DataSource = listproduct };



        }
        // Arrange price product
        private void txtArrange_SelectedIndexChanged(object sender, EventArgs e)
        {

            //_productList = new ProductService();
            //if (txtArrange.Text == "Price Ascending")
            //{
            //    var AscendingPro = _productList.GetAll().ToList().OrderBy(o => o.PriceProduct)
            //        .ThenBy(o => o.QuantityProduct).ThenBy(o => o.NameProduct).ThenBy(o => o.ProductType).Select(p => new
            //        {
            //            p.Sku,
            //            p.ProductType,
            //            p.NameProduct,
            //            p.QuantityProduct,
            //            p.PriceProduct,
            //            p.Mfg,
            //            p.Exp,
            //            p.StatusP,
            //        }).Where(p => p.StatusP == true);
            //    this.DgvListProduct.DataSource = new BindingSource() { DataSource = AscendingPro };
            //}
            //if (txtArrange.Text == "Price Decrease ")
            //{
            //    var AscendingPro = _productList.GetAll().ToList().OrderByDescending(o => o.PriceProduct)
            //        .ThenBy(o => o.QuantityProduct).ThenBy(o => o.NameProduct).ThenBy(o => o.ProductType).Select(p => new
            //        {
            //            p.Sku,
            //            p.ProductType,
            //            p.NameProduct,
            //            p.QuantityProduct,
            //            p.PriceProduct,
            //            p.Mfg,
            //            p.Exp,
            //            p.StatusP,
            //        }).Where(p => p.StatusP == true);
            //    this.DgvListProduct.DataSource = new BindingSource() { DataSource = AscendingPro };
            //}
            //if (txtArrange.Text == "ALL")
            //{
            //    var AscendingPro = _productList.GetAll().ToList().Where(p => p.StatusP == true);
            //    this.DgvListProduct.DataSource = new BindingSource() { DataSource = AscendingPro };
            //}
        }
        // Add product
        private void btCreateProduct_Click(object sender, EventArgs e)
        {

            _productList = new ProductService();
            var AddPro = _productList.GetAll().ToList().Where(e => e.Sku.ToUpper()
            .Equals(txtIDProduct.Text.ToUpper()))
                .FirstOrDefault();
            if (txtNameProduct.Text == "" ||
                !float.TryParse(txtPriceProduct.Text, out float price) ||
                price < 0 ||
                txtPriceProduct.Text == "" ||
                txtPathPictureProduct.Text == ""

                )
            {
                MessageBox.Show("Not Be Empty or Invalid Value");
            }
            else
            {
                if (AddPro != null)
                {
                    MessageBox.Show("ID Duplicated ");
                }
                else
                {

                    productService = new ProductService();
                    var _addProduct = productService.GetAll().ToList().FirstOrDefault();
                    _addProduct.Sku = autoID("SE19");
                    _addProduct.NameProduct = txtNameProduct.Text;
                    //_addProduct.PriceProduct = price;
                    //_addProduct.QuantityProduct = Int32.Parse(NumberQuantityProduct.Text);

                    _addProduct.Mfg = Convert.ToDateTime(dateTimeNXSProduct.Text);

                    _addProduct.Exp = Convert.ToDateTime(dateTimeNXSProduct.Text);

                    _addProduct.Exp = Convert.ToDateTime(dateTimeHSDProduct.Text);
                    _addProduct.ProductType = txtTypeProductList.Text;

                    if (url == "")
                    {
                        _addProduct.PictureProduct = txtPathPictureProduct.Text;
                    }
                    else
                    {
                        _addProduct.PictureProduct = (txtPathPictureProduct.Text = ImageToBase64(url));
                    }

                    if (txtStatusProduct.Text == "Availability")
                    {
                        _addProduct.StatusP = true;
                    }
                    else
                    {
                        _addProduct.StatusP = false;
                    }
                    DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        productService.Create(_addProduct);
                        txtLoadPro_Click(sender, new EventArgs());
                    }
                }
            }

        }
        // Detele Product
        private void btDeteleProduct_Click(object sender, EventArgs e)
        {

            _productList = new ProductService();
            var RemovePro = _productList.GetAll()
                .Where(p => p.Sku.Equals(txtIDProduct.Text) && p.StatusP == true).FirstOrDefault();
            if (RemovePro != null)
            {

                if (RemovePro.StatusP == false)
                {
                    MessageBox.Show("Item is in status Sold Out");
                }
                else
                {
                    RemovePro.StatusP = false;
                    DialogResult result = MessageBox.Show("You Want To Remove", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        _productList.Update(RemovePro);
                        txtLoadPro_Click(sender, new EventArgs());
                    }

                }
            }
        }
        // Update Product
        private void btUpdateProduct_Click(object sender, EventArgs e)
        {
            _productList = new ProductService();
            var _UpdatePro = _productList.GetAll().Where(p => p.Sku == txtIDProduct.Text).FirstOrDefault();
            if (txtNameProduct.Text == "" ||
                NumberQuantityProduct.Text == "" ||
                txtPriceProduct.Text == ""
                )
            {
                MessageBox.Show("Not Be Empty");
            }
            else
            {
                if (txtPathPictureProduct.Text == _UpdatePro.PictureProduct)
                {
                    _UpdatePro.Sku = txtIDProduct.Text;
                    //_UpdatePro.QuantityProduct = Int32.Parse(NumberQuantityProduct.Text);
                    //_UpdatePro.PriceProduct = float.Parse(txtPriceProduct.Text);
                    _UpdatePro.Mfg = Convert.ToDateTime(dateTimeNXSProduct.Text);
                    _UpdatePro.Exp = Convert.ToDateTime(dateTimeHSDProduct.Text);

                    if (txtStatusProduct.Text == "Availability")
                    {
                        _UpdatePro.StatusP = true;
                    }
                    else
                    {
                        _UpdatePro.StatusP = false;
                    }
                    _UpdatePro.ProductType = txtTypeProductList.Text;

                    var proUp = _UpdatePro;
                    DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        _productList.Update(proUp);
                        txtLoadPro_Click(sender, new EventArgs());
                    }
                    txtLoadPro_Click(sender, new EventArgs());
                }
                else
                {
                    _UpdatePro.Sku = txtIDProduct.Text;
                    //_UpdatePro.QuantityProduct = Int32.Parse(NumberQuantityProduct.Text);
                    //_UpdatePro.PriceProduct = float.Parse(txtPriceProduct.Text);
                    _UpdatePro.Mfg = Convert.ToDateTime(dateTimeNXSProduct.Text);
                    _UpdatePro.Exp = Convert.ToDateTime(dateTimeHSDProduct.Text);

                    if (txtStatusProduct.Text == "Availability")
                    {
                        _UpdatePro.StatusP = true;
                    }
                    else
                    {
                        _UpdatePro.StatusP = false;
                    }
                    _UpdatePro.ProductType = txtTypeProductList.Text;

                    var proUp = _UpdatePro;
                    DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        _productList.Update(proUp);
                        txtLoadPro_Click(sender, new EventArgs());
                    }

                    txtLoadPro_Click(sender, new EventArgs());

                }
            }
        }
        //Add Type Product
        private void btCreateTypeProduct_Click(object sender, EventArgs e)
        {
            _catalogyList = new CatalogyService();
            var AddPro = _catalogyList.GetAll().ToList().Where(e => e.IdCa
            .Equals(txtIDTypeProduct.Text.ToUpper())).OrderBy(o => o.IdCa).FirstOrDefault();
            if (AddPro != null)
            {
                MessageBox.Show("Trung ID");
            }
            else
            {
                _updateType = new CatalogyService();
                var _addProduct = _updateType.GetAll().ToList().FirstOrDefault();
                _addProduct.IdCa = int.Parse(autoIDType(3));
                _addProduct.ProductType = txtTypeProductCategory.Text;
                DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    _updateType.Create(_addProduct);
                    txtLoadPro_Click(sender, new EventArgs());
                }
            }
        }



        //Edit status product to change Availability to Sold Out
        private void btEditStatusProduct_Click(object sender, EventArgs e)
        {
            Form form = new UpdateStatusProduct();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _catalogyList = new CatalogyService();
            var listproductType = _catalogyList.GetAll().ToList()
                .OrderBy(o => o.IdCa);
            DgvTypeProduct.DataSource = new BindingSource { DataSource = listproductType };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIDProduct.Clear();
            txtNameProduct.Clear();
            txtPriceProduct.Clear();
            pictureProduct.Image = default;
            txtPathPictureProduct.Clear();
            NumberQuantityProduct.Value = 0;
        }

        private void txtPriceProduct_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPriceProduct.Text.Equals("0"))
                    return;
                double temp = Convert.ToDouble(txtPriceProduct.Text);
                txtPriceProduct.Text = temp.ToString("#,###");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi:" + ex);
            }
        }

        private void btPrictProduct_Click(object sender, EventArgs e)
        {
            //string input = txtPriceFilter1.Text;
            //string input2 = txtPriceFilter2.Text;
            //if (txtPriceFilter1.Text == "" || txtPriceFilter2.Text == "")
            //{
            //    MessageBox.Show("Do Not Leave Blank");
            //}
            //else if (int.TryParse(input, out int filterPrice) && int.TryParse(input2, out int filterPrice2))
            //{
            //    _productList = new ProductService();
            //    var PriceProduct = _productList.GetAll().ToList().Where(p => p.StatusP == true &&
            //     (filterPrice <= p.PriceProduct && p.PriceProduct <= filterPrice2));
            //    if (PriceProduct != null)
            //    {

            //        DgvListProduct.DataSource = new BindingSource() { DataSource = PriceProduct };
            //    }
            //}

            //else
            //{
            //    MessageBox.Show("Value column value is not a valid integer!");


            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Only for excel Microsoft offical!", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DgvListProduct.SelectAll();
                    DataObject copyDate = DgvListProduct.GetClipboardContent();
                    if (copyDate != null)
                    {
                        Clipboard.SetDataObject(copyDate);
                    }
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbook xlWbook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWsheet;
                    object data = System.Reflection.Missing.Value;
                    xlWbook = excel.Workbooks.Add(data);
                    xlWsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlWsheet.Cells[2, 1];
                    xlWsheet.Cells[1, 2].Value = "Product ID";
                    xlWsheet.Cells[1, 3].Value = "Type";
                    xlWsheet.Cells[1, 4].Value = "Name Product";
                    xlWsheet.Cells[1, 5].Value = "Quantity";
                    xlWsheet.Cells[1, 6].Value = "Price";
                    xlr.Select();
                    xlWsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Can not find Microsoft offical in you device!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                return;
            }
        }

        private void ManageAllProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
