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
        public string oldEmpSalary;
        public string oldGuardSalary;
        Utinity u = new Utinity();
        public frmEditEachSalary()
        {
            InitializeComponent();
        }

        private void frmEditEachSalary_Load(object sender, EventArgs e)
        {
            txtNewEmp.Text = oldEmpSalary;
            txtNewGuard.Text = oldGuardSalary;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _permissionService = new PermissionService();
            if (oldEmpSalary != txtNewEmp.Text || oldGuardSalary != txtNewGuard.Text)
            {
                var emp = _permissionService.GetAll().Where(p => p.Roles == 2).FirstOrDefault();
                if (emp != null)
                {
                    emp.BasicSalary = Double.Parse(txtNewEmp.Text);
                }
                _permissionService.Update(emp);

                //
                var guard = _permissionService.GetAll().Where(p => p.Roles == 3).FirstOrDefault();
                if (guard != null)
                {
                    guard.BasicSalary = Double.Parse(txtNewGuard.Text);
                }
                _permissionService.Update(guard);

                //MessageBox.Show("Save Successfull.", "messages", MessageBoxButtons.OK);
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

        private void txtNewEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, txtNewEmp.Text, 9);
        }

        private void txtNewGuard_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, txtNewGuard.Text, 9);
        }
    }
}
