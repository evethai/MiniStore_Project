namespace MiniStoreWinF.ManageSalary
{
    partial class frmHstl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHstl));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            bhxh = new TextBox();
            bhyt = new TextBox();
            bhtn = new TextBox();
            gtgccn = new TextBox();
            gtgcnpt = new TextBox();
            mini = new TextBox();
            max = new TextBox();
            label7 = new Label();
            btSave = new Button();
            notiSave = new NotifyIcon(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 48);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Social insurance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 94);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 0;
            label2.Text = "Health insurance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 143);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(228, 25);
            label3.TabIndex = 0;
            label3.Text = "Unemployment insurance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 188);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(275, 25);
            label4.TabIndex = 0;
            label4.Text = "Reduce personal circumstances";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 233);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(309, 25);
            label5.TabIndex = 0;
            label5.Text = "Reduce the situation of dependents";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 280);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 0;
            label6.Text = "Minimum wage";
            // 
            // bhxh
            // 
            bhxh.Location = new Point(412, 36);
            bhxh.Margin = new Padding(5);
            bhxh.Name = "bhxh";
            bhxh.Size = new Size(280, 33);
            bhxh.TabIndex = 1;
            bhxh.KeyPress += bhxh_KeyPress;
            // 
            // bhyt
            // 
            bhyt.Location = new Point(412, 82);
            bhyt.Margin = new Padding(5);
            bhyt.Name = "bhyt";
            bhyt.Size = new Size(280, 33);
            bhyt.TabIndex = 1;
            bhyt.KeyPress += bhyt_KeyPress;
            // 
            // bhtn
            // 
            bhtn.Location = new Point(412, 131);
            bhtn.Margin = new Padding(5);
            bhtn.Name = "bhtn";
            bhtn.Size = new Size(280, 33);
            bhtn.TabIndex = 1;
            bhtn.KeyPress += bhtn_KeyPress;
            // 
            // gtgccn
            // 
            gtgccn.Location = new Point(412, 176);
            gtgccn.Margin = new Padding(5);
            gtgccn.Name = "gtgccn";
            gtgccn.Size = new Size(280, 33);
            gtgccn.TabIndex = 1;
            gtgccn.KeyPress += gtgccn_KeyPress;
            // 
            // gtgcnpt
            // 
            gtgcnpt.Location = new Point(412, 223);
            gtgcnpt.Margin = new Padding(5);
            gtgcnpt.Name = "gtgcnpt";
            gtgcnpt.Size = new Size(280, 33);
            gtgcnpt.TabIndex = 1;
            gtgcnpt.KeyPress += gtgcnpt_KeyPress;
            // 
            // mini
            // 
            mini.Location = new Point(412, 268);
            mini.Margin = new Padding(5);
            mini.Name = "mini";
            mini.Size = new Size(280, 33);
            mini.TabIndex = 1;
            mini.KeyPress += mini_KeyPress;
            // 
            // max
            // 
            max.Location = new Point(412, 313);
            max.Margin = new Padding(5);
            max.Name = "max";
            max.Size = new Size(280, 33);
            max.TabIndex = 1;
            max.KeyPress += max_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 325);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(177, 25);
            label7.TabIndex = 0;
            label7.Text = "Maximum premium";
            // 
            // btSave
            // 
            btSave.Location = new Point(601, 383);
            btSave.Margin = new Padding(4);
            btSave.Name = "btSave";
            btSave.Size = new Size(92, 39);
            btSave.TabIndex = 2;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // notiSave
            // 
            notiSave.Text = "notifyIcon1";
            notiSave.Visible = true;
            // 
            // frmHstl
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 444);
            Controls.Add(btSave);
            Controls.Add(max);
            Controls.Add(mini);
            Controls.Add(gtgcnpt);
            Controls.Add(gtgccn);
            Controls.Add(bhtn);
            Controls.Add(bhyt);
            Controls.Add(bhxh);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(764, 483);
            MinimumSize = new Size(764, 483);
            Name = "frmHstl";
            Text = "Data salary ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox bhxh;
        private TextBox bhyt;
        private TextBox bhtn;
        private TextBox gtgccn;
        private TextBox gtgcnpt;
        private TextBox mini;
        private TextBox max;
        private Label label7;
        private Button btSave;
        private NotifyIcon notiSave;
    }
}