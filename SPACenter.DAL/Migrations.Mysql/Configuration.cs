namespace SPACenter.DAL.Migrations.Mysql
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SPACenter.DAL.Concrete.Mysql.MysqlSaunaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations.Mysql";
        }

        protected override void Seed(SPACenter.DAL.Concrete.Mysql.MysqlSaunaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
