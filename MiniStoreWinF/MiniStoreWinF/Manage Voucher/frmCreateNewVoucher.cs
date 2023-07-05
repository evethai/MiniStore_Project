using Repository.Models;
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
    public partial class frmCreateNewVoucher : Form
    {
        public frmCreateNewVoucher()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text == "" ||

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
                var codeVoucher = new CodeVoucher();

                voucher.Name = txtAddName.Text;

                voucher.Conditions = float.Parse(numAddCondition.Text);



                voucher.Exp = dpkNewDate.Value;
                voucher.Price = float.Parse(txtNewPrice.Text);
                voucher.Quantity = int.Parse(txtNewQuantity.Text);
                DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Validation createVoucher = new Validation();
                    createVoucher.AddNewVoucher(voucher);
                    MessageBox.Show("Create voucher successfully!");
                    for (int i = 0; i < int.Parse(txtNewQuantity.Text); i++)
                    {
                        codeVoucher.QuantityValue = 1;
                        codeVoucher.StatusV = true;
                        codeVoucher.IdVoucher = voucher.IdVoucher;
                        createVoucher.AddNewEachVoucher(codeVoucher);
                        this.Close();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

