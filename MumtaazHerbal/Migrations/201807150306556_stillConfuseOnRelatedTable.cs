namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stillConfuseOnRelatedTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Penjualans", "PiutangId", "dbo.Piutangs");
            DropIndex("dbo.Penjualans", new[] { "PiutangId" });
            AddColumn("dbo.Piutangs", "PelangganId", c => c.Int(nullable: true));
            CreateIndex("dbo.Piutangs", "PelangganId");
            AddForeignKey("dbo.Piutangs", "PelangganId", "dbo.Pelanggans", "Id");
            DropColumn("dbo.Penjualans", "PiutangId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Penjualans", "PiutangId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Piutangs", "PelangganId", "dbo.Pelanggans");
            DropIndex("dbo.Piutangs", new[] { "PelangganId" });
            DropColumn("dbo.Piutangs", "PelangganId");
            CreateIndex("dbo.Penjualans", "PiutangId");
            AddForeignKey("dbo.Penjualans", "PiutangId", "dbo.Piutangs", "Id");
        }
    }
}
