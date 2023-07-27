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

namespace MiniStoreWinF.InformationEmployee
{
    public partial class frmInformationEmp : Form
    {
        EmployeeService _employeeService = new EmployeeService();
        public string DataEmployee { get; set; }
        string DataLoadEmployee = ContextScope.currentEmployee.IdEmp;
        public frmInformationEmp()
        {
            InitializeComponent();

        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        } // function translate base64 to image  => OK 

        private void btResetPassword_Click(object sender, EventArgs e)
        {
            pnShowReset.Enabled = true;
            pnShowReset.Visible = true;
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {

            var CheckPassWork = _employeeService.GetAll().Where(p => p.IdEmp == DataLoadEmployee).FirstOrDefault();
            if (CheckPassWork != null)
            {
                cbCheck.Checked = true;
                if (cbCheck.Checked && txtConfirmm.Text.Equals(txtNewPass.Text) == true && txtCurrent.Text.Equals(CheckPassWork.Password))
                {
                    CheckPassWork.Password = txtNewPass.Text;
                    cbCheck2.Checked = true;
                    _employeeService.Update(CheckPassWork);
                    MessageBox.Show("Reset Password Successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnShowReset.Visible = false;
                    txtCurrent.Text = null;
                    txtConfirmm.Text = null;
                    txtNewPass.Text = null;
                }
                else
                {
                    MessageBox.Show("Sorry confirm is wrong ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
            else
            {
                MessageBox.Show("BUG");
            }
        }

        private void frmInformationEmp_Load(object sender, EventArgs e)
        {

            string PictureEmp = "";
            var infoEmployee = _employeeService.GetAll().Where(p => p.IdEmp == ContextScope.currentEmployee.IdEmp).FirstOrDefault();
            if (infoEmployee != null)
            {
                txtId.Text = infoEmployee.IdEmp;
                txtName.Text = infoEmployee.FullNameEmp;
                txtCI.Text = infoEmployee.Cccd;
                txtAddresss.Text = infoEmployee.AddressEmp;
                txtDepen.Text = infoEmployee.Snpt.ToString();
                txtEmail.Text = infoEmployee.Email.ToString();
                if (infoEmployee.Sex == true)
                {
                    txtGender.Text = "Female";
                }
                else
                {
                    txtGender.Text = "Male";
                }
                txtPhonee.Text = infoEmployee.PhoneEmp;

                txtBirth.Text = infoEmployee.DoB.ToString();
                PictureEmp = infoEmployee.PictureEmp;
                pbEmployee.Image = Base64ToImage(PictureEmp);
            }
            else
            {
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
