namespace MiniStoreWinF.ManageSalary
{
    partial class frmResetSalaryCheck
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
            dtpTime = new DateTimePicker();
            btReset = new Button();
            SuspendLayout();
            // 
            // dtpTime
            // 
            dtpTime.CustomFormat = "MM/yyyy";
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.Location = new Point(19, 18);
            dtpTime.Margin = new Padding(5, 4, 5, 4);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(279, 33);
            dtpTime.TabIndex = 0;
            // 
            // btReset
            // 
            btReset.Location = new Point(91, 178);
            btReset.Margin = new Padding(5, 4, 5, 4);
            btReset.Name = "btReset";
            btReset.Size = new Size(118, 34);
            btReset.TabIndex = 1;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // frmResetSalaryCheck
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(314, 229);
            Controls.Add(btReset);
            Controls.Add(dtpTime);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Red;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmResetSalaryCheck";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpTime;
        private Button btReset;
    }
}