using Microsoft.Data.SqlClient;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Azure.Core.HttpHeader;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MiniStoreWinF.ManageProducts
{
    public partial class ShowProducts : Form
    {

        ProductService _product;
        ProductService _SearchName;
        CatalogyService _combo;
        ProductService _SearchType;
        ProductService _SearchName1;
        private int rowindex { get; set; }
        public ShowProducts()
        {
            _product = new ProductService();
            InitializeComponent();
            var listProduct = _product.GetAll().ToList().Select(p => new
            {
                p.Sku,
                p.ProductType,
                p.NameProduct,
                p.QuantityProduct,
                p.PriceProduct,
                p.Mfg,
                p.Exp,
                p.StatusP,


            });

            //var listProduct = _product.GetAll().ToList().Select(p => Base64ToImage(p.PictureProduct));
            //dgvProduct.DataSource = listProduct;

            dgvProduct.DataSource = new BindingSource() { DataSource = listProduct };



            _combo = new CatalogyService();
            var _listComboProduct = _combo.GetAll().Select(c => new { c.IdCa, c.ProductType }).ToList();
            txtComboType.ValueMember = "IdCa";
            txtComboType.DisplayMember = "ProductType";
            txtComboType.DataSource = _listComboProduct;
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }



        private void ShowProducts_Load(object sender, EventArgs e)
        {

        }
        private void txtBackMaPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProducts _manageProducts = new ManageProducts();
            _manageProducts.Show();
        }

        private async void txtSearchName_Click(object sender, EventArgs e)
        {
            if (txtCheckName.Checked == true && txtCheckType.Checked == false)
            {
                _SearchName = new ProductService();
                string _nam = txtName.Text;
                var nameS = _SearchName.GetAll().ToList().Where(entity => entity.NameProduct.ToLower().StartsWith(_nam.ToLower()));
                if (nameS != null)
                {

                    dgvProduct.DataSource = new BindingSource() { DataSource = nameS };
                }
            }
            else if (txtCheckName.Checked == false && txtCheckType.Checked == true)
            {
                _SearchType = new ProductService();
                string _type = txtComboType.Text;
                var typeProduct = _SearchType.GetAll().ToList().Where(e => e.ProductType == _type);
                if (typeProduct != null)
                {
                    dgvProduct.DataSource = new BindingSource() { DataSource = typeProduct };
                }


            }
            else if (txtCheckName.Checked == true && txtCheckName.Checked == true)
            {
                _SearchName1 = new ProductService();
                string _TypePro = txtComboType.Text;
                string _NamePro = txtName.Text;
                var TypeAndName = _SearchName1.GetAll().ToList().Where(e => e.ProductType == _TypePro && e.NameProduct.ToLower().StartsWith(_NamePro.ToLower()));
                if (TypeAndName != null)
                {
                    dgvProduct.DataSource = new BindingSource() { DataSource = TypeAndName };
                }
            }
            else
            {
                MessageBox.Show("Ko Bo Trong check");
            }
        }

        private void txtLoadPro_Click(object sender, EventArgs e)
        {
            _product = new ProductService();
            var listProduct = _product.GetAll().ToList();
            dgvProduct.DataSource = listProduct;
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _product = new ProductService();
            var id = dgvProduct[0, e.RowIndex].Value;
            var ShowPic = _product.GetAll().Where(p => p.Sku.Equals(id)).FirstOrDefault();
            if (ShowPic != null)
            {
                PicShowPro.Image = Base64ToImage(ShowPic.PictureProduct);
            }
        }

        private void btArrange_Click(object sender, EventArgs e)
        {
            _product = new ProductService();
            if (txtArrange.Text == "Price Ascending")
            {
                var AscendingPro = _product.GetAll().ToList().OrderBy(o => o.PriceProduct)
                    .ThenBy(o => o.QuantityProduct).ThenBy(o => o.NameProduct).ThenBy(o => o.ProductType).Select(p => new
                    {
                        p.Sku,
                        p.ProductType,
                        p.NameProduct,
                        p.QuantityProduct,
                        p.PriceProduct,
                        p.Mfg,
                        p.Exp,
                        p.StatusP,
                    });
                this.dgvProduct.DataSource = new BindingSource() { DataSource = AscendingPro };
            }
            if (txtArrange.Text == "Price Decrease ")
            {
                var AscendingPro = _product.GetAll().ToList().OrderByDescending(o => o.PriceProduct)
                    .ThenBy(o => o.QuantityProduct).ThenBy(o => o.NameProduct).ThenBy(o => o.ProductType).Select(p => new
                    {
                        p.Sku,
                        p.ProductType,
                        p.NameProduct,
                        p.QuantityProduct,
                        p.PriceProduct,
                        p.Mfg,
                        p.Exp,
                        p.StatusP,
                    });
                this.dgvProduct.DataSource = new BindingSource() { DataSource = AscendingPro };
            }

        }

    }
}
