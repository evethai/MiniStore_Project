using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiniStoreWinF.ManageProducts
{
    public partial class UpdateRemoveProduct : Form
    {

        ProductService _upateDelete;
        ProductService _product;
        

        public UpdateRemoveProduct()
        {
            _upateDelete = new ProductService();
            InitializeComponent();
            var listProductUPDE = _upateDelete.GetAll().ToList().Select(p => new
            {
                p.Sku,
                p.ProductType,
                p.NameProduct,
                p.QuantityProduct,
                p.PriceProduct,
                p.Nxx,
                p.Hsd,
                p.StatusP,
                Image = Base64ToImage(p.PictureProduct)

            });
            DgvUpDe.DataSource = new BindingSource { DataSource = listProductUPDE };

            


        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void txtBackLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProducts _manageProducts = new ManageProducts();
            _manageProducts.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new ManageToUpDe();
            form.ShowDialog();
        }

        private void DgvUpDe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = DgvUpDe[0, e.RowIndex].Value;
            var _LiPro = _product.GetAll().Where(p => p.Sku.Equals(id)).FirstOrDefault();
            if (_LiPro != null)
            {
                Form form = new ManageToUpDe();
                form.ShowDialog();
            }
        }
    }
}
