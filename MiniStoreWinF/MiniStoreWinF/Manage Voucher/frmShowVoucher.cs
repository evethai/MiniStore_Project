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
            pnShow.Visible = true;
            try
            {
                var name = dgvVoucher[0, e.RowIndex].Value;
                var voucher = _voucherService.GetAll().Where(entity => entity.Name.Equals(name)).FirstOrDefault();

                if (rdExpired.Checked)
                {

                    txtID.Text = voucher.IdVoucher.ToString();
                    txtName.Text = voucher.Name;
                    txtPrice.Text = voucher.Price.ToString();
                    txtQuantity.Text = voucher.Quantity.ToString();
                    //txtType.Text = voucher.Type.ToString();
                    dpkEXP.Text = voucher.Exp.ToString();

                    voucher = _voucherService.GetAll().Where(e => e.Exp < DateTime.Now && e.Name.Equals(name)).FirstOrDefault();
                    rowIndex = e.RowIndex;
                    if (voucher != null)
                    {
                        txtID.Text = voucher.IdVoucher.ToString();
                        txtName.Text = voucher.Name;
                        txtPrice.Text = voucher.Price.ToString();
                        txtQuantity.Text = voucher.Quantity.ToString();
                        txtType.Text = voucher.Type.ToString();
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
                        txtType.Text = voucher.Type.ToString();
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
                txtQuantity.Text == "" ||
                txtType.Text == "")
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
        //Call Create voucher panel
        private void button1_Click(object sender, EventArgs e)
        {

            pnAdd.Visible = true;

        }
        //Create new voucher and save it
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text == "" ||
                txtAddType.Text == "" ||
                txtNewQuantity.Text == "" ||
                txtNewPrice.Text == "")
            {
                MessageBox.Show("Please input all information!");
            }
            else if (dpkNewDate.Value < DateTime.Now)
            {
                MessageBox.Show("Expire date must higher than now!");
            }
            else
            {
                var voucher = new Voucher();

                voucher.Name = txtAddName.Text;
                //voucher.Type = txtAddType.Text;
                voucher.Exp = dpkNewDate.Value;
                voucher.Price = float.Parse(txtNewPrice.Text);
                voucher.Quantity = int.Parse(txtNewQuantity.Text);
                DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Validation createVoucher = new Validation();
                    createVoucher.Add(voucher);
                    MessageBox.Show("Create voucher successfully!");

                }
                else
                {

                }

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
    }
}
