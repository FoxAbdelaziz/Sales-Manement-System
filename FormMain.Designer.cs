namespace Sales_Manement_System
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Panel_Navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ptnHome = new DevExpress.XtraEditors.SimpleButton();
            this.ptnCategory = new DevExpress.XtraEditors.SimpleButton();
            this.ptnSuppliers = new DevExpress.XtraEditors.SimpleButton();
            this.ptnPurchasing = new DevExpress.XtraEditors.SimpleButton();
            this.ptnCustomers = new DevExpress.XtraEditors.SimpleButton();
            this.ptnSales = new DevExpress.XtraEditors.SimpleButton();
            this.ptnReport = new DevExpress.XtraEditors.SimpleButton();
            this.ptnUsers = new DevExpress.XtraEditors.SimpleButton();
            this.ptnSetting = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ptnCollapse = new DevExpress.XtraEditors.SimpleButton();
            this.Panel_Contuner = new System.Windows.Forms.Panel();
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.ptnNotification = new DevExpress.XtraEditors.SimpleButton();
            this.ptnMin = new DevExpress.XtraEditors.SimpleButton();
            this.ptnMix = new DevExpress.XtraEditors.SimpleButton();
            this.ptnExit = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Panel_Navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.Panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Navbar
            // 
            this.Panel_Navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Panel_Navbar.Controls.Add(this.flowLayoutPanel1);
            this.Panel_Navbar.Controls.Add(this.panel1);
            this.Panel_Navbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Navbar.Location = new System.Drawing.Point(1146, 0);
            this.Panel_Navbar.Name = "Panel_Navbar";
            this.Panel_Navbar.Size = new System.Drawing.Size(220, 720);
            this.Panel_Navbar.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ptnHome);
            this.flowLayoutPanel1.Controls.Add(this.ptnCategory);
            this.flowLayoutPanel1.Controls.Add(this.ptnSuppliers);
            this.flowLayoutPanel1.Controls.Add(this.ptnPurchasing);
            this.flowLayoutPanel1.Controls.Add(this.ptnCustomers);
            this.flowLayoutPanel1.Controls.Add(this.ptnSales);
            this.flowLayoutPanel1.Controls.Add(this.ptnReport);
            this.flowLayoutPanel1.Controls.Add(this.ptnUsers);
            this.flowLayoutPanel1.Controls.Add(this.ptnSetting);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 172);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 548);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // ptnHome
            // 
            this.ptnHome.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnHome.Appearance.ForeColor = System.Drawing.Color.White;
            this.ptnHome.Appearance.Options.UseFont = true;
            this.ptnHome.Appearance.Options.UseForeColor = true;
            this.ptnHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.ptnHome.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptnHome.Location = new System.Drawing.Point(10, 3);
            this.ptnHome.Name = "ptnHome";
            this.ptnHome.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptnHome.Size = new System.Drawing.Size(207, 36);
            this.ptnHome.TabIndex = 14;
            this.ptnHome.Text = "الرئيسية";
            this.ptnHome.Click += new System.EventHandler(this.ptnHome_Click);
            // 
            // ptnCategory
            // 
            this.ptnCategory.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnCategory.Appearance.ForeColor = System.Drawing.Color.White;
            this.ptnCategory.Appearance.Options.UseFont = true;
            this.ptnCategory.Appearance.Options.UseForeColor = true;
            this.ptnCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.ptnCategory.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptnCategory.Location = new System.Drawing.Point(10, 45);
            this.ptnCategory.Name = "ptnCategory";
            this.ptnCategory.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptnCategory.Size = new System.Drawing.Size(207, 36);
            this.ptnCategory.TabIndex = 15;
            this.ptnCategory.Text = "الأصناف";
            this.ptnCategory.Click += new System.EventHandler(this.ptnCategory_Click);
            // 
            // ptnSuppliers
            // 
            this.ptnSuppliers.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnSuppliers.Appearance.ForeColor = System.Drawing.Color.White;
            this.ptnSuppliers.Appearance.Options.UseFont = true;
            this.ptnSuppliers.Appearance.Options.UseForeColor = true;
            this.ptnSuppliers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.ptnSuppliers.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptnSuppliers.Location = new System.Drawing.Point(10, 87);
            this.ptnSuppliers.Name = "ptnSuppliers";
            this.ptnSuppliers.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptnSuppliers.Size = new System.Drawing.Size(207, 36);
            this.ptnSuppliers.TabIndex = 16;
            this.ptnSuppliers.Text = "الموردين";
            // 
            // ptnPurchasing
            // 
            this.ptnPurchasing.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnPurchasing.Appearance.ForeColor = System.Drawing.Color.White;
            this.ptnPurchasing.Appearance.Options.UseFont = true;
            this.ptnPurchasing.Appearance.Options.UseForeColor = true;
            this.ptnPurchasing.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.ptnPurchasing.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptnPurchasing.Location = new System.Drawing.Point(10, 129);
            this.ptnPurchasing.Name = "ptnPurchasing";
            this.ptnPurchasing.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnPurchasing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptnPurchasing.Size = new System.Drawing.Size(207, 36);
            this.ptnPurchasing.TabIndex = 17;
            this.ptnPurchasing.Text = "المشتريات";
            // 
            // ptnCustomers
            // 
            this.ptnCustomers.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnCustomers.Appearance.ForeColor = System.Drawing.Color.White;
            this.ptnCustomers.Appearance.Options.UseFont = true;
            this.ptnCustomers.Appearance.Options.UseForeColor = true;
            this.ptnCustomers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.ptnCustomers.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptnCustomers.Location = new System.Drawing.Point(10, 171);
            this.ptnCustomers.Name = "ptnCustomers";
            this.ptnCustomers.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptnCustomers.Size = new System.Drawing.Size(207, 36);
            this.ptnCustomers.TabIndex = 18;
            this.ptnCustomers.Text = "العملاء";
            // 
            // ptnSales
            // 
            this.ptnSales.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnSales.Appearance.ForeColor = System.Drawing.Color.White;
            this.ptnSales.Appearance.Options.UseFont = true;
            this.ptnSales.Appearance.Options.UseForeColor = true;
            this.ptnSales.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptnSales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton7.ImageOptions.SvgImage")));
            this.ptnSales.Location = new System.Drawing.Point(10, 213);
            this.ptnSales.Name = "ptnSales";
            this.ptnSales.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptnSales.Size = new System.Drawing.Size(207, 36);
            this.ptnSales.TabIndex = 19;
            this.ptnSales.Text = "المبيعات";
            // 
            // ptnReport
            // 
            this.ptnReport.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnReport.Appearance.ForeColor = System.Drawing.Color.White;
            this.ptnReport.Appearance.Options.UseFont = true;
            this.ptnReport.Appearance.Options.UseForeColor = true;
            this.ptnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton8.ImageOptions.Image")));
            this.ptnReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptnReport.Location = new System.Drawing.Point(10, 255);
            this.ptnReport.Name = "ptnReport";
            this.ptnReport.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptnReport.Size = new System.Drawing.Size(207, 36);
            this.ptnReport.TabIndex = 20;
            this.ptnReport.Text = "التقارير";
            // 
            // ptnUsers
            // 
            this.ptnUsers.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnUsers.Appearance.ForeColor = System.Drawing.Color.White;
            this.ptnUsers.Appearance.Options.UseFont = true;
            this.ptnUsers.Appearance.Options.UseForeColor = true;
            this.ptnUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.ImageOptions.Image")));
            this.ptnUsers.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptnUsers.Location = new System.Drawing.Point(10, 297);
            this.ptnUsers.Name = "ptnUsers";
            this.ptnUsers.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptnUsers.Size = new System.Drawing.Size(207, 36);
            this.ptnUsers.TabIndex = 21;
            this.ptnUsers.Text = "المستخدمين";
            // 
            // ptnSetting
            // 
            this.ptnSetting.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnSetting.Appearance.ForeColor = System.Drawing.Color.White;
            this.ptnSetting.Appearance.Options.UseFont = true;
            this.ptnSetting.Appearance.Options.UseForeColor = true;
            this.ptnSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton10.ImageOptions.Image")));
            this.ptnSetting.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptnSetting.Location = new System.Drawing.Point(10, 339);
            this.ptnSetting.Name = "ptnSetting";
            this.ptnSetting.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptnSetting.Size = new System.Drawing.Size(207, 36);
            this.ptnSetting.TabIndex = 22;
            this.ptnSetting.Text = "الاعدادات";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Panel_Title);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 172);
            this.panel1.TabIndex = 0;
            // 
            // Panel_Title
            // 
            this.Panel_Title.Controls.Add(this.label2);
            this.Panel_Title.Controls.Add(this.label3);
            this.Panel_Title.Controls.Add(this.pictureBox1);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(176, 172);
            this.Panel_Title.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "عبدالعزيز محمد ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(55, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "مبرمج النظام";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sales_Manement_System.Properties.Resources.minister_log_En1;
            this.pictureBox1.Location = new System.Drawing.Point(36, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ptnCollapse);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(176, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(44, 172);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // ptnCollapse
            // 
            this.ptnCollapse.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptnCollapse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnCollapse.ImageOptions.Image")));
            this.ptnCollapse.Location = new System.Drawing.Point(3, 3);
            this.ptnCollapse.Name = "ptnCollapse";
            this.ptnCollapse.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnCollapse.Size = new System.Drawing.Size(38, 31);
            this.ptnCollapse.TabIndex = 12;
            this.ptnCollapse.Click += new System.EventHandler(this.ptnCollapse_Click);
            // 
            // Panel_Contuner
            // 
            this.Panel_Contuner.BackColor = System.Drawing.Color.White;
            this.Panel_Contuner.Location = new System.Drawing.Point(0, 48);
            this.Panel_Contuner.Name = "Panel_Contuner";
            this.Panel_Contuner.Size = new System.Drawing.Size(1146, 672);
            this.Panel_Contuner.TabIndex = 3;
            // 
            // Panel_Top
            // 
            this.Panel_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Panel_Top.Controls.Add(this.lblTitleName);
            this.Panel_Top.Controls.Add(this.ptnNotification);
            this.Panel_Top.Controls.Add(this.ptnMin);
            this.Panel_Top.Controls.Add(this.ptnMix);
            this.Panel_Top.Controls.Add(this.ptnExit);
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(1146, 48);
            this.Panel_Top.TabIndex = 4;
            // 
            // lblTitleName
            // 
            this.lblTitleName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitleName.ForeColor = System.Drawing.Color.White;
            this.lblTitleName.Location = new System.Drawing.Point(520, 0);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(206, 48);
            this.lblTitleName.TabIndex = 9;
            this.lblTitleName.Text = "الشاشة الرئيسية للنظام";
            // 
            // ptnNotification
            // 
            this.ptnNotification.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnNotification.ImageOptions.Image")));
            this.ptnNotification.Location = new System.Drawing.Point(136, 6);
            this.ptnNotification.Name = "ptnNotification";
            this.ptnNotification.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnNotification.Size = new System.Drawing.Size(38, 36);
            this.ptnNotification.TabIndex = 8;
            // 
            // ptnMin
            // 
            this.ptnMin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnMin.ImageOptions.Image")));
            this.ptnMin.Location = new System.Drawing.Point(92, 6);
            this.ptnMin.Name = "ptnMin";
            this.ptnMin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnMin.Size = new System.Drawing.Size(38, 36);
            this.ptnMin.TabIndex = 7;
            this.ptnMin.Click += new System.EventHandler(this.ptnMin_Click);
            // 
            // ptnMix
            // 
            this.ptnMix.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnMix.ImageOptions.Image")));
            this.ptnMix.Location = new System.Drawing.Point(48, 6);
            this.ptnMix.Name = "ptnMix";
            this.ptnMix.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnMix.Size = new System.Drawing.Size(38, 36);
            this.ptnMix.TabIndex = 6;
            this.ptnMix.Click += new System.EventHandler(this.ptnMix_Click);
            // 
            // ptnExit
            // 
            this.ptnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnExit.ImageOptions.Image")));
            this.ptnExit.Location = new System.Drawing.Point(4, 6);
            this.ptnExit.Name = "ptnExit";
            this.ptnExit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnExit.Size = new System.Drawing.Size(38, 36);
            this.ptnExit.TabIndex = 5;
            this.ptnExit.Click += new System.EventHandler(this.ptnExit_Click_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Panel_Top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.Panel_Top);
            this.Controls.Add(this.Panel_Contuner);
            this.Controls.Add(this.Panel_Navbar);
            this.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Managemetn System ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Panel_Navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Navbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton ptnCollapse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton ptnHome;
        private DevExpress.XtraEditors.SimpleButton ptnCategory;
        private DevExpress.XtraEditors.SimpleButton ptnSuppliers;
        private DevExpress.XtraEditors.SimpleButton ptnPurchasing;
        private DevExpress.XtraEditors.SimpleButton ptnCustomers;
        private DevExpress.XtraEditors.SimpleButton ptnSales;
        private DevExpress.XtraEditors.SimpleButton ptnReport;
        private DevExpress.XtraEditors.SimpleButton ptnUsers;
        private DevExpress.XtraEditors.SimpleButton ptnSetting;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Panel Panel_Contuner;
        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Label lblTitleName;
        private DevExpress.XtraEditors.SimpleButton ptnNotification;
        private DevExpress.XtraEditors.SimpleButton ptnMin;
        private DevExpress.XtraEditors.SimpleButton ptnMix;
        private DevExpress.XtraEditors.SimpleButton ptnExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

