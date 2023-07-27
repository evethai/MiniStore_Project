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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.Office.Interop.Excel;

namespace MiniStoreWinF.ManageEmployees
{
    public partial class frmShowEmployee : Form
    {

        Validation _employeeService = new Validation();
        Permission _permission = new Permission();
        PermissionService _permissionService = new PermissionService();
        SubTypeService _subTypeService = new SubTypeService();
        SubDetailService _subDetailService = new SubDetailService();
        SubSalaryService _subSalaryService = new SubSalaryService();
        public string url = "";


        private int rowIndex { get; set; }
        public frmShowEmployee()
        {
            InitializeComponent();

            var employeeList = DataLoad().Where(e => e.IsActive == true).ToList();
            dgvEmployee.DataSource = new BindingSource() { DataSource = employeeList };
            var permission = DataLoadPermission();
            if (permission != null)
            {
                cbRole.DataSource = permission;
                cbRole.DisplayMember = "Permission1";
            }

            //var employeeService = _employeeService.GetAll().Where(e => e.IsActive == true);
            //dgvEmployee.DataSource = new BindingSource() { DataSource = employeeService };



        }
        List<Permission> DataLoadPermission()
        {
            if (ContextScope.currentEmployee.Roles >= 1)
            {
                var permissionList = _permissionService.GetAll().Where(e => e.Roles >= 2).ToList();
                dgvEmployee.DataSource = new BindingSource() { DataSource = permissionList };
                return permissionList;
            }
            else
            {
                var permissionList = _permissionService.GetAll().Where(e => e.Roles >= 1).ToList();
                dgvEmployee.DataSource = new BindingSource() { DataSource = permissionList };
                return permissionList;
            }

        }
        List<Employee> DataLoad()
        {
            if (ContextScope.currentEmployee.Roles >= 1)
            {
                var employeeList = _employeeService.GetAll().Where(e => e.Roles >= 2).ToList();
                dgvEmployee.DataSource = new BindingSource() { DataSource = employeeList };
                return employeeList;

            }
            else
            {
                var employeeList = _employeeService.GetAll().Where(e => e.Roles >= 1).ToList();
                dgvEmployee.DataSource = new BindingSource() { DataSource = employeeList };
                return employeeList;
            }

        }

        //Trasfer Base 64 code to Img
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        //Transfer Img to base 64 
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
        //Move to frmCreateEmployee to create new employee
        private void btAddEmployee_Click(object sender, EventArgs e)
        {
            Form form = new frmCreateEmployees();
            form.ShowDialog();
            if (rd1.Checked)
            {
                var employeeList = DataLoad().Where(e => e.IsActive == true).ToList();
                dgvEmployee.DataSource = new BindingSource() { DataSource = employeeList };
            }
            else if (rd2.Checked)
            {
                var employeeList = DataLoad().Where(e => e.IsActive == false).ToList();
                dgvEmployee.DataSource = new BindingSource() { DataSource = employeeList };

            }


        }

        //Import to update employee's picture
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
            rd1.Checked = true;

        }
        //Double click to get specific employee's information
        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var id = dgvEmployee[0, e.RowIndex].Value;
                var employeeInfo = _employeeService.GetAll().Where(entity => entity.FullNameEmp.Equals(id)).FirstOrDefault();

