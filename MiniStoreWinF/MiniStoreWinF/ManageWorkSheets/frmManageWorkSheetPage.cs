using MiniStoreWinF.ManageSalary;
using MiniStoreWinF.ManageWorkSheets;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace MiniStoreWinF.ManageWorkSheet
{
    public partial class frmManageWorkSheetPage : Form
    {
        Utinity u = new Utinity();
        public frmManageWorkSheetPage()
        {
            InitializeComponent();
            u.openChildForm(new frmTimeKeepingDetails(), pnlManageWorksheet);
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmTimeKeepingDetails(), pnlManageWorksheet);
        }

        private void btSheetDetails_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmSheetDetails(), pnlManageWorksheet);
        }

        private void btRegisterWorksheet_Click(object sender, EventArgs e)
        {
            u.openChildForm(new frmRegisterWorksheet(), pnlManageWorksheet);
        }
    }
}
