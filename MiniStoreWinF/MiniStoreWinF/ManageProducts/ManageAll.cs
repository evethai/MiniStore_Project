using MiniStoreWinF.DashBoard;
using MiniStoreWinF.ManageSalary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.ManageProducts
{
    public partial class ManageAll : Form
    {
        Utinity u = new Utinity();
        public ManageAll()
        {
            InitializeComponent();
            u.openChildForm(new ManageProducts.ManageAllProducs(), pnProduct);

        }

        private void AUTHORIZATION_Click(object sender, EventArgs e)
        {
            u.openChildForm(new ManageProducts.ManageAllProducs(), pnProduct);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.openChildForm(new ManageProducts.ManageUnitProduct(), pnProduct);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.openChildForm(new ManageProducts.ManageSupplier(), pnProduct);
        }
    }
}
