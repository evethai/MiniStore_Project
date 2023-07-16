using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace MiniStoreWinF.ManageProducts
{
    public partial class ManageUnitProduct : Form
    {
        private int rowindex { get; set; }
        UnitServices _showListUnit;
        UnitServices _showListUnit1;
        ProductService _showlistPro;
        ProductService _showlistPro1;
        UnitServices _IdUnit;
        public ManageUnitProduct()
        {
            InitializeComponent();
            //Show list Unit
            _showListUnit = new UnitServices();
            var showlist = _showListUnit.GetAll().ToList();
            dataGridView1.DataSource = new BindingSource() { DataSource = showlist };

            //Show List SKU
            _showlistPro = new ProductService();
            //var showlistPro = _showlistPro.GetAll().Select(c => c.Sku).ToList();
            //cbSku.DataSource = showlistPro.ToList();
            var showlistpro = _showlistPro.GetAll()
                .Select(c => new { c.Sku, c.NameProduct }).ToList();
            cbSku.ValueMember = "Sku";
            cbSku.DisplayMember = "NameProduct";
            cbSku.DataSource = showlistpro;

            //_comboType = new CatalogyService();
            //var _listComboProduct = _comboType.GetAll()
            //    .Select(c => new { c.IdCa, c.ProductType }).ToList();
            //txtTypeProductList.ValueMember = "IdCa";
            //txtTypeProductList.DisplayMember = "ProductType";
            //txtTypeProductList.DataSource = _listComboProduct;

            cbSku.Enabled = false;
            _showlistPro1 = new ProductService();
            _showListUnit1 = new UnitServices();
            var product = _showlistPro1.GetAll().ToList();
            var unitli = _showListUnit1.GetAll().ToList();
            foreach (var item in product)
            {
                foreach (var item2 in unitli)
                {
                    if (item.Sku == item2.Sku)
                    {

                        item2.Sku = item.NameProduct;
                        dataGridView1.DataSource = new BindingSource() { DataSource = unitli };
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _showListUnit = new UnitServices();
                _showlistPro = new ProductService();
                var showlistpro = _showlistPro.GetAll()
               .Select(c => new { c.Sku, c.NameProduct }).ToList();
                cbSku.ValueMember = "Sku";
                cbSku.DisplayMember = "NameProduct";
                cbSku.DataSource = showlistpro;
                var id = dataGridView1[0, e.RowIndex].Value;
                var showPro = _showListUnit.GetAll().Where(p => p.IdUnit.Trim().Equals(id)).FirstOrDefault();
                rowindex = e.RowIndex;
                if (showPro != null)
                {
                    txtIDUnit.Text = showPro.IdUnit.ToString();
                    numericQuantity.Text = showPro.QuantityUnit.ToString();
                    txtNameUnit.Text = showPro.UnitName.ToString();
                    //cbSku.Text = showPro.Sku.ToString();
                    var selectedProduct = showlistpro.FirstOrDefault(p => p.Sku == showPro.Sku);
                    if (selectedProduct != null)
                    {
                        cbSku.SelectedValue = selectedProduct.Sku;
                    }
                    txtPriceExport.Text = showPro.PriceExport.ToString();
                    double temp1 = Convert.ToDouble(txtPriceExport.Text);
                    txtPriceExport.Text = temp1.ToString("#,###");
                    txtPriceImport.Text = showPro.PriceImport.ToString();
                    double temp2 = Convert.ToDouble(txtPriceImport.Text);
                    txtPriceImport.Text = temp2.ToString("#,###");

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtArrange_SelectedIndexChanged(object sender, EventArgs e)
        {
            _showListUnit = new UnitServices();
            if (txtArrange.Text == "Price Ascending")
            {
                var AscendingPro = _showListUnit.GetAll().ToList().OrderBy(o => o.PriceImport)
                    .OrderBy(o => o.PriceExport).ThenBy(o => o.QuantityUnit).ThenBy(o => o.UnitName.Length);
                _showlistPro1 = new ProductService();
                var product = _showlistPro1.GetAll().ToList();
                foreach (var item in product)
                {
                    foreach (var item2 in AscendingPro)
                    {
                        if (item.Sku == item2.Sku)
                        {

                            item2.Sku = item.NameProduct;

                        }
                    }
                }
                this.dataGridView1.DataSource = new BindingSource() { DataSource = AscendingPro };
            }
            if (txtArrange.Text == "Price Decrease ")
            {
                var AscendingPro = _showListUnit.GetAll().ToList().OrderByDescending(o => o.PriceImport)
                    .OrderByDescending(o => o.PriceExport).ThenBy(o => o.QuantityUnit)
                    .ThenBy(o => o.UnitName.Length);
                _showlistPro1 = new ProductService();
                var product = _showlistPro1.GetAll().ToList();
                foreach (var item in product)
                {
                    foreach (var item2 in AscendingPro)
                    {
                        if (item.Sku == item2.Sku)
                        {

                            item2.Sku = item.NameProduct;

                        }
                    }
                }
                this.dataGridView1.DataSource = new BindingSource() { DataSource = AscendingPro };
            }
            if (txtArrange.Text == "ALL")
            {
                var AscendingPro = _showListUnit.GetAll().ToList();
                _showlistPro1 = new ProductService();
                var product = _showlistPro1.GetAll().ToList();
                foreach (var item in product)
                {
                    foreach (var item2 in AscendingPro)
                    {
                        if (item.Sku == item2.Sku)
                        {

                            item2.Sku = item.NameProduct;

                        }
                    }
                }
                this.dataGridView1.DataSource = new BindingSource() { DataSource = AscendingPro };
            }
        }
        //auto ID
        public string autoID(string id)
        {
            string prefix = id.Substring(0, 3);
            int number = int.Parse(id.Substring(1));
            number++;
            string nextID = prefix + number.ToString().PadLeft(2, '0');

            return nextID;
        }
        // Add unit
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    double temp = Convert.ToDouble(txtPriceImport.Text);
        //    txtPriceImport.Text = temp.ToString("#,###");
        //    double temp2 = Convert.ToDouble(txtPriceExport.Text);
        //    txtPriceExport.Text = temp2.ToString("#,###");
        //    _showListUnit = new UnitServices();
        //    var AddPro = _showListUnit.GetAll().ToList().Where(e => e.IdUnit.ToUpper()
        //    .Equals(txtIDUnit.Text.ToUpper()))
        //        .FirstOrDefault();
        //    if (txtNameUnit.Text == "" ||
        //        txtPriceImport.Text == "" ||
        //        txtPriceExport.Text == "" ||
        //        !float.TryParse(txtPriceImport.Text = temp.ToString("#,###"), out float price) ||
        //        price < 0 ||
        //        !float.TryParse(txtPriceExport.Text = temp2.ToString("#,###"), out float price1) ||
        //        price1 < 0
        //        )
        //    {
        //        MessageBox.Show("Not Be Empty or Invalid Value");
        //    }
        //    else
        //    {
        //        if (AddPro != null)
        //        {
        //            MessageBox.Show("ID Duplicated ");
        //        }
        //        else
        //        {
        //            _IdUnit = new UnitServices();
        //            var _autoid = _IdUnit.GetAll().ToList().Select(c => c.IdUnit).Max();
        //            string nextid = autoID(_autoid);
        //            _showListUnit1 = new UnitServices();
        //            var _addUnit = _showListUnit1.GetAll().ToList().FirstOrDefault();
        //            _addUnit.IdUnit = nextid;
        //            _addUnit.UnitName = txtNameUnit.Text;
        //            _addUnit.QuantityUnit = Int32.Parse(numericQuantity.Text);
        //            _addUnit.PriceImport = price;
        //            _addUnit.PriceExport = price1;
        //            _addUnit.Sku = cbSku.Text;
        //            DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //            if (result == DialogResult.OK)
        //            {
        //                _showListUnit1.Create(_addUnit);
        //                btLoad_Click(sender, e);
        //                btClear_Click(sender, e);
        //            }
        //        }
        //    }

        //}
        // Form Price Export .000
        private void txtPriceExport_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPriceExport.Text.Equals("0"))
                    return;
                double temp = Convert.ToDouble(txtPriceExport.Text);
                txtPriceExport.Text = temp.ToString("#,###");
            }
            catch (Exception ex)
            {
                //MessageBox.show("lỗi:" + ex);
            }
        }
        // Form Price Import .000
        private void txtPriceImport_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPriceImport.Text.Equals("0"))
                    return;
                double temp = Convert.ToDouble(txtPriceImport.Text);
                txtPriceImport.Text = temp.ToString("#,###");
            }
            catch (Exception ex)
            {
                //MessageBox.show("lỗi:" + ex);
            }
        }
        // Form Price filter 1 .000
        private void txtPriceFilter1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPriceFilter1.Text.Equals("0"))
                    return;
                double temp = Convert.ToDouble(txtPriceFilter1.Text);
                txtPriceFilter1.Text = temp.ToString("#,###");
            }
            catch (Exception ex)
            {
                //MessageBox.show("lỗi:" + ex);
            }
        }
        // Form Price filter 2 .000
        private void txtPriceFilter2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPriceFilter2.Text.Equals("0"))
                    return;
                double temp = Convert.ToDouble(txtPriceFilter2.Text);
                txtPriceFilter2.Text = temp.ToString("#,###");
            }
            catch (Exception ex)
            {
                //MessageBox.show("lỗi:" + ex);
            }
        }
        // Sort Price import
        private void btSort_Click(object sender, EventArgs e)
        {
            try
            {
                double temp = Convert.ToDouble(txtPriceFilter1.Text);
                //txtPriceFilter1.Text = temp.ToString("#,###");
                double temp2 = Convert.ToDouble(txtPriceFilter2.Text);
                //txtPriceFilter2.Text = temp2.ToString("#,###");
                if (txtPriceFilter1.Text == "" || txtPriceFilter2.Text == "")
                {
                    MessageBox.Show("Do Not Leave Blank");
                }
                else if (float.TryParse(txtPriceFilter1.Text = temp.ToString("#,###"), out float filterPrice)
                    && float.TryParse(txtPriceFilter2.Text = temp2.ToString("#,###"), out float filterPrice2))
                {
                    _showListUnit = new UnitServices();
                    var PriceProduct = _showListUnit.GetAll().ToList().Where(p =>
                     (filterPrice <= p.PriceImport && p.PriceImport <= filterPrice2));
                    if (PriceProduct != null)
                    {
                        _showlistPro1 = new ProductService();
                        var product = _showlistPro1.GetAll().ToList();
                        foreach (var item in product)
                        {
                            foreach (var item2 in PriceProduct)
                            {
                                if (item.Sku == item2.Sku)
                                {

                                    item2.Sku = item.NameProduct;

                                }
                            }
                        }
                        dataGridView1.DataSource = new BindingSource() { DataSource = PriceProduct };
                    }
                }
            }

            catch
            {
                MessageBox.Show("Value is not a valid integer! Or Value is Blank ");
            }

        }

        private void btload_click(object sender, EventArgs e)
        {
            _showListUnit = new UnitServices();
            var showlist = _showListUnit.GetAll().ToList();
            _showlistPro1 = new ProductService();
            var product = _showlistPro1.GetAll().ToList();
            foreach (var item in product)
            {
                foreach (var item2 in showlist)
                {
                    if (item.Sku == item2.Sku)
                    {

                        item2.Sku = item.NameProduct;

                    }
                }
            }
            dataGridView1.DataSource = new BindingSource() { DataSource = showlist };
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtIDUnit.Clear();
            txtNameUnit.Clear();
            txtPriceExport.Clear();
            txtPriceImport.Clear();
            numericQuantity.Value = 0;
            cbSku.SelectedIndex = 0;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(txtPriceImport.Text);
            //txtPriceImport.Text = temp.ToString("#,###");
            double temp2 = Convert.ToDouble(txtPriceExport.Text);
            //txtPriceExport.Text = temp2.ToString("#,###");
            _showListUnit = new UnitServices();
            var AddPro = _showListUnit.GetAll().ToList().Where(e => e.IdUnit.ToUpper()
            .Equals(txtIDUnit.Text.ToUpper()))
                .FirstOrDefault();
            if (txtNameUnit.Text == "" ||
                txtPriceImport.Text == "" ||
                txtPriceExport.Text == "" ||
                !float.TryParse(txtPriceImport.Text = temp.ToString("#,###"), out float price) ||
                price < 0 ||
                !float.TryParse(txtPriceExport.Text = temp2.ToString("#,###"), out float price1) ||
                price1 < 0
                )
            {
                MessageBox.Show("Not Be Empty or Invalid Value");
            }
            else
            {

                AddPro.IdUnit = txtIDUnit.Text;

                AddPro.QuantityUnit = Int32.Parse(numericQuantity.Text);

                AddPro.PriceExport = price1;

                DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    _showListUnit.Update(AddPro);
                    btload_click(sender, e);
                    btClear_Click(sender, e);

                }

            }
        }

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

        private void txtImportUnit_Click(object sender, EventArgs e)
        {
            var filePath = txtPathToImport.Text;

            var dataImporter = new ImportProducts();
            dataImporter.ImportDataFromExcelUnit(filePath);
            txtPathToImport.Clear();
            //btLoad_Click(sender, e);
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
                    xlWsheet.Cells[1, 1].Value = "Sku";
                    xlWsheet.Cells[1, 2].Value = "UnitName";
                    xlWsheet.Cells[1, 3].Value = "QuantityUnit";
                    xlWsheet.Cells[1, 4].Value = "PriceImport";
                    xlWsheet.Cells[1, 5].Value = "PriceExport";

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
    }
}
