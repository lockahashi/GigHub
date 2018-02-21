namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTypeOfGenre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "Genre_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Gigs", "Genre_Id");
            AddForeignKey("dbo.Gigs", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Gigs", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "Genre", c => c.Int(nullable: false));
            DropForeignKey("dbo.Gigs", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_Id" });
            DropColumn("dbo.Gigs", "Genre_Id");
        }
    }
}
