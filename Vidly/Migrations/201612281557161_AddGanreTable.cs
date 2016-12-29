namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGanreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ganres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        ReleaseDate = c.DateTime(),
                        DateAdded = c.DateTime(),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "Ganre_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Ganre_Id");
            AddForeignKey("dbo.Movies", "Ganre_Id", "dbo.Ganres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Ganre_Id", "dbo.Ganres");
            DropIndex("dbo.Movies", new[] { "Ganre_Id" });
            DropColumn("dbo.Movies", "Ganre_Id");
            DropTable("dbo.Ganres");
        }
    }
}
