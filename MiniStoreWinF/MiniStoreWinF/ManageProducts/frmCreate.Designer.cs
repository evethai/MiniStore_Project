namespace MiniStoreWinF.ManageProducts
{
    partial class frmCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreate));
            tableLayoutPanel1 = new TableLayoutPanel();
            pbNext = new PictureBox();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            BtAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pbNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(50, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(407, 554);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pbNext
            // 
            pbNext.Image = (Image)resources.GetObject("pbNext.Image");
            pbNext.Location = new Point(383, 582);
            pbNext.Name = "pbNext";
            pbNext.Size = new Size(74, 37);
            pbNext.SizeMode = PictureBoxSizeMode.Zoom;
            pbNext.TabIndex = 38;
            pbNext.TabStop = false;
            pbNext.Click += pbNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 582);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // BtAdd
            // 
            BtAdd.Location = new Point(403, 590);
            BtAdd.Name = "BtAdd";
            BtAdd.Size = new Size(94, 29);
            BtAdd.TabIndex = 40;
            BtAdd.Text = "Create";
            BtAdd.UseVisualStyleBackColor = true;
            BtAdd.Visible = false;
            BtAdd.Click += BtAdd_Click;
            // 
            // frmCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 631);
            Controls.Add(BtAdd);
            Controls.Add(pictureBox1);
            Controls.Add(pbNext);
            Controls.Add(tableLayoutPanel1);
            Name = "frmCreate";
            Text = "frmCreate";
            FormClosed += frmCreate_FormClosed;
            Load += frmCreate_Load;
            ((System.ComponentModel.ISupportInitialize)pbNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbNext;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button BtAdd;
    }
}