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

namespace MiniStoreWinF.DashBoard
{
    public partial class frmNewRole : Form
    {
        PermissionDetailService _permissionDetailService;
        PermissionService _permissionService;
        public frmNewRole()
        {
            InitializeComponent();
            _permissionDetailService = new PermissionDetailService();
            _permissionService = new PermissionService();

        }
        private void buOk_Click(object sender, EventArgs e)
        {
            Permission p = new Permission();
            if (txtRole.Text.Trim().Length > 0)
            {
                int n = 0;
                p.Permission1 = txtRole.Text.Trim().ToUpper();
                p.Tax = 0;
                p.BasicSalary = 0;
                var sum = _permissionService.GetAll().Last();
                if (sum != null)
                {
                    p.Roles = sum.Roles + 1;
                    n = sum.Roles + 1;
                }
                _permissionService.Create(p);


                var PerDetail = _permissionDetailService.GetAll().Where(p => p.IdPer == 0).ToList();
                foreach (var per in PerDetail)
                {
                    PermissionDetail permissionDetail = new PermissionDetail();
                    permissionDetail.IdPer = n;
                    permissionDetail.ActionName = per.ActionName;
                    permissionDetail.ActionCode = per.ActionCode;
                    permissionDetail.CheckAction = false;
                    _permissionDetailService.Create(permissionDetail);
                }
                MessageBox.Show("Add new Successful", "Messages", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter new Role");
                txtRole.Focus();
            }
        }
    }
}
