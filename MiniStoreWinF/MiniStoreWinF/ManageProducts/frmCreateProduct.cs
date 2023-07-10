using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.ManageProducts
{
    public partial class frmCreateProduct : Form
    {
        CatalogyService _comboType;
        SupplierServices _comboIdSup;
        string url = "";

        public frmCreateProduct()
        {
            InitializeComponent();

            _comboType = new CatalogyService();
            var _listComboProduct = _comboType.GetAll()
                .Select(c => new { c.IdCa, c.ProductType }).ToList();
            cbTypeProduct.ValueMember = "IdCa";
            cbTypeProduct.DisplayMember = "ProductType";
            cbTypeProduct.DataSource = _listComboProduct;

            _comboIdSup = new SupplierServices();
            var _listcomboIdSup = _comboIdSup.GetAll()
                .Select(c => new { c.IdSupplier, c.NameSupplier }).ToList();
            cbIdSupplier.ValueMember = "IdSupplier";
            cbIdSupplier.DisplayMember = "NameSupplier";
            cbIdSupplier.DataSource = _listcomboIdSup;
        }
        public TextBox TextBoxProductData => txtNameProduct;
        public ComboBox TextBoxProductData1 => cbTypeProduct;
        public ComboBox TextBoxProductData2 => cbIdSupplier;
        public DateTimePicker TextBoxProductData3 => dateEXP;
        public DateTimePicker TextBoxProductData4 => dateMFG;
        public DateTimePicker TextBoxProductData5 => dateDateImport;
        public ComboBox TextBoxProductData7 => cbStatus;
        public PictureBox TextBoxProductData8 => PictureProduct;
        public TextBox TextBoxProductData9 => txtPathPic;
        private void frmCreateProduct_FormClosed(object sender, FormClosedEventArgs e)
        {

            //FormDataStorage.ProductData = txtNameProduct.Text;
            //FormDataStorage.ProductData = cbTypeProduct.Text;
            //FormDataStorage.ProductData = cbIdSupplier.Text;
            //FormDataStorage.ProductData = dateEXP.Value.ToString();
            //FormDataStorage.ProductData = dateMFG.Value.ToString();
            //FormDataStorage.ProductData = dateDateImport.Value.ToString();
            //FormDataStorage.ProductData = cbStatus.Text;
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    PictureProduct.Image.Save(ms, PictureProduct.Image.RawFormat); // Lưu trữ hình ảnh vào MemoryStream
            //    byte[] imageBytes = ms.ToArray(); // Chuyển đổi hình ảnh thành mảng byte
            //    string base64String = Convert.ToBase64String(imageBytes); // Chuyển đổi mảng byte thành chuỗi Base64

            //    FormDataStorage.ProductData = base64String; // Gán chuỗi Base64 vào ProductData
            //}
            //FormDataStorage.ProductData = txtPathPic.Text;

        }
        public void Clear_Click(object sender, EventArgs e)
        {
            txtNameProduct.Text = "";
            //cbTypeProduct.SelectedIndex = 0;
            //cbIdSupplier.SelectedIndex = 0;
            dateEXP.Value = default;
            dateMFG.Value = default;
            dateDateImport.Value = default;
            //cbStatus.SelectedIndex = 0;
            txtPathPic.Text = "";
            PictureProduct.Image = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPathPic.Text = dlg.FileName;
                    PictureProduct.Image = new Bitmap(dlg.FileName);
                    url = dlg.FileName;
                }
            }
        }
        public void UpdateIDsupComboBox()
        {
            // Xóa tất cả các mục hiện có trong ComboBox IDsup

            var suppliers = FormDataStorage.CreateSupplier.ProductData;

            if (suppliers == "")
            {
                _comboIdSup = new SupplierServices();
                var _listcomboIdSup = _comboIdSup.GetAll()
                    .Select(c => new { c.IdSupplier, c.NameSupplier }).ToList();
                cbIdSupplier.ValueMember = "IdSupplier";
                cbIdSupplier.DisplayMember = "NameSupplier";
                cbIdSupplier.DataSource = _listcomboIdSup;
            }
            else
            {
                var supplierList = suppliers?.Split(',').ToList();

                // Gán danh sách supplierList làm nguồn dữ liệu cho cbIdSupplier
                cbIdSupplier.DataSource = supplierList;
            }
        }
    }
}
