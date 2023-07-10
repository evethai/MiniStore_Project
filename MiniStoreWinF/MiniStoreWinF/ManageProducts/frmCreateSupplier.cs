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
    public partial class frmCreateSupplier : Form
    {
        public frmCreateSupplier()
        {
            InitializeComponent();
        }
        public TextBox textBoxSupplierData => txtNameSupplier;
        public TextBox textBoxSupplierData1 => txtAddressSupplier;
        public TextBox textBoxSupplierData2 => txtNoteSupplier;
        private void frmCreateSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FormDataStorage.CreateSupplier.ProductData = txtNameSupplier.Text;
        }
        public void Clear_Click(object sender, EventArgs e)
        {
            txtAddressSupplier.Text = "";
            txtNoteSupplier.Text = "";
            txtNameSupplier.Text = "";
        }
    }
}
