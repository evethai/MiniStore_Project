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
    public partial class UpdateStatusTypeProduct : Form
    {
        string _status = "Sold Out";
        CatalogyService _comboType;
        CatalogyService _catalogyList;
        private int rowindex { get; set; }
        public UpdateStatusTypeProduct()
        {
            InitializeComponent();
            _comboType = new CatalogyService();
            var ListCatalogy = _comboType.GetAll().ToList().OrderBy(o => o.IdCa);
            DgvTypeProduct.DataSource = new BindingSource() { DataSource = ListCatalogy };
        }

        private void DgvTypeProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _catalogyList = new CatalogyService();
            var id = DgvTypeProduct[0, e.RowIndex].Value;
            var showProType = _catalogyList.GetAll()
                .Where(p => p.IdCa.Equals(id) )
                .FirstOrDefault();
            rowindex = e.RowIndex;
            if (showProType != null)
            {
                txtIDTypeProduct.Text = showProType.IdCa.ToString();
                txtTypeProductCategory.Text = showProType.ProductType.ToString();
                
            }
        }

        private void btUpdateTypeProduct_Click(object sender, EventArgs e)
        {
            _catalogyList = new CatalogyService();
            var RemovePro = _catalogyList.GetAll()
                .Where(p => p.IdCa.Equals(int.Parse(txtIDTypeProduct.Text)) ).FirstOrDefault();
            //if (RemovePro != null)
            //{

            //    if (RemovePro.StatusC == "Availability")
            //    {
            //        MessageBox.Show("Item is in status Sold Out");
            //    }
            //    else
            //    {
            //        RemovePro.StatusC = txtUpdateStatusTyPro.Text;
            //        _catalogyList.Update(RemovePro);
            //    }
            //}
        }

        private void btLoadUpSta_Click(object sender, EventArgs e)
        {
            _catalogyList = new CatalogyService();
            var listProduct = _catalogyList.GetAll().ToList();
            DgvTypeProduct.DataSource = new BindingSource() { DataSource = listProduct };
        }
    }
}
