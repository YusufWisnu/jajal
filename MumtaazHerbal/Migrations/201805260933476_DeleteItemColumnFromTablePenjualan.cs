namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteItemColumnFromTablePenjualan : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Penjualans", "ItemId", "dbo.Items");
            DropIndex("dbo.Penjualans", new[] { "ItemId" });
            DropColumn("dbo.Penjualans", "ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Penjualans", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.Penjualans", "ItemId");
            AddForeignKey("dbo.Penjualans", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
    }
}
