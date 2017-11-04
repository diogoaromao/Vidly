namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreDefaultData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Description) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Description) VALUES ('Action')");
            Sql("INSERT INTO Genres (Description) VALUES ('Family')");
            Sql("INSERT INTO Genres (Description) VALUES ('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
