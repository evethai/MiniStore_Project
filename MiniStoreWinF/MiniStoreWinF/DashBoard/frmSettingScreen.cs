using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.DashBoard
{
    public partial class frmSettingScreen : Form
    {
        private Font selectedFont; // Lưu trữ kiểu font được chọn
        private Color currentColor;
        public frmSettingScreen()
        {
            InitializeComponent();
            LoadAvailableFonts();
            currentColor = this.BackColor;
            numSize.Value = 12;

        }

        private void frmSettingScreen_Load(object sender, EventArgs e)
        {

        }
        private void LoadAvailableFonts()
        {
            // Lấy danh sách các font chữ khả dụng
            FontFamily[] fontFamilies = FontFamily.Families;

            // Đưa danh sách font chữ vào ComboBox
            foreach (FontFamily fontFamily in fontFamilies)
            {
                // Kiểm tra nếu font chữ là TrueType hoặc OpenType
                if (fontFamily.IsStyleAvailable(FontStyle.Regular))
                {
                    // Thêm tên font chữ vào ComboBox
                    cbFont.Items.Add(fontFamily.Name);
                }
            }
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = cbFont.SelectedItem.ToString();

            // Tạo kiểu font mới từ tên font được chọn
            selectedFont = new Font(selectedFontName, 12);
        }
        private void ApplyFontToAllForms(FormCollection forms)
        {
            // Đổi font cho từng Form trong FormCollection
            foreach (Form form in forms)
            {
                form.Font = selectedFont; // Đặt kiểu font mới

                // Kiểm tra nếu Form có chứa các control con
                if (form.HasChildren)
                {
                    ApplyFontToControls(form.Controls); // Áp dụng font cho các control con trong Form
                }
            }
        }
        private void ApplyFontToControls(Control.ControlCollection controls)
        {
            // Đổi font cho từng điều khiển trong ControlCollection
            foreach (Control control in controls)
            {
                control.Font = selectedFont; // Đặt kiểu font mới

                // Kiểm tra nếu control có chứa các control con
                if (control.HasChildren)
                {
                    ApplyFontToControls(control.Controls); // Đệ quy để đặt font cho các control con
                }
            }
        }
        private void btApply_Click(object sender, EventArgs e)
        {
            ApplyFontToAllForms(Application.OpenForms);

        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {

        }



    }
}