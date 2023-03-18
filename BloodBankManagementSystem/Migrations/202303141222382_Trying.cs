namespace BloodBankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Trying : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BloodDonations", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.BloodTransfers", "BloodStock_BloodStockID", "dbo.BloodStocks");
            DropIndex("dbo.BloodDonations", new[] { "PatientID" });
            DropIndex("dbo.BloodTransfers", new[] { "BloodStock_BloodStockID" });
            DropColumn("dbo.BloodTransfers", "SourceStockID");
            RenameColumn(table: "dbo.BloodTransfers", name: "BloodStock_BloodStockID", newName: "SourceStockID");
            AddColumn("dbo.BloodDonations", "QuantityInLiters", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.BloodStocks", "QuantityInLiters", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.BloodTransfers", "DestinationPatientID", c => c.Int(nullable: false));
            AddColumn("dbo.BloodTransfers", "QuantityInLiters", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Donors", "DonorFirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Donors", "DonorLastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Donors", "DonorGender", c => c.String(maxLength: 10));
            AlterColumn("dbo.Donors", "BloodGroup", c => c.String(maxLength: 5));
            AlterColumn("dbo.Donors", "LastDonationDate", c => c.DateTime());
            AlterColumn("dbo.Donors", "ContactNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.Donors", "Address", c => c.String(maxLength: 100));
            AlterColumn("dbo.Patients", "PatientFirstName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Patients", "PatientLastName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Patients", "PatientGender", c => c.String(maxLength: 10));
            AlterColumn("dbo.Patients", "BloodGroup", c => c.String(maxLength: 5));
            AlterColumn("dbo.Patients", "ContactNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "Address", c => c.String(maxLength: 100));
            AlterColumn("dbo.BloodStocks", "BloodGroup", c => c.String(maxLength: 5));
            AlterColumn("dbo.BloodTransfers", "BloodGroup", c => c.String(maxLength: 5));
            AlterColumn("dbo.BloodTransfers", "SourceStockID", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Role", c => c.String(nullable: false, maxLength: 10));
            CreateIndex("dbo.BloodTransfers", "SourceStockID");
            CreateIndex("dbo.Users", "Email", unique: true);
            AddForeignKey("dbo.BloodTransfers", "SourceStockID", "dbo.BloodStocks", "BloodStockID", cascadeDelete: true);
            DropColumn("dbo.BloodDonations", "PatientID");
            DropColumn("dbo.BloodDonations", "BloodGroup");
            DropColumn("dbo.BloodDonations", "Quantity");
            DropColumn("dbo.BloodStocks", "TotalQuantity");
            DropColumn("dbo.BloodStocks", "UsedQuantity");
            DropColumn("dbo.BloodTransfers", "DestinationStockID");
            DropColumn("dbo.BloodTransfers", "Quantity");
            DropColumn("dbo.Users", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Name", c => c.String());
            AddColumn("dbo.BloodTransfers", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.BloodTransfers", "DestinationStockID", c => c.Int(nullable: false));
            AddColumn("dbo.BloodStocks", "UsedQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.BloodStocks", "TotalQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.BloodDonations", "Quantity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.BloodDonations", "BloodGroup", c => c.String());
            AddColumn("dbo.BloodDonations", "PatientID", c => c.Int(nullable: false));
            DropForeignKey("dbo.BloodTransfers", "SourceStockID", "dbo.BloodStocks");
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.BloodTransfers", new[] { "SourceStockID" });
            AlterColumn("dbo.Users", "Role", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.BloodTransfers", "SourceStockID", c => c.Int());
            AlterColumn("dbo.BloodTransfers", "BloodGroup", c => c.String());
            AlterColumn("dbo.BloodStocks", "BloodGroup", c => c.String());
            AlterColumn("dbo.Patients", "Address", c => c.String());
            AlterColumn("dbo.Patients", "ContactNumber", c => c.String());
            AlterColumn("dbo.Patients", "BloodGroup", c => c.String());
            AlterColumn("dbo.Patients", "PatientGender", c => c.String());
            AlterColumn("dbo.Patients", "PatientLastName", c => c.String());
            AlterColumn("dbo.Patients", "PatientFirstName", c => c.String());
            AlterColumn("dbo.Donors", "Address", c => c.String());
            AlterColumn("dbo.Donors", "ContactNumber", c => c.String());
            AlterColumn("dbo.Donors", "LastDonationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Donors", "BloodGroup", c => c.String());
            AlterColumn("dbo.Donors", "DonorGender", c => c.String());
            AlterColumn("dbo.Donors", "DonorLastName", c => c.String());
            AlterColumn("dbo.Donors", "DonorFirstName", c => c.String());
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
            DropColumn("dbo.BloodTransfers", "QuantityInLiters");
            DropColumn("dbo.BloodTransfers", "DestinationPatientID");
            DropColumn("dbo.BloodStocks", "QuantityInLiters");
            DropColumn("dbo.BloodDonations", "QuantityInLiters");
            RenameColumn(table: "dbo.BloodTransfers", name: "SourceStockID", newName: "BloodStock_BloodStockID");
            AddColumn("dbo.BloodTransfers", "SourceStockID", c => c.Int(nullable: false));
            CreateIndex("dbo.BloodTransfers", "BloodStock_BloodStockID");
            CreateIndex("dbo.BloodDonations", "PatientID");
            AddForeignKey("dbo.BloodTransfers", "BloodStock_BloodStockID", "dbo.BloodStocks", "BloodStockID");
            AddForeignKey("dbo.BloodDonations", "PatientID", "dbo.Patients", "PatientID", cascadeDelete: true);
        }
    }
}
