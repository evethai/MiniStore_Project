using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.OrdersProducts
{
    public partial class frmCashPayment : Form
    {
        public frmCashPayment()
        {
            InitializeComponent();
        }
        public double DataProvidesCash { get; set; }
        public double TotalBill;
        private void btOk_Click(object sender, EventArgs e)
        {
            DataProvidesCash = Convert.ToDouble(txtProvidesCash.Text);
            if (DataProvidesCash >= TotalBill)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("The amount entered is not enough", "Notification", MessageBoxButtons.OK);
                return;
            }

        }

        private void txtProvidesCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
