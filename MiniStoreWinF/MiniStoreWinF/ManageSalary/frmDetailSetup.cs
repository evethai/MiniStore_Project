﻿using Repository.Service;
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
            _employeeService = new EmployeeService();

        }

        private void frmDetailSetup_Load(object sender, EventArgs e)
        {
            var listEmp = _employeeService.GetAll()
                .Where(p => (p.Roles == 2) && p.IsActive == true).ToList();
            dgvEmp.DataSource = listEmp;

            var listGuard = _employeeService.GetAll()
                .Where(p => (p.Roles == 3) && p.IsActive == true).ToList();
            dgvGuard.DataSource = listGuard;
        }
    }
}
