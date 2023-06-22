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

namespace MiniStoreWinF.ManageSalary
{
    public partial class frmAddNewAdvSalary : Form
    {
        DetailAdvanceSalaryService _detailAdvanceSalaryService;
        Utinity u = new Utinity();

        public frmAddNewAdvSalary()
        {
            InitializeComponent();

        }

        //nhấn button để lưu kết quả add new 
        private void BtOK_Click(object sender, EventArgs e)
        {

            double salary;
            if (txtDis.Text == null || !Double.TryParse(txtTotal.Text, out salary))
            {
                MessageBox.Show("No Value In Here!!!", "Message", MessageBoxButtons.OK);
            }
            else
            {
                _detailAdvanceSalaryService = new DetailAdvanceSalaryService();
                DetailAdvanceSalary detailAdvanceSalary = new DetailAdvanceSalary();
                int n = _detailAdvanceSalaryService.GetAll().Count();
                detailAdvanceSalary.IdAdvanceSalary = u.GenerateAutoId(n, "ADV");//auto tạo ID
                //
                var adv = _detailAdvanceSalaryService.GetAll().Count(p => p.IdAdvanceSalary.Equals(detailAdvanceSalary.IdAdvanceSalary));
                if (adv > 0)
                {
                    n = n + 1;//check id đã tồn tại
                }
                else
                {
                    detailAdvanceSalary.IdEmp = cbName.SelectedValue.ToString();
                    detailAdvanceSalary.DescriptionA = txtDis.Text;
                    detailAdvanceSalary.AdvanceSalary = salary;
                    detailAdvanceSalary.DateAs = dtpDate.Value;
                    _detailAdvanceSalaryService.Create(detailAdvanceSalary);//add to data base
                    MessageBox.Show("Add Susseccful.", "Message", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;//xác nhận form  
                    this.Close();//đống form 
                }
                //

            }

        }

        private void frmAddNewAdvSalary_Load(object sender, EventArgs e)
        {
            u.showListEmp(cbName);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, txtTotal.Text, 9);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
