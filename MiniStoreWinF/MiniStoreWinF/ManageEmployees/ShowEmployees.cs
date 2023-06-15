using Repository.Models;
using Repository.Service;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.ManageEmployees
{
    public partial class ShowEmployees : Form
    {
        Validation _employeeService = new Validation();
        Employee Employee { get; set; }
        public string url = "";


        private int rowIndex { get; set; }
        public ShowEmployees()
        {
            var employeeService = _employeeService.GetAll().Where(e => e.IsActive == true); ;
            InitializeComponent();


            dgvEmployee.DataSource = new BindingSource() { DataSource = employeeService };


        }





        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
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

        private void btAddEmployee_Click(object sender, EventArgs e)
        {
            Form form = new CreateEmployees();
            form.ShowDialog();
            var employeeService = _employeeService.GetAll().Where(e => e.IsActive == true); ;

            dgvEmployee.DataSource = new BindingSource() { DataSource = employeeService };


        }
        private void btImport_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtUrl.Text = dlg.FileName;
                    pBEmp.Image = new Bitmap(dlg.FileName);
                    url = dlg.FileName;
                }
            }
        }

        private void ShowEmployees_Load(object sender, EventArgs e)
        {

        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                
                var id = dgvEmployee[0, e.RowIndex].Value;
                
                var RoleType = _employeeService.GetAll().Where(entity => entity.FullNameEmp.Equals(id)).FirstOrDefault();
                rowIndex = e.RowIndex;
                if (RoleType != null)
                {
                    txtId.Text = RoleType.IdEmp.ToString();
                    txtName.Text = RoleType.FullNameEmp.ToString();
                    txtAddress.Text = RoleType.AddressEmp.ToString();
                    txtPhone.Text = RoleType.PhoneEmp.ToString();
                    txtUsername.Text = RoleType.Username.ToString();
                    txtPassword.Text = RoleType.Password.ToString();
                    txtDoB.Text = RoleType.DoB.ToString();
                    txtCccd.Text = RoleType.Cccd.ToString();
                    pBEmp.Image = Base64ToImage(RoleType.PictureEmp);
                    txtUrl.Text = RoleType.PictureEmp.ToString();
                    cbRole.Text = RoleType.Roles.ToString();
                    if (RoleType.Sex == false)
                    {
                        cbGender.Text = "Man";
                    }
                    else if (RoleType.Sex == true)
                    {
                        cbGender.Text = "Woman";
                    }
                    if (RoleType.IsActive == true)
                    {
                        cBStatus.Text = "Active";
                    }
                    else
                    {
                        cBStatus.Text = "Disable";
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose in the grid!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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


        private void btUpdate_Click(object sender, EventArgs e)
        {


            bool valid;
            var employeeService = _employeeService.GetAll().Where(e => e.IdEmp == txtId.Text).FirstOrDefault();
            if (txtName.Text == "" ||
                txtPhone.Text == "" ||
                txtAddress.Text == "" ||
                txtPassword.Text == ""


                )
            {
                MessageBox.Show("Please input all information!");

            }
            else
            {
                
                


                    if (employeeService.PictureEmp == txtUrl.Text)
                    {
                    
                    
                        employeeService.FullNameEmp = txtName.Text;
                        employeeService.PhoneEmp = txtPhone.Text;
                        employeeService.AddressEmp = txtAddress.Text;
                        employeeService.Password = txtPassword.Text;
                        employeeService.Username = txtUsername.Text;
                        employeeService.Cccd = txtCccd.Text;
                        //employeeService.PictureEmp = (txtUrl.Text = ImageToBase64(url));

                        if (cbGender.SelectedItem.Equals("Man"))
                        {
                            employeeService.Sex = true;
                        }
                        else if (cbGender.SelectedItem.Equals("Woman"))
                        {
                            employeeService.Sex = false;
                        }
                        if (cbRole.SelectedItem.Equals("Admin"))
                        {
                            employeeService.Roles = "Admin";
                        }
                        else if (cbRole.SelectedItem.Equals("Employee"))
                        {
                            employeeService.Roles = "Employee";
                        }
                        else if (cbRole.SelectedItem.Equals("Guard"))
                        {
                            employeeService.Roles = "Guard";
                        }
                        var Update = employeeService;
                        if (txtPhone.Text.Length != 10 && !txtPhone.Text.StartsWith("0")|| txtCccd.Text.Length != 12)
                        {
                            MessageBox.Show("INVALID INFORMATION!", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPhone.Focus();
                            txtPhone.SelectAll();
                        
                        }
                        else if(txtPhone.Text.Length == 10 && txtPhone.Text.StartsWith("0") || txtCccd.Text.Length == 12)
                        {
                            _employeeService.Update(Update);
                            valid = true;
                            
                            MessageBox.Show("UPDATE SUCCESSFULLY!");

                        }
                    

                       
                    }
                
            
                else
                {
                    txtUrl.Text = ImageToBase64(url);
                    employeeService.FullNameEmp = txtName.Text;
                    employeeService.PhoneEmp = txtPhone.Text;
                    employeeService.AddressEmp = txtAddress.Text;
                    employeeService.Password = txtPassword.Text;
                    employeeService.Username = txtUsername.Text;
                    employeeService.PictureEmp = txtUrl.Text;
                    if (cbGender.SelectedIndex.Equals("Man"))
                    {
                        employeeService.Sex = true;
                    }
                    else if (cbGender.SelectedItem.Equals("Woman"))
                    {
                        employeeService.Sex = false;
                    }


                    employeeService.Cccd = txtCccd.Text;
                    var update = employeeService;
                    _employeeService.Update(update);
                    MessageBox.Show("UPDATE SUCCESSFULLY!");
                }

            }
            var employeeServiceU = _employeeService.GetAll().Where(e => e.IsActive == true);
            dgvEmployee.DataSource = new BindingSource() { DataSource = employeeServiceU };
        }

       


        private void dgvEmployee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = value ? "Woman" : "Man";
                    e.FormattingApplied = true;
                }
            }
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd2.Checked)
            {

                var employeeService = _employeeService.GetAll().Where(e => e.IsActive == false);
                dgvEmployee.DataSource = new BindingSource() { DataSource = employeeService };
            }
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                var employeeService = _employeeService.GetAll().Where(e => e.IsActive == true);
                dgvEmployee.DataSource = new BindingSource() { DataSource = employeeService };
            }
        }



        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            if (searchName.Length > 0 && rd1.Checked)
            {
                var listSearchName = _employeeService.GetName(searchName).Where(e => e.IsActive == true);
                dgvEmployee.DataSource = new BindingSource() { DataSource = listSearchName };

            }
            else if (searchName.Length > 0 && rd2.Checked)
            {
                var listSearchName = _employeeService.GetName(searchName).Where(e => e.IsActive == false);
                dgvEmployee.DataSource = new BindingSource() { DataSource = listSearchName };
            }

            else
            {
                var listSearchName = _employeeService.GetName(searchName).Where(e => e.IsActive == true);
                dgvEmployee.DataSource = new BindingSource() { DataSource = listSearchName };
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {



            if (cBStatus.SelectedItem.Equals("Active"))
            {
                var employeeService = _employeeService.GetAll().Where(e => e.IsActive == false).FirstOrDefault();
                employeeService.IsActive = true;
                rd1.Checked = true;
                MessageBox.Show("ACTIVE SUCCESSFULLY!");
                var update = employeeService;
                _employeeService.Update(update);
            }
            else if ((cBStatus.SelectedItem.Equals("Disable")))
            {
                var employeeService = _employeeService.GetAll().Where(e => e.IsActive == true).FirstOrDefault();
                employeeService.IsActive = false;
                rd1.Checked = true;
                MessageBox.Show("DISABLE SUCCESSFULLY!");
                var update = employeeService;
                _employeeService.Update(update);
            }


            var listSearchName = _employeeService.GetAll().Where(e => e.IsActive == true);

            dgvEmployee.DataSource = new BindingSource() { DataSource = listSearchName };

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
