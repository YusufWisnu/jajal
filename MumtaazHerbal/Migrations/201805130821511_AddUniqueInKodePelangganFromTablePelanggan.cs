namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniqueInKodePelangganFromTablePelanggan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pelanggans", "Nama", c => c.String(nullable: false, maxLength: 255, unicode: false));
            AlterColumn("dbo.Pelanggans", "KodePelanggan", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.Pelanggans", "NoHp", c => c.String(maxLength: 30, unicode: false));
            AlterColumn("dbo.Pelanggans", "Alamat", c => c.String(maxLength: 500));
            AlterColumn("dbo.Pelanggans", "Email", c => c.String(maxLength: 255, unicode: false));
            CreateIndex("dbo.Pelanggans", "KodePelanggan", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Pelanggans", new[] { "KodePelanggan" });
            AlterColumn("dbo.Pelanggans", "Email", c => c.String());
            AlterColumn("dbo.Pelanggans", "Alamat", c => c.String());
            AlterColumn("dbo.Pelanggans", "NoHp", c => c.String());
            AlterColumn("dbo.Pelanggans", "KodePelanggan", c => c.String());
            AlterColumn("dbo.Pelanggans", "Nama", c => c.String());
        }
    }
}
