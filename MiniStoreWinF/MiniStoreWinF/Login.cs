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
            
        }
    }
}