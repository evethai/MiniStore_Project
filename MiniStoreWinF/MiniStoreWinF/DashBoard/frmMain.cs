using Microsoft.IdentityModel.Tokens;
using MiniStoreWinF.ManageSalary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.DashBoard
{
    public partial class frmMain : Form
    {
        Utinity u = new Utinity();
        public bool check;
        public string user = "";
        public frmMain()
        {
            InitializeComponent();
            checkRoles(check);
        }

        public void checkRoles(bool b)
        {
            ToolStripMenuItem menu = menuStrip.Items["mnuAdmin"] as ToolStripMenuItem;
            if (b == false)
            {
                menu.Enabled = false;
            }
            else
            {
                menu.Enabled = true;

            }
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmDashBoard(), pMain);
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Form form = new frmLogin();
            this.Hide();
            form.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtUser.Text = user;
        }

        private void mnuStore_Click(object sender, EventArgs e)
        {
            u.openChildForm(new OrdersProducts.OrderProducts(), pMain);
        }

        private void btCheckIn_Click(object sender, EventArgs e)
        {

        }
    }
}
