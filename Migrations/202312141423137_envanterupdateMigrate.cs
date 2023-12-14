namespace EFDatabaseFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class envanterupdateMigrate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inventory", "ProductPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Inventory", "ProductPrice");
        }
    }
}
