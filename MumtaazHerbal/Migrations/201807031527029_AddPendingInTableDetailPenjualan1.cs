namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPendingInTableDetailPenjualan1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailPenjualans", "Keterangan", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetailPenjualans", "Keterangan");
        }
    }
}
