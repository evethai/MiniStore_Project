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

namespace MiniStoreWinF.ManageProducts
{
    public partial class frmCreateUnit : Form
    {
        ProductService _showlistPro;
        UnitService _showlistunit;
        public frmCreateUnit()
        {
            InitializeComponent();
            _showlistPro = new ProductService();
            var showlistpro = _showlistPro.GetAll()
                .Select(c => new { c.Sku, c.NameProduct }).ToList();
            cbNameProduct.ValueMember = "Sku";
            cbNameProduct.DisplayMember = "NameProduct";
            cbNameProduct.DataSource = showlistpro;

            _showlistunit = new UnitService();
            var showlistUnitName = _showlistunit.GetAll().GroupBy(c => c.UnitName);
            cbNameUnit.Items.Clear();
            foreach (var group in showlistUnitName)
            {
                string groupName = group.Key;
                if (groupName != null)
                {
                    cbNameUnit.Items.Add(groupName);
                }
                
            }
        }
        
        public ComboBox textBoxUnitData => cbNameUnit;
        public ComboBox textBoxUnitData1 => cbNameProduct;
        public NumericUpDown textBoxUnitData2 => numericQuantity;
        public TextBox textBoxUnitData3 => txtPriceIm;
        public TextBox textBoxUnitData4 => txtPriceEx;

        private void frmCreateUnit_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FormDataStorage.UnitData = textBox1.Text; // Lưu trữ dữ liệu tạm thời của frmCreateUnit
        }
        public void btClear_Click(object sender, EventArgs e)
        {
            //cbNameUnit.SelectedIndex= 0;
            _showlistPro = new ProductService();
            var showlistpro = _showlistPro.GetAll()
                .Select(c => new { c.Sku, c.NameProduct }).ToList();
            cbNameProduct.ValueMember = "Sku";
            cbNameProduct.DisplayMember = "NameProduct";
            cbNameProduct.DataSource = showlistpro;
            txtPriceEx.Text="";
            txtPriceIm.Text ="";
            numericQuantity.Value = 0;
            //cbNameProduct.SelectedIndex = 0;
        }
        public void updattest()
        {
            var suppliers = FormDataStorage.CreateProductData.ProductData;
            if (suppliers == "")
            {
                _showlistPro = new ProductService();
                var showlistpro = _showlistPro.GetAll()
                    .Select(c => new { c.Sku, c.NameProduct }).ToList();
                cbNameProduct.ValueMember = "Sku";
                cbNameProduct.DisplayMember = "NameProduct";
                cbNameProduct.DataSource = showlistpro;
            }
        }
        public void loadUnit(object sender, EventArgs e)
        {
            _showlistPro = new ProductService();
            var showlistpro = _showlistPro.GetAll()
                .Select(c => new { c.Sku, c.NameProduct }).ToList();
            cbNameProduct.ValueMember = "Sku";
            cbNameProduct.DisplayMember = "NameProduct";
            cbNameProduct.DataSource = showlistpro;

            _showlistunit = new UnitService();
            var showlistUnitName = _showlistunit.GetAll().GroupBy(c => c.UnitName);
            cbNameUnit.Items.Clear();
            foreach (var group in showlistUnitName)
            {
                string groupName = group.Key;
                if (groupName != null)
                {
                    cbNameUnit.Items.Add(groupName);
                }

            }
        }
        public void UpdateSKUComboBox()
        {
            // Xóa tất cả các mục hiện có trong ComboBox IDsup

            var suppliers = FormDataStorage.CreateProductData.ProductData;

            if (suppliers == "")
            {
                _showlistPro = new ProductService();
                var showlistpro = _showlistPro.GetAll()
                    .Select(c => new { c.Sku, c.NameProduct }).ToList();
                cbNameProduct.ValueMember = "Sku";
                cbNameProduct.DisplayMember = "NameProduct";
                cbNameProduct.DataSource = showlistpro;
            }
            else
            {
                var supplierList = suppliers.Split(',').ToList();

                // Gán danh sách supplierList làm nguồn dữ liệu cho cbIdSupplier
                cbNameProduct.DataSource = supplierList;
            }
        }
    }
}
