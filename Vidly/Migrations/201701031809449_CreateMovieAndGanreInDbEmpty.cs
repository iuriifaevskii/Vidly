namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMovieAndGanreInDbEmpty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.Movies", "GanreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));


        }
        
        public override void Down()
        {

        }
    }
}
