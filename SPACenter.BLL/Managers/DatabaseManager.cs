using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using SPACenter.BLL.Ninject;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;
using SPACenter.Entities.Models;

namespace SPACenter.BLL.Managers
{
    public class DatabaseManager
    {
        private IDatabaseDAL _IDatabaseDal;
        private IServerSettingDAL _IServerSettingDal;
        private UserManager userManager;
        private ConnectInfo ConnectInfo { get; set; }

        public DatabaseManager(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
            _IDatabaseDal = new NinjectModules(connectInfo).StandardKernel.Get<IDatabaseDAL>();
            _IServerSettingDal = new NinjectModules(connectInfo).StandardKernel.Get<IServerSettingDAL>();

        }

        public bool CreatDatabase(User adminUser)
        {
            bool creatDatabase = _IDatabaseDal.CreateDatabase();
            InsertStartValues(adminUser);
            return creatDatabase;
        }

        private void InsertStartValues(User adminUser)
        {
            List<ServerSetting> serverSettings = new List<ServerSetting>()
            {
                new ServerSetting {TagName = "PERIODSEND", Value   = "00:18:30:00" , Descripton = "Mesai Sonu", DisplayName  = "Mesai Sonu", EditOnList  = true },
                new ServerSetting {TagName = "PERIODSSTART", Value = "00:10:30:00", Descripton = "Başlama Zamanı", DisplayName  = "Başlama Zamanı", EditOnList  = true }
            };
            serverSettings.ForEach(x =>
            {
                _IServerSettingDal.Add(x);

            });
            userManager = new UserManager(ConnectInfo);
            adminUser.SystemAdmin = true;
            userManager.Add(adminUser);

        }

        public bool TestDatabase()
        {
            return _IDatabaseDal.Test();
        }
    }
}
