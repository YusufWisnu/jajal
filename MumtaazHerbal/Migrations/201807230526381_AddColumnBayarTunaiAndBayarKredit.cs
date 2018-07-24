namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnBayarTunaiAndBayarKredit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Penjualans", "BayarTunai", c => c.Int(nullable: false));
            AddColumn("dbo.Penjualans", "BayarKredit", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Penjualans", "BayarKredit");
            DropColumn("dbo.Penjualans", "BayarTunai");
        }
    }
}
