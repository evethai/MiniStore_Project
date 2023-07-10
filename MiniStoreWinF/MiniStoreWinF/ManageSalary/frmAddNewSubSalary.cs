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
        DetailSubSalaryService _detailSubSalaryService;
        Utinity u = new Utinity();
        public frmAddNewSubSalary()
        {
            InitializeComponent();
            _detailSubSalaryService = new DetailSubSalaryService();
        }

        //button click to add new 
        private void btOKEdit_Click(object sender, EventArgs e)
        {
            double subSalary;
            if (txtDis.Text == null || !double.TryParse(txtSalary.Text, out subSalary))
            {
                MessageBox.Show("Can not empty Discribe", "Messages", MessageBoxButtons.OK);
                txtDis.Focus();
                return;
            }
            else if (dtpEffect.Value<DateTime.Now)
            {
                MessageBox.Show("Time effect need from to day", "Messages", MessageBoxButtons.OK);
                dtpEffect.Value=DateTime.Now;
                return;
            }
            else
                    {
                        _detailSubSalaryService = new DetailSubSalaryService();
                        DetailSubSalary detailSubSalary = new DetailSubSalary();
                        int n = _detailSubSalaryService.GetAll().Count();
                        detailSubSalary.IdDetailSubSalary = u.GenerateAutoId(n, "SUB");

                        var Sub = _detailSubSalaryService.GetAll().Count(p => p.IdDetailSubSalary.Equals(detailSubSalary.IdDetailSubSalary));
                        if (Sub > 0)
                        {
                            n = n + 1;
                        }
                        else
                        {
                            detailSubSalary.DescriptionA = txtDis.Text;
                            detailSubSalary.SubsidiesSalary = subSalary;
                            detailSubSalary.Condition = Int32.Parse(cbCondi.Text);
                            detailSubSalary.ActiveSub = true;
                            detailSubSalary.DateCreate = DateTime.Now;
                            detailSubSalary.DateEffect = dtpEffect.Value;
                            _detailSubSalaryService.Create(detailSubSalary);
                            MessageBox.Show("Add successfull", "Message", MessageBoxButtons.OK);

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }


                    }
        }

        private void frmAddNewSubSalary_Load(object sender, EventArgs e)
        {
            u.comboxGeneration(cbCondi, 30);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, txtSalary.Text, 9);
        }
    }
}
