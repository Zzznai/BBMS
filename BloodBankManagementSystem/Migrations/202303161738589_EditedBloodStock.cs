namespace BloodBankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedBloodStock : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.BloodStocks", "BloodGroup", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.BloodStocks", new[] { "BloodGroup" });
        }
    }
}
