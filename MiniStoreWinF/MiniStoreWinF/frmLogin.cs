using Microsoft.VisualBasic.ApplicationServices;
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
            var login = _employeeService.GetAll().Where(entity => entity.Username == userName && entity.Password == password && entity.IsActive == true).FirstOrDefault(); //create check login username-password
            if (userName.Length <= 0 || password.Length <= 0)
            {
                MessageBox.Show("Username and Password cannot be left blank !!", "Notification", MessageBoxButtons.OK);
            }// end check empty username or password
            else if (login == null)
            {
                MessageBox.Show("Invalid username or password !!", "Notification", MessageBoxButtons.OK);
            }//end check wrong username or password
            else if (login.Roles == "Admin")
            {
                this.Hide();
                ManagePage.AdminPage adminPage = new ManagePage.AdminPage();
                adminPage.Show();
            }// end check role admin
            else if (login.Roles == "Employee")
            {
                this.Hide();
                OrdersProducts.OrderProducts employessPage = new OrdersProducts.OrderProducts();
                employessPage.DataEmployee = txtUserName.Text;
                employessPage.Show();
            }//end check role employee
            else
            {
                MessageBox.Show("Invalid role !!", "Notification", MessageBoxButtons.OK);
            }//end check other role               
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