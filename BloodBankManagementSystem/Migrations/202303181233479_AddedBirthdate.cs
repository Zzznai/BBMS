namespace BloodBankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Donors", "DonorBirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Patients", "PatientBirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "PatientBirthDate");
            DropColumn("dbo.Donors", "DonorBirthDate");
        }
    }
}
