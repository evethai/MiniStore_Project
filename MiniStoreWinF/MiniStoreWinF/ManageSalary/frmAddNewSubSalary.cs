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
    public partial class frmAddNewSubSalary : Form
    {
        SubSalaryService _subSalaryService;
        Utinity u = new Utinity();
        public frmAddNewSubSalary()
        {
            InitializeComponent();
        }

        //button click to add new 
        private void btOKEdit_Click(object sender, EventArgs e)
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
            _subSalaryService = new SubSalaryService();
            double ss;
            if (txtDis.Text == "" || !double.TryParse(txtSalary.Text, out ss))
            {
                MessageBox.Show("Can not empty Discribe", "Messages", MessageBoxButtons.OK);
                txtDis.Focus();
                return;
            }
            else if (dtpEffect.Value < DateTime.Now)
            {
                MessageBox.Show("Time effect need from to day", "Messages", MessageBoxButtons.OK);
                dtpEffect.Value = DateTime.Now;
                return;
            }
            else
            {
                SubSalary subSalary = new SubSalary();
                int n = _subSalaryService.GetAll().Count();
                subSalary.IdSub = u.GenerateAutoId(n, "SUB");

                var Sub = _subSalaryService.GetAll().Count(p => p.IdSub.Equals(subSalary.IdSub));
                if (Sub > 0)
                {
                    n = n + 1;
                }
                else
                {
                    subSalary.Describe = txtDis.Text;
                    subSalary.Money = ss;
                    subSalary.Condition = Int32.Parse(cbCondi.Text);
                    subSalary.Type = type;
                    subSalary.IsActive = true;
                    subSalary.TimeBegin = DateTime.Now;
                    subSalary.TimeEnd = dtpEffect.Value;
                    _subSalaryService.Create(subSalary);
                    MessageBox.Show("Add successfull", "Message", MessageBoxButtons.OK);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }


            }
        }

        private void frmAddNewSubSalary_Load(object sender, EventArgs e)
        {
            u.comboxGeneration(cbCondi, 30);
            List<string> type = new List<string>();
            type.Add("Day");
            type.Add("Month");
            cbType.DataSource = type;
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, txtSalary.Text, 9);
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
