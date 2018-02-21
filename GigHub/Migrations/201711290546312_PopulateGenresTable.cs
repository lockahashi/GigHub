namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        /// <summary>
        /// Created a blank migration to insert values into the genres table
        /// </summary>
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1,'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2,'Blue')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3,'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4,'Country')");
        }
        
        /// <summary>
        /// The Down method will do the opposite of the Up method
        /// </summary>
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
