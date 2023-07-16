namespace MiniStoreWinF.ManageEmployees
{
    partial class frmAddSubForEmployee
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
            cbTypeSub = new ComboBox();
            dtpTimeEnd = new DateTimePicker();
            dtpTimeStart = new DateTimePicker();
            btAddSub = new Button();
            idEmp = new TextBox();
            SuspendLayout();
            // 
            // cbTypeSub
            // 
            cbTypeSub.FormattingEnabled = true;
            cbTypeSub.Location = new Point(12, 140);
            cbTypeSub.Name = "cbTypeSub";
            cbTypeSub.Size = new Size(100, 23);
            cbTypeSub.TabIndex = 1;
            cbTypeSub.SelectedIndexChanged += cbTypeSub_SelectedIndexChanged;
            // 
            // dtpTimeEnd
            // 
            dtpTimeEnd.Location = new Point(12, 283);
            dtpTimeEnd.Name = "dtpTimeEnd";
            dtpTimeEnd.Size = new Size(200, 23);
            dtpTimeEnd.TabIndex = 2;
            // 
            // dtpTimeStart
            // 
            dtpTimeStart.Location = new Point(12, 200);
            dtpTimeStart.Name = "dtpTimeStart";
            dtpTimeStart.Size = new Size(200, 23);
            dtpTimeStart.TabIndex = 3;
            // 
            // btAddSub
            // 
            btAddSub.Location = new Point(12, 322);
            btAddSub.Name = "btAddSub";
            btAddSub.Size = new Size(75, 23);
            btAddSub.TabIndex = 4;
            btAddSub.Text = "Add";
            btAddSub.UseVisualStyleBackColor = true;
            btAddSub.Click += btAddSub_Click;
            // 
            // idEmp
            // 
            idEmp.Enabled = false;
            idEmp.Location = new Point(12, 53);
            idEmp.Name = "idEmp";
            idEmp.Size = new Size(100, 23);
            idEmp.TabIndex = 5;
            // 
            // frmAddSubForEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 450);
            Controls.Add(idEmp);
            Controls.Add(btAddSub);
            Controls.Add(dtpTimeStart);
            Controls.Add(dtpTimeEnd);
            Controls.Add(cbTypeSub);
            Name = "frmAddSubForEmployee";
            Text = "frmAddSubForEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbTypeSub;
        private DateTimePicker dtpTimeEnd;
        private DateTimePicker dtpTimeStart;
        private Button btAddSub;
        private TextBox idEmp;
    }
}