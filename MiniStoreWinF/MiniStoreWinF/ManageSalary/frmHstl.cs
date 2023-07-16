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

namespace MiniStoreWinF.ManageSalary
{
    public partial class frmHstl : Form
    {
        HeSoTinhLuongService _heSoTinhLuongService;
        Utinity u = new Utinity();
        public frmHstl()
        {
            InitializeComponent();
            _heSoTinhLuongService = new HeSoTinhLuongService();
            var hstl = _heSoTinhLuongService.GetAll().FirstOrDefault();
            bhxh.Text = hstl.Bhxh.ToString();
            bhyt.Text = hstl.Bhyt.ToString();
            bhtn.Text = hstl.Bhtn.ToString();
            gtgccn.Text = hstl.GtgcBanthan.ToString();
            gtgcnpt.Text = hstl.GtgcNpt.ToString();
            mini.Text = hstl.LuongToiThieu.ToString();
            max.Text = hstl.MucBhToiDa.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _heSoTinhLuongService = new HeSoTinhLuongService();
            HeSoTinhLuong hstl = new HeSoTinhLuong();
            hstl.Id = "1";
            hstl.Bhxh = double.Parse(bhxh.Text);
            hstl.Bhyt = double.Parse(bhyt.Text);
            hstl.Bhtn = double.Parse(bhtn.Text);
            hstl.GtgcBanthan = double.Parse(gtgccn.Text);
            hstl.GtgcNpt = double.Parse(gtgcnpt.Text);
            hstl.LuongToiThieu = double.Parse(mini.Text);
            hstl.MucBhToiDa = double.Parse(max.Text);
            _heSoTinhLuongService.Update(hstl);

            notiSave.BalloonTipText = "Save Successfull";
            notiSave.BalloonTipTitle = "Change Success";
            notiSave.Icon = SystemIcons.Exclamation;
            notiSave.ShowBalloonTip(1000);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void bhxh_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, bhxh.Text, 5);
        }

        private void bhyt_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, bhyt.Text, 5);

        }

        private void bhtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, bhtn.Text, 5);

        }

        private void gtgccn_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, gtgccn.Text, 9);

        }

        private void gtgcnpt_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, gtgcnpt.Text, 9);

        }

        private void mini_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, mini.Text, 9);

        }

        private void max_KeyPress(object sender, KeyPressEventArgs e)
        {
            u.numberOnly(e, max.Text, 9);

        }
    }
}
