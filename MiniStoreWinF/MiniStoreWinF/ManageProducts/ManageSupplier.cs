using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.ManageProducts
{
    public partial class ManageSupplier : Form
    {
        private int rowindex { get; set; }
        SupplierServices _ShowListSupplier;
        SupplierServices _Update;
        SupplierServices _idSup;
        public ManageSupplier()
        {
            InitializeComponent();
            _ShowListSupplier = new SupplierServices();
            var ShowList = _ShowListSupplier.GetAll().ToList();
            dataGridView1.DataSource = new BindingSource() { DataSource = ShowList };

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _ShowListSupplier = new SupplierServices();
                var id = dataGridView1[0, e.RowIndex].Value;
                var showListS = _ShowListSupplier.GetAll()
                    .Where(p => p.IdSupplier.Equals(id))
                    .FirstOrDefault();
                rowindex = e.RowIndex;
                if (showListS != null)
                {
                    txtIDSupplier.Text = showListS.IdSupplier;
                    txtNameSupplier.Text = showListS.NameSupplier;
                    txtAdressSupplier.Text = showListS.AddressSupplier;
                    txtNoteSupplier.Text = showListS.Note;

                }
            }
            catch (Exception ex)
            {

            }
        }
        public string autoID(string id)
        {
            string prefix = id.Substring(0, 2);
            int number = int.Parse(id.Substring(2));
            number++;
            string nextID = prefix + number.ToString().PadLeft(2, '0');

            return nextID;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            _ShowListSupplier = new SupplierServices();
            var AddPro = _ShowListSupplier.GetAll().ToList().Where(p => p.IdSupplier == txtIDSupplier.Text).FirstOrDefault();
            if (txtNameSupplier.Text == "" || txtAdressSupplier.Text == ""
                    || txtNoteSupplier.Text == "")
            {
                MessageBox.Show("Not Be Empty ");
            }
            else
            {
                if (AddPro != null)
                {
                    MessageBox.Show("Trung ID");
                }
                else
                {
                    _idSup = new SupplierServices();
                    var _autoID = _idSup.GetAll().ToList().Select(c => c.IdSupplier).Max();
                    string nextID = autoID(_autoID);
                    _Update = new SupplierServices();
                    var _addSupplier = _Update.GetAll().ToList().FirstOrDefault();
                    _addSupplier.IdSupplier = nextID;
                    _addSupplier.NameSupplier = txtNameSupplier.Text.ToUpper();
                    _addSupplier.AddressSupplier = txtAdressSupplier.Text;
                    _addSupplier.Note = txtNoteSupplier.Text;
                    DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        _Update.Create(_addSupplier);
                        btLoad_Click(sender, e);
                    }

                }

            }


        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            _ShowListSupplier = new SupplierServices();
            var ShowList = _ShowListSupplier.GetAll().ToList();
            dataGridView1.DataSource = new BindingSource() { DataSource = ShowList };
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtAdressSupplier.Clear();
            txtIDSupplier.Clear();
            txtNameSupplier.Clear();
            txtNoteSupplier.Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            _ShowListSupplier = new SupplierServices();
            var UpdateSup = _ShowListSupplier.GetAll().ToList().Where(p => p.IdSupplier == txtIDSupplier.Text).FirstOrDefault();
            if (txtNameSupplier.Text == "" || txtAdressSupplier.Text == ""
                    || txtNoteSupplier.Text == "")
            {
                MessageBox.Show("Not Be Empty ");
            }
            else
            {
                if (UpdateSup != null)
                {
                    UpdateSup.NameSupplier = txtNameSupplier.Text.ToUpper();
                    UpdateSup.AddressSupplier = txtAdressSupplier.Text;
                    UpdateSup.Note = txtNoteSupplier.Text;
                    DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        _ShowListSupplier.Update(UpdateSup);
                        btLoad_Click(sender, e);
                    }
                }
            }
        }
    }
}
