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
            CheckColor(btSheetDetails);
            u.openChildForm(new frmTimeKeepingDetails(), pnlManageWorksheet);
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

        private void btHistory_Click(object sender, EventArgs e)
        {
            CheckColor(btHistory);
            u.openChildForm(new frmTimeKeepingDetails(), pnlManageWorksheet);
        }

        private void btSheetDetails_Click(object sender, EventArgs e)
        {
            CheckColor(btSheetDetails);
            u.openChildForm(new frmSheetDetails(), pnlManageWorksheet);
        }

        private void btRegisterWorksheet_Click(object sender, EventArgs e)
        {
            CheckColor(btRegisterWorksheet);
            u.openChildForm(new frmRegisterWorksheet(), pnlManageWorksheet);
        }
    }
}
