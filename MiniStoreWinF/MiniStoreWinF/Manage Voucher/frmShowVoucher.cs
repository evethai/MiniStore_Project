using Microsoft.Office.Interop.Excel;
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

namespace MiniStoreWinF.Manage_Voucher
{
    public partial class frmShowVoucher : Form
    {
        VoucherService _voucherService = new VoucherService();
        private int rowIndex { get; set; }
        Validation valid = new Validation();
        public frmShowVoucher()
        {
            InitializeComponent();



            var voucher = _voucherService.GetAll();
            dgvVoucher.DataSource = new BindingSource() { DataSource = voucher };


        }

        //Double click to get data of voucher
        private void dgvVoucher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _voucherService = new VoucherService();
            pnVoucher.Visible = true;
            lbAnnou.Visible = true;
            try
            {
                var name = dgvVoucher[0, e.RowIndex].Value;
                var voucher = _voucherService.GetAll().Where(entity => entity.Name.Equals(name)).FirstOrDefault();

                if (rdExpired.Checked)
                {
                    voucher = _voucherService.GetAll().Where(e => e.Exp < DateTime.Now && e.Name.Equals(name)).FirstOrDefault();
                    rowIndex = e.RowIndex;
                    if (voucher != null)
                    {
                        txtID.Text = voucher.IdVoucher.ToString();
                        txtName.Text = voucher.Name;
                        txtPrice.Text = voucher.Price.ToString();
                        txtQuantity.Text = voucher.Quantity.ToString();
                        lbPrice.Text = txtPrice.Text;
                        lbName.Text = voucher.Name;
                        lbDate.Text = voucher.Exp.ToString();
                        dpkEXP.Text = voucher.Exp.ToString();


                    }
                }
                else if (rdInUse.Checked)
                {
                    voucher = _voucherService.GetAll().Where(e => e.Exp > DateTime.Now && e.Name.Equals(name)).FirstOrDefault();
                    rowIndex = e.RowIndex;
                    if (voucher != null)
                    {
                        txtID.Text = voucher.IdVoucher.ToString();
                        txtName.Text = voucher.Name;
                        txtPrice.Text = voucher.Price.ToString();
                        txtQuantity.Text = voucher.Quantity.ToString();
                        lbPrice.Text = txtPrice.Text;
                        lbName.Text = voucher.Name;
                        lbDate.Text = voucher.Exp.ToString();
                        dpkEXP.Text = voucher.Exp.ToString();


                    }
                }


            }
            catch (Exception)
            {

            }
        }

        //First load of form
        private void frmShowVoucher_Load(object sender, EventArgs e)
        {
            pnShow.Visible = false;
            rdInUse.Checked = true;

        }
        //Update voucher and save it
        private void btUpdate_Click(object sender, EventArgs e)
        {

            var data = _voucherService.GetAll().Where(e => e.Exp > DateTime.Now);
            var voucher = _voucherService.GetAll().Where(e => e.IdVoucher.Equals(txtID.Text)).FirstOrDefault();
            if (txtName.Text == "" ||
                txtPrice.Text == "" ||
                txtQuantity.Text == ""

                )
            {
                MessageBox.Show("Please input all information!");
            }
            else if (dpkEXP.Value < DateTime.Now)
            {
                MessageBox.Show("Expire date must higher than now!");
            }
            else
            {
                voucher.Name = txtName.Text;
                voucher.Price = float.Parse(txtPrice.Text);
                voucher.Quantity = int.Parse(txtQuantity.Text);
                voucher.Conditions = float.Parse(numCondition.Text);
                voucher.Exp = dpkEXP.Value;
                var update = voucher;
                DialogResult result = MessageBox.Show("Have you check all update information?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _voucherService.Update(update);
                    dgvVoucher.DataSource = new BindingSource() { DataSource = data };
                    MessageBox.Show("Update successfully!");
                }



            }
        }
        //Create new voucher and save it
        private void button1_Click(object sender, EventArgs e)
        {

            {
                Form frmCreate = new frmCreateNewVoucher();
                frmCreate.ShowDialog();

            }
            var voucherCreate = _voucherService.GetAll().Where(e => e.Exp > DateTime.Now);
            dgvVoucher.DataSource = new BindingSource() { DataSource = voucherCreate };

        }


        //Search Voucher by Name
        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            if (searchName != null)
            {
                var listSearchName = valid.GetName(searchName).Where(e => e.Quantity > 0);
                dgvVoucher.DataSource = new BindingSource() { DataSource = listSearchName };
            }

        }


        //Quantity must Number only
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }
        }
        //Quantity must Number only
        private void txtNewQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }
        }
        //Price number only
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }
        //Price number only
        private void txtNewPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Kiểm tra xem có nhiều hơn một dấu chấm không
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        private void rdInUse_CheckedChanged(object sender, EventArgs e)
        {
            var voucher = _voucherService.GetAll().Where(e => e.Exp > DateTime.Now);
            dgvVoucher.DataSource = new BindingSource() { DataSource = voucher };
        }

        private void rdExpired_CheckedChanged(object sender, EventArgs e)
        {
            var voucher = _voucherService.GetAll().Where(e => e.Exp < DateTime.Now);
            dgvVoucher.DataSource = new BindingSource() { DataSource = voucher };
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmShowVoucher_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pnVoucher_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pbVoucher_Click(object sender, EventArgs e)
        {

            lbAnnou.Text = "*Click to see voucher";
            pbVoucher.Visible = false;
            lbPrice.Visible = false;
            lbName.Visible = false;
            lbDate.Visible = false;
            pnShow.Visible = true;
            pnVoucher.Visible = false;
        }

        private void pnShow_Click(object sender, EventArgs e)
        {
            lbAnnou.Text = "*Click to see detail of voucher";
            pbVoucher.Visible = true;
            lbPrice.Visible = true;
            lbName.Visible = true;
            lbDate.Visible = true;
            pnShow.Visible = false;
            pnVoucher.Visible = true;
        }

        private void pnVoucher_Click(object sender, EventArgs e)
        {
            lbAnnou.Text = "*Click to see voucher";
            pbVoucher.Visible = false;
            lbPrice.Visible = false;
            lbName.Visible = false;
            lbDate.Visible = false;
            pnShow.Visible = true;
        }
    }
}
