namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniquePropertyFromItemsAndSuppliersTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Items", new[] { "KodeItem" });
            DropIndex("dbo.Suppliers", new[] { "KodeSupplier" });
            CreateIndex("dbo.Items", "KodeItem", unique: true);
            CreateIndex("dbo.Suppliers", "KodeSupplier", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Suppliers", new[] { "KodeSupplier" });
            DropIndex("dbo.Items", new[] { "KodeItem" });
            CreateIndex("dbo.Suppliers", "KodeSupplier");
            CreateIndex("dbo.Items", "KodeItem");
        }
    }
}
