using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MiniStoreWinF.ManageSalary
{
    public partial class frmEditEachTax : Form
    {
        PermissionService _permissionService;
        Utinity u = new Utinity();
        public frmEditEachTax()
        {
            InitializeComponent();
            _permissionService = new PermissionService();

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var emp = _permissionService.GetAll().ToList();
            foreach (var item in emp)
            {
                item.Tax = Double.Parse(txtTax.Text);
                _permissionService.Update(item);
            }

            notiSave.BalloonTipText = "Save Successfull";
            notiSave.BalloonTipTitle = "Change Success";
            notiSave.Icon = SystemIcons.Hand;
            notiSave.ShowBalloonTip(1000);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmEditEachTax_Load(object sender, EventArgs e)
        {
            var tax = _permissionService.GetAll().Where(p => p.Roles == 2).FirstOrDefault();
            txtTax.Text = tax.Tax.ToString();
        }

        private void txtNewEmp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, txtTax.Text, 11);
        }

    }
}
