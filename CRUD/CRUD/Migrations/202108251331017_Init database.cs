namespace CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Age = c.Int(nullable: false),
                        Salary = c.Double(nullable: false),
                        Position_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Positions", t => t.Position_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Priority = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskEmployees",
                c => new
                    {
                        Task_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Task_Id, t.Employee_Id })
                .ForeignKey("dbo.Tasks", t => t.Task_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .Index(t => t.Task_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskEmployees", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.TaskEmployees", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.Employees", "Position_Id", "dbo.Positions");
            DropIndex("dbo.TaskEmployees", new[] { "Employee_Id" });
            DropIndex("dbo.TaskEmployees", new[] { "Task_Id" });
            DropIndex("dbo.Employees", new[] { "Position_Id" });
            DropTable("dbo.TaskEmployees");
            DropTable("dbo.Tasks");
            DropTable("dbo.Positions");
            DropTable("dbo.Employees");
        }
    }
}
