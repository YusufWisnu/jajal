namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingAnotherRelationship : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Piutangs", "Penjualan_Id", "dbo.Penjualans");
            DropIndex("dbo.Piutangs", new[] { "Penjualan_Id" });
            DropColumn("dbo.Piutangs", "Penjualan_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Piutangs", "Penjualan_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Piutangs", "Penjualan_Id");
            AddForeignKey("dbo.Piutangs", "Penjualan_Id", "dbo.Penjualans", "Id");
        }
    }
}
