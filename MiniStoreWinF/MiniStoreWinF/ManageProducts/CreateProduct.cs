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
    public partial class CreateProduct : Form
    {
        SupplierServices _comboIdSup;
        CatalogyService _comboType;
        public CreateProduct()
        {
            InitializeComponent();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            panelUnit.Visible = true;
            panelInForUnit.Visible = true;
            labelInfor.Visible = true;
            panalIdSupplier.Visible = true;
            panelSupplier.Visible = true;
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            panelUnit.Visible = false;
            panelInForUnit.Visible = false;
            labelInfor.Visible = false;
            panalIdSupplier.Visible = false;
            panelSupplier.Visible = false;

            _comboIdSup = new SupplierServices();
            var _listcomboIdSup = _comboIdSup.GetAll()
                .Select(c => new { c.IdSupplier, c.NameSupplier }).ToList();
            cbIdSupplier.ValueMember = "IdSupplier";
            cbIdSupplier.DisplayMember = "NameSupplier";
            cbIdSupplier.DataSource = _listcomboIdSup;

            _comboType = new CatalogyService();
            var _listComboProduct = _comboType.GetAll()
                .Select(c => new { c.IdCa, c.ProductType }).ToList();
            cbTypeProduct.ValueMember = "IdCa";
            cbTypeProduct.DisplayMember = "ProductType";
            cbTypeProduct.DataSource = _listComboProduct;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            txtAddressSupplier.Visible = true;
            txtNameSupplier.Visible = true;
            txtNoteSupplier.Visible = true;
            btConfirm.Visible = true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
