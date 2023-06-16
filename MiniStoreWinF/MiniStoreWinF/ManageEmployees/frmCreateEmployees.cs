using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MiniStoreWinF.ManageEmployees
{
    public partial class frmCreateEmployees : Form
    {
        public EmployeeService employeeService = new EmployeeService();
        public string url = "";

        public frmCreateEmployees()
        {
            InitializeComponent();

            var role = new PermissionService().GetAll();
            cbRole.DataSource = role;
            cbRole.DisplayMember = "Roles";
        }






        private void CreateEmployees_Load(object sender, EventArgs e)
        {
            pnAccount.Visible = false;
            pnAccount1.Visible = false;
            pnAccount2.Visible = true;
        }
        private void btNext_Click(object sender, EventArgs e)
        {


            pnAccount.Visible = true;
            pnAccount1.Visible = true;
            pnAccount2.Visible = true;

        }
        public string ImageToBase64(string path)
        {
            // string path = "D:\SampleImage.jpg";
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            Validation duplicated = new Validation();
            duplicated.Duplicated(txtUsername.Text);
            if (txtAddName.Text == "" ||
                txtAddPhone.Text == "" ||
                txtAddAddress.Text == "" ||
                txtAddCCCD.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtConfirm.Text == ""
                )
            {
                MessageBox.Show("Please input all requires information!");

            }
            else if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Confirm password is not match!");
            }
            //else if (duplicated != null)
            //{
            //    MessageBox.Show("Duplicated username!");
            //}


            else
            {
                var employee = new Employee();
                employee.FullNameEmp = txtAddName.Text.Trim();
                employee.PhoneEmp = txtAddPhone.Text.Trim();
                employee.AddressEmp = txtAddAddress.Text.Trim();
                employee.Cccd = txtAddCCCD.Text.Trim();
                employee.Username = txtUsername.Text.Trim();
                employee.Password = txtPassword.Text.Trim();
                employee.DateJoin = DateTime.Now;
                employee.DoB = dtDoB.Value;

                Permission permission = cbRole.SelectedItem as Permission;
                employee.Roles = permission.Roles;
                employee.PictureEmp = (txtImport.Text = ImageToBase64(url));

                employee.IsActive = true;
                if (cbGender.SelectedItem.Equals("Man"))
                {
                    employee.Sex = true;
                }
                else
                {
                    employee.Sex = false;
                }
                DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Validation employeeService = new Validation();
                    employeeService.Add(employee);
                    this.Close();
                }
                else
                {

                }
            }

        }

        private void btImport_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtImport.Text = dlg.FileName;
                    pbEmployee.Image = new Bitmap(dlg.FileName);
                    url = dlg.FileName;
                }
            }

        }


        private void pbEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            string confirm = txtConfirm.Text;
            if (confirm == txtPassword.Text)
            {
                pbValid.Visible = true;
                pbInvalid.Visible = false;

            }
            else
            {
                pbValid.Visible = false;
                pbInvalid.Visible = true;

            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
