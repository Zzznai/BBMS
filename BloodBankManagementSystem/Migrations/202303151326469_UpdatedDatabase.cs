namespace BloodBankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDatabase : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BloodTransfers", newName: "BloodTransfusions");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.BloodTransfusions", newName: "BloodTransfers");
        }
    }
}
