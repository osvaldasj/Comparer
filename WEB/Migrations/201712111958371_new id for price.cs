namespace WEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newidforprice : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Prices");
            AddColumn("dbo.Prices", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Prices", "ProductID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Prices", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Prices");
            AlterColumn("dbo.Prices", "ProductID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Prices", "ID");
            AddPrimaryKey("dbo.Prices", "ProductID");
        }
    }
}
