using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Abstracts
{
    public interface IServerSettingDAL
    {
        ServerSetting Add(ServerSetting c);
        ServerSetting Update(ServerSetting c);
        ServerSetting Delete(int id);

        List<ServerSetting> GetAll();
        T Get<T>(string tagName);
        // bu metot çağrıldığında dönen değer, çağrıldığı yerdeki kullanılan türe göre belirlenir.
    }
}
