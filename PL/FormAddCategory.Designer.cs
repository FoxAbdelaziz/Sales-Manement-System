namespace Sales_Manement_System.PL
{
    partial class FormAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCategory));
            this.ptnExit = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picCategory = new DevExpress.XtraEditors.PictureEdit();
            this.ptnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.ptnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptnExit
            // 
            this.ptnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnExit.ImageOptions.Image")));
            this.ptnExit.Location = new System.Drawing.Point(303, 12);
            this.ptnExit.Name = "ptnExit";
            this.ptnExit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptnExit.Size = new System.Drawing.Size(38, 36);
            this.ptnExit.TabIndex = 6;
            this.ptnExit.Click += new System.EventHandler(this.ptnExit_Click);
            // 
            // lblTitleName
            // 
            this.lblTitleName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitleName.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleName.Location = new System.Drawing.Point(98, 21);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(119, 48);
            this.lblTitleName.TabIndex = 10;
            this.lblTitleName.Text = "اسم الصنف";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(43, 72);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 32);
            this.txtName.TabIndex = 12;
            // 
            // picCategory
            // 
            this.picCategory.EditValue = global::Sales_Manement_System.Properties.Resources.images__1_;
            this.picCategory.Location = new System.Drawing.Point(43, 110);
            this.picCategory.Name = "picCategory";
            this.picCategory.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picCategory.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picCategory.Size = new System.Drawing.Size(267, 157);
            this.picCategory.TabIndex = 14;
            // 
            // ptnAdd
            // 
            this.ptnAdd.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnAdd.Appearance.Options.UseFont = true;
            this.ptnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnAdd.ImageOptions.Image")));
            this.ptnAdd.Location = new System.Drawing.Point(202, 285);
            this.ptnAdd.Name = "ptnAdd";
            this.ptnAdd.Size = new System.Drawing.Size(145, 50);
            this.ptnAdd.TabIndex = 15;
            this.ptnAdd.Text = "اضافة صنف";
            this.ptnAdd.Click += new System.EventHandler(this.ptnAdd_Click);
            // 
            // ptnClose
            // 
            this.ptnClose.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnClose.Appearance.Options.UseFont = true;
            this.ptnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnClose.ImageOptions.Image")));
            this.ptnClose.Location = new System.Drawing.Point(12, 285);
            this.ptnClose.Name = "ptnClose";
            this.ptnClose.Size = new System.Drawing.Size(145, 50);
            this.ptnClose.TabIndex = 16;
            this.ptnClose.Text = "الغاء";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 347);
            this.Controls.Add(this.ptnClose);
            this.Controls.Add(this.ptnAdd);
            this.Controls.Add(this.picCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTitleName);
            this.Controls.Add(this.ptnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCategory";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ptnExit;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.TextBox txtName;
        private DevExpress.XtraEditors.PictureEdit picCategory;
        private DevExpress.XtraEditors.SimpleButton ptnClose;
        public DevExpress.XtraEditors.SimpleButton ptnAdd;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}