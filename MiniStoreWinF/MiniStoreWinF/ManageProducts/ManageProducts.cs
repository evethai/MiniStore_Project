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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }
        private void ManageProducts_Load(object sender, EventArgs e)
        {

        }

        private void btShowProducts_Click(object sender, EventArgs e) //Show Products
        {
            this.Hide();
            ShowProducts showProducts = new ShowProducts();
            showProducts.Show();
        }

        private void btCreateProducts_Click(object sender, EventArgs e)//Create Products
        {
            this.Hide();
            CreateProducts createProducts = new CreateProducts();
            createProducts.Show();
        }

        private void btUpdateRemoveEmployees_Click(object sender, EventArgs e) //Update-Remove Products
        {
            this.Hide();
            UpdateRemoveProduct updateRemoveProduct = new UpdateRemoveProduct();
            updateRemoveProduct.Show();
        }
    }
}
