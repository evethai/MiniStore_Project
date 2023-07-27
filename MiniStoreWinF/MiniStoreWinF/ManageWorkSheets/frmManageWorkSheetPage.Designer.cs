namespace MiniStoreWinF.ManageWorkSheet
{
    partial class frmManageWorkSheetPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageWorkSheetPage));
            workSheetBindingSource = new BindingSource(components);
            sheetDetailBindingSource = new BindingSource(components);
            btRegisterWorksheet = new Button();
            btSheetDetails = new Button();
            btHistory = new Button();
            flowPanel = new FlowLayoutPanel();
            pnlManageWorksheet = new Panel();
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).BeginInit();
            flowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // workSheetBindingSource
            // 
            workSheetBindingSource.DataSource = typeof(Repository.Models.WorkSheet);
            // 
            // sheetDetailBindingSource
            // 
            sheetDetailBindingSource.DataSource = typeof(Repository.Models.SheetDetail);
            // 
            // btRegisterWorksheet
            // 
            btRegisterWorksheet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btRegisterWorksheet.Image = (Image)resources.GetObject("btRegisterWorksheet.Image");
            btRegisterWorksheet.ImageAlign = ContentAlignment.MiddleLeft;
            btRegisterWorksheet.Location = new Point(5, 150);
            btRegisterWorksheet.Margin = new Padding(5, 4, 5, 4);
            btRegisterWorksheet.Name = "btRegisterWorksheet";
            btRegisterWorksheet.Size = new Size(253, 65);
            btRegisterWorksheet.TabIndex = 2;
            btRegisterWorksheet.Text = "Register";
            btRegisterWorksheet.TextAlign = ContentAlignment.MiddleRight;
            btRegisterWorksheet.UseVisualStyleBackColor = true;
            btRegisterWorksheet.Click += btRegisterWorksheet_Click;
            // 
            // btSheetDetails
            // 
            btSheetDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btSheetDetails.Image = (Image)resources.GetObject("btSheetDetails.Image");
            btSheetDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btSheetDetails.Location = new Point(5, 77);
            btSheetDetails.Margin = new Padding(5, 4, 5, 4);
            btSheetDetails.Name = "btSheetDetails";
            btSheetDetails.Size = new Size(253, 65);
            btSheetDetails.TabIndex = 1;
            btSheetDetails.Text = "Details";
            btSheetDetails.TextAlign = ContentAlignment.MiddleRight;
            btSheetDetails.UseVisualStyleBackColor = true;
            btSheetDetails.Click += btSheetDetails_Click;
            // 
            // btHistory
            // 
            btHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btHistory.Image = (Image)resources.GetObject("btHistory.Image");
            btHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btHistory.Location = new Point(5, 4);
            btHistory.Margin = new Padding(5, 4, 5, 4);
            btHistory.Name = "btHistory";
            btHistory.Size = new Size(253, 65);
            btHistory.TabIndex = 0;
            btHistory.Text = "History";
            btHistory.TextAlign = ContentAlignment.MiddleRight;
            btHistory.UseVisualStyleBackColor = true;
            btHistory.Click += btHistory_Click;
            // 
            // flowPanel
            // 
            flowPanel.BorderStyle = BorderStyle.Fixed3D;
            flowPanel.Controls.Add(btHistory);
            flowPanel.Controls.Add(btSheetDetails);
            flowPanel.Controls.Add(btRegisterWorksheet);
            flowPanel.Dock = DockStyle.Left;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Margin = new Padding(5, 4, 5, 4);
            flowPanel.MaximumSize = new Size(267, 0);
            flowPanel.MinimumSize = new Size(267, 0);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(267, 835);
            flowPanel.TabIndex = 1;
            // 
            // pnlManageWorksheet
            // 
            pnlManageWorksheet.BorderStyle = BorderStyle.Fixed3D;
            pnlManageWorksheet.Dock = DockStyle.Fill;
            pnlManageWorksheet.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pnlManageWorksheet.Location = new Point(267, 0);
            pnlManageWorksheet.Name = "pnlManageWorksheet";
            pnlManageWorksheet.Size = new Size(1653, 835);
            pnlManageWorksheet.TabIndex = 2;
            // 
            // frmManageWorkSheetPage
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 835);
            Controls.Add(pnlManageWorksheet);
            Controls.Add(flowPanel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmManageWorkSheetPage";
            Text = "Manage WorkSheet Page";
            ((System.ComponentModel.ISupportInitialize)workSheetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sheetDetailBindingSource).EndInit();
            flowPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource workSheetBindingSource;
        private BindingSource sheetDetailBindingSource;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btHistory;
        private Button btRegisterWorksheet;
        private Button btSheetDetails;
        private FlowLayoutPanel flowPanel;
        private Panel pnlManageWorksheet;
    }
}