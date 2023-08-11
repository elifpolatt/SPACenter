using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace SPACenter.UI.Wait_Forms
{
    public partial class WaitForm : DevExpress.XtraWaitForm.WaitForm
    {
        public WaitForm()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }

        public static void ShowWaitForm(bool open = true ,string caption = "İşlem yapılırken bekleyiniz.", string description = "Yükleniyor...")
        {
            if (!open)
            {
                SplashScreenManager.CloseForm(false);
                return;
            }

            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm));
            }
            catch (Exception )
            {
                SplashScreenManager.CloseForm(false);
                SplashScreenManager.ShowForm(typeof(WaitForm));

            }
            SplashScreenManager.Default.SetWaitFormCaption(caption);
            SplashScreenManager.Default.SetWaitFormDescription(description);
        }
    }
}