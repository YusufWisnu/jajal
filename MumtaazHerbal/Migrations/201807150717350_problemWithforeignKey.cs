namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class problemWithforeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DetailPiutangs", "PenjualanId", "dbo.Penjualans");
            DropForeignKey("dbo.Piutangs", "PelangganId", "dbo.Pelanggans");
            AddForeignKey("dbo.DetailPiutangs", "PenjualanId", "dbo.Penjualans", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Piutangs", "PelangganId", "dbo.Pelanggans", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Piutangs", "PelangganId", "dbo.Pelanggans");
            DropForeignKey("dbo.DetailPiutangs", "PenjualanId", "dbo.Penjualans");
            AddForeignKey("dbo.Piutangs", "PelangganId", "dbo.Pelanggans", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DetailPiutangs", "PenjualanId", "dbo.Penjualans", "Id");
        }
    }
}
