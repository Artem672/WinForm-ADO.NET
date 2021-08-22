namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newGamesProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Mode", c => c.Boolean(nullable: false));
            AddColumn("dbo.Games", "Sales", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Sales");
            DropColumn("dbo.Games", "Mode");
        }
    }
}
