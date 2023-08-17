namespace SPACenter.UI.Forms
{
    partial class XtraFormDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDepartment));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlDepartment = new DevExpress.XtraGrid.GridControl();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotaPerSeance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentPerSeance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemAdd,
            this.barButtonItemUpdate,
            this.barButtonItemDelete});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1134, 183);
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Bölüm Ekle";
            this.barButtonItemAdd.Id = 1;
            this.barButtonItemAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAdd.ImageOptions.Image")));
            this.barButtonItemAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemAdd.ImageOptions.LargeImage")));
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemUpdate
            // 
            this.barButtonItemUpdate.Caption = "Bölüm Güncelle";
            this.barButtonItemUpdate.Id = 2;
            this.barButtonItemUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemUpdate.ImageOptions.Image")));
            this.barButtonItemUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemUpdate.ImageOptions.LargeImage")));
            this.barButtonItemUpdate.Name = "barButtonItemUpdate";
            this.barButtonItemUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUpdate_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Sil";
            this.barButtonItemDelete.Id = 3;
            this.barButtonItemDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDelete.ImageOptions.Image")));
            this.barButtonItemDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemDelete.ImageOptions.LargeImage")));
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Bölümler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // gridControlDepartment
            // 
            this.gridControlDepartment.DataSource = this.departmentBindingSource;
            this.gridControlDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDepartment.Location = new System.Drawing.Point(0, 183);
            this.gridControlDepartment.MainView = this.gridView1;
            this.gridControlDepartment.MenuManager = this.ribbonControl1;
            this.gridControlDepartment.Name = "gridControlDepartment";
            this.gridControlDepartment.Size = new System.Drawing.Size(1134, 458);
            this.gridControlDepartment.TabIndex = 4;
            this.gridControlDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(SPACenter.Entities.Database.Department);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colQuotaPerSeance,
            this.colPaymentPerSeance,
            this.colSessionLength,
            this.colDelFlag});
            this.gridView1.GridControl = this.gridControlDepartment;
            this.gridView1.Name = "gridView1";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colQuotaPerSeance
            // 
            this.colQuotaPerSeance.FieldName = "QuotaPerSeance";
            this.colQuotaPerSeance.MinWidth = 25;
            this.colQuotaPerSeance.Name = "colQuotaPerSeance";
            this.colQuotaPerSeance.Visible = true;
            this.colQuotaPerSeance.VisibleIndex = 1;
            this.colQuotaPerSeance.Width = 94;
            // 
            // colPaymentPerSeance
            // 
            this.colPaymentPerSeance.FieldName = "PaymentPerSeance";
            this.colPaymentPerSeance.MinWidth = 25;
            this.colPaymentPerSeance.Name = "colPaymentPerSeance";
            this.colPaymentPerSeance.Visible = true;
            this.colPaymentPerSeance.VisibleIndex = 2;
            this.colPaymentPerSeance.Width = 94;
            // 
            // colSessionLength
            // 
            this.colSessionLength.FieldName = "SessionLength";
            this.colSessionLength.MinWidth = 25;
            this.colSessionLength.Name = "colSessionLength";
            this.colSessionLength.Visible = true;
            this.colSessionLength.VisibleIndex = 3;
            this.colSessionLength.Width = 94;
            // 
            // colDelFlag
            // 
            this.colDelFlag.FieldName = "DelFlag";
            this.colDelFlag.MinWidth = 25;
            this.colDelFlag.Name = "colDelFlag";
            this.colDelFlag.Width = 94;
            // 
            // XtraFormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 641);
            this.Controls.Add(this.gridControlDepartment);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XtraFormDepartment";
            this.Text = "Bölümler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUpdate;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.GridControl gridControlDepartment;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotaPerSeance;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentPerSeance;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionLength;
        private DevExpress.XtraGrid.Columns.GridColumn colDelFlag;
    }
}