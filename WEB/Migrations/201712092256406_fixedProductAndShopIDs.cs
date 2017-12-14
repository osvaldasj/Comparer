namespace WEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedProductAndShopIDs : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Prices");
            AlterColumn("dbo.Prices", "ProductID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Prices", "ShopID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Prices", "ProductID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Prices");
            AlterColumn("dbo.Prices", "ShopID", c => c.String());
            AlterColumn("dbo.Prices", "ProductID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Prices", "ProductID");
        }
    }
}
