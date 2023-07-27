using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.Manage_Voucher
{
    public partial class frmMemberVVoucher : Form
    {
        public frmMemberVVoucher()
        {
            InitializeComponent();
            CheckColor(M);
            valid.openChildForm(new ManageMember.frmMember(), pnMain);
        }
        Validation valid = new Validation();

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

        private void btVoucher_Click(object sender, EventArgs e)
        {
            CheckColor(V);
            valid.openChildForm(new frmShowVoucher(), pnMain);
        }

        private void btMember_Click(object sender, EventArgs e)
        {
            CheckColor(M);
            valid.openChildForm(new ManageMember.frmMember(), pnMain);
        }
    }
}
