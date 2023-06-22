namespace MiniStoreWinF.DashBoard
{
    partial class frmCheckIn
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
            pictureBox1 = new PictureBox();
            txtName = new TextBox();
            txtTime = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(137, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 110);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 182);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 25);
            txtName.TabIndex = 1;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(105, 237);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(207, 25);
            txtTime.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(149, 302);
            button1.Name = "button1";
            button1.Size = new Size(123, 59);
            button1.TabIndex = 2;
            button1.Text = "Check In";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmCheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 404);
            Controls.Add(button1);
            Controls.Add(txtTime);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            Name = "frmCheckIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtName;
        private TextBox txtTime;
        private Button button1;
    }
}