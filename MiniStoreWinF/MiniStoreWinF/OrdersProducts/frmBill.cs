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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        public event EventHandler ChildFormClosed;

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            ChildFormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void frmBill_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
