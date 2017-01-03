namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies( Name,GanreId) VALUES ('Hangover',1)");
            Sql("INSERT INTO Movies( Name,GanreId) VALUES ('Die Hard',3)");
            Sql("INSERT INTO Movies( Name,GanreId) VALUES ('The Terminator',3)");
            Sql("INSERT INTO Movies( Name,GanreId) VALUES ('Toy Stiry',2)");
            Sql("INSERT INTO Movies( Name,GanreId) VALUES ('Titanic',4)");
        }
        
        public override void Down()
        {
        }
    }
}
