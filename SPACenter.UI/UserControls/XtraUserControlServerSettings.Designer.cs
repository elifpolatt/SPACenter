namespace SPACenter.UI.UserControls
{
    partial class XtraUserControlServerSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraUserControlServerSettings));
            this.labelControlDisplayName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.serverSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverSettingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlDisplayName
            // 
            this.labelControlDisplayName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serverSettingBindingSource, "DisplayName", true));
            this.labelControlDisplayName.Location = new System.Drawing.Point(17, 20);
            this.labelControlDisplayName.Name = "labelControlDisplayName";
            this.labelControlDisplayName.Size = new System.Drawing.Size(100, 16);
            this.labelControlDisplayName.TabIndex = 0;
            this.labelControlDisplayName.Text = "labelDisplayName";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(86, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Değer:";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.serverSettingBindingSource, "Value", true));
            this.textEdit1.Location = new System.Drawing.Point(145, 55);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(346, 22);
            this.textEdit1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serverSettingBindingSource, "Descripton", true));
            this.textBox1.Location = new System.Drawing.Point(145, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 106);
            this.textBox1.TabIndex = 3;
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButtonSave.Location = new System.Drawing.Point(497, 174);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonSave.TabIndex = 4;
            this.simpleButtonSave.Text = "Kaydet";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // serverSettingBindingSource
            // 
            this.serverSettingBindingSource.DataSource = typeof(SPACenter.Entities.Database.ServerSetting);
            // 
            // XtraUserControlServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButtonSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControlDisplayName);
            this.Name = "XtraUserControlServerSettings";
            this.Size = new System.Drawing.Size(609, 233);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverSettingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlDisplayName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource serverSettingBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
    }
}
