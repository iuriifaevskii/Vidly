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

                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "GanreId", c => c.Int());
            CreateIndex("dbo.Movies", "GanreId");
            AddForeignKey("dbo.Movies", "GanreId", "dbo.Ganres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GanreId", "dbo.Ganres");
            DropIndex("dbo.Movies", new[] { "GanreId" });
            DropColumn("dbo.Movies", "GanreId");
            DropTable("dbo.Ganres");
        }
    }
}
