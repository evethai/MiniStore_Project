using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniStoreWinF.ManageSalary;
namespace MiniStoreWinF.InformationEmployee
{
    public partial class frmInformationMain : Form
    {
        Utinity u = new Utinity();

        public frmInformationMain()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInformationEmp frmInformationEmp = new frmInformationEmp();
            u.openChildForm(frmInformationEmp, tlMain);

        }

        private void pbSalary_Click(object sender, EventArgs e)
        {
            frmLastMonthSalary frmLastMonthSalary = new frmLastMonthSalary();
            u.openChildForm(frmLastMonthSalary, tlMain);
        }
    }
}
