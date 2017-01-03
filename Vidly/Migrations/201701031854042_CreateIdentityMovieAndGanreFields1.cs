namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateIdentityMovieAndGanreFields1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Ganre_Id", "dbo.Ganres");
            DropIndex("dbo.Movies", new[] { "Ganre_Id" });
            DropColumn("dbo.Movies", "GanreId");
            RenameColumn(table: "dbo.Movies", name: "Ganre_Id", newName: "GanreId");
            AlterColumn("dbo.Movies", "GanreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "GanreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GanreId");
            AddForeignKey("dbo.Movies", "GanreId", "dbo.Ganres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GanreId", "dbo.Ganres");
            DropIndex("dbo.Movies", new[] { "GanreId" });
            AlterColumn("dbo.Movies", "GanreId", c => c.Int());
            AlterColumn("dbo.Movies", "GanreId", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Movies", name: "GanreId", newName: "Ganre_Id");
            AddColumn("dbo.Movies", "GanreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Ganre_Id");
            AddForeignKey("dbo.Movies", "Ganre_Id", "dbo.Ganres", "Id");
        }
    }
}
