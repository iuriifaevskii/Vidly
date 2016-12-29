namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGanreInsert : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Ganres( Name, ReleaseDate, DateAdded, Number) VALUES ('Comedy','2015-01-01 00:00:00.000' ,'2016-01-01 00:00:00.000', 5)");
            Sql("INSERT INTO Ganres( Name, ReleaseDate, DateAdded, Number) VALUES ('Family','2015-01-01 00:00:00.000' ,'2016-01-01 00:00:00.000', 2)");
            Sql("INSERT INTO Ganres( Name, ReleaseDate, DateAdded, Number) VALUES ('Action','2015-01-01 00:00:00.000' ,'2016-01-01 00:00:00.000', 3)");
            Sql("INSERT INTO Ganres( Name, ReleaseDate, DateAdded, Number) VALUES ('Romance','2015-01-01 00:00:00.000' ,'2016-01-01 00:00:00.000', 10)");
        }
        
        public override void Down()
        {
        }
    }
}
