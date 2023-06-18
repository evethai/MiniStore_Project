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

        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuAdminDB_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmDashBoard(), pMain);
        }
    }
}
