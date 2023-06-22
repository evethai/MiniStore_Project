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
    public partial class CreateMember : Form
    {
        MemberService _memberservice = new MemberService();
        private int rowIndex { get; set; }

        public CreateMember()
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
            if (txtPhone.Text == "" ||
                txtPoint.Text == "" ||
                txtName.Text == "")
            {
                MessageBox.Show("Please input all fiels information!");
            }
            else
            {
                var member = _memberservice.GetAll().ToList().FirstOrDefault();
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

        private void btSearch_Click(object sender, EventArgs e)
        {
            String _name = txtSearch.Text;
            var nameSe = _memberservice.GetAll().ToList().Where(e => e.Name.Trim().ToUpper().StartsWith(_name.Trim().ToUpper()));
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
                memberservice.Point = int.Parse(txtPoint.Text);
                _memberservice.Update(memberservice);
            }
            dgvMember.DataSource = new BindingSource() { DataSource = memberservice };

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var removeMem = _memberservice.GetAll().Where(e => e.PhoneMember.Equals(txtPhone.Text.Trim())).FirstOrDefault();
            if (removeMem != null)
            {
                _memberservice.Delete(removeMem);   
            }
            dgvMember.DataSource = new BindingSource() { DataSource = removeMem };
        }

        private void txtLoad_Click(object sender, EventArgs e)
        {
            var ListProduct = _memberservice.GetAll().ToList();
            dgvMember.DataSource = new BindingSource() { DataSource = ListProduct };
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var phone = dgvMember[0, e.RowIndex].ToString();
            var showMem = _memberservice.GetAll().Where(p => p.PhoneMember.Equals(txtPhone.Text.Trim())).FirstOrDefault();
            rowIndex = e.RowIndex;
            if(showMem != null)
            {
                txtPhone.Text = showMem.PhoneMember.ToString();
                txtPoint.Text = showMem.Point.ToString();
                txtName.Text = showMem.Name.ToString();
                cbGender.Text  = showMem.Gender.ToString(); 
                dtDoB.Text = showMem.DoB.ToString();
            }
        }
    }
}
