namespace MiniStoreWinF.DashBoard
{
    partial class frmSettingScreen
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
            lbSetting = new Label();
            label1 = new Label();
            cbColor = new ComboBox();
            label2 = new Label();
            cbFont = new ComboBox();
            btApply = new Button();
            numSize = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            SuspendLayout();
            // 
            // lbSetting
            // 
            lbSetting.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbSetting.Location = new Point(12, 9);
            lbSetting.Name = "lbSetting";
            lbSetting.Size = new Size(150, 56);
            lbSetting.TabIndex = 0;
            lbSetting.Text = "Setting";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 80);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "App color";
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "White", "Black" });
            cbColor.Location = new Point(112, 77);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(159, 28);
            cbColor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 130);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "Font";
            // 
            // cbFont
            // 
            cbFont.FormattingEnabled = true;
            cbFont.Location = new Point(112, 127);
            cbFont.Name = "cbFont";
            cbFont.Size = new Size(159, 28);
            cbFont.TabIndex = 4;
            cbFont.SelectedIndexChanged += cbFont_SelectedIndexChanged;
            // 
            // btApply
            // 
            btApply.Location = new Point(177, 279);
            btApply.Name = "btApply";
            btApply.Size = new Size(94, 29);
            btApply.TabIndex = 5;
            btApply.Text = "Apply";
            btApply.UseVisualStyleBackColor = true;
            btApply.Click += btApply_Click;
            // 
            // numSize
            // 
            numSize.Location = new Point(112, 174);
            numSize.Name = "numSize";
            numSize.Size = new Size(150, 27);
            numSize.TabIndex = 6;
            numSize.ValueChanged += numSize_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 176);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "Size";
            // 
            // frmSettingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 648);
            Controls.Add(label3);
            Controls.Add(numSize);
            Controls.Add(btApply);
            Controls.Add(cbFont);
            Controls.Add(label2);
            Controls.Add(cbColor);
            Controls.Add(label1);
            Controls.Add(lbSetting);
            Name = "frmSettingScreen";
            Text = "frmSettingScreen";
            Load += frmSettingScreen_Load;
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSetting;
        private Label label1;
        private ComboBox cbColor;
        private Label label2;
        private ComboBox cbFont;
        private Button btApply;
        private NumericUpDown numSize;
        private Label label3;
    }
}