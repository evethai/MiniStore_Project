using Microsoft.VisualBasic.ApplicationServices;
using Repository.Service;

namespace MiniStoreWinF
{
    public partial class Login : Form
    {
        EmployeeService _employeeService = new EmployeeService();//create new service to check loginForm
        public Login()
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
                employessPage.Data=txtUserName.Text;
                employessPage.Show();
            }//end check role employee
            else
            {
                MessageBox.Show("Invalid role !!", "Notification", MessageBoxButtons.OK);
            }//end check other role               

        }
    }
}