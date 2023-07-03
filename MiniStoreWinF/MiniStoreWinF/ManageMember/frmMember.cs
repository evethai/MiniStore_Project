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
using static Azure.Core.HttpHeader;

namespace MiniStoreWinF.ManageMember
{
    public partial class frmMember : Form
    {
        MemberService _memberservice = new MemberService();
        private int rowIndex { get; set; }

        public frmMember()
        {
            InitializeComponent();
            var memberservice = _memberservice.GetAll();

            dgvMember.DataSource = new BindingSource() { DataSource = memberservice };
        }

        private void CreateMember_Load(object sender, EventArgs e)
        {
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            // this.Close();
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Close();
            else if (result == DialogResult.No)
                MessageBox.Show("Tiếp tục thao tác");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            Form createMember = new frmCreateMember();
            createMember.ShowDialog();
            var memberCreate = _memberservice.GetAll();
            dgvMember.DataSource = new BindingSource() { DataSource = memberCreate };


        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            var nameSe = _memberservice.GetAll().ToList().Where(e => e.Name.Trim().Contains(txtSearch.Text.Trim()) || e.PhoneMember.Contains(txtSearch.Text));
            if (nameSe != null)
            {
                dgvMember.DataSource = new BindingSource() { DataSource = nameSe };
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            var memberservice = _memberservice.GetAll().Where(e => e.PhoneMember.Equals(txtPhone.Text.Trim())).FirstOrDefault();
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Please input your phone!!!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Have you check all information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    memberservice.Point = int.Parse(txtPoint.Text);
                    memberservice.Name = txtName.Text;
                    memberservice.PhoneMember = txtPhone.Text.Trim();

                    _memberservice.Update(memberservice);
                    var memberUpdate = _memberservice.GetAll();
                    dgvMember.DataSource = new BindingSource() { DataSource = memberUpdate };

                }
                else
                {
                    return;
                }


            }


        }

        private void txtLoad_Click(object sender, EventArgs e)
        {
            var ListProduct = _memberservice.GetAll().ToList();
            dgvMember.DataSource = new BindingSource() { DataSource = ListProduct };
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var phone = dgvMember[0, e.RowIndex].Value;
                var showMem = _memberservice.GetAll().Where(p => p.PhoneMember.Equals(phone)).FirstOrDefault();
                rowIndex = e.RowIndex;
                if (showMem != null)
                {
                    txtPhone.Text = showMem.PhoneMember.ToString();
                    txtPoint.Text = showMem.Point.ToString();
                    txtName.Text = showMem.Name.ToString();
                    cbGender.Text = showMem.Gender.ToString();
                    dtDoB.Text = showMem.DoB.ToString();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Cannot continue input
                }

                // Kiểm tra giới hạn độ dài của chuỗi
                if (txtPhone.Text.Length >= 10 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Cannot continue input
                }

                // Kiểm tra việc bắt đầu với số 0
                if (txtPhone.Text.Length == 0 && e.KeyChar != '0')
                {
                    e.Handled = true; // Cannot continue input
                }

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

