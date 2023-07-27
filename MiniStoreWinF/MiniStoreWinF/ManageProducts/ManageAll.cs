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
            CheckColor(P);
            u.openChildForm(new ManageProducts.ManageAllProducs(), pnMain);
        }

        private void CheckColor(Button button)
        {
            foreach (Control control in flowPanel.Controls)
            {
                if (control is Button)
                {
                    if (control == button)
                    {
                        control.BackColor = Color.PowderBlue;
                    }
                    else
                    {
                        control.BackColor = Color.White;
                    }
                }
            }
        }

        private void P_Click(object sender, EventArgs e)
        {
            CheckColor(P);
            u.openChildForm(new ManageProducts.ManageAllProducs(), pnMain);
        }

        private void U_Click(object sender, EventArgs e)
        {
            CheckColor(U);
            u.openChildForm(new ManageProducts.ManageUnitProduct(), pnMain);
        }

        private void S_Click(object sender, EventArgs e)
        {
            CheckColor(S);
            u.openChildForm(new ManageProducts.ManageSupplier(), pnMain);
        }
    }
}
