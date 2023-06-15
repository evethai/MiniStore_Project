namespace MiniStoreWinF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagePage.AdminPage adminPage = new ManagePage.AdminPage();
            adminPage.Show();
        }
    }
}