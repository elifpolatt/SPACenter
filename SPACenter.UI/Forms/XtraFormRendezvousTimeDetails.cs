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
    public partial class XtraFormRendezvousTimeDetails : DevExpress.XtraEditors.XtraForm
    {
        public bool Result { get; set; }
        private RendezvousTimeManager rendezvousTimeManager;
        public RendezvousTime RendezvousTime { get; set; }

        public XtraFormRendezvousTimeDetails()
        {
            InitializeComponent();
            rendezvousTimeManager = new RendezvousTimeManager(GlobalVariables.ConnectInfo);
            RendezvousTime = new RendezvousTime();
            rendezvousTimeBindingSource.DataSource = RendezvousTime;
        }

        public XtraFormRendezvousTimeDetails(int id)
        {
            InitializeComponent();
            rendezvousTimeManager = new RendezvousTimeManager(GlobalVariables.ConnectInfo);
            RendezvousTime = rendezvousTimeManager.Get(id);
            rendezvousTimeBindingSource.DataSource = RendezvousTime;
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Tuple<bool, List<string>, RendezvousTime> operationResult;

            if (RendezvousTime.Id > 0)  //id sıfırdan buyukse yanı bır secim yapıldıysa save butonunda guncelleme islemi yap
            {
                operationResult = rendezvousTimeManager.Update(RendezvousTime);
            }
            else // yoksa ekleme işlemi yap 
            {
                operationResult = rendezvousTimeManager.Add(RendezvousTime);
            }

            MessageBoxes.ShowResult(operationResult);  //kullanıcıya sonucu messageboxesdan goster 

            if (operationResult.Item1)  //bool = true ise işlem basarılıysa: 
            {
                RendezvousTime = operationResult.Item3;  //eklenmiş veya güncellenmiş olan müsteri bilgisini güncelle
                Result = operationResult.Item1; //sonucu true olarak ayarla ve kaapt
                Close();
            }
        }
    }
}