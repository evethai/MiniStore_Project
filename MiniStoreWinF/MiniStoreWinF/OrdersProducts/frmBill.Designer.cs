namespace MiniStoreWinF.OrdersProducts
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            Logo = new Panel();
            panel1 = new Panel();
            btLogo = new Button();
            button1 = new Button();
            Logo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Controls.Add(panel1);
            Logo.Dock = DockStyle.Top;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(479, 125);
            Logo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btLogo);
            panel1.Location = new Point(154, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 125);
            panel1.TabIndex = 0;
            // 
            // btLogo
            // 
            btLogo.BackColor = SystemColors.Control;
            btLogo.BackgroundImage = (Image)resources.GetObject("btLogo.BackgroundImage");
            btLogo.BackgroundImageLayout = ImageLayout.Zoom;
            btLogo.Dock = DockStyle.Fill;
            btLogo.Location = new Point(0, 0);
            btLogo.Name = "btLogo";
            btLogo.Size = new Size(162, 125);
            btLogo.TabIndex = 0;
            btLogo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(182, 641);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Lose";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 682);
            Controls.Add(button1);
            Controls.Add(Logo);
            Name = "frmBill";
            Text = "Bill";
            FormClosed += frmBill_FormClosed;
            Logo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Logo;
        private Panel panel1;
        private Button btLogo;
        private Button button1;
    }
}