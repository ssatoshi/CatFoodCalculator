namespace CatFoodCalculator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BodyInfoCategories", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Makers", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Makers", "IsDeleted");
            DropColumn("dbo.BodyInfoCategories", "IsDeleted");
        }
    }
}
