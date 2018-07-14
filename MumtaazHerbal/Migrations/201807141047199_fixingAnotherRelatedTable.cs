namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingAnotherRelatedTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Penjualans", "PiutangId", c => c.Int(nullable: true));
            CreateIndex("dbo.Penjualans", "PiutangId");
            AddForeignKey("dbo.Penjualans", "PiutangId", "dbo.Piutangs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Penjualans", "PiutangId", "dbo.Piutangs");
            DropIndex("dbo.Penjualans", new[] { "PiutangId" });
            DropColumn("dbo.Penjualans", "PiutangId");
        }
    }
}
