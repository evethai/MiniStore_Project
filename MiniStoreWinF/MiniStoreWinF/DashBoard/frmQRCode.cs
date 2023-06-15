using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing;
using ZXing.Rendering;
using ZXing.Windows.Compatibility;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace MiniStoreWinF.DashBoard
{
    public partial class frmQRCode : Form
    {
        public frmQRCode()
        {
            InitializeComponent();
        }

        public void CreatQRCode()
        {
            //var qr_code = $"2|99|{txt_phone.Text.Trim()}|{txt_name.Text.Trim()}|{txt_email.Text.Trim()}|0|0|{txt_sotien.Text.Trim()}";
            //BarcodeWriter barcodeWriter = new BarcodeWriter();
            //EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
            //encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            //barcodeWriter.Renderer = new BitmapRenderer();
            //barcodeWriter.Options = encodingOptions;
            //barcodeWriter.Format = BarcodeFormat.QR_CODE;
            //Bitmap bitmap = barcodeWriter.Write(qr_code);
            //Bitmap logo = resizeImage(Properties.Resources.MoMo, 64, 64) as Bitmap;
            //Graphics g = Graphics.FromImage(bitmap);
            //g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            //pictureBox1.Image = bitmap;
        }

        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void frmQRCode_Load(object sender, EventArgs e)
        {
            CreatQRCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var qr_code = $"2|99|{txt_phone.Text.Trim()}|{txt_name.Text.Trim()}|{txt_email.Text.Trim()}|0|0|{txt_sotien.Text.Trim()}";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qr_code);
            Bitmap logo = resizeImage(Properties.Resources.MoMo, 64, 64) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            pictureBox1.Image = bitmap;
        }
    }
}
