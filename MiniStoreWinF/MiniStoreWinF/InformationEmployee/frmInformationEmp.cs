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
            pnlShowResetPassword.Enabled = true;
            pnlShowResetPassword.Visible = true;
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {

            var CheckPassWork = _employeeService.GetAll().Where(p => p.IdEmp == DataEmployee).FirstOrDefault();
            if (CheckPassWork != null)
            {
                cbCheckExactly.Checked = true;
                if (cbCheckExactly.Checked && txtConfirmNewPassword.Text.Equals(txtNewPassword.Text) == true && txtCurrentPassword.Text.Equals(CheckPassWork.Password))
                {
                    CheckPassWork.Password = txtNewPassword.Text;
                    chbConfirmSuccess.Checked = true;
                    _employeeService.Update(CheckPassWork);
                    MessageBox.Show("Reset Password Successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlShowResetPassword.Visible = false;
                    txtCurrentPassword.Text = null;
                    txtConfirmNewPassword.Text = null;
                    txtNewPassword.Text = null;
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
            var infoEmployee = _employeeService.GetAll().Where(p => p.IdEmp == DataEmployee).FirstOrDefault();
            if (infoEmployee != null)
            {
                txtIdEmp.Text = infoEmployee.IdEmp;
                txtFullName.Text = infoEmployee.FullNameEmp;
                txtCCCD.Text = infoEmployee.Cccd;
                txtAddress.Text = infoEmployee.AddressEmp;
                if (infoEmployee.Sex == true)
                {
                    txtSex.Text = "Female";
                }
                else
                {
                    txtSex.Text = "Male";
                }
                txtPhone.Text = infoEmployee.PhoneEmp;
                txtUsername.Text = infoEmployee.Username;
                txtBoD.Text = infoEmployee.DoB.ToString();
                txtPassworkShow.Text = infoEmployee.Password;
                PictureEmp = infoEmployee.PictureEmp;
                pcPictureEmp.Image = Base64ToImage(PictureEmp);
            }
            else
            {
                return;
            }
        }
    }
}
