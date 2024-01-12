namespace WorkListMaker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TcId = c.String(),
                        MaxDailyWorkingHours = c.Int(nullable: false),
                        MinDailyWorkingHours = c.Int(nullable: false),
                        MaxWorkingHoursPerMonth = c.Int(nullable: false),
                        SpecialStatusCode = c.Int(nullable: false),
                        OvertimeHours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PolyclinicAreas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        NumberOfEmployeesRequired = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PolyclinicAreas");
            DropTable("dbo.Employees");
        }
    }
}
