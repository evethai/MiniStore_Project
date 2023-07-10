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
    public partial class FrmToImport : Form
    {
        Utinity u = new Utinity();
        public FrmToImport()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            u.openChildForm(new ManageProducts.ImportWithNewSupplier(), pnImport);
        }

        private void btOld_Click(object sender, EventArgs e)
        {
            u.openChildForm(new ManageProducts.ImportWithOldSupplier(), pnImport);
        }
    }
}
