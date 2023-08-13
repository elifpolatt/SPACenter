using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SPACenter.BLL.Ninject;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;
using SPACenter.Entities.Models;

namespace SPACenter.BLL.Managers
{
    public class ServerSettingManager
    {
        private IServerSettingDAL _IServerSettingDal;

        public ServerSettingManager(ConnectInfo connectInfo)
        {
            _IServerSettingDal = new NinjectModules(connectInfo).StandardKernel.Get<IServerSettingDAL>();
        }

        public T Get<T>(string tagName)
        {
            return _IServerSettingDal.Get<T>(tagName);
        }

        public ServerSetting Update(ServerSetting serverSetting)
        {
            return _IServerSettingDal.Update(serverSetting);
        }

        public List<ServerSetting> GetAll(bool? displayOnList)
        {
            return _IServerSettingDal.GetAll().Where(x=>displayOnList == null || x.EditOnList == displayOnList).ToList();
        }
    }
}
