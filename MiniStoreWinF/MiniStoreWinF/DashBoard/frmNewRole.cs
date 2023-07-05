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
            Permission per = new Permission();
            if (txtRole.Text.Trim().Length > 0)
            {
                int n = 0;
                per.Permission1 = txtRole.Text.Trim().ToUpper();
                per.Tax = 0;
                per.BasicSalary = 0;
                var sum = _permissionService.GetAll().Last();
                if (sum != null)
                {
                    per.Roles = sum.Roles + 1;
                    n = sum.Roles + 1;
                }
                _permissionService.Create(per);


                var PerDetail = _permissionDetailService.GetAll().Where(p => p.IdPer == 0).ToList();
                foreach (var item in PerDetail)
                {
                    PermissionDetail permissionDetail = new PermissionDetail();
                    permissionDetail.IdPer = n;
                    permissionDetail.ActionName = item.ActionName;
                    permissionDetail.ActionCode = item.ActionCode;
                    permissionDetail.CheckAction = false;
                    _permissionDetailService.Create(permissionDetail);
                }
                MessageBox.Show("Add new Successful","Messages",MessageBoxButtons.OK);
                ContextScope.newPermission = per;
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
