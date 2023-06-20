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

namespace MiniStoreWinF.ManageSalary
{
    public partial class frmDetailSetup : Form
    {
        EmployeeService _employeeService;
        public frmDetailSetup()
        {
            InitializeComponent();
        }

        private void frmDetailSetup_Load(object sender, EventArgs e)
        {
            _employeeService = new EmployeeService();
            var list = _employeeService.GetAll()
                .Where(p => (p.Roles.Equals("Employee") || p.Roles.Equals("Guard")) && p.IsActive == true).ToList();
            dgvRoles.DataSource = list;
        }
    }
}
