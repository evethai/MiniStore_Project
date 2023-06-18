using Microsoft.EntityFrameworkCore.ValueGeneration;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MiniStoreWinF.ManageProducts
{
    public partial class ManageToUpDe : Form
    {
        private int rowindex { get; set; }
        string url = "";
        CatalogyService _catalogy;
        ProductService _product;
        ProductService _product2;
        public ManageToUpDe()
        {
            InitializeComponent();
            _product = new ProductService();
            var ShowProLi = _product.GetAll();
            DGVPro.DataSource = new BindingSource() { DataSource = ShowProLi };
            _catalogy = new CatalogyService();
            var _listComboProduct = _catalogy.GetAll().Select(c => new { c.IdCa, c.ProductType }).ToList();
            txtUDTypeProducts.ValueMember = "IdCa";
            txtUDTypeProducts.DisplayMember = "ProductType";
            txtUDTypeProducts.DataSource = _listComboProduct;


        }
        private void DGVPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _product2 = new ProductService();
            var id = DGVPro[0, e.RowIndex].Value;
            var showPro = _product2.GetAll().Where(p => p.Sku.Trim().Equals(id)).FirstOrDefault();
            rowindex = e.RowIndex;
            if (showPro != null)
            {
                //txtUpDeSKUProducts.Text = showPro.Sku.ToString();
                txtUpDeSKUProducts.Text = showPro.Sku.ToString();
                txtUpDeNameProducts.Text = showPro.NameProduct.ToString();
                txtUpDeQuantityProducts.Text = showPro.QuantityProduct.ToString();
                txtUpDePriceProducts.Text = showPro.PriceProduct.ToString();
                txtUpDeNXXProducts.Value = showPro.Mfg.Value;
                txtUpDeHSDProducts.Value = showPro.Exp.Value;
                txtUDTypeProducts.Text = showPro.ProductType.ToString();
                txtSatusUD.Text = showPro.StatusP.ToString();
                txtTextPic.Text = showPro.PictureProduct;
                pictureBoxPro.Image = Base64ToImage(showPro.PictureProduct);
            }

        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        private void txtPictureProUD_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    pictureBoxPro.Image = new Bitmap(dlg.FileName);
                    url = dlg.FileName;
                }
            }
        }

        private void txtUpdatePro_Click(object sender, EventArgs e)
        {

            _product = new ProductService();
            //var UpdatePro = _product.GetAll().ToList().Where(p => p.Sku.Equals(txtUpDeSKUProducts.Text)).FirstOrDefault();
            //if (UpdatePro != null)
            //{

            //    _product2 = new ProductService();
            //    var Update2 = _product2.GetAll().ToList().FirstOrDefault();

            //    Update2.NameProduct = txtUpDeNameProducts.Text;
            //    Update2.PriceProduct = float.Parse(txtUpDePriceProducts.Text);
            //    Update2.QuantityProduct = Int32.Parse(txtUpDeQuantityProducts.Text);
            //    Update2.Nxx = Convert.ToDateTime(txtUpDeNXXProducts.Text);
            //    Update2.Hsd = Convert.ToDateTime(txtUpDeHSDProducts.Text);
            //    Update2.ProductType = txtUDTypeProducts.Text;
            //    Update2.StatusP = txtSatusUD.Text;
            //    if (Update2.PictureProduct != txtTextPic.Text)
            //    {
            //        Update2.PictureProduct = (txtTextPic.Text = ImageToBase64(url));
            //    }
            //    else
            //    {
            //        Update2.PictureProduct = txtTextPic.Text;
            //    }

            //    _product2.Update(Update2);

            //}

            var _UpdatePro = _product.GetAll();
            if(txtUpDeNameProducts.Text =="" || 
                txtUpDeQuantityProducts.Text==""||
                txtUpDePriceProducts.Text ==""
                )
            {
                MessageBox.Show("Ko dc");
            }
            else
            {    if (txtTextPic.Text == _UpdatePro[rowindex].PictureProduct)
                {
                    _UpdatePro[rowindex].Sku = txtUpDeSKUProducts.Text;
                    _UpdatePro[rowindex].QuantityProduct = Int32.Parse(txtUpDeQuantityProducts.Text);
                    _UpdatePro[rowindex].PriceProduct = float.Parse(txtUpDePriceProducts.Text);
                    _UpdatePro[rowindex].Mfg = Convert.ToDateTime(txtUpDeNXXProducts.Text);
                    _UpdatePro[rowindex].Exp = Convert.ToDateTime(txtUpDeHSDProducts.Text);
                    //_UpdatePro[rowindex].StatusP = txtSatusUD.Text;
                    _UpdatePro[rowindex].ProductType = txtUDTypeProducts.Text;

                    var proUp = _UpdatePro[rowindex];
                    _product.Update(proUp);

                    DGVPro.DataSource = new BindingSource() { DataSource = _UpdatePro };
                }
                else
                {
                    _UpdatePro[rowindex].Sku = txtUpDeSKUProducts.Text;
                    _UpdatePro[rowindex].QuantityProduct = Int32.Parse(txtUpDeQuantityProducts.Text);
                    _UpdatePro[rowindex].PriceProduct = float.Parse(txtUpDePriceProducts.Text);
                    _UpdatePro[rowindex].Mfg = Convert.ToDateTime(txtUpDeNXXProducts.Text);
                    _UpdatePro[rowindex].Exp = Convert.ToDateTime(txtUpDeHSDProducts.Text);
                    //_UpdatePro[rowindex].StatusP = txtSatusUD.Text;
                    _UpdatePro[rowindex].ProductType = txtUDTypeProducts.Text;
                    _UpdatePro[rowindex].PictureProduct = (txtTextPic.Text = ImageToBase64(url));
                    var proUp = _UpdatePro[rowindex];
                    _product.Update(proUp);

                    DGVPro.DataSource = new BindingSource() { DataSource = _UpdatePro };

                }
            }

        }
        public string ImageToBase64(string path)
        {
            // string path = "D:\SampleImage.jpg";
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

        private void txtPictureProUD_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtTextPic.Text = dlg.FileName;
                    pictureBoxPro.Image = new Bitmap(dlg.FileName);
                    url = dlg.FileName;
                }
            }
        }

        private void txtDeletePro_Click(object sender, EventArgs e)
        {
             
            _product2 = new ProductService();
            var RemovePro = _product2.GetAll().Where(p => p.Sku.Equals(txtUpDeSKUProducts.Text)).FirstOrDefault();
            
            if (RemovePro != null)
            {

                if (RemovePro.StatusP == false)
                {
                    MessageBox.Show("Item is in status Sold Out");
                }
                else
                {
                    RemovePro.StatusP = false;
                    _product2.Update(RemovePro);
                }
            }
        }
    }
}
