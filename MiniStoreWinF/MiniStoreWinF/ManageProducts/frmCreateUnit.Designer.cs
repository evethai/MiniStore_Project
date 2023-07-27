namespace MiniStoreWinF.ManageProducts
{
    partial class frmCreateUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateUnit));
            panelInForUnit = new Panel();
            cbNameUnit = new ComboBox();
            cbNameProduct = new ComboBox();
            label1 = new Label();
            txtPriceEx = new TextBox();
            txtPriceIm = new TextBox();
            label13 = new Label();
            label8 = new Label();
            numericQuantity = new NumericUpDown();
            label7 = new Label();
            label2 = new Label();
            panelUnit = new Panel();
            labelInfor = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelInForUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            panelUnit.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelInForUnit
            // 
            panelInForUnit.BorderStyle = BorderStyle.FixedSingle;
            panelInForUnit.Controls.Add(cbNameUnit);
            panelInForUnit.Controls.Add(cbNameProduct);
            panelInForUnit.Controls.Add(label1);
            panelInForUnit.Controls.Add(txtPriceEx);
            panelInForUnit.Controls.Add(txtPriceIm);
            panelInForUnit.Controls.Add(label13);
            panelInForUnit.Controls.Add(label8);
            panelInForUnit.Controls.Add(numericQuantity);
            panelInForUnit.Controls.Add(label7);
            panelInForUnit.Controls.Add(label2);
            panelInForUnit.Dock = DockStyle.Fill;
            panelInForUnit.Location = new Point(5, 60);
            panelInForUnit.Margin = new Padding(5, 4, 5, 4);
            panelInForUnit.Name = "panelInForUnit";
            panelInForUnit.Size = new Size(575, 498);
            panelInForUnit.TabIndex = 5;
            // 
            // cbNameUnit
            // 
            cbNameUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNameUnit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbNameUnit.FormattingEnabled = true;
            cbNameUnit.Location = new Point(221, 162);
            cbNameUnit.Margin = new Padding(5, 4, 5, 4);
            cbNameUnit.Name = "cbNameUnit";
            cbNameUnit.Size = new Size(265, 33);
            cbNameUnit.TabIndex = 20;
            // 
            // cbNameProduct
            // 
            cbNameProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNameProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbNameProduct.FormattingEnabled = true;
            cbNameProduct.Location = new Point(221, 95);
            cbNameProduct.Margin = new Padding(5, 4, 5, 4);
            cbNameProduct.Name = "cbNameProduct";
            cbNameProduct.Size = new Size(265, 33);
            cbNameProduct.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 95);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 18;
            label1.Text = "Name Product";
            // 
            // txtPriceEx
            // 
            txtPriceEx.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPriceEx.Location = new Point(221, 350);
            txtPriceEx.Margin = new Padding(5, 4, 5, 4);
            txtPriceEx.Name = "txtPriceEx";
            txtPriceEx.Size = new Size(328, 33);
            txtPriceEx.TabIndex = 17;
            txtPriceEx.KeyPress += txtPriceIm_KeyPress;
            // 
            // txtPriceIm
            // 
            txtPriceIm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPriceIm.Location = new Point(221, 302);
            txtPriceIm.Margin = new Padding(5, 4, 5, 4);
            txtPriceIm.Name = "txtPriceIm";
            txtPriceIm.Size = new Size(328, 33);
            txtPriceIm.TabIndex = 16;
            txtPriceIm.KeyPress += txtPriceIm_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(61, 350);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(113, 25);
            label13.TabIndex = 15;
            label13.Text = "Price Export";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(61, 295);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(115, 25);
            label8.TabIndex = 14;
            label8.Text = "Price Import";
            // 
            // numericQuantity
            // 
            numericQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericQuantity.Location = new Point(221, 224);
            numericQuantity.Margin = new Padding(5, 4, 5, 4);
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(179, 33);
            numericQuantity.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(61, 226);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 12;
            label7.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 162);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 11;
            label2.Text = "Name Unit";
            // 
            // panelUnit
            // 
            panelUnit.BorderStyle = BorderStyle.FixedSingle;
            panelUnit.Controls.Add(labelInfor);
            panelUnit.Dock = DockStyle.Fill;
            panelUnit.Location = new Point(5, 4);
            panelUnit.Margin = new Padding(5, 4, 5, 4);
            panelUnit.Name = "panelUnit";
            panelUnit.Size = new Size(575, 48);
            panelUnit.TabIndex = 4;
            // 
            // labelInfor
            // 
            labelInfor.AutoSize = true;
            labelInfor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfor.Location = new Point(197, 4);
            labelInfor.Margin = new Padding(5, 0, 5, 0);
            labelInfor.Name = "labelInfor";
            labelInfor.Size = new Size(223, 32);
            labelInfor.TabIndex = 0;
            labelInfor.Text = "Information Of Unit";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelInForUnit, 0, 1);
            tableLayoutPanel1.Controls.Add(panelUnit, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(585, 562);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // frmCreateUnit
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 562);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MaximumSize = new Size(601, 601);
            MinimumSize = new Size(601, 601);
            Name = "frmCreateUnit";
            Text = "Create units";
            FormClosed += frmCreateUnit_FormClosed;
            panelInForUnit.ResumeLayout(false);
            panelInForUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            panelUnit.ResumeLayout(false);
            panelUnit.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInForUnit;
        private TextBox txtPriceEx;
        private TextBox txtPriceIm;
        private Label label13;
        private Label label8;
        private NumericUpDown numericQuantity;
        private Label label7;
        private Label label2;
        private Panel panelUnit;
        private Label labelInfor;
        private ComboBox cbNameProduct;
        private Label label1;
        private ComboBox cbNameUnit;
        private TableLayoutPanel tableLayoutPanel1;
    }
}