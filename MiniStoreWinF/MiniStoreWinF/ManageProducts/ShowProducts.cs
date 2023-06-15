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
    public partial class ShowProducts : Form
    {
        ProductService _product;
        public ShowProducts()
        {
            _product = new ProductService();
            InitializeComponent();
            var listProduct = _product.GetAll().ToList();
            dgvProduct.DataSource = listProduct;
        }

        private void ShowProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
