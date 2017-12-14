namespace WEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CardID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Spent = c.Single(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.CardID);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        ProductID = c.String(nullable: false, maxLength: 128),
                        ShopID = c.String(),
                        DateT = c.DateTime(nullable: false),
                        PriceD = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        Shop = c.String(),
                        Date = c.DateTime(nullable: false),
                        Accept = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shops");
            DropTable("dbo.Products");
            DropTable("dbo.Prices");
            DropTable("dbo.Customers");
        }
    }
}
