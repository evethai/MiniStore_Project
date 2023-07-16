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
        SubSalaryService _subSalaryService;

        public frmEditSubSalary()
        {
            InitializeComponent();

            _subSalaryService = new SubSalaryService();

        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            string type;
            if (cbType.SelectedItem.ToString() == "Day")
            {
                type = "D";
            }
            else
            {
                type = "M";
            }
            double subSalary;
            string id = ContextScope.currentSubSalary.IdSub;
            if (txtDis.Text == null || !double.TryParse(txtSalary.Text, out subSalary))
            {
                MessageBox.Show("Can not empty Discribe", "Messages", MessageBoxButtons.OK);
                txtDis.Focus();
                return;
            }
            else if (dtpEffect.Value < DateTime.Now)
            {
                MessageBox.Show("Need set time effect more than to day", "Messages", MessageBoxButtons.OK);
                return;
            }
            else
            {
                _subSalaryService = new SubSalaryService();
                var detailSub = _subSalaryService.GetAll().Where(p => p.IdSub.Equals(id)).FirstOrDefault();
                if (detailSub != null)
                {
                    detailSub.Describe = txtDis.Text;
                    detailSub.Money = subSalary;
                    detailSub.Type = type;
                    detailSub.Condition = Int32.Parse(cbCondi.Text);
                    detailSub.TimeEnd = dtpEffect.Value;
                }
                _subSalaryService.Update(detailSub);
                MessageBox.Show("Update successfull", "Message", MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            string id = ContextScope.currentSubSalary.IdSub;
            DialogResult result = MessageBox.Show("Remove SubSalary!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var sub_salary = _subSalaryService.GetAll().Where(p => p.IdSub.Equals(id)).FirstOrDefault();
                if (sub_salary != null)
                {
                    sub_salary.IsActive = false;
                    _subSalaryService.Update(sub_salary);
                    MessageBox.Show("Remove Subsitive Salary " + sub_salary.Describe, "Messages");
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
            txtDis.Text = ContextScope.currentSubSalary.Describe.Trim().ToString();
            txtSalary.Text = ContextScope.currentSubSalary.Money.ToString();
            cbCondi.Text = ContextScope.currentSubSalary.Condition.ToString();
            dtpEffect.Text = ContextScope.currentSubSalary.TimeEnd.ToString();

            List<string> type = new List<string>();
            type.Add("Day");
            type.Add("Month");
            cbType.DataSource = type;
            //
            List<int> num = new List<int>();
            for (int i = 1; i <= 30; i++)
            {
                num.Add(i);
            }
            cbCondi.DataSource = num;


            if (ContextScope.currentSubSalary.Type.Equals("M"))
            {
                cbType.SelectedIndex = 1;
                cbCondi.SelectedItem = ContextScope.currentSubSalary.Condition;
            }
            else
            {
                cbType.SelectedIndex = 0;
            }



        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự không hợp lệ
                e.Handled = true;
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem.ToString() == "Day")
            {
                cbCondi.Enabled = false;
                cbCondi.Text = "1";
            }
            else
            {
                cbCondi.Enabled = true;
            }
        }
    }
}
