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
            gbAddSub = new GroupBox();
            btOKEdit = new Button();
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
            gbAddSub.Controls.Add(btOKEdit);
            gbAddSub.Controls.Add(cbCondi);
            gbAddSub.Controls.Add(txtSalary);
            gbAddSub.Controls.Add(txtDis);
            gbAddSub.Controls.Add(label3);
            gbAddSub.Controls.Add(label2);
            gbAddSub.Controls.Add(label1);
            gbAddSub.Location = new Point(2, 2);
            gbAddSub.Name = "gbAddSub";
            gbAddSub.Size = new Size(252, 250);
            gbAddSub.TabIndex = 3;
            gbAddSub.TabStop = false;
            gbAddSub.Text = "Add New Subsidized Salary";
            // 
            // btOKEdit
            // 
            btOKEdit.Location = new Point(126, 204);
            btOKEdit.Name = "btOKEdit";
            btOKEdit.Size = new Size(75, 23);
            btOKEdit.TabIndex = 4;
            btOKEdit.Text = "OK";
            btOKEdit.UseVisualStyleBackColor = true;
            btOKEdit.Click += btOKEdit_Click;
            // 
            // cbCondi
            // 
            cbCondi.DropDownHeight = 50;
            cbCondi.FormattingEnabled = true;
            cbCondi.IntegralHeight = false;
            cbCondi.Location = new Point(107, 141);
            cbCondi.Name = "cbCondi";
            cbCondi.Size = new Size(121, 25);
            cbCondi.TabIndex = 3;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(107, 80);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(121, 25);
            txtSalary.TabIndex = 2;
            txtSalary.KeyPress += txtSalary_KeyPress;
            // 
            // txtDis
            // 
            txtDis.Location = new Point(107, 32);
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(121, 25);
            txtDis.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 149);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 1;
            label3.Text = "Condition";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 88);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 1;
            label2.Text = "Salary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 40);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 0;
            label1.Text = "Discribe";
            // 
            // frmAddNewSubSalary
            // 
            AcceptButton = btOKEdit;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 264);
            Controls.Add(gbAddSub);
            Name = "frmAddNewSubSalary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddNewSubSalary";
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
    }
}