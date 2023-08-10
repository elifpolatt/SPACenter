namespace SPACenter.UI.Forms
{
    partial class XtraFormAppointmentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormAppointmentDetails));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRendevousDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRendezvousTimeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRendevousTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRendevousDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRendezvousTimeId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRendevousTime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEdit3 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridLookUpEdit4 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.rendezvousTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit4View)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemSave,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(764, 183);
            // 
            // barButtonItemSave
            // 
            this.barButtonItemSave.Caption = "Kaydet";
            this.barButtonItemSave.Id = 1;
            this.barButtonItemSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemSave.ImageOptions.Image")));
            this.barButtonItemSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemSave.ImageOptions.LargeImage")));
            this.barButtonItemSave.Name = "barButtonItemSave";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Temizle";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(75, 243);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(212, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Randevu Verilecek Müşteri:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(77, 280);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(205, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Randevu Verilecek Bölüm:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(77, 316);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(195, 22);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Randevu Verilecek Tarih:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(75, 356);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(208, 22);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Randevu Verilecek Saatler:";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(347, 237);
            this.gridLookUpEdit1.MenuManager = this.ribbonControl1;
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.customerBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "Name";
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.ValueMember = "Id";
            this.gridLookUpEdit1.Size = new System.Drawing.Size(229, 28);
            this.gridLookUpEdit1.TabIndex = 5;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SPACenter.Entities.Database.Customer);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCustomerId,
            this.colCustomer,
            this.colRendevousDate,
            this.colRendezvousTimeId,
            this.colRendevousTime,
            this.colDepartmentId,
            this.colDepartment});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            // 
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 0;
            // 
            // colRendevousDate
            // 
            this.colRendevousDate.FieldName = "RendevousDate";
            this.colRendevousDate.Name = "colRendevousDate";
            // 
            // colRendezvousTimeId
            // 
            this.colRendezvousTimeId.FieldName = "RendezvousTimeId";
            this.colRendezvousTimeId.Name = "colRendezvousTimeId";
            // 
            // colRendevousTime
            // 
            this.colRendevousTime.FieldName = "RendevousTime";
            this.colRendevousTime.Name = "colRendevousTime";
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(SPACenter.Entities.Database.Appointment);
            // 
            // gridLookUpEdit2
            // 
            this.gridLookUpEdit2.Location = new System.Drawing.Point(347, 274);
            this.gridLookUpEdit2.MenuManager = this.ribbonControl1;
            this.gridLookUpEdit2.Name = "gridLookUpEdit2";
            this.gridLookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEdit2.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit2.Properties.DataSource = this.appointmentBindingSource;
            this.gridLookUpEdit2.Properties.PopupView = this.gridLookUpEdit2View;
            this.gridLookUpEdit2.Size = new System.Drawing.Size(229, 28);
            this.gridLookUpEdit2.TabIndex = 6;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colCustomerId1,
            this.colCustomer1,
            this.colRendevousDate1,
            this.colRendezvousTimeId1,
            this.colRendevousTime1,
            this.colDepartmentId1,
            this.colDepartment1});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // colCustomerId1
            // 
            this.colCustomerId1.FieldName = "CustomerId";
            this.colCustomerId1.Name = "colCustomerId1";
            // 
            // colCustomer1
            // 
            this.colCustomer1.FieldName = "Customer";
            this.colCustomer1.Name = "colCustomer1";
            // 
            // colRendevousDate1
            // 
            this.colRendevousDate1.FieldName = "RendevousDate";
            this.colRendevousDate1.Name = "colRendevousDate1";
            // 
            // colRendezvousTimeId1
            // 
            this.colRendezvousTimeId1.FieldName = "RendezvousTimeId";
            this.colRendezvousTimeId1.Name = "colRendezvousTimeId1";
            // 
            // colRendevousTime1
            // 
            this.colRendevousTime1.FieldName = "RendevousTime";
            this.colRendevousTime1.Name = "colRendevousTime1";
            // 
            // colDepartmentId1
            // 
            this.colDepartmentId1.FieldName = "DepartmentId";
            this.colDepartmentId1.Name = "colDepartmentId1";
            // 
            // colDepartment1
            // 
            this.colDepartment1.FieldName = "Department";
            this.colDepartment1.Name = "colDepartment1";
            this.colDepartment1.Visible = true;
            this.colDepartment1.VisibleIndex = 0;
            // 
            // gridLookUpEdit3
            // 
            this.gridLookUpEdit3.Location = new System.Drawing.Point(347, 310);
            this.gridLookUpEdit3.MenuManager = this.ribbonControl1;
            this.gridLookUpEdit3.Name = "gridLookUpEdit3";
            this.gridLookUpEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEdit3.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit3.Properties.PopupView = this.gridLookUpEdit3View;
            this.gridLookUpEdit3.Size = new System.Drawing.Size(229, 28);
            this.gridLookUpEdit3.TabIndex = 7;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // gridLookUpEdit4
            // 
            this.gridLookUpEdit4.Location = new System.Drawing.Point(347, 350);
            this.gridLookUpEdit4.MenuManager = this.ribbonControl1;
            this.gridLookUpEdit4.Name = "gridLookUpEdit4";
            this.gridLookUpEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEdit4.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit4.Properties.DataSource = this.rendezvousTimeBindingSource;
            this.gridLookUpEdit4.Properties.PopupView = this.gridLookUpEdit4View;
            this.gridLookUpEdit4.Properties.ValueMember = "Id";
            this.gridLookUpEdit4.Size = new System.Drawing.Size(229, 28);
            this.gridLookUpEdit4.TabIndex = 8;
            // 
            // rendezvousTimeBindingSource
            // 
            this.rendezvousTimeBindingSource.DataSource = typeof(SPACenter.Entities.Database.RendezvousTime);
            // 
            // gridLookUpEdit4View
            // 
            this.gridLookUpEdit4View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId2,
            this.colStartTime,
            this.colEndTime,
            this.colDepartmentId2,
            this.colDepartment2,
            this.colActive});
            this.gridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit4View.Name = "gridLookUpEdit4View";
            this.gridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            // 
            // colStartTime
            // 
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 0;
            // 
            // colEndTime
            // 
            this.colEndTime.FieldName = "EndTime";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.Visible = true;
            this.colEndTime.VisibleIndex = 1;
            // 
            // colDepartmentId2
            // 
            this.colDepartmentId2.FieldName = "DepartmentId";
            this.colDepartmentId2.Name = "colDepartmentId2";
            // 
            // colDepartment2
            // 
            this.colDepartment2.FieldName = "Department";
            this.colDepartment2.Name = "colDepartment2";
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            // 
            // XtraFormAppointmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 477);
            this.Controls.Add(this.gridLookUpEdit4);
            this.Controls.Add(this.gridLookUpEdit3);
            this.Controls.Add(this.gridLookUpEdit2);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XtraFormAppointmentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Randevu Detayları";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit4View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit4View;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colRendevousDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRendezvousTimeId;
        private DevExpress.XtraGrid.Columns.GridColumn colRendevousTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer1;
        private DevExpress.XtraGrid.Columns.GridColumn colRendevousDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colRendezvousTimeId1;
        private DevExpress.XtraGrid.Columns.GridColumn colRendevousTime1;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId1;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment1;
        private System.Windows.Forms.BindingSource rendezvousTimeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId2;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment2;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
    }
}