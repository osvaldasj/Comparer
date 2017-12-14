namespace WEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addToProductShopId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ShopID", c => c.String(nullable:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ShopID");
        }
    }
}
