namespace MiniStoreWinF.OrdersProducts
{
    partial class frmCashPayment
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
            txtProvidesCash = new TextBox();
            lblCustomerProvidesCash = new Label();
            btOk = new Button();
            btCancel = new Button();
            SuspendLayout();
            // 
            // txtProvidesCash
            // 
            txtProvidesCash.Location = new Point(124, 9);
            txtProvidesCash.Name = "txtProvidesCash";
            txtProvidesCash.Size = new Size(165, 27);
            txtProvidesCash.TabIndex = 0;
            txtProvidesCash.KeyPress += txtProvidesCash_KeyPress;
            // 
            // lblCustomerProvidesCash
            // 
            lblCustomerProvidesCash.AutoSize = true;
            lblCustomerProvidesCash.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomerProvidesCash.Location = new Point(12, 9);
            lblCustomerProvidesCash.Name = "lblCustomerProvidesCash";
            lblCustomerProvidesCash.Size = new Size(106, 20);
            lblCustomerProvidesCash.TabIndex = 17;
            lblCustomerProvidesCash.Text = "Provides cash:";
            // 
            // btOk
            // 
            btOk.Location = new Point(195, 61);
            btOk.Name = "btOk";
            btOk.Size = new Size(94, 29);
            btOk.TabIndex = 18;
            btOk.Text = "Ok";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(76, 61);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(94, 29);
            btCancel.TabIndex = 19;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // frmCashPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 102);
            Controls.Add(btCancel);
            Controls.Add(btOk);
            Controls.Add(lblCustomerProvidesCash);
            Controls.Add(txtProvidesCash);
            Name = "frmCashPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCashPayment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProvidesCash;
        private Label lblCustomerProvidesCash;
        private Button btOk;
        private Button btCancel;
    }
}