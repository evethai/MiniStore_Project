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
        bool check;
        public frmMain()
        {
            InitializeComponent();
            checkRoles(check);
        }

        private void mnuAdminDB_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmDashBoard(), pMain);
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
    }
}
