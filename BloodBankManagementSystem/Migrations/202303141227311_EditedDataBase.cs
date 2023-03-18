namespace BloodBankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedDataBase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Donors", "DonorFirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Donors", "DonorLastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Donors", "DonorGender", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Donors", "BloodGroup", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Donors", "LastDonationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Donors", "ContactNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Donors", "Address", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.BloodStocks", "BloodGroup", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.BloodTransfers", "BloodGroup", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Patients", "PatientFirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Patients", "PatientLastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Patients", "PatientGender", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Patients", "BloodGroup", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Patients", "ContactNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Patients", "Address", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Address", c => c.String(maxLength: 100));
            AlterColumn("dbo.Patients", "ContactNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "BloodGroup", c => c.String(maxLength: 5));
            AlterColumn("dbo.Patients", "PatientGender", c => c.String(maxLength: 10));
            AlterColumn("dbo.Patients", "PatientLastName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Patients", "PatientFirstName", c => c.String(maxLength: 30));
            AlterColumn("dbo.BloodTransfers", "BloodGroup", c => c.String(maxLength: 5));
            AlterColumn("dbo.BloodStocks", "BloodGroup", c => c.String(maxLength: 5));
            AlterColumn("dbo.Donors", "Address", c => c.String(maxLength: 100));
            AlterColumn("dbo.Donors", "ContactNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.Donors", "LastDonationDate", c => c.DateTime());
            AlterColumn("dbo.Donors", "BloodGroup", c => c.String(maxLength: 5));
            AlterColumn("dbo.Donors", "DonorGender", c => c.String(maxLength: 10));
            AlterColumn("dbo.Donors", "DonorLastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Donors", "DonorFirstName", c => c.String(maxLength: 50));
        }
    }
}
