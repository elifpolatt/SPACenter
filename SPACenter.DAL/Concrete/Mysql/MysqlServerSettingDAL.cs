using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mysql
{
    public class MysqlServerSettingDAL : IServerSettingDAL
    {
        public ServerSetting Add(ServerSetting c)
        {
            throw new NotImplementedException();
        }

        public ServerSetting Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string tagName)
        {
            throw new NotImplementedException();
        }

        public List<ServerSetting> GetAll()
        {
            throw new NotImplementedException();
        }

        public ServerSetting Update(ServerSetting c)
        {
            throw new NotImplementedException();
        }
    }
}
