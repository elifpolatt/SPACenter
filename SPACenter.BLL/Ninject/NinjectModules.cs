﻿using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.DAL.Concrete.Mssql;
using SPACenter.Entities.Enums;
using SPACenter.Entities.Models;
using SPACenter.DAL.Concrete.Mysql;

namespace SPACenter.BLL.Ninject
{
    //NinjectModules sınıfı uygulama baslatılması sırasında kullanılmak uzere tasarlanmıstır.

    public class NinjectModules : NinjectModule
    {
        private DatabaseType DatabaseType;
        private string ConString { get; set; }
        public IKernel StandardKernel { get; set; }

        public NinjectModules(ConnectInfo connect)
        {
            ConString = connect.ConnectionString;
            DatabaseType = connect.DatabaseType;
            StandardKernel = new StandardKernel();
            Load();
            //Bu iki satırı NinjectModules sınıfının kurucu metodunda tanımlamanın nedeni, bağımlılıkları enjekte etmek ve modülleri yüklemek için Ninject kütüphanesini kullanıyorsanız, bu işlemleri sınıfın örneği oluşturulduğunda otomatik olarak gerçekleştirmek istemenizdir.

            //StandardKernel Nesnesi Oluşturma: StandardKernel sınıfı, Ninject kütüphanesinin temel nesnesidir ve bağımlılıkları çözümlemek, modülleri yüklemek ve enjeksiyonları yönetmek için kullanılır. NinjectModules sınıfının kurucusunda StandardKernel nesnesi oluşturuluyor çünkü bu nesne, bağımlılıkları enjekte etmek için kullanılacak temel nesnedir.

            //    Load Metodu Çağrısı: Load metodu, Ninject modüllerini yüklemek ve bağımlılıkları çözmek için kullanılır.Bu metotun çağrılması, belirli bir modülün bağımlılıklarını çözmeye başlaması anlamına gelir. NinjectModules sınıfının kurucusunda Load metodu çağrılıyor çünkü sınıfın örneği oluşturulduğunda bağımlılıkları hemen çözmek ve modülleri yüklemek isteniyor olabilir.
        }

        public override void Load()
        {
            //tercihe gore mysqlde veya mssqlde olusturulabılecek
            switch (DatabaseType)
            {
                case DatabaseType.Mssql:
                    LoadMssql();
                    break;
                case DatabaseType.Mysql:
                    LoadMysql();
                    break;
            }
        }

        public void LoadMysql()
        {
            StandardKernel.Bind<ICustomerDAL>().To<MysqlCustomerDAL>().WithConstructorArgument("dbConnectionString", ConString);
        }

        public void LoadMssql()
        {
            //ICustomerDAL isminde bir interface gördüğünde MssqlCustomerDAL sınıfından bir nesne baglayacak.
            StandardKernel.Bind<ICustomerDAL>().To<MssqlCustomerDAL>().WithConstructorArgument("dbConnectionString", ConString);
            //bu connectionString sanırım globalvariabledan geliyor.

        }
    }
}