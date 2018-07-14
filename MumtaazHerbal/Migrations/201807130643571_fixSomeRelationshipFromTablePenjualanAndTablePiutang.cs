namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixSomeRelationshipFromTablePenjualanAndTablePiutang : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Piutangs", "pelangganId", "dbo.Pelanggans");
            DropIndex("dbo.Piutangs", new[] { "pelangganId" });
            AddColumn("dbo.Penjualans", "Sisa", c => c.Int(nullable: false));
            AddColumn("dbo.Penjualans", "TanggalJT", c => c.DateTime(nullable: false));
            AddColumn("dbo.Piutangs", "PenjualanId", c => c.Int(nullable: false));
            CreateIndex("dbo.Piutangs", "PenjualanId");
            AddForeignKey("dbo.Piutangs", "PenjualanId", "dbo.Penjualans", "Id");
            DropColumn("dbo.Piutangs", "pelangganId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Piutangs", "pelangganId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Piutangs", "PenjualanId", "dbo.Penjualans");
            DropIndex("dbo.Piutangs", new[] { "PenjualanId" });
            DropColumn("dbo.Piutangs", "PenjualanId");
            DropColumn("dbo.Penjualans", "TanggalJT");
            DropColumn("dbo.Penjualans", "Sisa");
            CreateIndex("dbo.Piutangs", "pelangganId");
            AddForeignKey("dbo.Piutangs", "pelangganId", "dbo.Pelanggans", "Id", cascadeDelete: true);
        }
    }
}
