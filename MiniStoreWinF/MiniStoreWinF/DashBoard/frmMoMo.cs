using Microsoft.Data.SqlClient;
using MiniStoreWinF.ManageSalary;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MiniStoreWinF.DashBoard
{
    public partial class frmMoMo : Form
    {
        MoMoService _moService;
        Utinity u = new Utinity();
        public frmMoMo()
        {
            InitializeComponent();
            _moService = new MoMoService();

        }

        private void frmMoMo_Load(object sender, EventArgs e)
        {
            loadPage();
        }
        public void loadPage()
        {
            var list = _moService.GetAll().ToList();
            dgvList.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string gmail = txtGmail.Text;
            if (gmail.Contains('@'))
            {
                DialogResult result = MessageBox.Show("Are you sure add new Account MoMo", "Messages", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _moService = new MoMoService();
                    MoMo m = new MoMo();
                    m.Phone = txtPhone.Text;
                    m.Name = txtName.Text;
                    m.Gmail = gmail;
                    m.Active = false;
                    _moService.Create(m);
                    loadPage();
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Invalid Email Syntax", "Messages", MessageBoxButtons.OK);
                return;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, txtPhone.Text, 10);
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvList[0, e.RowIndex].Value;
            var s = _moService.GetAll().Where(p => p.Id.Equals(id)).FirstOrDefault();
            if (s != null)
            {
                txtPhone.Text = s.Phone;
                txtName.Text = s.Name;
                txtGmail.Text = s.Gmail;
                txtSave.Text = s.Id.ToString();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var momo = _moService.GetAll().Where(p => p.Id == Int32.Parse(txtSave.Text)).FirstOrDefault();
            if (momo != null)
            {
                momo.Phone = txtPhone.Text;
                momo.Name = txtName.Text;
                momo.Gmail = txtGmail.Text;
                _moService.Update(momo);
            }
            loadPage();
            txtName.Text = "";
            txtPhone.Text = "";
            txtGmail.Text = "";
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change your MoMo account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var list = _moService.GetAll().Where(p => p.Id == Int32.Parse(txtSave.Text)).FirstOrDefault();
                if (list != null)
                {
                    list.Active = true;
                    _moService.Update(list);
                }
                var listFalse = _moService.GetAll().Where(p => p.Id != Int32.Parse(txtSave.Text)).ToList();
                foreach (var item in listFalse)
                {
                    item.Active = false;
                    _moService.Update(item);
                }
                MessageBox.Show("Chang Successful " + list.Phone, "Messages", MessageBoxButtons.OK);
                loadPage();
            }
            else
            {
                return;
            }

        }
    }
}
