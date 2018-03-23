namespace LeagueAppManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBaseEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Guid", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Guid");
        }
    }
}
