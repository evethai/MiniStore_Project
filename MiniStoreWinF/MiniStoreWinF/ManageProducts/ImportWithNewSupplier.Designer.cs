namespace MiniStoreWinF.ManageProducts
{
    partial class ImportWithNewSupplier
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
            btExport = new Button();
            txtPathToImport = new TextBox();
            btSelect = new Button();
            btImport = new Button();
            SuspendLayout();
            // 
            // btExport
            // 
            btExport.BackColor = SystemColors.ButtonShadow;
            btExport.ForeColor = SystemColors.ActiveCaptionText;
            btExport.Location = new Point(12, 21);
            btExport.Name = "btExport";
            btExport.Size = new Size(96, 67);
            btExport.TabIndex = 30;
            btExport.Text = "Export Form";
            btExport.UseVisualStyleBackColor = false;
            btExport.Click += btExport_Click;
            // 
            // txtPathToImport
            // 
            txtPathToImport.Location = new Point(129, 21);
            txtPathToImport.Name = "txtPathToImport";
            txtPathToImport.Size = new Size(208, 27);
            txtPathToImport.TabIndex = 31;
            // 
            // btSelect
            // 
            btSelect.BackColor = SystemColors.ButtonShadow;
            btSelect.ForeColor = SystemColors.ActiveCaptionText;
            btSelect.Location = new Point(129, 56);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(96, 32);
            btSelect.TabIndex = 32;
            btSelect.Text = "Select";
            btSelect.UseVisualStyleBackColor = false;
            btSelect.Click += btSelect_Click;
            // 
            // btImport
            // 
            btImport.BackColor = SystemColors.ButtonShadow;
            btImport.ForeColor = SystemColors.ActiveCaptionText;
            btImport.Location = new Point(241, 56);
            btImport.Name = "btImport";
            btImport.Size = new Size(96, 32);
            btImport.TabIndex = 33;
            btImport.Text = "Import";
            btImport.UseVisualStyleBackColor = false;
            btImport.Click += btImport_Click;
            // 
            // ImportWithNewSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 129);
            Controls.Add(btImport);
            Controls.Add(btSelect);
            Controls.Add(txtPathToImport);
            Controls.Add(btExport);
            Name = "ImportWithNewSupplier";
            Text = "ImportWithNewSupplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExport;
        private TextBox txtPathToImport;
        private Button btSelect;
        private Button btImport;
    }
}