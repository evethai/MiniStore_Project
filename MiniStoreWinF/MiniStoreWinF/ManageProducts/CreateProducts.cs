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
    public partial class CreateProducts : Form
    {
        public string url = "";
        ProductService productService;
        ProductService productService1;
        CatalogyService _combo1;
        public CreateProducts()
        {
            InitializeComponent();
            _combo1 = new CatalogyService();
            var _listComboProduct = _combo1.GetAll().Select(c => new { c.IdCa, c.ProductType }).ToList();
            txtAddTypeProducts.ValueMember = "IdCa";
            txtAddTypeProducts.DisplayMember = "ProductType";
            txtAddTypeProducts.DataSource = _listComboProduct;


        }

        private void btAddProducts_Click(object sender, EventArgs e)
        {
            productService = new ProductService();
            var AddPro = productService.GetAll().ToList().Where(e => e.Sku.ToUpper().Equals(txtAddSKUProducts.Text.ToUpper())).FirstOrDefault();
            if (AddPro != null)
            {
                MessageBox.Show("Trung ID");
            }
            else
            {
                productService1 = new ProductService();
                var _addProduct = productService1.GetAll().ToList().FirstOrDefault();
                _addProduct.Sku = txtAddSKUProducts.Text;
                _addProduct.NameProduct = txtAddNameProducts.Text;
                _addProduct.PriceProduct = float.Parse(txtAddPriceProducts.Text);
                _addProduct.QuantityProduct = Int32.Parse(txtAddQuantityProducts.Text);
                _addProduct.Nxx = Convert.ToDateTime(txtNXX.Text);
                _addProduct.Hsd = Convert.ToDateTime(txtHSD.Text);
                _addProduct.ProductType = txtAddTypeProducts.Text;
                //_addProduct.StatusP = txtStatusPro.Text;

                _addProduct.PictureProduct = (txtPic.Text = ImageToBase64(url));
                productService.Create(_addProduct);

            }

        }

        private void txtBackM_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProducts _manageProducts = new ManageProducts();
            _manageProducts.Show();
        }

        private void txtPicturePro_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPic.Text = dlg.FileName;
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    url = dlg.FileName;
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
        //public static string GetStringFromImage(Image image)
        //{
        //    if (image != null)
        //    {
        //        ImageConverter ic = new ImageConverter();
        //        byte[] buffer = (byte[])ic.ConvertTo(image, typeof(byte[]));
        //        return Convert.ToBase64String(
        //            buffer,
        //            Base64FormattingOptions.InsertLineBreaks);
        //    }
        //    else
        //        return null;
        //}
    }
}


