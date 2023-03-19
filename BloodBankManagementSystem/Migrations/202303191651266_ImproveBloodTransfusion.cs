namespace BloodBankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImproveBloodTransfusion : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.BloodTransfusions", name: "SourceStockID", newName: "BloodStockId");
            RenameIndex(table: "dbo.BloodTransfusions", name: "IX_SourceStockID", newName: "IX_BloodStockId");
            CreateIndex("dbo.BloodTransfusions", "DestinationPatientID");
            AddForeignKey("dbo.BloodTransfusions", "DestinationPatientID", "dbo.Patients", "PatientID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BloodTransfusions", "DestinationPatientID", "dbo.Patients");
            DropIndex("dbo.BloodTransfusions", new[] { "DestinationPatientID" });
            RenameIndex(table: "dbo.BloodTransfusions", name: "IX_BloodStockId", newName: "IX_SourceStockID");
            RenameColumn(table: "dbo.BloodTransfusions", name: "BloodStockId", newName: "SourceStockID");
        }
    }
}
