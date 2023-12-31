﻿namespace SPACenter.UI.Forms
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
            this.gridLookUpEditCustomer = new DevExpress.XtraEditors.GridLookUpEdit();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEditDepartment = new DevExpress.XtraEditors.GridLookUpEdit();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotaPerSeance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentPerSeance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEditSeances = new DevExpress.XtraEditors.GridLookUpEdit();
            this.rendezvousTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToDisplay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTimeTemp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTimeTemp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEditDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditSeances.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(699, 183);
            // 
            // barButtonItemSave
            // 
            this.barButtonItemSave.Caption = "Kaydet";
            this.barButtonItemSave.Id = 1;
            this.barButtonItemSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemSave.ImageOptions.Image")));
            this.barButtonItemSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemSave.ImageOptions.LargeImage")));
            this.barButtonItemSave.Name = "barButtonItemSave";
            this.barButtonItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSave_ItemClick);
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
            // gridLookUpEditCustomer
            // 
            this.gridLookUpEditCustomer.Location = new System.Drawing.Point(347, 237);
            this.gridLookUpEditCustomer.MenuManager = this.ribbonControl1;
            this.gridLookUpEditCustomer.Name = "gridLookUpEditCustomer";
            this.gridLookUpEditCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEditCustomer.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditCustomer.Properties.DataSource = this.customerBindingSource;
            this.gridLookUpEditCustomer.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditCustomer.Size = new System.Drawing.Size(229, 28);
            this.gridLookUpEditCustomer.TabIndex = 5;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SPACenter.Entities.Database.Customer);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.ReadOnly = true;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            // 
            // gridLookUpEditDepartment
            // 
            this.gridLookUpEditDepartment.Location = new System.Drawing.Point(347, 274);
            this.gridLookUpEditDepartment.MenuManager = this.ribbonControl1;
            this.gridLookUpEditDepartment.Name = "gridLookUpEditDepartment";
            this.gridLookUpEditDepartment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEditDepartment.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditDepartment.Properties.DataSource = this.departmentBindingSource;
            this.gridLookUpEditDepartment.Properties.PopupView = this.gridLookUpEdit2View;
            this.gridLookUpEditDepartment.Size = new System.Drawing.Size(229, 28);
            this.gridLookUpEditDepartment.TabIndex = 6;
            this.gridLookUpEditDepartment.EditValueChanged += new System.EventHandler(this.gridLookUpEditDepartment_EditValueChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(SPACenter.Entities.Database.Department);
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colQuotaPerSeance,
            this.colPaymentPerSeance,
            this.colSessionLength,
            this.colDelFlag});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colQuotaPerSeance
            // 
            this.colQuotaPerSeance.FieldName = "QuotaPerSeance";
            this.colQuotaPerSeance.Name = "colQuotaPerSeance";
            // 
            // colPaymentPerSeance
            // 
            this.colPaymentPerSeance.FieldName = "PaymentPerSeance";
            this.colPaymentPerSeance.Name = "colPaymentPerSeance";
            // 
            // colSessionLength
            // 
            this.colSessionLength.FieldName = "SessionLength";
            this.colSessionLength.Name = "colSessionLength";
            // 
            // colDelFlag
            // 
            this.colDelFlag.FieldName = "DelFlag";
            this.colDelFlag.Name = "colDelFlag";
            // 
            // gridLookUpEditSeances
            // 
            this.gridLookUpEditSeances.Location = new System.Drawing.Point(347, 350);
            this.gridLookUpEditSeances.MenuManager = this.ribbonControl1;
            this.gridLookUpEditSeances.Name = "gridLookUpEditSeances";
            this.gridLookUpEditSeances.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEditSeances.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditSeances.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditSeances.Properties.DataSource = this.rendezvousTimeBindingSource;
            this.gridLookUpEditSeances.Properties.PopupView = this.gridLookUpEdit4View;
            this.gridLookUpEditSeances.Size = new System.Drawing.Size(229, 28);
            this.gridLookUpEditSeances.TabIndex = 8;
            // 
            // rendezvousTimeBindingSource
            // 
            this.rendezvousTimeBindingSource.DataSource = typeof(SPACenter.Entities.Database.RendezvousTime);
            // 
            // gridLookUpEdit4View
            // 
            this.gridLookUpEdit4View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colStartTime,
            this.colEndTime,
            this.colDepartmentId,
            this.colToDisplay,
            this.colDepartment,
            this.colActive,
            this.colStartTimeTemp,
            this.colEndTimeTemp});
            this.gridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit4View.Name = "gridLookUpEdit4View";
            this.gridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
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
            // colDepartmentId
            // 
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            // 
            // colToDisplay
            // 
            this.colToDisplay.FieldName = "ToDisplay";
            this.colToDisplay.Name = "colToDisplay";
            this.colToDisplay.OptionsColumn.ReadOnly = true;
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            // 
            // colStartTimeTemp
            // 
            this.colStartTimeTemp.FieldName = "StartTimeTemp";
            this.colStartTimeTemp.Name = "colStartTimeTemp";
            // 
            // colEndTimeTemp
            // 
            this.colEndTimeTemp.FieldName = "EndTimeTemp";
            this.colEndTimeTemp.Name = "colEndTimeTemp";
            // 
            // dateEditDate
            // 
            this.dateEditDate.EditValue = null;
            this.dateEditDate.Location = new System.Drawing.Point(347, 310);
            this.dateEditDate.MenuManager = this.ribbonControl1;
            this.dateEditDate.Name = "dateEditDate";
            this.dateEditDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEditDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Size = new System.Drawing.Size(229, 28);
            this.dateEditDate.TabIndex = 10;
            // 
            // XtraFormAppointmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 595);
            this.Controls.Add(this.dateEditDate);
            this.Controls.Add(this.gridLookUpEditSeances);
            this.Controls.Add(this.gridLookUpEditDepartment);
            this.Controls.Add(this.gridLookUpEditCustomer);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XtraFormAppointmentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Randevu Detayları";
            this.Load += new System.EventHandler(this.XtraFormAppointmentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditSeances.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditSeances;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit4View;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource rendezvousTimeBindingSource;
        private DevExpress.XtraEditors.DateEdit dateEditDate;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotaPerSeance;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentPerSeance;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionLength;
        private DevExpress.XtraGrid.Columns.GridColumn colDelFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colToDisplay;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTimeTemp;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTimeTemp;
    }
}