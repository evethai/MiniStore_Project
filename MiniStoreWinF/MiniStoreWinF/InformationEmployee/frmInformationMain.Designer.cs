namespace MiniStoreWinF.InformationEmployee
{
    partial class frmInformationMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformationMain));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pbSalary = new PictureBox();
            pbInformation = new PictureBox();
            tlMain = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInformation).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pbSalary);
            panel1.Controls.Add(pbInformation);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 680);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 333);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 5;
            label3.Text = "WorkSheet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 229);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 4;
            label2.Text = "Last Month Salary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 129);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 3;
            label1.Text = "Personal Information";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pbSalary
            // 
            pbSalary.Image = (Image)resources.GetObject("pbSalary.Image");
            pbSalary.Location = new Point(22, 162);
            pbSalary.Name = "pbSalary";
            pbSalary.Size = new Size(104, 64);
            pbSalary.SizeMode = PictureBoxSizeMode.Zoom;
            pbSalary.TabIndex = 1;
            pbSalary.TabStop = false;
            pbSalary.Click += pbSalary_Click;
            // 
            // pbInformation
            // 
            pbInformation.Image = (Image)resources.GetObject("pbInformation.Image");
            pbInformation.Location = new Point(22, 62);
            pbInformation.Name = "pbInformation";
            pbInformation.Size = new Size(104, 64);
            pbInformation.SizeMode = PictureBoxSizeMode.Zoom;
            pbInformation.TabIndex = 0;
            pbInformation.TabStop = false;
            pbInformation.Click += pictureBox1_Click;
            // 
            // tlMain
            // 
            tlMain.ColumnCount = 1;
            tlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlMain.Dock = DockStyle.Fill;
            tlMain.Location = new Point(148, 0);
            tlMain.Name = "tlMain";
            tlMain.RowCount = 1;
            tlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlMain.Size = new Size(1475, 680);
            tlMain.TabIndex = 1;
            // 
            // frmInformationMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1623, 680);
            Controls.Add(tlMain);
            Controls.Add(panel1);
            Name = "frmInformationMain";
            Text = "frmInformationMain";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInformation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tlMain;
        private PictureBox pbInformation;
        private PictureBox pictureBox3;
        private PictureBox pbSalary;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}