using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;
using SPACenter.UI.Message;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormRendezvousTime : DevExpress.XtraEditors.XtraForm
    {
        private RendezvousTimeManager rendezvousTimeManager;
        public XtraFormRendezvousTime()
        {
            InitializeComponent();
            rendezvousTimeManager = new RendezvousTimeManager(GlobalVariables.ConnectInfo);
        }

        void GetRendevousTime()
        {
            List<RendezvousTime> rendezvousTimes = rendezvousTimeManager.GetAll();
            rendezvousTimeBindingSource.DataSource = rendezvousTimes;
        }
        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormRendezvousTimeDetails rendezvousTimeDetails = new XtraFormRendezvousTimeDetails();
            rendezvousTimeDetails.ShowDialog();
            if (rendezvousTimeDetails.Result)
            {
                GetRendevousTime();
            }
        }

        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RendezvousTime rendezvousTime = rendezvousTimeBindingSource.Current as RendezvousTime;

            if (rendezvousTime == null)
            {
                return;
            }

            XtraFormRendezvousTimeDetails rendezvousTimeDetails = new XtraFormRendezvousTimeDetails(rendezvousTime.Id);
            rendezvousTimeDetails.ShowDialog();
            if (rendezvousTimeDetails.Result)
            {
                GetRendevousTime();
            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RendezvousTime rendezvousTime = rendezvousTimeBindingSource.Current as RendezvousTime;

            if (rendezvousTime == null)
            {
                return;

            }

            if (MessageBoxes.DeleteConfirmationDialog(name: rendezvousTime.ToString()) != DialogResult.Yes)
            {
                return;

            }

            Tuple<bool, List<string>, RendezvousTime> delete = rendezvousTimeManager.Delete(rendezvousTime.Id);
            MessageBoxes.ShowResult(delete);
            if (delete.Item1)
            {
                GetRendevousTime();
            }

        }
    }
}