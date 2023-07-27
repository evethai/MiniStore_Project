using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MiniStoreWinF.ManageSalary;
namespace MiniStoreWinF.InformationEmployee
{
    public partial class frmInformationMain : Form
    {
        Utinity u = new Utinity();

        public frmInformationMain()
        {
            InitializeComponent();
            CheckColor(pbInformation);
            frmInformationEmp frmInformationEmp = new frmInformationEmp();
            u.openChildForm(frmInformationEmp, tlMain);
        }
        private void CheckColor(PictureBox pictureBox)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is PictureBox)
                {
                    if (control == pictureBox)
                    {
                        control.BackColor = Color.PowderBlue;
                    }
                    else
                    {
                        control.BackColor = Color.White;
                    }
                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CheckColor(pbInformation);
            frmInformationEmp frmInformationEmp = new frmInformationEmp();
            u.openChildForm(frmInformationEmp, tlMain);

        }

        private void pbSalary_Click(object sender, EventArgs e)
        {
            CheckColor(pbSalary);
            frmLastMonthSalary frmLastMonthSalary = new frmLastMonthSalary();
            u.openChildForm(frmLastMonthSalary, tlMain);
        }


        private void btworksheet_Click(object sender, EventArgs e)
        {
            CheckColor(btworksheet);
            frmLastMonthWorksheet frmLastMonthWorksheet = new frmLastMonthWorksheet();
            u.openChildForm(frmLastMonthWorksheet, tlMain);
        }
    }
}
