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

namespace MiniStoreWinF.ManageMember
{
    public partial class frmCreateMember : Form
    {

        public frmCreateMember()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            MemberService _memberservice = new MemberService();

            if (txtPhone.Text == "" ||
                txtPoint.Text == "" ||
                txtName.Text == "")
            {
                MessageBox.Show("Please input all fiels information!");
            }
            else
            {
                var member = new Member();
                member.PhoneMember = txtPhone.Text.Trim();
                member.Point = int.Parse(txtPoint.Text);
                member.Name = txtName.Text.Trim();
                member.Gender = cbGender.Text;
                member.DoB = dtDoB.Value;
                DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    _memberservice.Create(member);
                   
                }
            }
        }

    }
}
