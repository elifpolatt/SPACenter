namespace SPACenter.UI.Forms
{
    partial class XtraFormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEditUser = new DevExpress.XtraEditors.GridLookUpEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPasswordTemp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSystemAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageBytes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(98, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(98, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Şifre:";
            // 
            // gridLookUpEditUser
            // 
            this.gridLookUpEditUser.Location = new System.Drawing.Point(232, 66);
            this.gridLookUpEditUser.Name = "gridLookUpEditUser";
            this.gridLookUpEditUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEditUser.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditUser.Properties.DataSource = this.userBindingSource;
            this.gridLookUpEditUser.Properties.DisplayMember = "FullName";
            this.gridLookUpEditUser.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditUser.Properties.ValueMember = "Id";
            this.gridLookUpEditUser.Size = new System.Drawing.Size(247, 28);
            this.gridLookUpEditUser.TabIndex = 2;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(SPACenter.Entities.Database.User);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colSurname,
            this.colPassword,
            this.colPasswordTemp,
            this.colDelFlag,
            this.colSystemAdmin,
            this.colAccountType,
            this.colImageBytes,
            this.colImage});
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
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            // 
            // colPasswordTemp
            // 
            this.colPasswordTemp.FieldName = "PasswordTemp";
            this.colPasswordTemp.Name = "colPasswordTemp";
            // 
            // colDelFlag
            // 
            this.colDelFlag.FieldName = "DelFlag";
            this.colDelFlag.Name = "colDelFlag";
            // 
            // colSystemAdmin
            // 
            this.colSystemAdmin.FieldName = "SystemAdmin";
            this.colSystemAdmin.Name = "colSystemAdmin";
            // 
            // colAccountType
            // 
            this.colAccountType.FieldName = "AccountType";
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.OptionsColumn.ReadOnly = true;
            // 
            // colImageBytes
            // 
            this.colImageBytes.FieldName = "ImageBytes";
            this.colImageBytes.Name = "colImageBytes";
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            // 
            // textEditPassword
            // 
            this.textEditPassword.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "PasswordTemp", true));
            this.textEditPassword.Location = new System.Drawing.Point(232, 109);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditPassword.Size = new System.Drawing.Size(247, 28);
            this.textEditPassword.TabIndex = 3;
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCancel.ImageOptions.Image")));
            this.simpleButtonCancel.Location = new System.Drawing.Point(319, 158);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButtonCancel.Size = new System.Drawing.Size(38, 29);
            this.simpleButtonCancel.TabIndex = 4;
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButtonLogin
            // 
            this.simpleButtonLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonLogin.Appearance.Options.UseFont = true;
            this.simpleButtonLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLogin.ImageOptions.Image")));
            this.simpleButtonLogin.Location = new System.Drawing.Point(363, 158);
            this.simpleButtonLogin.Name = "simpleButtonLogin";
            this.simpleButtonLogin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButtonLogin.Size = new System.Drawing.Size(119, 29);
            this.simpleButtonLogin.TabIndex = 5;
            this.simpleButtonLogin.Text = "Giriş Yap";
            this.simpleButtonLogin.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // XtraFormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 228);
            this.Controls.Add(this.simpleButtonLogin);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.gridLookUpEditUser);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "XtraFormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.XtraFormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colPasswordTemp;
        private DevExpress.XtraGrid.Columns.GridColumn colDelFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colSystemAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn colImageBytes;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
    }
}