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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportWithOldSupplier));
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
            btExport.Location = new Point(16, 29);
            btExport.Margin = new Padding(5, 4, 5, 4);
            btExport.Name = "btExport";
            btExport.Size = new Size(132, 84);
            btExport.TabIndex = 31;
            btExport.Text = "Export Form";
            btExport.UseVisualStyleBackColor = false;
            btExport.Click += btExport_Click;
            // 
            // txtPathToImport
            // 
            txtPathToImport.Location = new Point(171, 29);
            txtPathToImport.Margin = new Padding(5, 4, 5, 4);
            txtPathToImport.Name = "txtPathToImport";
            txtPathToImport.Size = new Size(284, 33);
            txtPathToImport.TabIndex = 32;
            // 
            // btSelect
            // 
            btSelect.BackColor = SystemColors.ButtonShadow;
            btSelect.ForeColor = SystemColors.ActiveCaptionText;
            btSelect.Location = new Point(171, 72);
            btSelect.Margin = new Padding(5, 4, 5, 4);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(132, 40);
            btSelect.TabIndex = 33;
            btSelect.Text = "Select";
            btSelect.UseVisualStyleBackColor = false;
            btSelect.Click += btSelect_Click;
            // 
            // btImport
            // 
            btImport.BackColor = SystemColors.ButtonShadow;
            btImport.ForeColor = SystemColors.ActiveCaptionText;
            btImport.Location = new Point(325, 72);
            btImport.Margin = new Padding(5, 4, 5, 4);
            btImport.Name = "btImport";
            btImport.Size = new Size(132, 40);
            btImport.TabIndex = 34;
            btImport.Text = "Import";
            btImport.UseVisualStyleBackColor = false;
            btImport.Click += btImport_Click;
            // 
            // ImportWithOldSupplier
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 156);
            Controls.Add(btImport);
            Controls.Add(btSelect);
            Controls.Add(txtPathToImport);
            Controls.Add(btExport);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MaximumSize = new Size(491, 195);
            MinimumSize = new Size(491, 195);
            Name = "ImportWithOldSupplier";
            Text = "Old supplier";
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