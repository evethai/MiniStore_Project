using Microsoft.Office.Interop.Excel;
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
using Microsoft.Office.Interop.Excel;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace MiniStoreWinF.ManageProducts
{
    public partial class ManageAllProducs : Form
    {
        private int rowindex { get; set; }
        string url = "";
        ProductService _ShowList;
        ProductService _ShowList1;
        ProductService _Search;
        ProductService _id;
        CatalogyService _comboType;
        SupplierServices _comboIdSup;
        UnitServices _comboUnit;
        public ManageAllProducs()
        {
            InitializeComponent();

            // Show Product in Dgv
            _ShowList1 = new ProductService();
            var showlistPro = _ShowList1.GetAll().ToList().Where(p => p.StatusP == true);
            dataGridView1.DataSource = new BindingSource() { DataSource = showlistPro };

            // combo type product
            _comboType = new CatalogyService();
            var _listComboProduct = _comboType.GetAll()
                .Select(c => new { c.IdCa, c.ProductType }).ToList();
            cbTypeProduct.ValueMember = "IdCa";
            cbTypeProduct.DisplayMember = "ProductType";
            cbTypeProduct.DataSource = _listComboProduct;
            txtComboType.ValueMember = "IdCa";
            txtComboType.DisplayMember = "ProductType";
            txtComboType.DataSource = _listComboProduct;

            //combo id supplier
            _comboIdSup = new SupplierServices();
            var _listcomboIdSup = _comboIdSup.GetAll()
                .Select(c => c.IdSupplier).ToList();
            cbIdSupplier.DataSource = _listcomboIdSup;

            // suggest name product for search
            _ShowList1 = new ProductService();
            var productNameList = _ShowList1.GetAll().Select(p => p.NameProduct).ToList();
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(productNameList.ToArray());
            txtName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtName.AutoCompleteCustomSource = autoCompleteCollection;

            //combo id unit
            //_comboUnit = new UnitServices();
            //var _listcomboUnit = _comboUnit.GetAll()
            //    .Select(c => c.IdUnit).ToList();
            //cbIdUnit.DataSource = _listcomboUnit;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Change Base64 To Image
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        // Cell click detail Product
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _ShowList = new ProductService();
                var id = dataGridView1[0, e.RowIndex].Value;
                var showPro = _ShowList.GetAll().Where(p => p.Sku.Trim().Equals(id)).FirstOrDefault();
                rowindex = e.RowIndex;
                if (showPro != null)
                {
                    txtIDProduct.Text = showPro.Sku.ToString();
                    txtNameProduct.Text = showPro.NameProduct.ToString();
                    cbTypeProduct.Text = showPro.ProductType.ToString();
                    //numericQuantityPro.Text = showPro.QuantityProduct.ToString();
                    //txtPriceImport.Text = showPro.PriceProduct.ToString();
                    //double temp1 = Convert.ToDouble(txtPriceImport.Text);
                    //txtPriceImport.Text = temp1.ToString("#,###");
                    //txtPriceToOrders.Text = showPro.PriceToOrders.ToString();
                    //double temp2 = Convert.ToDouble(txtPriceToOrders.Text);
                    //txtPriceToOrders.Text = temp2.ToString("#,###");

                    cbIdSupplier.Text = showPro.IdSupplier.ToString();
                    //cbIdUnit.Text = showPro.IdUnit.ToString();
                    //numericQuantityUnit.Text = showPro.QuantityUnit.ToString();
                    //txtPriceUnit.Text = showPro.PriceUnit.ToString();
                    //double temp3 = Convert.ToDouble(txtPriceUnit.Text);
                    //txtPriceUnit.Text = temp3.ToString("#,###");
                    //txtTotalPrice.Text = showPro.TotalPriceUnit.ToString();
                    //double temp4 = Convert.ToDouble(txtTotalPrice.Text);
                    //txtTotalPrice.Text = temp4.ToString("#,###");

                    dateMFG.Value = showPro.Mfg.Value;
                    dateEXP.Value = showPro.Exp.Value;
                    dateDateImport.Value = showPro.DateImport.Value;
                    if (showPro.StatusP == true)
                    {
                        cbStatus.Text = "Availability";
                    }
                    else
                    {
                        cbStatus.Text = "Sold Out";
                    }
                    txtPathPicture.Text = showPro.PictureProduct.ToString();
                    PictureProduct.Image = Base64ToImage(showPro.PictureProduct);

                }
            }
            catch (Exception ex)
            {

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
                    txtPathPicture.Text = dlg.FileName;
                    PictureProduct.Image = new Bitmap(dlg.FileName);
                    url = dlg.FileName;
                }
            }
        }

        // Product avaibility
        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            _ShowList = new ProductService();
            var showlist = _ShowList.GetAll().ToList().Where(p => p.StatusP == true);
            dataGridView1.DataSource = new BindingSource() { DataSource = showlist };
        }
        // product sold out
        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            _ShowList = new ProductService();
            var showlist = _ShowList.GetAll().ToList().Where(p => p.StatusP == false);
            dataGridView1.DataSource = new BindingSource() { DataSource = showlist };
        }
        // Load datagridview
        private void button4_Click(object sender, EventArgs e)
        {
            if (rd1.Checked == true)
            {
                _ShowList = new ProductService();
                var showlist = _ShowList.GetAll().ToList().Where(p => p.StatusP == true);
                dataGridView1.DataSource = new BindingSource() { DataSource = showlist };
                button2_Click(sender, e);

            }
            else if (rd2.Checked == true)
            {
                _ShowList = new ProductService();
                var showlist = _ShowList.GetAll().ToList().Where(p => p.StatusP == false);
                dataGridView1.DataSource = new BindingSource() { DataSource = showlist };
                button2_Click(sender, e);
            }
            else
            {
                _ShowList = new ProductService();
                var showlist = _ShowList.GetAll().ToList().Where(p => p.StatusP == true);
                dataGridView1.DataSource = new BindingSource() { DataSource = showlist };
                button2_Click(sender, e);
            }
        }
        // change image to base64
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
        //auto ID
        public string autoID(string id)
        {
            string prefix = id.Substring(0, 1);
            int number = int.Parse(id.Substring(1));
            number++;
            string nextID = prefix + number.ToString().PadLeft(2, '0');

            return nextID;
        }
        // Create Product
        private void button1_Click(object sender, EventArgs e)
        {
            _ShowList = new ProductService();
            var AddPro = _ShowList.GetAll().ToList().Where(e => e.Sku.ToUpper()
            .Equals(txtIDProduct.Text.ToUpper()))
                .FirstOrDefault();
            if (txtNameProduct.Text == "" ||
                txtPathPicture.Text == ""

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
                    _id = new ProductService();
                    var _autoID = _id.GetAll().ToList().Select(c => c.Sku).Max();
                    string nextID = autoID(_autoID);
                    _ShowList1 = new ProductService();
                    var _addProduct = _ShowList1.GetAll().ToList().FirstOrDefault();
                    _addProduct.Sku = nextID;
                    _addProduct.NameProduct = txtNameProduct.Text;
                    _addProduct.ProductType = cbTypeProduct.Text;
                    //_addProduct.QuantityProduct = Int32.Parse(numericQuantityPro.Text);
                    //_addProduct.PriceProduct = price;
                    //_addProduct.PriceToOrders = float.Parse(txtPriceToOrders.Text);

                    _addProduct.IdSupplier = cbIdSupplier.Text;
                    //_addProduct.IdUnit = cbIdUnit.Text;
                    //_addProduct.QuantityUnit = Int32.Parse(numericQuantityUnit.Text);
                    //_addProduct.PriceUnit = float.Parse(txtPriceUnit.Text);
                    //_addProduct.TotalPriceUnit = float.Parse(txtTotalPrice.Text);

                    _addProduct.Mfg = Convert.ToDateTime(dateMFG.Text);
                    _addProduct.Exp = Convert.ToDateTime(dateEXP.Text);
                    _addProduct.DateImport = Convert.ToDateTime(dateDateImport.Text);

                    if (url == "")
                    {
                        _addProduct.PictureProduct = txtPathPicture.Text;
                    }
                    else
                    {
                        _addProduct.PictureProduct = (txtPathPicture.Text = ImageToBase64(url));
                    }

                    if (cbStatus.Text == "Availability")
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
                        _ShowList1.Create(_addProduct);
                        button4_Click(sender, e);
                        button2_Click(sender, e);
                    }
                }
            }
        }
        // update product
        private void btUpdate_Click(object sender, EventArgs e)
        {
            _ShowList = new ProductService();
            var _UpdatePro = _ShowList.GetAll().Where(p => p.Sku == txtIDProduct.Text).FirstOrDefault();
            if (txtNameProduct.Text == "" ||
                txtPathPicture.Text == ""
                )
            {
                MessageBox.Show("Not Be Empty");
            }
            else
            {
                if (txtPathPicture.Text == _UpdatePro.PictureProduct)
                {
                    _UpdatePro.ProductType = cbTypeProduct.Text;
                    _UpdatePro.NameProduct = txtNameProduct.Text;
                    //_UpdatePro.QuantityProduct = Int32.Parse(numericQuantityPro.Text);
                    //_UpdatePro.PriceProduct = float.Parse(txtPriceImport.Text);
                    //_UpdatePro.PriceToOrders = float.Parse(txtPriceToOrders.Text);

                    _UpdatePro.IdSupplier = cbIdSupplier.Text;
                    //_UpdatePro.IdUnit = cbIdUnit.Text;
                    //_UpdatePro.QuantityUnit = Int32.Parse(numericQuantityUnit.Text);
                    //_UpdatePro.PriceUnit = float.Parse(txtPriceUnit.Text);
                    //_UpdatePro.TotalPriceUnit = float.Parse(txtTotalPrice.Text);

                    _UpdatePro.Mfg = Convert.ToDateTime(dateMFG.Text);
                    _UpdatePro.Exp = Convert.ToDateTime(dateEXP.Text);
                    _UpdatePro.DateImport = Convert.ToDateTime(dateDateImport.Text);
                    if (cbStatus.Text == "Availability")
                    {
                        _UpdatePro.StatusP = true;
                    }
                    else
                    {
                        _UpdatePro.StatusP = false;
                    }
                    var proUp = _UpdatePro;
                    DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        _ShowList.Update(proUp);
                        button4_Click(sender, e);
                        button2_Click(sender, e);
                    }

                }
                else
                {
                    _UpdatePro.ProductType = cbTypeProduct.Text;
                    _UpdatePro.NameProduct = txtNameProduct.Text;
                    //_UpdatePro.QuantityProduct = Int32.Parse(numericQuantityPro.Text);
                    //_UpdatePro.PriceProduct = float.Parse(txtPriceImport.Text);
                    //_UpdatePro.PriceToOrders = float.Parse(txtPriceToOrders.Text);

                    _UpdatePro.IdSupplier = cbIdSupplier.Text;
                    //_UpdatePro.IdUnit = cbIdUnit.Text;
                    //_UpdatePro.QuantityUnit = Int32.Parse(numericQuantityUnit.Text);
                    //_UpdatePro.PriceUnit = float.Parse(txtPriceUnit.Text);
                    //_UpdatePro.TotalPriceUnit = float.Parse(txtTotalPrice.Text);

                    _UpdatePro.Mfg = Convert.ToDateTime(dateMFG.Text);
                    _UpdatePro.Exp = Convert.ToDateTime(dateEXP.Text);
                    _UpdatePro.DateImport = Convert.ToDateTime(dateDateImport.Text);
                    _UpdatePro.PictureProduct = (txtPathPicture.Text = ImageToBase64(url));
                    if (cbStatus.Text == "Availability")
                    {
                        _UpdatePro.StatusP = true;
                    }
                    else
                    {
                        _UpdatePro.StatusP = false;
                    }
                    var proUp = _UpdatePro;
                    DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        _ShowList.Update(proUp);
                        button4_Click(sender, e);
                        button2_Click(sender, e);
                    }
                }
            }
        }
        // clear button
        private void button2_Click(object sender, EventArgs e)
        {
            txtIDProduct.Clear();
            txtNameProduct.Clear();
            cbTypeProduct.SelectedItem = 0;
            cbIdSupplier.SelectedItem = 0;
            dateEXP.Value = DateTime.Now.Date;
            dateMFG.Value = DateTime.Now.Date;
            dateDateImport.Value = DateTime.Now.Date;
            PictureProduct.Image = default;
            txtPathPicture.Clear();

        }
        // change status product
        private void button3_Click(object sender, EventArgs e)
        {
            _ShowList = new ProductService();
            var RemovePro = _ShowList.GetAll()
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
                        _ShowList.Update(RemovePro);
                        _ShowList1 = new ProductService();
                        var showlist = _ShowList1.GetAll().ToList().Where(p => p.StatusP == true);
                        dataGridView1.DataSource = new BindingSource() { DataSource = showlist };
                        button2_Click(sender, e);

                    }

                }
            }
        }
        // arrange name product
        private void btSearch_Click(object sender, EventArgs e)
        {
            if (rd1.Checked == true)
            {
                if (txtCheckName.Checked == true && txtCheckType.Checked == false)
                {
                    _Search = new ProductService();
                    string _nam = txtName.Text;
                    var nameS = _Search.GetAll().ToList().Where(entity => entity.StatusP==true 
                    && entity.NameProduct.ToLower().StartsWith(_nam.ToLower()));
                    if (nameS != null)
                    {

                        dataGridView1.DataSource = new BindingSource() { DataSource = nameS };
                    }
                }
                else if (txtCheckName.Checked == false && txtCheckType.Checked == true)
                {
                    _Search = new ProductService();
                    string _type = txtComboType.Text;
                    var typeProduct = _Search.GetAll().ToList().Where(e => e.ProductType == _type && e.StatusP ==true);
                    if (typeProduct != null)
                    {
                        dataGridView1.DataSource = new BindingSource() { DataSource = typeProduct };
                    }


                }
                else if (txtCheckName.Checked == true && txtCheckName.Checked == true)
                {
                    _Search = new ProductService();
                    string _TypePro = txtComboType.Text;
                    string _NamePro = txtName.Text;
                    var TypeAndName = _Search.GetAll().ToList().Where(e => e.ProductType == _TypePro 
                    && e.NameProduct.ToLower().StartsWith(_NamePro.ToLower())
                    && e.StatusP == true);
                    if (TypeAndName != null)
                    {
                        dataGridView1.DataSource = new BindingSource() { DataSource = TypeAndName };
                    }
                }
                else
                {
                    MessageBox.Show("Do not leave blank Check");
                }
            }
            else if(rd2.Checked ==true)
            {
                if (txtCheckName.Checked == true && txtCheckType.Checked == false)
                {
                    _Search = new ProductService();
                    string _nam = txtName.Text;
                    var nameS = _Search.GetAll().ToList().Where(entity => entity.StatusP == false &&
                    entity.NameProduct.ToLower().StartsWith(_nam.ToLower()));
                    if (nameS != null)
                    {

                        dataGridView1.DataSource = new BindingSource() { DataSource = nameS };
                    }
                }
                else if (txtCheckName.Checked == false && txtCheckType.Checked == true)
                {
                    _Search = new ProductService();
                    string _type = txtComboType.Text;
                    var typeProduct = _Search.GetAll().ToList().Where(e => e.ProductType == _type && e.StatusP == false);
                    if (typeProduct != null)
                    {
                        dataGridView1.DataSource = new BindingSource() { DataSource = typeProduct };
                    }


                }
                else if (txtCheckName.Checked == true && txtCheckName.Checked == true)
                {
                    _Search = new ProductService();
                    string _TypePro = txtComboType.Text;
                    string _NamePro = txtName.Text;
                    var TypeAndName = _Search.GetAll().ToList().Where(e => e.StatusP ==false &&
                    e.ProductType == _TypePro && e.NameProduct.ToLower().StartsWith(_NamePro.ToLower()));
                    if (TypeAndName != null)
                    {
                        dataGridView1.DataSource = new BindingSource() { DataSource = TypeAndName };
                    }
                }
                else
                {
                    MessageBox.Show("Do not leave blank Check");
                }
            }
            else
            {
                if (txtCheckName.Checked == true && txtCheckType.Checked == false)
                {
                    _Search = new ProductService();
                    string _nam = txtName.Text;
                    var nameS = _Search.GetAll().ToList().Where(entity => entity.StatusP == true
                    && entity.NameProduct.ToLower().StartsWith(_nam.ToLower()));
                    if (nameS != null)
                    {

                        dataGridView1.DataSource = new BindingSource() { DataSource = nameS };
                    }
                }
                else if (txtCheckName.Checked == false && txtCheckType.Checked == true)
                {
                    _Search = new ProductService();
                    string _type = txtComboType.Text;
                    var typeProduct = _Search.GetAll().ToList().Where(e => e.ProductType == _type && e.StatusP == true);
                    if (typeProduct != null)
                    {
                        dataGridView1.DataSource = new BindingSource() { DataSource = typeProduct };
                    }


                }
                else if (txtCheckName.Checked == true && txtCheckName.Checked == true)
                {
                    _Search = new ProductService();
                    string _TypePro = txtComboType.Text;
                    string _NamePro = txtName.Text;
                    var TypeAndName = _Search.GetAll().ToList().Where(e => e.ProductType == _TypePro
                    && e.NameProduct.ToLower().StartsWith(_NamePro.ToLower())
                    && e.StatusP == true);
                    if (TypeAndName != null)
                    {
                        dataGridView1.DataSource = new BindingSource() { DataSource = TypeAndName };
                    }
                }
                else
                {
                    MessageBox.Show("Do not leave blank Check");
                }
            }
            
        }
        // arrange Name
        private void txtArrange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rd1.Checked == true)
            {
                _Search = new ProductService();
                if (txtArrange.Text == "Name Ascending")
                {
                    var ascendingpro = _Search.GetAll().ToList()
                        .OrderBy(o => o.NameProduct.Length)
                        .ThenBy(o => o.ProductType).ThenBy(o => o.IdSupplier).ThenBy(o => o.DateImport)
                        .Where(p => p.StatusP == true);
                    this.dataGridView1.DataSource = new BindingSource() { DataSource = ascendingpro };
                }
                if (txtArrange.Text == "Name Decrease")
                {
                    var ascendingpro = _Search.GetAll().ToList()
                        .OrderByDescending(o => o.NameProduct.Length)
                        .ThenBy(o => o.ProductType).ThenBy(o => o.IdSupplier).ThenBy(o => o.DateImport)
                        .Where(p => p.StatusP == true);
                    this.dataGridView1.DataSource = new BindingSource() { DataSource = ascendingpro };
                }
                if (txtArrange.Text == "All")
                {
                    var ascendingpro = _Search.GetAll().ToList().Where(p => p.StatusP == true);
                    this.dataGridView1.DataSource = new BindingSource() { DataSource = ascendingpro };
                }
                
            }
            else if (rd2.Checked == true)
            {
                _Search = new ProductService();
                if (txtArrange.Text == "Name Ascending")
                {
                    var ascendingpro = _Search.GetAll().ToList()
                        .OrderBy(o => o.NameProduct.Length)
                        .ThenBy(o => o.ProductType).ThenBy(o => o.IdSupplier).ThenBy(o => o.DateImport)
                        .Where(p => p.StatusP == false);
                    this.dataGridView1.DataSource = new BindingSource() { DataSource = ascendingpro };
                }
                if (txtArrange.Text == "Name Decrease")
                {
                    var ascendingpro = _Search.GetAll().ToList()
                        .OrderByDescending(o => o.NameProduct.Length)
                        .ThenBy(o => o.ProductType).ThenBy(o => o.IdSupplier).ThenBy(o => o.DateImport)
                        .Where(p => p.StatusP == false);
                    this.dataGridView1.DataSource = new BindingSource() { DataSource = ascendingpro };
                }
                if (txtArrange.Text == "All")
                {
                    var ascendingpro = _Search.GetAll().ToList().Where(p => p.StatusP == false);
                    this.dataGridView1.DataSource = new BindingSource() { DataSource = ascendingpro };
                }
            }
            else
            {
                _Search = new ProductService();
                if (txtArrange.Text == "Name Ascending")
                {
                    var ascendingpro = _Search.GetAll().ToList()
                        .OrderBy(o => o.NameProduct.Length)
                        .ThenBy(o => o.ProductType).ThenBy(o => o.IdSupplier).ThenBy(o => o.DateImport)
                        .Where(p => p.StatusP == true);
                    this.dataGridView1.DataSource = new BindingSource() { DataSource = ascendingpro };
                }
                if (txtArrange.Text == "Name Decrease")
                {
                    var ascendingpro = _Search.GetAll().ToList()
                        .OrderByDescending(o => o.NameProduct.Length)
                        .ThenBy(o => o.ProductType).ThenBy(o => o.IdSupplier).ThenBy(o => o.DateImport)
                        .Where(p => p.StatusP == true);
                    this.dataGridView1.DataSource = new BindingSource() { DataSource = ascendingpro };
                }
                if (txtArrange.Text == "All")
                {
                    var ascendingpro = _Search.GetAll().ToList().Where(p => p.StatusP == true);
                    this.dataGridView1.DataSource = new BindingSource() { DataSource = ascendingpro };
                }
            }

        }
        // clear picture and path
        private void btClearPic_Click(object sender, EventArgs e)
        {
            PictureProduct.Image = null;
            txtPathPicture.Clear();
        }
        // select file to import Products
        private void txtSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Select Excel File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathToImport.Text = openFileDialog.FileName;
            }
        }
        //import Product
        private void button5_Click(object sender, EventArgs e)
        {
            var filePath = txtPathToImport.Text;

            var dataImporter = new ImportProducts();
            dataImporter.ImportDataFromExcel(filePath);
            txtPathToImport.Clear();
            button4_Click(sender, e);
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Only for excel Microsoft offical!", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbook xlWbook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWsheet;
                    object data = System.Reflection.Missing.Value;
                    xlWbook = excel.Workbooks.Add(data);
                    xlWsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
                    xlWsheet.Cells[1, 1].Value = "ProductType";
                    xlWsheet.Cells[1, 2].Value = "NameProduct";
                    xlWsheet.Cells[1, 3].Value = "IdSupplier";
                    xlWsheet.Cells[1, 4].Value = "Mfg";
                    xlWsheet.Cells[1, 5].Value = "Exp";
                    xlWsheet.Cells[1, 6].Value = "DateImport";
                    xlWsheet.Cells[1, 7].Value = "PictureProduct";
                    xlWsheet.Cells[1, 8].Value = "StatusP";
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

        private void txtExpProduct_Click(object sender, EventArgs e)
        {
            _ShowList = new ProductService();
            var ProductExp = _ShowList.GetAll().ToList().Where(p => p.Exp > DateTime.Today &&
             p.Exp <= DateTime.Today.AddDays(30));
            if (ProductExp != null)
            {
                dataGridView1.DataSource = new BindingSource() { DataSource = ProductExp };
            }
        }
    }
}
