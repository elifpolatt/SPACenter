namespace SPACenter.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        RendevousDate = c.DateTime(nullable: false),
                        RendezvousTimeId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .ForeignKey("dbo.RendezvousTimes", t => t.RendezvousTimeId)
                .Index(t => t.CustomerId)
                .Index(t => t.RendezvousTimeId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        PhoneNumber = c.String(maxLength: 20),
                        Photo = c.Binary(),
                        Mail = c.String(maxLength: 200),
                        DelFlag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(),
                        DepartmentId = c.Int(),
                        DateTime = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                        PaymentType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        QuotaPerSeance = c.Int(nullable: false),
                        PaymentPerSeance = c.Double(nullable: false),
                        SessionLength = c.Int(nullable: false),
                        DelFlag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.RendezvousTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.Time(nullable: false, precision: 7),
                        EndTime = c.Time(nullable: false, precision: 7),
                        DepartmentId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.ServerSettings",
                c => new
                    {
                        TagName = c.String(nullable: false, maxLength: 20),
                        Value = c.String(nullable: false),
                        Descripton = c.String(),
                        DisplayName = c.String(nullable: false, maxLength: 60),
                        EditOnList = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TagName);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false),
                        DelFlag = c.Boolean(nullable: false),
                        SystemAdmin = c.String(),
                        ImageBytes = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.RendezvousTimes", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Appointments", "RendezvousTimeId", "dbo.RendezvousTimes");
            DropForeignKey("dbo.Payments", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Appointments", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Appointments", "CustomerId", "dbo.Customers");
            DropIndex("dbo.RendezvousTimes", new[] { "DepartmentId" });
            DropIndex("dbo.Departments", new[] { "Name" });
            DropIndex("dbo.Payments", new[] { "DepartmentId" });
            DropIndex("dbo.Payments", new[] { "CustomerId" });
            DropIndex("dbo.Appointments", new[] { "DepartmentId" });
            DropIndex("dbo.Appointments", new[] { "RendezvousTimeId" });
            DropIndex("dbo.Appointments", new[] { "CustomerId" });
            DropTable("dbo.Users");
            DropTable("dbo.ServerSettings");
            DropTable("dbo.RendezvousTimes");
            DropTable("dbo.Departments");
            DropTable("dbo.Payments");
            DropTable("dbo.Customers");
            DropTable("dbo.Appointments");
        }
    }
}
