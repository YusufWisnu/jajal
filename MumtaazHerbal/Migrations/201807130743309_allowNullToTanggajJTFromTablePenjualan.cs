namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allowNullToTanggajJTFromTablePenjualan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Penjualans", "TanggalJT", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Penjualans", "TanggalJT", c => c.DateTime(nullable: false));
        }
    }
}
