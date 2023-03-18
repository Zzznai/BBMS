namespace BloodBankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDonorTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Donors", "LastDonationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Donors", "LastDonationDate", c => c.DateTime(nullable: false));
        }
    }
}
