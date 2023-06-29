﻿using Repository.Models;
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
        public string oldTaxEmp;
        public string oldTaxGuard;
        Utinity u = new Utinity();
        public frmEditEachTax()
        {
            InitializeComponent();
            _permissionService = new PermissionService();

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (oldTaxEmp != txtNewEmp.Text || oldTaxGuard != txtNewGuard.Text)
            {
                var emp = _permissionService.GetAll().Where(p => p.Roles == 2).FirstOrDefault();
                if (emp != null)
                {
                    emp.Tax = Double.Parse(txtNewEmp.Text);
                }
                _permissionService.Update(emp);

                //
                var guard = _permissionService.GetAll().Where(p => p.Roles == 3).FirstOrDefault();
                if (guard != null)
                {
                    guard.Tax = Double.Parse(txtNewGuard.Text);
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

        private void frmEditEachTax_Load(object sender, EventArgs e)
        {
            txtNewEmp.Text = oldTaxEmp;
            txtNewGuard.Text = oldTaxGuard;
        }

        private void txtNewEmp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, txtNewEmp.Text, 11);
        }

        private void txtNewGuard_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, txtNewGuard.Text, 11);
        }
    }
}
