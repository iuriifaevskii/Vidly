namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMoviesSecond : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Ganres( Name) VALUES ('Comedy')");
            Sql("INSERT INTO Ganres( Name) VALUES ('Family')");
            Sql("INSERT INTO Ganres( Name) VALUES ('Action')");
            Sql("INSERT INTO Ganres( Name) VALUES ('Romance')");

            Sql("INSERT INTO Movies( Name,ReleaseDate,DateAdded,NumberInStock,GanreId) VALUES ('Hangover','12-01-16 12:32','11-01-16 12:32',5,1)");
            Sql("INSERT INTO Movies( Name,ReleaseDate,DateAdded,NumberInStock,GanreId) VALUES ('Die Hard','12-01-16 12:32','11-01-16 12:32',5,3)");
            Sql("INSERT INTO Movies( Name,ReleaseDate,DateAdded,NumberInStock,GanreId) VALUES ('The Terminator','12-01-16 12:32','11-01-16 12:32',5,3)");
            Sql("INSERT INTO Movies( Name,ReleaseDate,DateAdded,NumberInStock,GanreId) VALUES ('Toy Stiry','12-01-16 12:32','11-01-16 12:32',5,2)");
            Sql("INSERT INTO Movies( Name,ReleaseDate,DateAdded,NumberInStock,GanreId) VALUES ('Titanic','12-01-16 12:32','11-01-16 12:32',5,4)");
        }
        
        public override void Down()
        {
        }
    }
}
