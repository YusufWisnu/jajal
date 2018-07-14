namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingFixingRelationship : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Piutangs", name: "PenjualanId", newName: "Penjualan_Id");
            RenameIndex(table: "dbo.Piutangs", name: "IX_PenjualanId", newName: "IX_Penjualan_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Piutangs", name: "IX_Penjualan_Id", newName: "IX_PenjualanId");
            RenameColumn(table: "dbo.Piutangs", name: "Penjualan_Id", newName: "PenjualanId");
        }
    }
}
