namespace MiniStoreWinF.ManageProducts
{
    partial class frmCreateSupplier
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
            panalIdSupplier = new Panel();
            label17 = new Label();
            txtNoteSupplier = new TextBox();
            label16 = new Label();
            txtAddressSupplier = new TextBox();
            label15 = new Label();
            txtNameSupplier = new TextBox();
            panelSupplier = new Panel();
            label14 = new Label();
            panalIdSupplier.SuspendLayout();
            panelSupplier.SuspendLayout();
            SuspendLayout();
            // 
            // panalIdSupplier
            // 
            panalIdSupplier.BorderStyle = BorderStyle.FixedSingle;
            panalIdSupplier.Controls.Add(label17);
            panalIdSupplier.Controls.Add(txtNoteSupplier);
            panalIdSupplier.Controls.Add(label16);
            panalIdSupplier.Controls.Add(txtAddressSupplier);
            panalIdSupplier.Controls.Add(label15);
            panalIdSupplier.Controls.Add(txtNameSupplier);
            panalIdSupplier.Location = new Point(39, 72);
            panalIdSupplier.Name = "panalIdSupplier";
            panalIdSupplier.Size = new Size(308, 237);
            panalIdSupplier.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(15, 85);
            label17.Name = "label17";
            label17.Size = new Size(37, 17);
            label17.TabIndex = 20;
            label17.Text = "Note";
            // 
            // txtNoteSupplier
            // 
            txtNoteSupplier.Location = new Point(112, 80);
            txtNoteSupplier.Multiline = true;
            txtNoteSupplier.Name = "txtNoteSupplier";
            txtNoteSupplier.Size = new Size(126, 62);
            txtNoteSupplier.TabIndex = 19;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(15, 52);
            label16.Name = "label16";
            label16.Size = new Size(56, 17);
            label16.TabIndex = 18;
            label16.Text = "Address";
            // 
            // txtAddressSupplier
            // 
            txtAddressSupplier.Location = new Point(112, 47);
            txtAddressSupplier.Name = "txtAddressSupplier";
            txtAddressSupplier.Size = new Size(126, 27);
            txtAddressSupplier.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(15, 19);
            label15.Name = "label15";
            label15.Size = new Size(95, 17);
            label15.TabIndex = 16;
            label15.Text = "Name Supplier";
            // 
            // txtNameSupplier
            // 
            txtNameSupplier.Location = new Point(112, 14);
            txtNameSupplier.Name = "txtNameSupplier";
            txtNameSupplier.Size = new Size(126, 27);
            txtNameSupplier.TabIndex = 15;
            // 
            // panelSupplier
            // 
            panelSupplier.BorderStyle = BorderStyle.FixedSingle;
            panelSupplier.Controls.Add(label14);
            panelSupplier.Location = new Point(38, 25);
            panelSupplier.Name = "panelSupplier";
            panelSupplier.Size = new Size(309, 41);
            panelSupplier.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(73, 10);
            label14.Name = "label14";
            label14.Size = new Size(166, 20);
            label14.TabIndex = 0;
            label14.Text = "Information Of Supplier";
            // 
            // frmCreateSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 450);
            Controls.Add(panalIdSupplier);
            Controls.Add(panelSupplier);
            Name = "frmCreateSupplier";
            Text = "frmCreateSupplier";
            FormClosed += frmCreateSupplier_FormClosed;
            panalIdSupplier.ResumeLayout(false);
            panalIdSupplier.PerformLayout();
            panelSupplier.ResumeLayout(false);
            panelSupplier.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panalIdSupplier;
        private Label label17;
        private TextBox txtNoteSupplier;
        private Label label16;
        private TextBox txtAddressSupplier;
        private Label label15;
        private TextBox txtNameSupplier;
        private Button button2;
        private ComboBox cbIdSupplier;
        private Label label4;
        private Panel panelSupplier;
        private Label label14;
    }
}