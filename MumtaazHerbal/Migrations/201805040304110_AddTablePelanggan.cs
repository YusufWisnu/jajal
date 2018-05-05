namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablePelanggan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pelanggans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nama = c.String(),
                        KodePelanggan = c.String(),
                        NoHp = c.String(),
                        Alamat = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pelanggans");
        }
    }
}
