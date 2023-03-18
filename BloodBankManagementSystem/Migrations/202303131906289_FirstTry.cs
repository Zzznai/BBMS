namespace BloodBankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodDonations",
                c => new
                    {
                        DonationID = c.Int(nullable: false, identity: true),
                        DonorID = c.Int(nullable: false),
                        PatientID = c.Int(nullable: false),
                        DonationDate = c.DateTime(nullable: false),
                        BloodGroup = c.String(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DonationID)
                .ForeignKey("dbo.Donors", t => t.DonorID, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.DonorID)
                .Index(t => t.PatientID);
            
            CreateTable(
                "dbo.Donors",
                c => new
                    {
                        DonorID = c.Int(nullable: false, identity: true),
                        DonorFirstName = c.String(),
                        DonorLastName = c.String(),
                        DonorGender = c.String(),
                        DonorAge = c.Int(nullable: false),
                        BloodGroup = c.String(),
                        LastDonationDate = c.DateTime(nullable: false),
                        ContactNumber = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.DonorID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        PatientFirstName = c.String(),
                        PatientLastName = c.String(),
                        PatientGender = c.String(),
                        PatientAge = c.Int(nullable: false),
                        BloodGroup = c.String(),
                        ContactNumber = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.PatientID);
            
            CreateTable(
                "dbo.BloodStocks",
                c => new
                    {
                        BloodStockID = c.Int(nullable: false, identity: true),
                        BloodGroup = c.String(),
                        TotalQuantity = c.Int(nullable: false),
                        UsedQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BloodStockID);
            
            CreateTable(
                "dbo.BloodTransfers",
                c => new
                    {
                        TransferID = c.Int(nullable: false, identity: true),
                        SourceStockID = c.Int(nullable: false),
                        DestinationStockID = c.Int(nullable: false),
                        TransferDate = c.DateTime(nullable: false),
                        BloodGroup = c.String(),
                        Quantity = c.Int(nullable: false),
                        BloodStock_BloodStockID = c.Int(),
                    })
                .PrimaryKey(t => t.TransferID)
                .ForeignKey("dbo.BloodStocks", t => t.BloodStock_BloodStockID)
                .Index(t => t.BloodStock_BloodStockID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Name = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BloodTransfers", "BloodStock_BloodStockID", "dbo.BloodStocks");
            DropForeignKey("dbo.BloodDonations", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.BloodDonations", "DonorID", "dbo.Donors");
            DropIndex("dbo.BloodTransfers", new[] { "BloodStock_BloodStockID" });
            DropIndex("dbo.BloodDonations", new[] { "PatientID" });
            DropIndex("dbo.BloodDonations", new[] { "DonorID" });
            DropTable("dbo.Users");
            DropTable("dbo.BloodTransfers");
            DropTable("dbo.BloodStocks");
            DropTable("dbo.Patients");
            DropTable("dbo.Donors");
            DropTable("dbo.BloodDonations");
        }
    }
}
