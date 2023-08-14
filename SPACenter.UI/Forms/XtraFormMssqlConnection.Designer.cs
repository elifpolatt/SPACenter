namespace SPACenter.UI.Forms
{
    partial class XtraFormMssqlConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormMssqlConnection));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemTest = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditDatabase = new DevExpress.XtraEditors.TextEdit();
            this.textEditUser = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEditAuth = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditAuth.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemSave,
            this.barButtonItemTest,
            this.barButtonItemCancel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(608, 183);
            // 
            // barButtonItemSave
            // 
            this.barButtonItemSave.Caption = "Kaydet";
            this.barButtonItemSave.Id = 1;
            this.barButtonItemSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemSave.ImageOptions.Image")));
            this.barButtonItemSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemSave.ImageOptions.LargeImage")));
            this.barButtonItemSave.Name = "barButtonItemSave";
            // 
            // barButtonItemTest
            // 
            this.barButtonItemTest.Caption = "Test";
            this.barButtonItemTest.Id = 2;
            this.barButtonItemTest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemTest.ImageOptions.Image")));
            this.barButtonItemTest.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemTest.ImageOptions.LargeImage")));
            this.barButtonItemTest.Name = "barButtonItemTest";
            this.barButtonItemTest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemTest_ItemClick);
            // 
            // barButtonItemCancel
            // 
            this.barButtonItemCancel.Caption = "İptal";
            this.barButtonItemCancel.Id = 3;
            this.barButtonItemCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemCancel.ImageOptions.Image")));
            this.barButtonItemCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCancel.ImageOptions.LargeImage")));
            this.barButtonItemCancel.Name = "barButtonItemCancel";
            this.barButtonItemCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Bağlantı Ayarları";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemTest);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(106, 262);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Veri Tabanı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(106, 298);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Doğrulama:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(106, 336);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 21);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Kullanıcı Adı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(106, 378);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 21);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Parola:";
            // 
            // textEditDatabase
            // 
            this.textEditDatabase.Location = new System.Drawing.Point(240, 256);
            this.textEditDatabase.MenuManager = this.ribbonControl1;
            this.textEditDatabase.Name = "textEditDatabase";
            this.textEditDatabase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditDatabase.Properties.Appearance.Options.UseFont = true;
            this.textEditDatabase.Size = new System.Drawing.Size(199, 28);
            this.textEditDatabase.TabIndex = 5;
            // 
            // textEditUser
            // 
            this.textEditUser.Location = new System.Drawing.Point(240, 329);
            this.textEditUser.MenuManager = this.ribbonControl1;
            this.textEditUser.Name = "textEditUser";
            this.textEditUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditUser.Properties.Appearance.Options.UseFont = true;
            this.textEditUser.Size = new System.Drawing.Size(199, 28);
            this.textEditUser.TabIndex = 6;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(240, 372);
            this.textEditPassword.MenuManager = this.ribbonControl1;
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditPassword.Size = new System.Drawing.Size(199, 28);
            this.textEditPassword.TabIndex = 7;
            // 
            // comboBoxEditAuth
            // 
            this.comboBoxEditAuth.Location = new System.Drawing.Point(240, 291);
            this.comboBoxEditAuth.MenuManager = this.ribbonControl1;
            this.comboBoxEditAuth.Name = "comboBoxEditAuth";
            this.comboBoxEditAuth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEditAuth.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditAuth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditAuth.Size = new System.Drawing.Size(199, 28);
            this.comboBoxEditAuth.TabIndex = 8;
            this.comboBoxEditAuth.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditAuth_SelectedIndexChanged);
            // 
            // XtraFormMssqlConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 476);
            this.Controls.Add(this.comboBoxEditAuth);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditUser);
            this.Controls.Add(this.textEditDatabase);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XtraFormMssqlConnection";
            this.Text = "Veri Tabanı Bağlantı Ayarları";
            this.Load += new System.EventHandler(this.XtraFormMssqlConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditAuth.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItemTest;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditDatabase;
        private DevExpress.XtraEditors.TextEdit textEditUser;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditAuth;
    }
}