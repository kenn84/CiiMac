namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EFTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Guid(nullable: false),
                        LoginId = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        CVR = c.String(nullable: false),
                        ContactPerson = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyId)
                .ForeignKey("dbo.Login", t => t.LoginId, cascadeDelete: true)
                .Index(t => t.LoginId);
            
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Company", "LoginId", "dbo.Login");
            DropIndex("dbo.Company", new[] { "LoginId" });
            DropTable("dbo.Login");
            DropTable("dbo.Company");
        }
    }
}
