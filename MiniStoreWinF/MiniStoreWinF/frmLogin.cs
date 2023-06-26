using Microsoft.VisualBasic.ApplicationServices;
using MiniStoreWinF.DashBoard;
using Repository.Service;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MiniStoreWinF
{
    public partial class frmLogin : Form
    {
        EmployeeService _employeeService = new EmployeeService();//create new service to check loginForm
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (userName.Length <= 0 || password.Length <= 0)
            {
                MessageBox.Show("Username and Password cannot be left blank !!", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                var login = _employeeService.GetAll()
                    .Where(entity => entity.Username == userName
                    && entity.Password == password
                    && entity.IsActive == true)
                    .FirstOrDefault();
                if (login != null)
                {
                    ContextScope.currentEmployee = login;
                    frmMainScreen form = new frmMainScreen();
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password !!", "Notification", MessageBoxButtons.OK);
                    return;
                }
            }

        }
        private void ptbSeePasswords_Click(object sender, EventArgs e)
        {

            ptbNoSeePasswords.Visible = true;
            ptbSeePasswords.Visible = false;
            // Hiển thị mật khẩu
            txtPassword.PasswordChar = '\0'; // '\0' là ký tự null
        }

        private void ptbNoSeePasswords_Click(object sender, EventArgs e)
        {
            ptbNoSeePasswords.Visible = false;
            ptbSeePasswords.Visible = true;
            // Ẩn mật khẩu
            txtPassword.PasswordChar = '*';
        }
    }
}