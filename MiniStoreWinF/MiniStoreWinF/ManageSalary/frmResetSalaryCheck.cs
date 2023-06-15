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
    public partial class frmResetSalaryCheck : Form
    {
        SalaryService _salaryService;
        Utinity u = new Utinity();
        public frmResetSalaryCheck()
        {
            InitializeComponent();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            _salaryService = new SalaryService();
            CalculationAuto ca = new CalculationAuto();
            DateTime time = u.GetLastDayOfMonth(dtpTime.Value);
            DialogResult result = MessageBox.Show("Remember choice time to reset salary!", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var reset = _salaryService.GetAll().Where(p=>p.DateImonth.Month.Equals(time.Month)).ToList();
                if (reset.Count>0)
                {
                    foreach (var item in reset)
                    {
                        _salaryService.Delete(item);
                    }
                    ca.CalculatorSalary(getTime(time));
                    MessageBox.Show("Reset Salary in " + time.Month+"/"+time.Year, "Messages", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Month not have Salary to reset.", "Messages", MessageBoxButtons.OK);
                }
            }
        }
        public DateTime getTime(DateTime time)
        {
            return time.AddMonths(+1);
        }
    }
}
