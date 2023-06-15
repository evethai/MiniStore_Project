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

        }

        //button click to add new 
        private void btOKEdit_Click(object sender, EventArgs e)
        {
            _detailSubSalaryService = new DetailSubSalaryService();
            double subSalary;
            if (txtDis.Text == null || !double.TryParse(txtSalary.Text, out subSalary))
            {
                MessageBox.Show("Can not empty Discribe", "Messages", MessageBoxButtons.OK);
            }
            else
            {
                _detailSubSalaryService = new DetailSubSalaryService();
                DetailSubSalary detailSubSalary = new DetailSubSalary();
                int n = _detailSubSalaryService.GetAll().Count();
                detailSubSalary.IdDetailSubSalary = u.GenerateAutoId(n, "SUB");
                
                var Sub = _detailSubSalaryService.GetAll().Count(p=>p.IdDetailSubSalary.Equals(detailSubSalary.IdDetailSubSalary));
                if(Sub > 0)
                {
                    n = n + 1;
                }
                else
                {
                    detailSubSalary.DescriptionA = txtDis.Text;
                    detailSubSalary.SubsidiesSalary = subSalary;
                    detailSubSalary.Condition = Int32.Parse(cbCondi.Text);
                    detailSubSalary.ActiveSub = true;
                    _detailSubSalaryService.Create(detailSubSalary);
                    MessageBox.Show("Add successfull", "Message", MessageBoxButtons.OK);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                

            }
        }

        private void frmAddNewSubSalary_Load(object sender, EventArgs e)
        {
            List<int> num = new List<int>();
            for (int i = 0; i <= 30; i++)
            {
                num.Add(i);
            }
            cbCondi.DataSource = num;
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e,txtSalary.Text);
        }
    }
}
