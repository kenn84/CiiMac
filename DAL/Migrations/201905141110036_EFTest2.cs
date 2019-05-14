namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EFTest2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Address", "CompanyDbModel_CompanyId", c => c.Guid());
            CreateIndex("dbo.Address", "CompanyDbModel_CompanyId");
            AddForeignKey("dbo.Address", "CompanyDbModel_CompanyId", "dbo.Company", "CompanyId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Address", "CompanyDbModel_CompanyId", "dbo.Company");
            DropIndex("dbo.Address", new[] { "CompanyDbModel_CompanyId" });
            DropColumn("dbo.Address", "CompanyDbModel_CompanyId");
        }
    }
}
