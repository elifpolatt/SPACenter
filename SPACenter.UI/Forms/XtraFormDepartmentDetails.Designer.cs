namespace SPACenter.UI.Forms
{
    partial class XtraFormDepartmentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDepartmentDetails));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEditPaymentPerSeance = new DevExpress.XtraEditors.TextEdit();
            this.textEditQuatoPerSeance = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSessionLength = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPaymentPerSeance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuatoPerSeance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSessionLength.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemSave,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(889, 183);
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Temizle";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // textEditName
            // 
            this.textEditName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.departmentBindingSource, "Name", true));
            this.textEditName.Location = new System.Drawing.Point(440, 288);
            this.textEditName.MenuManager = this.ribbonControl1;
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditName.Properties.Appearance.Options.UseFont = true;
            this.textEditName.Size = new System.Drawing.Size(224, 30);
            this.textEditName.TabIndex = 1;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(SPACenter.Entities.Database.Department);
            // 
            // textEditPaymentPerSeance
            // 
            this.textEditPaymentPerSeance.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.departmentBindingSource, "PaymentPerSeance", true));
            this.textEditPaymentPerSeance.Location = new System.Drawing.Point(440, 334);
            this.textEditPaymentPerSeance.MenuManager = this.ribbonControl1;
            this.textEditPaymentPerSeance.Name = "textEditPaymentPerSeance";
            this.textEditPaymentPerSeance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditPaymentPerSeance.Properties.Appearance.Options.UseFont = true;
            this.textEditPaymentPerSeance.Size = new System.Drawing.Size(224, 30);
            this.textEditPaymentPerSeance.TabIndex = 2;
            // 
            // textEditQuatoPerSeance
            // 
            this.textEditQuatoPerSeance.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.departmentBindingSource, "QuotaPerSeance", true));
            this.textEditQuatoPerSeance.Location = new System.Drawing.Point(440, 379);
            this.textEditQuatoPerSeance.MenuManager = this.ribbonControl1;
            this.textEditQuatoPerSeance.Name = "textEditQuatoPerSeance";
            this.textEditQuatoPerSeance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditQuatoPerSeance.Properties.Appearance.Options.UseFont = true;
            this.textEditQuatoPerSeance.Size = new System.Drawing.Size(224, 30);
            this.textEditQuatoPerSeance.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(181, 294);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 24);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Bölüm Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(181, 340);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(118, 24);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Seans Ücreti:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(181, 385);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(222, 24);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Seans Başına Kontenjan:";
            // 
            // textEditSessionLength
            // 
            this.textEditSessionLength.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.departmentBindingSource, "SessionLength", true));
            this.textEditSessionLength.Location = new System.Drawing.Point(440, 425);
            this.textEditSessionLength.Name = "textEditSessionLength";
            this.textEditSessionLength.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditSessionLength.Properties.Appearance.Options.UseFont = true;
            this.textEditSessionLength.Size = new System.Drawing.Size(224, 30);
            this.textEditSessionLength.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(181, 431);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(185, 24);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Seans Uzunluğu(dk):";
            // 
            // XtraFormDepartmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 561);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditSessionLength);
            this.Controls.Add(this.textEditQuatoPerSeance);
            this.Controls.Add(this.textEditPaymentPerSeance);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XtraFormDepartmentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bölüm Detayları";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPaymentPerSeance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuatoPerSeance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSessionLength.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.TextEdit textEditPaymentPerSeance;
        private DevExpress.XtraEditors.TextEdit textEditQuatoPerSeance;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DevExpress.XtraEditors.TextEdit textEditSessionLength;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}