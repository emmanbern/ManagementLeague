namespace LeagueAppManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPositionToPlayers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Position", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Position");
        }
    }
}
