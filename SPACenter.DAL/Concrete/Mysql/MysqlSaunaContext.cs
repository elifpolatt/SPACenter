﻿using MySql.Data.EntityFramework;
using SPACenter.Entities.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//MySql.Data ve MySql.Data.EntityFramework paketlerini yukledim.
namespace SPACenter.DAL.Concrete.Mysql

{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    //Mysql'e baglamak icin yapıldı. configde gelip <entityFramework codeConfigurationType="MySql.Data.Entity.MySqlEFConfiguration, MySql.Data.EntityFramework"> bu kısmı eklesek de olurdu. context'te yapıldıgında da oluyor.

    public class MysqlSaunaContext : DbContext
    {
        public MysqlSaunaContext() : base("MysqlSaunaContext") { }

        public MysqlSaunaContext(string dbConnectionString)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<RendezvousTime> RendezvousTime { get; set; }
        public DbSet<ServerSetting> ServerSettings { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasMany(x => x.Appointments).WithRequired(x => x.Customer).WillCascadeOnDelete(false);
            //müşteri için: birden fazla randevu olusturulabilir. randevunun musterısı olmak zorunda. ve silme işlemleri birbirinden bagımsız olacak.

            modelBuilder.Entity<Customer>().HasMany(x => x.Payments).WithOptional(x => x.Customer).HasForeignKey(x => x.CustomerId).WillCascadeOnDelete(false);
            //müşteri için: birden fazla ödeme yapılabilir. ödeme musterıye bagımlı customerid ile ilişkili. silme birbirinden bagımsız.

            modelBuilder.Entity<Department>().HasMany(x => x.Appointments).WithRequired(x => x.Department).WillCascadeOnDelete(false);
            //bölüm için: birden fazla randevu olusturulabılır. randevunun bölümü olmak zorunda. ve silme işlemleri birbirinden bagımsız olacak.

            modelBuilder.Entity<Department>().HasMany(x => x.Payments).WithOptional(x => x.Department).HasForeignKey(x => x.DepartmentId).WillCascadeOnDelete(false);
            //bölüm için: birden fazla ödeme olabilir ama bu opsiyonel. departmentid ile ilişkili. silme birbirinden bagımsız.

            modelBuilder.Entity<RendezvousTime>().HasMany(x => x.Appointments).WithRequired(x => x.RendevousTime).HasForeignKey(x => x.RendezvousTimeId).WillCascadeOnDelete(false);
            //randevu zamanı için : birden fazla randevu olusturulabılır. randevunun randevu zamanı olmak zorunda. ve silme işlemleri bagımsız.

            modelBuilder.Entity<Department>().HasMany(x => x.RendezvousTimes).WithRequired(x => x.Department).HasForeignKey(x => x.DepartmentId).WillCascadeOnDelete(false);
            //bölüm için birden fazla ödeme olabilir ve bölümidye baglı.

        }
        public new bool SaveChanges()
        {
            try
            {
                base.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
