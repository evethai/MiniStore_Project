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
    public partial class UpdateStatusProduct : Form
    {
        private int rowindex { get; set; }
        ProductService _productList;
        
        public UpdateStatusProduct()
        {
            InitializeComponent();
            _productList = new ProductService();
            var listProduct = _productList.GetAll().ToList().Select(p => new
            {
                p.Sku,
                p.NameProduct,
                p.StatusP,
            }).Where(p => p.StatusP == false);
            DgvListProduct.DataSource = new BindingSource() { DataSource = listProduct };
        }

        private void UpdateStatusProduct_Load(object sender, EventArgs e)
        {

        }

        private void DgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _productList = new ProductService();
            var id = DgvListProduct[0, e.RowIndex].Value;
            var showPro = _productList.GetAll().Where(p => p.Sku.Trim().Equals(id)).FirstOrDefault();
            rowindex = e.RowIndex;
            if (showPro != null)
            {
                txtIDProduct.Text = showPro.Sku.ToString();
                txtNameProduct.Text = showPro.NameProduct.ToString();
                //txtStatusProduct.Text = showPro.StatusP.ToString();
                if (showPro.StatusP == true)
                {
                    txtStatusProduct.Text = "Availability";
                }
                else
                {
                    txtStatusProduct.Text = "Sold Out";
                }

            }
        }

        private void btUpdateProduct_Click(object sender, EventArgs e)
        {
            _productList = new ProductService();
            var RemovePro = _productList.GetAll()
                .Where(p => p.Sku.Equals(txtIDProduct.Text) && p.StatusP==false).FirstOrDefault();
            if (RemovePro != null)
            {

                if (RemovePro.StatusP ==true)
                {
                    MessageBox.Show("Item is in status Sold Out");
                }
                else
                {
                    //RemovePro.StatusP = txtStatusProduct.Text;
                    if (txtStatusProduct.Text == "Availability")
                    {
                        RemovePro.StatusP = true;
                    }
                    else
                    {
                        RemovePro.StatusP = false;
                    }
                    _productList.Update(RemovePro);
                }
            }
        }

        private void txtLoadPro_Click(object sender, EventArgs e)
        {
            _productList = new ProductService();
            var listProduct = _productList.GetAll().ToList().Where(p => p.StatusP == false);
            DgvListProduct.DataSource = new BindingSource() { DataSource = listProduct };
        }
    }
}
