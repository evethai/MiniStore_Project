using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MiniStoreWinF.ManageEmployees
{
    public partial class frmCreateEmployees : Form
    {
        public EmployeeService employeeService = new EmployeeService();
        public string url = "";
        Validation validation = new Validation();
        PermissionService permissionService = new PermissionService();
        Permission Permission = new Permission();
        private string verificationCode;
        public frmCreateEmployees()
        {
            InitializeComponent();
            if (ContextScope.currentEmployee.Roles == 0)
            {
                var role = new PermissionService().GetAll().Where(e => e.Roles > 0).ToList();
                cbRole.DataSource = role;

                cbRole.DisplayMember = "Permission1";
            }
            else
            {
                var role = new PermissionService().GetAll().Where(e => e.Roles > 1).ToList();
                cbRole.DataSource = role;

                cbRole.DisplayMember = "Permission1";
            }

        }

        public string ImageToBase64(string path)
        {
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

            //Check existed username
            var duplicatedUsername = employeeService.GetAll().Where(entity => entity.Username.Equals(txtUsername.Text)).FirstOrDefault();
            var duplicatedCI = employeeService.GetAll().Where(e => e.Cccd.Equals(txtAddCCCD.Text)).FirstOrDefault();
            var duplicatedPhone = employeeService.GetAll().Where(e => e.PhoneEmp.Equals(txtAddPhone.Text)).FirstOrDefault();
            if (txtAddName.Text == "" ||
                txtAddPhone.Text == "" ||
                txtAddAddress.Text == "" ||
                txtAddCCCD.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtConfirm.Text == "" ||
                txtSub.Text == ""

                )
            {
                MessageBox.Show("Please input all requires information!");

            }
            //Check confirm password is match or not
            else if (txtPassword.Text != txtConfirm.Text)
            {
                pbInvalid.Visible = true;
                pbValid.Visible = false;
                MessageBox.Show("Confirm password is not match!");
                txtConfirm.Focus();
                txtConfirm.SelectAll();
                txtConfirm.Text = "";

            }


            else if (duplicatedUsername != null)
            {
                MessageBox.Show("Username already exist!");
                txtUsername.Focus();
                txtUsername.SelectAll();
                txtUsername.Text = "";
            }
            else if (duplicatedPhone != null)
            {
                MessageBox.Show("Phone already exist!");
                txtAddPhone.Focus();
                txtAddPhone.SelectAll();
                txtAddPhone.Text = "";
            }
            else if (duplicatedCI != null)
            {
                MessageBox.Show("CI already exist!");
                txtAddCCCD.Focus();
                txtAddCCCD.SelectAll();
                txtAddCCCD.Text = "";
            }

            //Check age > 18
            else if (DateTime.Now.Year - dtDoB.Value.Year < 18)
            {
                MessageBox.Show("Employee's age must higher than 18!");
                dtDoB.Focus();

            }
            else if (int.Parse(txtSub.Text) < 0 && int.Parse(txtSub.Text) > 100)
            {
                MessageBox.Show("Dependents is invalid");
                txtSub.Focus();
            }

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
                employee.Snpt = int.Parse(txtSub.Text);
                Permission permission = cbRole.SelectedItem as Permission;
                employee.Roles = permission.Roles;
                employee.PictureEmp = (txtImport.Text = ImageToBase64(url));

                employee.IsActive = true;
                if (cbGender.SelectedItem.Equals("Man"))
                {
                    employee.Sex = false;
                }
                else
                {
                    employee.Sex = true;
                }
                DialogResult result = MessageBox.Show("Have you checked all the information?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Validation employeeService = new Validation();
                    if (cbIdType.Text == null)
                    {
                        employeeService.Add(employee, "SE");
                    }
                    else
                    {
                        employeeService.Add(employee, cbIdType.Text);
                    }

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
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirm.Text)
            {
                pbInvalid.Visible = true;
                pbValid.Visible = false;


            }
            else if (txtConfirm.Text == txtPassword.Text)
            {
                pbValid.Visible = true;
                pbInvalid.Visible = false;
            }
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirm.Text)
            {
                pbInvalid.Visible = true;
                pbValid.Visible = false;


            }
            else if (txtConfirm.Text == txtPassword.Text)
            {
                pbValid.Visible = true;
                pbInvalid.Visible = false;
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                // Hiển thị mật khẩu
                txtPassword.PasswordChar = '\0'; // '\0' là ký tự null
            }
            else
            {
                // Ẩn mật khẩu
                txtPassword.PasswordChar = '*';
            }
        }
        //Check phone valid - 10 numbers, number only, start with '0'
        private void txtAddPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }

            // Kiểm tra giới hạn độ dài của chuỗi
            if (txtAddPhone.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }

            // Kiểm tra việc bắt đầu với số 0
            if (txtAddPhone.Text.Length == 0 && e.KeyChar != '0')
            {
                e.Handled = true; // Cannot continue input
            }
        }

        private void txtAddCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }

            // Check length input
            if (txtAddCCCD.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSub_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = true;
            }

        }


    }
}
