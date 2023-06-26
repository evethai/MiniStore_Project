namespace MiniStoreWinF.ManageWorkSheets
{
    partial class frmTableWork
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
            panel1 = new Panel();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            addSheetToolStripMenuItem = new ToolStripMenuItem();
            todayToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            btLastday = new Button();
            btNextday = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 422);
            panel2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(276, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addSheetToolStripMenuItem, todayToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // addSheetToolStripMenuItem
            // 
            addSheetToolStripMenuItem.Name = "addSheetToolStripMenuItem";
            addSheetToolStripMenuItem.Size = new Size(92, 24);
            addSheetToolStripMenuItem.Text = "Add Sheet";
            // 
            // todayToolStripMenuItem
            // 
            todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            todayToolStripMenuItem.Size = new Size(63, 24);
            todayToolStripMenuItem.Text = "Today";
            // 
            // panel3
            // 
            panel3.Controls.Add(btNextday);
            panel3.Controls.Add(btLastday);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 35);
            panel3.TabIndex = 2;
            // 
            // btLastday
            // 
            btLastday.Location = new Point(39, 3);
            btLastday.Name = "btLastday";
            btLastday.Size = new Size(94, 29);
            btLastday.TabIndex = 2;
            btLastday.Text = "Last day";
            btLastday.UseVisualStyleBackColor = true;
            // 
            // btNextday
            // 
            btNextday.Location = new Point(654, 3);
            btNextday.Name = "btNextday";
            btNextday.Size = new Size(94, 29);
            btNextday.TabIndex = 3;
            btNextday.Text = "Next day";
            btNextday.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 387);
            panel4.TabIndex = 3;
            // 
            // frmTableWork
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "frmTableWork";
            Text = "frmTableWork";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addSheetToolStripMenuItem;
        private ToolStripMenuItem todayToolStripMenuItem;
        private Panel panel3;
        private Button btNextday;
        private Button btLastday;
        private Panel panel4;
    }
}