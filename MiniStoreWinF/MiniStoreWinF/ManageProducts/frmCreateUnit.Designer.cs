﻿namespace MiniStoreWinF.ManageProducts
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
            panelInForUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            panelUnit.SuspendLayout();
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
            panelInForUnit.Location = new Point(40, 74);
            panelInForUnit.Name = "panelInForUnit";
            panelInForUnit.Size = new Size(351, 235);
            panelInForUnit.TabIndex = 5;
            // 
            // cbNameUnit
            // 
            cbNameUnit.FormattingEnabled = true;
            cbNameUnit.Location = new Point(112, 55);
            cbNameUnit.Name = "cbNameUnit";
            cbNameUnit.Size = new Size(151, 28);
            cbNameUnit.TabIndex = 20;
            // 
            // cbNameProduct
            // 
            cbNameProduct.FormattingEnabled = true;
            cbNameProduct.Location = new Point(112, 11);
            cbNameProduct.Name = "cbNameProduct";
            cbNameProduct.Size = new Size(151, 28);
            cbNameProduct.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 18;
            label1.Text = "Name Product";
            // 
            // txtPriceEx
            // 
            txtPriceEx.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPriceEx.Location = new Point(112, 175);
            txtPriceEx.Name = "txtPriceEx";
            txtPriceEx.Size = new Size(210, 25);
            txtPriceEx.TabIndex = 17;
            // 
            // txtPriceIm
            // 
            txtPriceIm.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPriceIm.Location = new Point(112, 134);
            txtPriceIm.Name = "txtPriceIm";
            txtPriceIm.Size = new Size(210, 25);
            txtPriceIm.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(15, 178);
            label13.Name = "label13";
            label13.Size = new Size(78, 17);
            label13.TabIndex = 15;
            label13.Text = "Price Export";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 139);
            label8.Name = "label8";
            label8.Size = new Size(79, 17);
            label8.TabIndex = 14;
            label8.Text = "Price Import";
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(112, 94);
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(88, 27);
            numericQuantity.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 98);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 12;
            label7.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 60);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 11;
            label2.Text = "Name Unit";
            // 
            // panelUnit
            // 
            panelUnit.BorderStyle = BorderStyle.FixedSingle;
            panelUnit.Controls.Add(labelInfor);
            panelUnit.Location = new Point(40, 27);
            panelUnit.Name = "panelUnit";
            panelUnit.Size = new Size(351, 41);
            panelUnit.TabIndex = 4;
            // 
            // labelInfor
            // 
            labelInfor.AutoSize = true;
            labelInfor.Location = new Point(112, 11);
            labelInfor.Name = "labelInfor";
            labelInfor.Size = new Size(138, 20);
            labelInfor.TabIndex = 0;
            labelInfor.Text = "Information Of Unit";
            // 
            // frmCreateUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(panelInForUnit);
            Controls.Add(panelUnit);
            Name = "frmCreateUnit";
            Text = "frmCreateUnit";
            FormClosed += frmCreateUnit_FormClosed;
            panelInForUnit.ResumeLayout(false);
            panelInForUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            panelUnit.ResumeLayout(false);
            panelUnit.PerformLayout();
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
    }
}