                rowIndex = e.RowIndex;
                if (employeeInfo != null)
                {
                    var roles = employeeInfo.Roles;
                    var permission = _permissionService.GetAll().Where(entity => entity.Roles.Equals(roles)).FirstOrDefault();




                    txtId.Text = employeeInfo.IdEmp.ToString();
                    txtName.Text = employeeInfo.FullNameEmp.ToString();
                    txtAddress.Text = employeeInfo.AddressEmp.ToString();
                    txtPhone.Text = employeeInfo.PhoneEmp.ToString();
                    dtDoB.Value = employeeInfo.DoB.Value;
                    txtCccd.Text = employeeInfo.Cccd.ToString();
                    pBEmp.Image = Base64ToImage(employeeInfo.PictureEmp);
                    txtUrl.Text = employeeInfo.PictureEmp.ToString();
                    cbRole.Text = employeeInfo.Roles.ToString();
                    txtDependent.Text = employeeInfo.Snpt.ToString();
                    txtEmail.Text = employeeInfo.Email.ToString();
                    if (employeeInfo.Sex == false)
                    {
                        cbGender.Text = "Man";
                    }
                    else if (employeeInfo.Sex == true)
                    {
                        cbGender.Text = "Woman";
                    }
                    if (employeeInfo.IsActive == true)
                    {
                        cBStatus.Text = "Active";
                    }
                    else
                    {
                        cBStatus.Text = "Disable";
                    }
                    if (permission != null)
                    {
                        cbRole.Text = permission.Permission1.ToString();
                    }
                    else
                    {
                        cbRole.Text = "None";
                    }


                }
                else if (employeeInfo == null)
                {
                    return;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please choose in the grid!");
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose in the grid!");
            }
        }



        //Update employee's information
        private void btUpdate_Click(object sender, EventArgs e)
        {
            var duplicatedCI = _employeeService.GetAll().Where(e => e.Cccd.Equals(txtCccd.Text)).FirstOrDefault();
            var duplicatedPhone = _employeeService.GetAll().Where(e => e.PhoneEmp.Equals(txtPhone.Text)).FirstOrDefault();

            var employeeService = _employeeService.GetAll().Where(e => e.IdEmp == txtId.Text).FirstOrDefault();
            var duplicatedEmail = _employeeService.GetAll().Where(e => e.Email.Equals(txtEmail.Text)).FirstOrDefault();
            if (txtName.Text == "" ||
                txtPhone.Text == "" ||
                txtAddress.Text == "")
            {
                MessageBox.Show("Please input all information!");

            }

            else if (duplicatedPhone != null && txtPhone.Text != txtPhone.Text)
            {
                MessageBox.Show("Phone already exist!");
                txtPhone.Focus();
                txtPhone.SelectAll();
                txtPhone.Text = "";
            }
            else if (duplicatedEmail != null || txtEmail.Text != txtEmail.Text)
            {
                MessageBox.Show("Email is duplucated!");
                txtEmail.Focus();
                txtEmail.SelectAll();

            }
            else if (!txtEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Email is invalid!");
                txtEmail.Focus();
                txtEmail.SelectAll();

            }
            else if (duplicatedCI != null && txtCccd.Text != txtCccd.Text)
            {
                MessageBox.Show("CI already exist!");
                txtPhone.Focus();
                txtPhone.SelectAll();
                txtPhone.Text = "";
            }
            //Check age > 18
            else if (DateTime.Now.Year - dtDoB.Value.Year < 18)
            {
                MessageBox.Show("Employee's age must higher than 18!");
                dtDoB.Focus();

            }

            else if (int.Parse(txtDependent.Text) < 0 || int.Parse(txtDependent.Text) > 100)
            {
                MessageBox.Show("Number of dependents is invalid");
            }

            else
            {
                if (employeeService.PictureEmp == txtUrl.Text)
                {
                    employeeService.FullNameEmp = txtName.Text;
                    employeeService.PhoneEmp = txtPhone.Text;
                    employeeService.AddressEmp = txtAddress.Text;
                    employeeService.Snpt = int.Parse(txtDependent.Text);
                    employeeService.Cccd = txtCccd.Text;
                    employeeService.Email = txtEmail.Text;
                    if (cbGender.SelectedItem.Equals("Man"))
                    {
                        employeeService.Sex = false;
                    }
                    else if (cbGender.SelectedItem.Equals("Woman"))
                    {
                        employeeService.Sex = true;
                    }

                    if (cBStatus.SelectedItem.Equals("Active"))
                    {
                        employeeService.IsActive = true;
                    }
                    else if (cBStatus.SelectedItem.Equals("Disable"))
                    {
                        employeeService.IsActive = false;
                    }
                    Permission permission = cbRole.SelectedItem as Permission;
                    employeeService.Roles = permission.Roles;

                    var Update = employeeService;
                    _employeeService.Update(Update);
                    MessageBox.Show("UPDATE SUCCESSFULLY!");

                }
                else
                {
                    txtUrl.Text = ImageToBase64(url);
                    employeeService.FullNameEmp = txtName.Text;
                    employeeService.PhoneEmp = txtPhone.Text;
                    employeeService.AddressEmp = txtAddress.Text;
                    employeeService.Email = txtEmail.Text;
                    employeeService.PictureEmp = txtUrl.Text;
                    employeeService.DoB = dtDoB.Value;
                    if (cbGender.SelectedIndex.Equals("Man"))
                    {
                        employeeService.Sex = true;
                    }
                    else if (cbGender.SelectedItem.Equals("Woman"))
                    {
                        employeeService.Sex = false;
                    }
                    if (cBStatus.SelectedItem.Equals("Active"))
                    {
                        employeeService.IsActive = true;
                    }
                    else if (cBStatus.SelectedItem.Equals("Disable"))
                    {
                        employeeService.IsActive = false;
                    }
                    Permission permission = cbRole.SelectedItem as Permission;
                    employeeService.Roles = permission.Roles;


                    employeeService.Cccd = txtCccd.Text;
                    var update = employeeService;
                    _employeeService.Update(update);
                    MessageBox.Show("UPDATE SUCCESSFULLY!");
                }

            }
            if (rd1.Checked)
            {
                var employeeList = DataLoad().Where(e => e.IsActive == true).ToList();
                dgvEmployee.DataSource = new BindingSource() { DataSource = employeeList };
            }
            else if (rd2.Checked)
            {
                var employeeList = DataLoad().Where(e => e.IsActive == false).ToList();
                dgvEmployee.DataSource = new BindingSource() { DataSource = employeeList };

            }



        }



        //Format true/false gender to man/woman
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
        //Show disable employee's list
        private void rd2_CheckedChanged(object sender, EventArgs e)
        {

            if (rd2.Checked)
            {
                var employeeList = DataLoad().Where(e => e.IsActive == false);
                dgvEmployee.DataSource = new BindingSource() { DataSource = employeeList };
            }
        }
        //Show active employee's list
        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                var employeeList = DataLoad().Where(e => e.IsActive == true);
                dgvEmployee.DataSource = new BindingSource() { DataSource = employeeList };
            }
        }


        //Search Employee's name base on name and status check
        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;


            if (searchName.Length > 0 && rd1.Checked)
            {
                var listSearchName = _employeeService.SearchEmployee(searchName).Where(e => e.IsActive == true);
                dgvEmployee.DataSource = new BindingSource() { DataSource = listSearchName };

            }
            else if (searchName.Length > 0 && rd2.Checked)
            {
                var listSearchName = _employeeService.SearchEmployee(searchName).Where(e => e.IsActive == false);
                dgvEmployee.DataSource = new BindingSource() { DataSource = listSearchName };
            }

            else
            {
                var listSearchName = _employeeService.SearchEmployee(searchName).Where(e => e.IsActive == true);
                dgvEmployee.DataSource = new BindingSource() { DataSource = listSearchName };
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }

            // Check length input
            if (txtCccd.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }


        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }

            // Check length limit
            if (txtPhone.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cannot continue input
            }

            // Check start with 0
            if (txtPhone.Text.Length == 0 && e.KeyChar != '0')
            {
                e.Handled = true; // Cannot continue input
            }
        }



        private void btShow_Click(object sender, EventArgs e)
        {
            if (tbMain.Visible == false)
            {


                tbMain.Visible = true;
            }
            else
            {
                tbMain.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var employeeService = _employeeService.GetAll().Where(e => e.IdEmp == txtId.Text).FirstOrDefault();
            if (txtName.Text == "" ||
                txtPhone.Text == "" ||
                txtAddress.Text == ""

                )
            {
                MessageBox.Show("Please input all information!");

            }
            //Check age > 18
            else if (DateTime.Now.Year - dtDoB.Value.Year < 18)
            {
                MessageBox.Show("Employee's age must higher than 18!");
                dtDoB.Focus();

            }

            else
            {
                if (employeeService.PictureEmp == txtUrl.Text)
                {
                    employeeService.FullNameEmp = txtName.Text;
                    employeeService.PhoneEmp = txtPhone.Text;
                    employeeService.AddressEmp = txtAddress.Text;

                    employeeService.Cccd = txtCccd.Text;
                    if (cbGender.SelectedItem.Equals("Man"))
                    {
                        employeeService.Sex = false;
                    }
                    else if (cbGender.SelectedItem.Equals("Woman"))
                    {
                        employeeService.Sex = true;
                    }

                    if (cBStatus.SelectedItem.Equals("Active"))
                    {
                        employeeService.IsActive = true;
                    }
                    else if (cBStatus.SelectedItem.Equals("Disable"))
                    {
                        employeeService.IsActive = false;
                    }
                    var Update = employeeService;
                    _employeeService.Update(Update);
                    MessageBox.Show("UPDATE SUCCESSFULLY!");
                }
                else
                {
                    txtUrl.Text = ImageToBase64(url);
                    employeeService.FullNameEmp = txtName.Text;
                    employeeService.PhoneEmp = txtPhone.Text;
                    employeeService.AddressEmp = txtAddress.Text;

                    employeeService.PictureEmp = txtUrl.Text;
                    employeeService.DoB = dtDoB.Value;
                    if (cbGender.SelectedIndex.Equals("Man"))
                    {
                        employeeService.Sex = true;
                    }
                    else if (cbGender.SelectedItem.Equals("Woman"))
                    {
                        employeeService.Sex = false;
                    }
                    if (cBStatus.SelectedItem.Equals("Active"))
                    {
                        employeeService.IsActive = true;
                    }
                    else if (cBStatus.SelectedItem.Equals("Disable"))
                    {
                        employeeService.IsActive = false;
                    }
                    employeeService.Cccd = txtCccd.Text;
                    var update = employeeService;
                    _employeeService.Update(update);
                    MessageBox.Show("UPDATE SUCCESSFULLY!");
                }
            }
        }

        private void btShowSubSalary_Click(object sender, EventArgs e)
        {
            Form form = new frmShowSubSalary();
            form.ShowDialog();
        }

        private void txtDependent_KeyPress(object sender, KeyPressEventArgs e)
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
