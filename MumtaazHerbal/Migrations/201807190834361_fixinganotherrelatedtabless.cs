namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSomeColumnInTableKasKeluarAndDetail : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.KasKeluars", new[] { "NoTransaksi" });
            AddColumn("dbo.DetailKasKeluars", "Keterangan", c => c.String());
            AddColumn("dbo.KasKeluars", "Keterangan", c => c.String(nullable: false, maxLength: 255, unicode: false));
            AlterColumn("dbo.KasKeluars", "NoTransaksi", c => c.String(nullable: false, maxLength: 255, unicode: false));
            CreateIndex("dbo.KasKeluars", "NoTransaksi", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.KasKeluars", new[] { "NoTransaksi" });
            AlterColumn("dbo.KasKeluars", "NoTransaksi", c => c.String(maxLength: 255, unicode: false));
            DropColumn("dbo.KasKeluars", "Keterangan");
            DropColumn("dbo.DetailKasKeluars", "Keterangan");
            CreateIndex("dbo.KasKeluars", "NoTransaksi", unique: true);
        }
    }
}
