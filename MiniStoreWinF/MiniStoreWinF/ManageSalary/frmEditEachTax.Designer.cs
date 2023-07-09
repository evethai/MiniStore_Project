namespace MiniStoreWinF.ManageSalary
{
    partial class frmEditEachTax
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditEachTax));
            btSave = new Button();
            txtTax = new TextBox();
            label5 = new Label();
            notiSave = new NotifyIcon(components);
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.Location = new Point(155, 114);
            btSave.Margin = new Padding(5, 4, 5, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 34);
            btSave.TabIndex = 6;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(243, 37);
            txtTax.Margin = new Padding(5, 4, 5, 4);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(155, 33);
            txtTax.TabIndex = 5;
            txtTax.KeyPress += txtNewEmp_KeyPress_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 37);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 4;
            label5.Text = "New basic tax";
            // 
            // notiSave
            // 
            notiSave.Text = "notifyIcon1";
            notiSave.Visible = true;
            // 
            // frmEditEachTax
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 190);
            Controls.Add(btSave);
            Controls.Add(txtTax);
            Controls.Add(label5);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(462, 229);
            MinimumSize = new Size(462, 229);
            Name = "frmEditEachTax";
            Text = "Edit new tax";
            Load += frmEditEachTax_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSave;
        private TextBox txtTax;
        private Label label5;
        private NotifyIcon notiSave;
    }
}