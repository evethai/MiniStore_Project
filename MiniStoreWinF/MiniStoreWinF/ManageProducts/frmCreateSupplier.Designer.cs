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
            label17 = new Label();
            txtNoteSupplier = new TextBox();
            label16 = new Label();
            txtAddressSupplier = new TextBox();
            label15 = new Label();
            txtNameSupplier = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(95, 403);
            label17.Margin = new Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Size = new Size(53, 25);
            label17.TabIndex = 20;
            label17.Text = "Note";
            // 
            // txtNoteSupplier
            // 
            txtNoteSupplier.Anchor = AnchorStyles.Left;
            txtNoteSupplier.Location = new Point(336, 389);
            txtNoteSupplier.Margin = new Padding(5, 4, 5, 4);
            txtNoteSupplier.Multiline = true;
            txtNoteSupplier.Name = "txtNoteSupplier";
            txtNoteSupplier.Size = new Size(172, 54);
            txtNoteSupplier.TabIndex = 19;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(95, 236);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(79, 25);
            label16.TabIndex = 18;
            label16.Text = "Address";
            // 
            // txtAddressSupplier
            // 
            txtAddressSupplier.Anchor = AnchorStyles.Left;
            txtAddressSupplier.Location = new Point(336, 232);
            txtAddressSupplier.Margin = new Padding(5, 4, 5, 4);
            txtAddressSupplier.Name = "txtAddressSupplier";
            txtAddressSupplier.Size = new Size(172, 33);
            txtAddressSupplier.TabIndex = 17;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(95, 70);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(137, 25);
            label15.TabIndex = 16;
            label15.Text = "Name Supplier";
            // 
            // txtNameSupplier
            // 
            txtNameSupplier.Anchor = AnchorStyles.Left;
            txtNameSupplier.Location = new Point(336, 66);
            txtNameSupplier.Margin = new Padding(5, 4, 5, 4);
            txtNameSupplier.Name = "txtNameSupplier";
            txtNameSupplier.Size = new Size(172, 33);
            txtNameSupplier.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(610, 562);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(txtNameSupplier, 2, 0);
            tableLayoutPanel2.Controls.Add(txtAddressSupplier, 2, 1);
            tableLayoutPanel2.Controls.Add(txtNoteSupplier, 2, 2);
            tableLayoutPanel2.Controls.Add(label15, 1, 0);
            tableLayoutPanel2.Controls.Add(label16, 1, 1);
            tableLayoutPanel2.Controls.Add(label17, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 59);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(604, 500);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 24);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 19;
            label1.Text = "Information Of Supplier";
            // 
            // frmCreateSupplier
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 562);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MaximumSize = new Size(626, 601);
            MinimumSize = new Size(626, 601);
            Name = "frmCreateSupplier";
            Text = "Create supplier";
            FormClosed += frmCreateSupplier_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label17;
        private TextBox txtNoteSupplier;
        private Label label16;
        private TextBox txtAddressSupplier;
        private Label label15;
        private TextBox txtNameSupplier;
        private Button button2;
        private ComboBox cbIdSupplier;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
    }
}