namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixGenreType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_Id" });
            AddColumn("dbo.Gigs", "Genre", c => c.Int(nullable: false));
            DropColumn("dbo.Gigs", "Genre_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "Genre_Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Gigs", "Genre");
            CreateIndex("dbo.Gigs", "Genre_Id");
            AddForeignKey("dbo.Gigs", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
