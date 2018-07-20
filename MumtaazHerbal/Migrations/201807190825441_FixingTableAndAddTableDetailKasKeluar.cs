namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingTableAndAddTableDetailKasKeluar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailKasKeluars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KaskeluarId = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KasKeluars", t => t.KaskeluarId, cascadeDelete: true)
                .Index(t => t.KaskeluarId);
            
            AddColumn("dbo.KasKeluars", "Total", c => c.Int(nullable: false));
            DropColumn("dbo.KasKeluars", "Keterangan");
            DropColumn("dbo.KasKeluars", "Jumlah");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KasKeluars", "Jumlah", c => c.Int(nullable: false));
            AddColumn("dbo.KasKeluars", "Keterangan", c => c.String());
            DropForeignKey("dbo.DetailKasKeluars", "KaskeluarId", "dbo.KasKeluars");
            DropIndex("dbo.DetailKasKeluars", new[] { "KaskeluarId" });
            DropColumn("dbo.KasKeluars", "Total");
            DropTable("dbo.DetailKasKeluars");
        }
    }
}
