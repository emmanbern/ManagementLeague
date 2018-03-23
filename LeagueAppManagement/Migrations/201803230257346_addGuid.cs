namespace LeagueAppManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGuid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Guid", c => c.Guid(nullable: false));
            CreateIndex("dbo.Players", "Guid");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Players", new[] { "Guid" });
            DropColumn("dbo.Players", "Guid");
        }
    }
}
