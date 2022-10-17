namespace Sales_Manement_System.PL
{
    partial class FormCategory
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            this.colCAT_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCAT_Image = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panelButton = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.ptnShowData = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ptnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ptnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.ptnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // colCAT_Name
            // 
            this.colCAT_Name.FieldName = "CAT_Name";
            this.colCAT_Name.Name = "colCAT_Name";
            this.colCAT_Name.Visible = true;
            this.colCAT_Name.VisibleIndex = 1;
            // 
            // colCAT_Image
            // 
            this.colCAT_Image.FieldName = "CAT_Image";
            this.colCAT_Image.Name = "colCAT_Image";
            this.colCAT_Image.Visible = true;
            this.colCAT_Image.VisibleIndex = 2;
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.gridControl1);
            this.panelCategory.Controls.Add(this.panelButton);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategory.Location = new System.Drawing.Point(0, 0);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(1141, 525);
            this.panelCategory.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Sales_Manement_System.TableCategory);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1141, 460);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCAT_Name,
            this.colCAT_Image});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.RowCount = 3;
            this.tileView1.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 30D;
            tableRowDefinition2.Length.Value = 74D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Column = this.colCAT_Name;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "colCAT_Name";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colCAT_Image;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colCAT_Image";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // panelButton
            // 
            this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelButton.Controls.Add(this.simpleButton4);
            this.panelButton.Controls.Add(this.ptnShowData);
            this.panelButton.Controls.Add(this.txtSearch);
            this.panelButton.Controls.Add(this.ptnDelete);
            this.panelButton.Controls.Add(this.ptnUpdate);
            this.panelButton.Controls.Add(this.ptnAdd);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 460);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1141, 65);
            this.panelButton.TabIndex = 6;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(1020, 5);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(107, 50);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "بحث";
            // 
            // ptnShowData
            // 
            this.ptnShowData.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnShowData.Appearance.Options.UseFont = true;
            this.ptnShowData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnShowData.ImageOptions.Image")));
            this.ptnShowData.Location = new System.Drawing.Point(463, 6);
            this.ptnShowData.Name = "ptnShowData";
            this.ptnShowData.Size = new System.Drawing.Size(145, 50);
            this.ptnShowData.TabIndex = 4;
            this.ptnShowData.Text = "تحديث ";
            this.ptnShowData.Click += new System.EventHandler(this.ptnShowData_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(650, 5);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(364, 50);
            this.txtSearch.TabIndex = 4;
            // 
            // ptnDelete
            // 
            this.ptnDelete.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnDelete.Appearance.Options.UseFont = true;
            this.ptnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnDelete.ImageOptions.Image")));
            this.ptnDelete.Location = new System.Drawing.Point(161, 5);
            this.ptnDelete.Name = "ptnDelete";
            this.ptnDelete.Size = new System.Drawing.Size(145, 50);
            this.ptnDelete.TabIndex = 2;
            this.ptnDelete.Text = "حذف";
            this.ptnDelete.Click += new System.EventHandler(this.ptnDelete_Click);
            // 
            // ptnUpdate
            // 
            this.ptnUpdate.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnUpdate.Appearance.Options.UseFont = true;
            this.ptnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnUpdate.ImageOptions.Image")));
            this.ptnUpdate.Location = new System.Drawing.Point(312, 5);
            this.ptnUpdate.Name = "ptnUpdate";
            this.ptnUpdate.Size = new System.Drawing.Size(145, 50);
            this.ptnUpdate.TabIndex = 1;
            this.ptnUpdate.Text = "تعديل";
            this.ptnUpdate.Click += new System.EventHandler(this.ptnUpdate_Click);
            // 
            // ptnAdd
            // 
            this.ptnAdd.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ptnAdd.Appearance.Options.UseFont = true;
            this.ptnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptnAdd.ImageOptions.Image")));
            this.ptnAdd.Location = new System.Drawing.Point(10, 5);
            this.ptnAdd.Name = "ptnAdd";
            this.ptnAdd.Size = new System.Drawing.Size(145, 50);
            this.ptnAdd.TabIndex = 0;
            this.ptnAdd.Text = "اضافة صنف";
            this.ptnAdd.Click += new System.EventHandler(this.ptnAdd_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 525);
            this.Controls.Add(this.panelCategory);
            this.Font = new System.Drawing.Font("Traditional Arabic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategory";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.panelCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton ptnShowData;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton ptnDelete;
        private DevExpress.XtraEditors.SimpleButton ptnUpdate;
        private DevExpress.XtraEditors.SimpleButton ptnAdd;
        public System.Windows.Forms.Panel panelCategory;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colID;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCAT_Name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCAT_Image;
        public DevExpress.XtraGrid.GridControl gridControl1;
    }
}