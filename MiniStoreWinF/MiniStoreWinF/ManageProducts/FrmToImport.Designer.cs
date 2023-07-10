namespace MiniStoreWinF.ManageProducts
{
    partial class FrmToImport
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btOld = new Button();
            btNew = new Button();
            pnImport = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.18894F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.81106F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pnImport, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(500, 144);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btOld);
            groupBox1.Controls.Add(btNew);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(129, 138);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btOld
            // 
            btOld.Location = new Point(2, 59);
            btOld.Name = "btOld";
            btOld.Size = new Size(127, 44);
            btOld.TabIndex = 1;
            btOld.Text = "Old Supplier";
            btOld.UseVisualStyleBackColor = true;
            btOld.Click += btOld_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(2, 9);
            btNew.Name = "btNew";
            btNew.Size = new Size(127, 44);
            btNew.TabIndex = 0;
            btNew.Text = "New Supplier";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // pnImport
            // 
            pnImport.ColumnCount = 1;
            pnImport.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnImport.Dock = DockStyle.Fill;
            pnImport.Location = new Point(138, 3);
            pnImport.Name = "pnImport";
            pnImport.RowCount = 1;
            pnImport.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnImport.Size = new Size(359, 138);
            pnImport.TabIndex = 1;
            // 
            // FrmToImport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 144);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmToImport";
            Text = "FrmToImport";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Button btOld;
        private Button btNew;
        private TableLayoutPanel pnImport;
    }
}