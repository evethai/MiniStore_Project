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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniStoreWinF.OrdersProducts
{
    public partial class frmMemberCheck : Form
    {

        MemberService _memberService = new MemberService();

        public frmMemberCheck()
        {
            InitializeComponent();
            cbGenderNewMember.Items.Add("Male");
            cbGenderNewMember.Items.Add("Female");
        }
        public string TextBoxValue
        {
            get { return txtSearchMember.Text; }
        }
        public string TextBoxValueMemberNew
        {
            get { return txtPhoneNewMember.Text; }
        }
        private void btCheckPhoneMember_Click(object sender, EventArgs e)
        {
            string _phoneMember = txtSearchMember.Text;
            var checkMember = _memberService.GetAll().Where(p => p.PhoneMember.Equals(_phoneMember)).FirstOrDefault();
            if (txtSearchMember.Text == "")
            {
                MessageBox.Show("Wrong format Phone number !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkMember != null)
            {
                dgvListMember.Visible = true;
                dgvListMember.DataSource = new BindingSource()
                {
                    DataSource = checkMember
                };
            }
            else if (checkMember == null)
            {
                MessageBox.Show("You aren't already a member", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Check Member ==> OK
        private void btCreateMember_Click(object sender, EventArgs e)
        {
            pnlCreateMember.Visible = true;
        } // Create Member Page=> OK
        private void btCloseMemberCheck_Click(object sender, EventArgs e)
        {
            CloseTest();
        }
        public void CloseTest()
        {
            DialogResult comback = MessageBox.Show("Do you want to Close Check Member", "Notification", MessageBoxButtons.YesNo);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        private void btCreateSusscessMember_Click(object sender, EventArgs e)
        {
            var newMember = new Member();
            string _phoneMember = txtPhoneNewMember.Text;
            string _NameMember = txtNameNewMember.Text;
            string _GenderMember = cbGenderNewMember.SelectedItem.ToString();
            var _DoBMember = dtDoBNewMember.Text;
            int _pointUsing = 0;
            DateTime _dateUsing = DateTime.Now;
            var checkMember = _memberService.GetAll().Where(p => p.PhoneMember.Equals(_phoneMember)).FirstOrDefault();
            bool nonLetterInPhone = false;
            foreach (char c in txtPhoneNewMember.Text)
            {
                if (Char.IsLetter(c))
                {
                    nonLetterInPhone = true;
                    break;
                }
            }
            if (nonLetterInPhone || txtPhoneNewMember.Text == "" || txtPhoneNewMember.TextLength > 10 || _NameMember == "")
            {
                MessageBox.Show("Wrong format to create Member !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkMember != null)
                {
                    MessageBox.Show("You are already a member", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvListMember.Visible = true;
                    dgvListMember.DataSource = new BindingSource()
                    {
                        DataSource = checkMember
                    };
                }
                else
                {
                    newMember.Name = _NameMember;
                    newMember.Gender = _GenderMember;
                    newMember.PhoneMember = _phoneMember;
                    newMember.Point = _pointUsing;
                    newMember.DoB = DateTime.Parse(_DoBMember);
                    newMember.TimeCreate = _dateUsing;
                    _memberService.Create(newMember);
                    MessageBox.Show("Create Successfully !", "Notification", MessageBoxButtons.OK);
                }
            }
        }
    }
}
