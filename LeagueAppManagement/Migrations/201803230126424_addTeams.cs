namespace LeagueAppManagement.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addTeams : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Players");
            CreateTable(
                "dbo.Teams",
                c => new
                {
                    Id = c.Int(nullable: false),
                    Name = c.String(),
                    Guid = c.Guid(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Guid);

            AddColumn("dbo.Players", "Team_Id", c => c.Int());
            AlterColumn("dbo.Players", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "Guid", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Players", "Id");
            CreateIndex("dbo.Players", "Guid");
            CreateIndex("dbo.Players", "Team_Id");
            AddForeignKey("dbo.Players", "Team_Id", "dbo.Teams", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Teams", new[] { "Guid" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Players", new[] { "Guid" });
            DropPrimaryKey("dbo.Players");
            AlterColumn("dbo.Players", "Guid", c => c.Guid(nullable: false));
            AlterColumn("dbo.Players", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Players", "Team_Id");
            DropTable("dbo.Teams");
            AddPrimaryKey("dbo.Players", "Id");
        }
    }
}
