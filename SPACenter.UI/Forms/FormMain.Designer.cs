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
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement});
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
            this.accordionControlElementPayments});
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
            // 
            // accordionControlElementPayments
            // 
            this.accordionControlElementPayments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementPayments.ImageOptions.Image")));
            this.accordionControlElementPayments.Name = "accordionControlElementPayments";
            this.accordionControlElementPayments.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPayments.Text = "Ödemeler";
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
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCustomers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementAppointments;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementPayments;
    }
}

