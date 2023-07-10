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
            valid.openChildForm(new ManageMember.frmMember(), pnMain);
        }
        Validation valid = new Validation();

        private void btVoucher_Click(object sender, EventArgs e)
        {
            valid.openChildForm(new frmShowVoucher(), pnMain);
        }

        private void btMember_Click(object sender, EventArgs e)
        {
            valid.openChildForm(new ManageMember.frmMember(), pnMain);
        }
    }
}
