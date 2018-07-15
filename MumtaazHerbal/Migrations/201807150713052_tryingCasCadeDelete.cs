namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingCasCadeDelete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Piutangs", "PelangganId", "dbo.Pelanggans");
            AddForeignKey("dbo.Piutangs", "PelangganId", "dbo.Pelanggans", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Piutangs", "PelangganId", "dbo.Pelanggans");
            AddForeignKey("dbo.Piutangs", "PelangganId", "dbo.Pelanggans", "Id");
        }
    }
}
