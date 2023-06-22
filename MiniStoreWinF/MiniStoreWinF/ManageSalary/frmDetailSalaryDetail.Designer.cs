namespace MiniStoreWinF.ManageSalary
{
    partial class frmDetailSalaryDetail
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
            listView1 = new ListView();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Top;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(1237, 149);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(155, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(871, 150);
            dataGridView1.TabIndex = 1;
            // 
            // frmDetailSalaryDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 517);
            Controls.Add(dataGridView1);
            Controls.Add(listView1);
            Name = "frmDetailSalaryDetail";
            Text = "frmDetailSalaryDetail";
            Load += frmDetailSalaryDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private DataGridView dataGridView1;
    }
}