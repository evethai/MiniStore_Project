namespace MiniStoreWinF.ManageProducts
{
    partial class ImportWithOldSupplier
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
            btExport.Location = new Point(12, 23);
            btExport.Name = "btExport";
            btExport.Size = new Size(96, 67);
            btExport.TabIndex = 31;
            btExport.Text = "Export Form";
            btExport.UseVisualStyleBackColor = false;
            btExport.Click += btExport_Click;
            // 
            // txtPathToImport
            // 
            txtPathToImport.Location = new Point(125, 23);
            txtPathToImport.Name = "txtPathToImport";
            txtPathToImport.Size = new Size(208, 27);
            txtPathToImport.TabIndex = 32;
            // 
            // btSelect
            // 
            btSelect.BackColor = SystemColors.ButtonShadow;
            btSelect.ForeColor = SystemColors.ActiveCaptionText;
            btSelect.Location = new Point(125, 58);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(96, 32);
            btSelect.TabIndex = 33;
            btSelect.Text = "Select";
            btSelect.UseVisualStyleBackColor = false;
            btSelect.Click += btSelect_Click;
            // 
            // btImport
            // 
            btImport.BackColor = SystemColors.ButtonShadow;
            btImport.ForeColor = SystemColors.ActiveCaptionText;
            btImport.Location = new Point(237, 58);
            btImport.Name = "btImport";
            btImport.Size = new Size(96, 32);
            btImport.TabIndex = 34;
            btImport.Text = "Import";
            btImport.UseVisualStyleBackColor = false;
            btImport.Click += btImport_Click;
            // 
            // ImportWithOldSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 125);
            Controls.Add(btImport);
            Controls.Add(btSelect);
            Controls.Add(txtPathToImport);
            Controls.Add(btExport);
            Name = "ImportWithOldSupplier";
            Text = "ImportWithOldSupplier";
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