namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGanreInMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GanreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Ganres", "ReleaseDate");
            DropColumn("dbo.Ganres", "DateAdded");
            DropColumn("dbo.Ganres", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ganres", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.Ganres", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Ganres", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "GanreId");
        }
    }
}
