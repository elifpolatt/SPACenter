namespace SPACenter.UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCustomers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementAppointments = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPayments = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementDepartments = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementTimes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElemenDB = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement,
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(260, 621);
            this.accordionControl1.TabIndex = 1;
            // 
            // accordionControlElement
            // 
            this.accordionControlElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementCustomers,
            this.accordionControlElementAppointments,
            this.accordionControlElementPayments,
            this.accordionControlSeparator1,
            this.accordionControlSeparator2});
            this.accordionControlElement.Expanded = true;
            this.accordionControlElement.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.accordionControlElement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement.ImageOptions.Image")));
            this.accordionControlElement.Name = "accordionControlElement";
            this.accordionControlElement.Text = "İşlemler";
            // 
            // accordionControlElementCustomers
            // 
            this.accordionControlElementCustomers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementCustomers.ImageOptions.Image")));
            this.accordionControlElementCustomers.Name = "accordionControlElementCustomers";
            this.accordionControlElementCustomers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCustomers.Text = "Müşteriler";
            this.accordionControlElementCustomers.Click += new System.EventHandler(this.accordionControlElementCustomers_Click);
            // 
            // accordionControlElementAppointments
            // 
            this.accordionControlElementAppointments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementAppointments.ImageOptions.Image")));
            this.accordionControlElementAppointments.Name = "accordionControlElementAppointments";
            this.accordionControlElementAppointments.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementAppointments.Text = "Randevular";
            this.accordionControlElementAppointments.Click += new System.EventHandler(this.accordionControlElementAppointments_Click);
            // 
            // accordionControlElementPayments
            // 
            this.accordionControlElementPayments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementPayments.ImageOptions.Image")));
            this.accordionControlElementPayments.Name = "accordionControlElementPayments";
            this.accordionControlElementPayments.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPayments.Text = "Ödemeler";
            this.accordionControlElementPayments.Click += new System.EventHandler(this.accordionControlElementPayments_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementDepartments,
            this.accordionControlElementUsers,
            this.accordionControlElementTimes,
            this.accordionControlElemenDB,
            this.accordionControlElementSettings});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Admin İşlemleri";
            // 
            // accordionControlElementDepartments
            // 
            this.accordionControlElementDepartments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementDepartments.ImageOptions.Image")));
            this.accordionControlElementDepartments.Name = "accordionControlElementDepartments";
            this.accordionControlElementDepartments.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementDepartments.Text = "Bölümler";
            this.accordionControlElementDepartments.Click += new System.EventHandler(this.accordionControlElementDepartments_Click);
            // 
            // accordionControlElementUsers
            // 
            this.accordionControlElementUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementUsers.ImageOptions.Image")));
            this.accordionControlElementUsers.Name = "accordionControlElementUsers";
            this.accordionControlElementUsers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementUsers.Text = "Sistem Kullanıcıları";
            this.accordionControlElementUsers.Click += new System.EventHandler(this.accordionControlElementUsers_Click);
            // 
            // accordionControlElementTimes
            // 
            this.accordionControlElementTimes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementTimes.ImageOptions.Image")));
            this.accordionControlElementTimes.Name = "accordionControlElementTimes";
            this.accordionControlElementTimes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementTimes.Text = "Seans Saatleri";
            // 
            // accordionControlElemenDB
            // 
            this.accordionControlElemenDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElemenDB.ImageOptions.Image")));
            this.accordionControlElemenDB.Name = "accordionControlElemenDB";
            this.accordionControlElemenDB.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElemenDB.Text = "Veri Tabanı İzleme";
            // 
            // accordionControlElementSettings
            // 
            this.accordionControlElementSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementSettings.ImageOptions.Image")));
            this.accordionControlElementSettings.Name = "accordionControlElementSettings";
            this.accordionControlElementSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementSettings.Text = "Sistem Ayarları";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 621);
            this.Controls.Add(this.accordionControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCustomers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementAppointments;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementPayments;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementDepartments;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementUsers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementTimes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElemenDB;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementSettings;
    }
}

