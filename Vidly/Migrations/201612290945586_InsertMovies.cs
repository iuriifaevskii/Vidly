namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies( Name,Ganre_Id) VALUES ('Hangover',1)");
            Sql("INSERT INTO Movies( Name,Ganre_Id) VALUES ('Die Hard',3)");
            Sql("INSERT INTO Movies( Name,Ganre_Id) VALUES ('The Terminator',3)");
            Sql("INSERT INTO Movies( Name,Ganre_Id) VALUES ('Toy Stiry',2)");
            Sql("INSERT INTO Movies( Name,Ganre_Id) VALUES ('Titanic',4)");
        }
        
        public override void Down()
        {
        }
    }
}
