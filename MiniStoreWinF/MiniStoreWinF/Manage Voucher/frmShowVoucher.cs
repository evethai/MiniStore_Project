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
        Validation voucherService = new Validation();
        public frmShowVoucher()
        {
            InitializeComponent();
            if (rdExpired.Checked == false)
            {
                var voucher = _voucherService.GetAll().Where(e => e.Exp > DateTime.Now);
                dgvVoucher.DataSource = new BindingSource() { DataSource = voucher };
            }
            else if (rdExpired.Checked == true)
            {
                var voucher = _voucherService.GetAll().Where(e => e.Exp < DateTime.Now);
                dgvVoucher.DataSource = new BindingSource() { DataSource = voucher };
            }

        }

        private void dgvVoucher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _voucherService = new VoucherService();
            pnShow.Visible = true;
            try
            {
                var name = dgvVoucher[0, e.RowIndex].Value;

                var voucher = _voucherService.GetAll().Where(entity => entity.Name.Equals(name)).FirstOrDefault();
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
            catch (Exception)
            {

            }
        }
        private void frmShowVoucher_Load(object sender, EventArgs e)
        {
            pnShow.Visible = false;
            rdCanUse.Checked = true;

        }

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
            else
            {
                voucher.Name = txtName.Text;
                voucher.Price = float.Parse(txtPrice.Text);
                voucher.Quantity = int.Parse(txtQuantity.Text);
                voucher.Exp = dpkEXP.Value;
                var update = voucher;
                DialogResult result = MessageBox.Show("Have you check all information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _voucherService.Update(update);
                    dgvVoucher.DataSource = new BindingSource() { DataSource = data };
                    MessageBox.Show("Update Successfully");
                }
                else
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pnAdd.Visible = true;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text == "" ||
                txtAddType.Text == "" ||
                txtNewQuantity.Text == "" ||
                txtNewPrice.Text == "")
            {
                MessageBox.Show("Please input all information!");
            }
            else
            {
                var voucher = new Voucher();

                voucher.Name = txtAddName.Text;
                voucher.Type = txtAddType.Text;
                voucher.Exp = dpkNewDate.Value;
                voucher.Price = float.Parse(txtNewPrice.Text);
                voucher.Quantity = int.Parse(txtNewQuantity.Text);
                DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    voucherService.Add(voucher);
                    MessageBox.Show("Create voucher successfully!");
                    txtAddName.Text = "";
                    txtAddType.Text = "";
                    txtNewQuantity.Text = "";
                    txtNewPrice.Text = "";
                }
                else
                {

                }

            }
            var voucherCreate = _voucherService.GetAll();
            dgvVoucher.DataSource = new BindingSource() { DataSource = voucherCreate };
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            if (searchName != null)
            {
                var listSearchName = voucherService.GetName(searchName).Where(e => e.Quantity > 0);
                dgvVoucher.DataSource = new BindingSource() { DataSource = listSearchName };
            }

        }

        private void rdExpired_CheckedChanged(object sender, EventArgs e)
        {
            if (rdExpired.Checked == false)
            {
                var voucher = _voucherService.GetAll().Where(e => e.Exp > DateTime.Now);
                dgvVoucher.DataSource = new BindingSource() { DataSource = voucher };
            }
            else if (rdExpired.Checked == true)
            {
                var voucher = _voucherService.GetAll().Where(e => e.Exp < DateTime.Now);
                dgvVoucher.DataSource = new BindingSource() { DataSource = voucher };
            }
        }


        private void rdCanUse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCanUse.Checked == true)
            {
                var voucher = _voucherService.GetAll().Where(e => e.Exp > DateTime.Now);
                dgvVoucher.DataSource = new BindingSource() { DataSource = voucher };
            }
            else if (rdCanUse.Checked == false)
            {
                var voucher = _voucherService.GetAll().Where(e => e.Exp < DateTime.Now);
                dgvVoucher.DataSource = new BindingSource() { DataSource = voucher };
            }
        }
    }
}
