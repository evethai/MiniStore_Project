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

        private void label10_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmShowVoucher_Load(object sender, EventArgs e)
        {
            pnShow.Visible = false;

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            var data = _voucherService.GetAll();
            var voucher = _voucherService.GetAll().Where(e => e.IdVoucher.Equals(int.Parse(txtID.Text))).FirstOrDefault();
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


                _voucherService.Update(update);
                dgvVoucher.DataSource = new BindingSource() { DataSource = data };


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pnAdd.Visible = true;

        }

        private void dgvVoucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    VoucherService voucherService = new VoucherService();
                    voucherService.Create(voucher);
                    MessageBox.Show("Create voucher successfully!");

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
            if(searchName != null )
            {
                var listSearchName = valid.GetName(searchName).Where(e => e.Quantity > 0);
                dgvVoucher.DataSource = new BindingSource() { DataSource = listSearchName };
            } 

        }
    }
}
