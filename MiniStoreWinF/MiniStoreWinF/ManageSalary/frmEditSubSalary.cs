using Microsoft.VisualBasic;
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
    public partial class frmEditSubSalary : Form
    {
        DetailSubSalaryService _detailSubSalaryService;

        public frmEditSubSalary()
        {
            InitializeComponent();

            _detailSubSalaryService = new DetailSubSalaryService();

        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            double subSalary;
            string id = ContextScope.currentSubSalary.IdDetailSubSalary;
            if (txtDis.Text == null || !double.TryParse(txtSalary.Text, out subSalary))
            {
                MessageBox.Show("Can not empty Discribe", "Messages", MessageBoxButtons.OK);
            }
            else
            {
                _detailSubSalaryService = new DetailSubSalaryService();
                //
                var detailSub = _detailSubSalaryService.GetAll().Where(p => p.IdDetailSubSalary.Equals(id)).FirstOrDefault();
                if (detailSub != null)
                {
                    detailSub.DescriptionA = txtDis.Text;
                    detailSub.SubsidiesSalary = subSalary;
                    detailSub.Condition = Int32.Parse(cbCondi.Text);
                }
                _detailSubSalaryService.Update(detailSub);
                MessageBox.Show("Update successfull", "Message", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            string id = ContextScope.currentSubSalary.IdDetailSubSalary;
            DialogResult result = MessageBox.Show("Remove SubSalary!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var sub_salary = _detailSubSalaryService.GetAll().Where(p => p.IdDetailSubSalary.Equals(id)).FirstOrDefault();
                if (sub_salary != null)
                {
                    sub_salary.ActiveSub = false;
                    _detailSubSalaryService.Update(sub_salary);
                    MessageBox.Show("Remove Subsitive Salary " + sub_salary.DescriptionA, "Messages");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }


        private void frmEditSubSalary_Load(object sender, EventArgs e)
        {
            txtDis.Text = ContextScope.currentSubSalary.DescriptionA;
            txtSalary.Text = ContextScope.currentSubSalary.SubsidiesSalary.ToString();
            cbCondi.Text = ContextScope.currentSubSalary.Condition.ToString();
            //
            List<int> num = new List<int>();
            for (int i = 0; i <= 30; i++)
            {
                num.Add(i);
            }
            cbCondi.DataSource = num;
        }

        private void txtSalary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự không hợp lệ
                e.Handled = true;
            }
        }
    }
}
