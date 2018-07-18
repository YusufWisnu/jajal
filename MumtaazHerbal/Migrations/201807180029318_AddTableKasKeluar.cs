namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableKasKeluar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KasKeluars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoTransaksi = c.String(maxLength: 255, unicode: false),
                        Tanggal = c.DateTime(nullable: false),
                        Keterangan = c.String(),
                        Jumlah = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NoTransaksi, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.KasKeluars", new[] { "NoTransaksi" });
            DropTable("dbo.KasKeluars");
        }
    }
}
