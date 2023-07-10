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

namespace MiniStoreWinF.ManageSalary
{

    public partial class frmEditEachSalary : Form
    {
        PermissionService _permissionService;
        Utinity u = new Utinity();
        public frmEditEachSalary()
        {
            InitializeComponent();
            _permissionService = new PermissionService();

        }

        private void frmEditEachSalary_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + " " + ContextScope.saPer.Permission1;
            txtSalary.Text = ContextScope.saPer.BasicSalary.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (ContextScope.saPer.BasicSalary.ToString() != txtSalary.Text)
            {
                var emp = _permissionService.GetAll().Where(p => p.Roles == ContextScope.saPer.Roles).FirstOrDefault();
                if (emp != null)
                {
                    emp.BasicSalary = Double.Parse(txtSalary.Text);
                }
                _permissionService.Update(emp);

                notiSave.BalloonTipText = "Save Successfull";
                notiSave.BalloonTipTitle = "Change Success";
                notiSave.Icon = SystemIcons.Hand;
                notiSave.ShowBalloonTip(1000);
                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            else
            {
                MessageBox.Show("Not Change!!!", "Messages", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void txtNewGuard_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, txtSalary.Text, 9);
        }
    }
}
