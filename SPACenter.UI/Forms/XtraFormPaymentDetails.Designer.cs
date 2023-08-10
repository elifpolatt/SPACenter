namespace SPACenter.UI.Forms
{
    partial class XtraFormPaymentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormPaymentDetails));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEditCustomers = new DevExpress.XtraEditors.GridLookUpEdit();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEditDepartment = new DevExpress.XtraEditors.GridLookUpEdit();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotaPerSeance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentPerSeance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelFlag1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comboBoxEditPaymentType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditAmount = new DevExpress.XtraEditors.TextEdit();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditCustomers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(715, 183);
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
            this.labelControl1.Location = new System.Drawing.Point(138, 239);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Müşteri Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(138, 283);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Bölüm:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(138, 324);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 22);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Ödeme Türü:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(138, 365);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 22);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Ödenen Miktar:";
            // 
            // gridLookUpEditCustomers
            // 
            this.gridLookUpEditCustomers.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Name", true));
            this.gridLookUpEditCustomers.Location = new System.Drawing.Point(283, 236);
            this.gridLookUpEditCustomers.MenuManager = this.ribbonControl1;
            this.gridLookUpEditCustomers.Name = "gridLookUpEditCustomers";
            this.gridLookUpEditCustomers.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEditCustomers.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditCustomers.Properties.DataSource = this.customerBindingSource;
            this.gridLookUpEditCustomers.Properties.DisplayMember = "Name";
            this.gridLookUpEditCustomers.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditCustomers.Properties.ValueMember = "Id";
            this.gridLookUpEditCustomers.Size = new System.Drawing.Size(260, 28);
            this.gridLookUpEditCustomers.TabIndex = 5;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SPACenter.Entities.Database.Customer);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colSurname,
            this.colPhoneNumber,
            this.colPhoto,
            this.colImage,
            this.colMail,
            this.colDelFlag});
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
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 1;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.Name = "colMail";
            // 
            // colDelFlag
            // 
            this.colDelFlag.FieldName = "DelFlag";
            this.colDelFlag.Name = "colDelFlag";
            // 
            // gridLookUpEditDepartment
            // 
            this.gridLookUpEditDepartment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.departmentBindingSource, "Name", true));
            this.gridLookUpEditDepartment.Location = new System.Drawing.Point(283, 277);
            this.gridLookUpEditDepartment.MenuManager = this.ribbonControl1;
            this.gridLookUpEditDepartment.Name = "gridLookUpEditDepartment";
            this.gridLookUpEditDepartment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEditDepartment.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditDepartment.Properties.DataSource = this.departmentBindingSource;
            this.gridLookUpEditDepartment.Properties.DisplayMember = "Name";
            this.gridLookUpEditDepartment.Properties.PopupView = this.gridLookUpEdit2View;
            this.gridLookUpEditDepartment.Properties.ValueMember = "Id";
            this.gridLookUpEditDepartment.Size = new System.Drawing.Size(260, 28);
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
            this.colId1,
            this.colName1,
            this.colQuotaPerSeance,
            this.colPaymentPerSeance,
            this.colSessionLength,
            this.colDelFlag1});
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
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
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
            // colDelFlag1
            // 
            this.colDelFlag1.FieldName = "DelFlag";
            this.colDelFlag1.Name = "colDelFlag1";
            // 
            // comboBoxEditPaymentType
            // 
            this.comboBoxEditPaymentType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentBindingSource, "SelectPaymentType", true));
            this.comboBoxEditPaymentType.EditValue = "Kredi Kartı";
            this.comboBoxEditPaymentType.Location = new System.Drawing.Point(283, 321);
            this.comboBoxEditPaymentType.MenuManager = this.ribbonControl1;
            this.comboBoxEditPaymentType.Name = "comboBoxEditPaymentType";
            this.comboBoxEditPaymentType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEditPaymentType.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPaymentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditPaymentType.Size = new System.Drawing.Size(260, 28);
            this.comboBoxEditPaymentType.TabIndex = 7;
            this.comboBoxEditPaymentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditPaymentType_SelectedIndexChanged);
            // 
            // textEditAmount
            // 
            this.textEditAmount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentBindingSource, "Amount", true));
            this.textEditAmount.Location = new System.Drawing.Point(283, 359);
            this.textEditAmount.MenuManager = this.ribbonControl1;
            this.textEditAmount.Name = "textEditAmount";
            this.textEditAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditAmount.Properties.Appearance.Options.UseFont = true;
            this.textEditAmount.Size = new System.Drawing.Size(260, 28);
            this.textEditAmount.TabIndex = 8;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataSource = typeof(SPACenter.Entities.Database.Payment);
            // 
            // XtraFormPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 515);
            this.Controls.Add(this.textEditAmount);
            this.Controls.Add(this.comboBoxEditPaymentType);
            this.Controls.Add(this.gridLookUpEditDepartment);
            this.Controls.Add(this.gridLookUpEditCustomers);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XtraFormPaymentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ödeme Detayları";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditCustomers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPaymentType;
        private DevExpress.XtraEditors.TextEdit textEditAmount;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colDelFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotaPerSeance;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentPerSeance;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionLength;
        private DevExpress.XtraGrid.Columns.GridColumn colDelFlag1;
        private System.Windows.Forms.BindingSource paymentBindingSource;
    }
}