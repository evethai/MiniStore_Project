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
            label2 = new Label();
            label1 = new Label();
            pbSalary = new PictureBox();
            pbInformation = new PictureBox();
            tlMain = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInformation).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbSalary);
            panel1.Controls.Add(pbInformation);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 510);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 172);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Month Salary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 97);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 3;
            label1.Text = "Personal Information";
            // 
            // pbSalary
            // 
            pbSalary.Image = (Image)resources.GetObject("pbSalary.Image");
            pbSalary.Location = new Point(19, 122);
            pbSalary.Margin = new Padding(3, 2, 3, 2);
            pbSalary.Name = "pbSalary";
            pbSalary.Size = new Size(91, 48);
            pbSalary.SizeMode = PictureBoxSizeMode.Zoom;
            pbSalary.TabIndex = 1;
            pbSalary.TabStop = false;
            pbSalary.Click += pbSalary_Click;
            // 
            // pbInformation
            // 
            pbInformation.Image = (Image)resources.GetObject("pbInformation.Image");
            pbInformation.Location = new Point(19, 46);
            pbInformation.Margin = new Padding(3, 2, 3, 2);
            pbInformation.Name = "pbInformation";
            pbInformation.Size = new Size(91, 48);
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
            tlMain.Location = new Point(130, 0);
            tlMain.Margin = new Padding(3, 2, 3, 2);
            tlMain.Name = "tlMain";
            tlMain.RowCount = 1;
            tlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlMain.Size = new Size(884, 510);
            tlMain.TabIndex = 1;
            // 
            // frmInformationMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 510);
            Controls.Add(tlMain);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmInformationMain";
            Text = "Employee's information";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInformation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tlMain;
        private PictureBox pbInformation;
        private PictureBox pbSalary;
        private Label label2;
        private Label label1;
    }
}