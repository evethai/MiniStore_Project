namespace MiniStoreWinF.ManageSalary
{
    partial class frmAddNewSubSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewSubSalary));
            gbAddSub = new GroupBox();
            label6 = new Label();
            dtpEffect = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            btOKEdit = new Button();
            cbType = new ComboBox();
            cbCondi = new ComboBox();
            txtSalary = new TextBox();
            txtDis = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbAddSub.SuspendLayout();
            SuspendLayout();
            // 
            // gbAddSub
            // 
            gbAddSub.BackColor = SystemColors.ButtonHighlight;
            gbAddSub.Controls.Add(label6);
            gbAddSub.Controls.Add(dtpEffect);
            gbAddSub.Controls.Add(label5);
            gbAddSub.Controls.Add(label4);
            gbAddSub.Controls.Add(btOKEdit);
            gbAddSub.Controls.Add(cbType);
            gbAddSub.Controls.Add(cbCondi);
            gbAddSub.Controls.Add(txtSalary);
            gbAddSub.Controls.Add(txtDis);
            gbAddSub.Controls.Add(label3);
            gbAddSub.Controls.Add(label2);
            gbAddSub.Controls.Add(label1);
            gbAddSub.Location = new Point(3, 3);
            gbAddSub.Margin = new Padding(5, 4, 5, 4);
            gbAddSub.Name = "gbAddSub";
            gbAddSub.Padding = new Padding(5, 4, 5, 4);
            gbAddSub.Size = new Size(646, 527);
            gbAddSub.TabIndex = 3;
            gbAddSub.TabStop = false;
            gbAddSub.Text = "Add new allowance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 213);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 7;
            label6.Text = "Type";
            // 
            // dtpEffect
            // 
            dtpEffect.Format = DateTimePickerFormat.Short;
            dtpEffect.Location = new Point(278, 375);
            dtpEffect.Name = "dtpEffect";
            dtpEffect.Size = new Size(200, 33);
            dtpEffect.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 375);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 5;
            label5.Text = "Effect from to day";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 266);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 5;
            // 
            // btOKEdit
            // 
            btOKEdit.Location = new Point(320, 467);
            btOKEdit.Margin = new Padding(5, 4, 5, 4);
            btOKEdit.Name = "btOKEdit";
            btOKEdit.Size = new Size(118, 34);
            btOKEdit.TabIndex = 4;
            btOKEdit.Text = "OK";
            btOKEdit.UseVisualStyleBackColor = true;
            btOKEdit.Click += btOKEdit_Click;
            // 
            // cbType
            // 
            cbType.DropDownHeight = 50;
            cbType.FormattingEnabled = true;
            cbType.IntegralHeight = false;
            cbType.Items.AddRange(new object[] { "Month", "Day" });
            cbType.Location = new Point(278, 205);
            cbType.Margin = new Padding(5, 4, 5, 4);
            cbType.Name = "cbType";
            cbType.Size = new Size(200, 33);
            cbType.TabIndex = 3;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // cbCondi
            // 
            cbCondi.DropDownHeight = 50;
            cbCondi.FormattingEnabled = true;
            cbCondi.IntegralHeight = false;
            cbCondi.Location = new Point(278, 287);
            cbCondi.Margin = new Padding(5, 4, 5, 4);
            cbCondi.Name = "cbCondi";
            cbCondi.Size = new Size(200, 33);
            cbCondi.TabIndex = 3;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(278, 121);
            txtSalary.Margin = new Padding(5, 4, 5, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(200, 33);
            txtSalary.TabIndex = 2;
            txtSalary.KeyPress += txtSalary_KeyPress;
            // 
            // txtDis
            // 
            txtDis.Location = new Point(278, 51);
            txtDis.Margin = new Padding(5, 4, 5, 4);
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(200, 33);
            txtDis.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 295);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 1;
            label3.Text = "Condition";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 129);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Salary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 59);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "Discribe";
            // 
            // frmAddNewSubSalary
            // 
            AcceptButton = btOKEdit;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 534);
            Controls.Add(gbAddSub);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MaximumSize = new Size(575, 573);
            MinimumSize = new Size(575, 573);
            Name = "frmAddNewSubSalary";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddNewSubSalary_Load;
            gbAddSub.ResumeLayout(false);
            gbAddSub.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAddSub;
        private Button btOKEdit;
        private ComboBox cbCondi;
        private TextBox txtSalary;
        private TextBox txtDis;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpEffect;
        private Label label5;
        private Label label4;
        private Label label6;
        private ComboBox cbType;
    }
}