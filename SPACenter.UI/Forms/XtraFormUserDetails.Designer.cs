namespace SPACenter.UI.Forms
{
    partial class XtraFormUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormUserDetails));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEditSurname = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.checkEditSystemAdmin = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSystemAdmin.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(753, 183);
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
            this.ribbonPage1.Text = "Kullanıcı Detayları";
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
            this.labelControl1.Location = new System.Drawing.Point(184, 264);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(184, 316);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Soyadı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(184, 362);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 22);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Şifre:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(184, 406);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 22);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Yönetici:";
            // 
            // textEditName
            // 
            this.textEditName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Name", true));
            this.textEditName.Location = new System.Drawing.Point(321, 261);
            this.textEditName.MenuManager = this.ribbonControl1;
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditName.Properties.Appearance.Options.UseFont = true;
            this.textEditName.Size = new System.Drawing.Size(210, 28);
            this.textEditName.TabIndex = 5;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(SPACenter.Entities.Database.User);
            // 
            // textEditSurname
            // 
            this.textEditSurname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Surname", true));
            this.textEditSurname.Location = new System.Drawing.Point(321, 310);
            this.textEditSurname.MenuManager = this.ribbonControl1;
            this.textEditSurname.Name = "textEditSurname";
            this.textEditSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditSurname.Properties.Appearance.Options.UseFont = true;
            this.textEditSurname.Size = new System.Drawing.Size(210, 28);
            this.textEditSurname.TabIndex = 6;
            // 
            // textEditPassword
            // 
            this.textEditPassword.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "PasswordTemp", true));
            this.textEditPassword.Location = new System.Drawing.Point(321, 356);
            this.textEditPassword.MenuManager = this.ribbonControl1;
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditPassword.Size = new System.Drawing.Size(210, 28);
            this.textEditPassword.TabIndex = 7;
            // 
            // checkEditSystemAdmin
            // 
            this.checkEditSystemAdmin.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "SystemAdmin", true));
            this.checkEditSystemAdmin.Location = new System.Drawing.Point(321, 406);
            this.checkEditSystemAdmin.MenuManager = this.ribbonControl1;
            this.checkEditSystemAdmin.Name = "checkEditSystemAdmin";
            this.checkEditSystemAdmin.Properties.Caption = "";
            this.checkEditSystemAdmin.Size = new System.Drawing.Size(94, 24);
            this.checkEditSystemAdmin.TabIndex = 10;
            this.checkEditSystemAdmin.CheckedChanged += new System.EventHandler(this.checkEditSystemAdmin_CheckedChanged);
            // 
            // XtraFormUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 571);
            this.Controls.Add(this.checkEditSystemAdmin);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditSurname);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XtraFormUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı Detayları";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSystemAdmin.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.TextEdit textEditSurname;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.CheckEdit checkEditSystemAdmin;
    }
}