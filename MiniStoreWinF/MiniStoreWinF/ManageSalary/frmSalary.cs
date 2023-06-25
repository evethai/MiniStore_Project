﻿using Repository.Models;
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
    public partial class frmSalary : Form
    {
        SalaryService _salaryService;
        SubSalaryService _subSalaryService;
        Utinity u = new Utinity();
        UpdateAuto ua = new UpdateAuto();
        CalculationAuto ca = new CalculationAuto();
        public frmSalary()
        {
            InitializeComponent();
            //auto calculator sub salary
            AutoSubSalary();

            //auto calculaotor salary
            AutoSalary();

            //begin page
            openChildForm(new frmSalarySetup());
        }
        public void AutoSubSalary()
        {
            _subSalaryService = new SubSalaryService();
            //check in last month calculated sub salary?
            var sum = _subSalaryService.GetAll().Count(p => p.Time.Value.Month.Equals(u.GetTime(DateTime.Now).Month));
            if (sum > 0)
            {
                return;
            }
            else
            {
                //the final day of last month 
                ua.save(u.GetLastDayOfMonth(u.GetTime(DateTime.Now)));
            }
        }
        public void AutoSalary()
        {
            _salaryService = new SalaryService();
            //check in last month calcualted Salary ?
            var sum1 = _salaryService.GetAll().Count(p => p.DateImonth.Month.Equals(u.GetTime(DateTime.Now).Month));
            if (sum1 > 0)
            {
                return;
            }
            else
            {
                ca.CalculatorSalary(u.GetLastDayOfMonth(u.GetTime(DateTime.Now)));
            }
        }

        private void frmSalary_Load(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;//đặt thuộc tính cho form con không được hiển thị độc lập
            childForm.FormBorderStyle = FormBorderStyle.None;//tắt đường viền tắt các nút thu nhỏ mở rộng hay đóng form con
            childForm.Dock = DockStyle.Fill;//form con lấp đầy panel body
            pMain.Controls.Add(childForm);//thêm form con vào panel body
            pMain.Tag = childForm;//gán form con cho thuộc tính tag của panel để lưu trử thông tin form con
            childForm.BringToFront();//ĐƯA form con ra trước trong các điều khiển panel
            childForm.Show();//hiện thị nó 
        }

        private void btManage_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSalarySetup());

        }

        private void btSalary_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSalaryDetail());
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSubSalary());
        }

    }
}
