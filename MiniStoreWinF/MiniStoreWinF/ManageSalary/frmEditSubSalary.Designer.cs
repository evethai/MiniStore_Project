namespace MiniStoreWinF.ManageSalary
{
    partial class frmEditSubSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditSubSalary));
            gbAddSub = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            dtpEffect = new DateTimePicker();
            btRemove = new Button();
            btUpdate = new Button();
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
            gbAddSub.Controls.Add(label5);
            gbAddSub.Controls.Add(label4);
            gbAddSub.Controls.Add(dtpEffect);
            gbAddSub.Controls.Add(btRemove);
            gbAddSub.Controls.Add(btUpdate);
            gbAddSub.Controls.Add(cbType);
            gbAddSub.Controls.Add(cbCondi);
            gbAddSub.Controls.Add(txtSalary);
            gbAddSub.Controls.Add(txtDis);
            gbAddSub.Controls.Add(label3);
            gbAddSub.Controls.Add(label2);
            gbAddSub.Controls.Add(label1);
            gbAddSub.Location = new Point(0, 4);
            gbAddSub.Margin = new Padding(5, 4, 5, 4);
            gbAddSub.Name = "gbAddSub";
            gbAddSub.Padding = new Padding(5, 4, 5, 4);
            gbAddSub.Size = new Size(585, 496);
            gbAddSub.TabIndex = 4;
            gbAddSub.TabStop = false;
            gbAddSub.Text = "Edit Subsidized Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 200);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 7;
            label5.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 354);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 6;
            label4.Text = "Time effect";
            // 
            // dtpEffect
            // 
            dtpEffect.Format = DateTimePickerFormat.Short;
            dtpEffect.Location = new Point(348, 346);
            dtpEffect.Name = "dtpEffect";
            dtpEffect.Size = new Size(200, 33);
            dtpEffect.TabIndex = 5;
            // 
            // btRemove
            // 
            btRemove.BackColor = Color.Red;
            btRemove.ForeColor = SystemColors.ButtonHighlight;
            btRemove.Location = new Point(142, 421);
            btRemove.Margin = new Padding(5, 4, 5, 4);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(118, 34);
            btRemove.TabIndex = 4;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = false;
            btRemove.Click += btRemove_Click;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = Color.Lime;
            btUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btUpdate.Location = new Point(303, 421);
            btUpdate.Margin = new Padding(5, 4, 5, 4);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(118, 34);
            btUpdate.TabIndex = 4;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // cbType
            // 
            cbType.DropDownHeight = 50;
            cbType.FormattingEnabled = true;
            cbType.IntegralHeight = false;
            cbType.Location = new Point(348, 192);
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
            cbCondi.Location = new Point(348, 274);
            cbCondi.Margin = new Padding(5, 4, 5, 4);
            cbCondi.Name = "cbCondi";
            cbCondi.Size = new Size(200, 33);
            cbCondi.TabIndex = 3;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(348, 118);
            txtSalary.Margin = new Padding(5, 4, 5, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(200, 33);
            txtSalary.TabIndex = 2;
            txtSalary.KeyPress += txtSalary_KeyPress;
            // 
            // txtDis
            // 
            txtDis.Location = new Point(348, 47);
            txtDis.Margin = new Padding(5, 4, 5, 4);
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(200, 33);
            txtDis.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 274);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(250, 25);
            label3.TabIndex = 1;
            label3.Text = "Condition (number of sheet)";
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
            // frmEditSubSalary
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 497);
            Controls.Add(gbAddSub);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(598, 536);
            MinimizeBox = false;
            MinimumSize = new Size(598, 536);
            Name = "frmEditSubSalary";
            Load += frmEditSubSalary_Load;
            gbAddSub.ResumeLayout(false);
            gbAddSub.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAddSub;
        private Button btRemove;
        private Button btUpdate;
        private ComboBox cbCondi;
        private TextBox txtSalary;
        private TextBox txtDis;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DateTimePicker dtpEffect;
        private Label label5;
        private ComboBox cbType;
    }
}