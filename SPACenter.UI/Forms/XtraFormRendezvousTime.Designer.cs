namespace SPACenter.UI.Forms
{
    partial class XtraFormRendezvousTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormRendezvousTime));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.rendezvousTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rendezvousTimeGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousTimeGridControl)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(952, 183);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Randevu Saatleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Randevu Saati Ekle";
            this.barButtonItemAdd.Id = 1;
            this.barButtonItemAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItemAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemUpdate
            // 
            this.barButtonItemUpdate.Caption = "Randevu Saatini Güncelle";
            this.barButtonItemUpdate.Id = 2;
            this.barButtonItemUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItemUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItemUpdate.Name = "barButtonItemUpdate";
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Sil";
            this.barButtonItemDelete.Id = 3;
            this.barButtonItemDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItemDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            // 
            // rendezvousTimeBindingSource
            // 
            this.rendezvousTimeBindingSource.DataSource = typeof(SPACenter.Entities.Database.RendezvousTime);
            // 
            // rendezvousTimeGridControl
            // 
            this.rendezvousTimeGridControl.DataSource = this.rendezvousTimeBindingSource;
            this.rendezvousTimeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rendezvousTimeGridControl.Location = new System.Drawing.Point(0, 183);
            this.rendezvousTimeGridControl.MainView = this.gridView1;
            this.rendezvousTimeGridControl.MenuManager = this.ribbonControl1;
            this.rendezvousTimeGridControl.Name = "rendezvousTimeGridControl";
            this.rendezvousTimeGridControl.Size = new System.Drawing.Size(952, 379);
            this.rendezvousTimeGridControl.TabIndex = 2;
            this.rendezvousTimeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colStartTime,
            this.colEndTime,
            this.colDepartmentId,
            this.colDepartment,
            this.colActive});
            this.gridView1.GridControl = this.rendezvousTimeGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colStartTime
            // 
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.MinWidth = 25;
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 1;
            this.colStartTime.Width = 94;
            // 
            // colEndTime
            // 
            this.colEndTime.FieldName = "EndTime";
            this.colEndTime.MinWidth = 25;
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.Visible = true;
            this.colEndTime.VisibleIndex = 2;
            this.colEndTime.Width = 94;
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.MinWidth = 25;
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.Width = 94;
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.MinWidth = 25;
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 0;
            this.colDepartment.Width = 94;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.MinWidth = 25;
            this.colActive.Name = "colActive";
            this.colActive.Width = 94;
            // 
            // XtraFormRendezvousTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 562);
            this.Controls.Add(this.rendezvousTimeGridControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XtraFormRendezvousTime";
            this.Text = "XtraFormRendezvousTime";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousTimeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUpdate;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private System.Windows.Forms.BindingSource rendezvousTimeBindingSource;
        private DevExpress.XtraGrid.GridControl rendezvousTimeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
    }
}