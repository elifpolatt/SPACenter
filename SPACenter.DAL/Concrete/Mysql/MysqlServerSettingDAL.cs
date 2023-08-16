﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mysql
{
    public class MysqlServerSettingDAL : IServerSettingDAL
    {
        private string DbConnectionString { get; set; }

        public MysqlServerSettingDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }
        public ServerSetting Add(ServerSetting c)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                ServerSetting serverSetting = context.ServerSettings.Add(c);
                if (context.SaveChanges())
                {
                    return serverSetting;
                }
                else
                {
                    return null;
                }
            }
        }

        public ServerSetting Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string tagName)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {

                ServerSetting serverSetting = context.ServerSettings.FirstOrDefault(x => x.TagName == tagName);

                TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
                return converter.CanConvertFrom(typeof(string))
                    ? (T)converter.ConvertFrom(serverSetting.Value)
                    : default(T);

                return (T)Convert.ChangeType(serverSetting.Value, typeof(T));
            }
        }

        public List<ServerSetting> GetAll()
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                return context.ServerSettings.ToList();

            }
        }

        public ServerSetting Update(ServerSetting c)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {

                context.Entry(c).State = EntityState.Modified;

                if (context.SaveChanges())
                {
                    return c;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
