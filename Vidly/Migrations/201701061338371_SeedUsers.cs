namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'02624ccd-a51a-4ad5-8602-ac9d092f8a4a', N'guest', N'AP8JVCl7gD781D82xK+tbwOT6UCGeStmKbvLlbJMk7w/XfRx1Hu/9X2r/8d9f6HUKQ==', N'0b4c9e56-eeb0-4a32-80b2-b6e1a6875af4', N'ApplicationUser')");
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'031ce2ba-45d6-4015-aeb2-120bff70cf02', N'admin', N'AFOjS8lVFA3SOEzh9D8a/ysY41M2V9pxNnJwoImuuVLBurLCjGV/07LM2XEkr3/qRQ==', N'89857d75-b168-41fc-b755-8e3da4af8870', N'ApplicationUser')");
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'75afb508-8b6c-468a-aceb-fdb48c90d0a5', N'yuriy', N'ADwmFGpcwHOl1oMIJM/CnMSoGQw4a+CiEAkbpELLpyLbv8UmwFkKU+A9MxpebIyl5w==', N'2eb00ab2-7631-4a22-a203-23319f608b16', N'ApplicationUser')");
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'fe60e233-60a9-4be2-bdb0-fe87f1612fee', N'yura123', N'AH7hXVTWq65bC2ODXzH2UgV2F2gJzqD3HD4RPygykva0yLxYxvgAGLaQj1qyy65vng==', N'd00bf246-9782-4d10-993a-3904f22848c1', N'ApplicationUser')");

            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'57b7cd02-7310-4f4d-b635-f6a5b0566f7b', N'CanManageMovies')");
            
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'031ce2ba-45d6-4015-aeb2-120bff70cf02', N'57b7cd02-7310-4f4d-b635-f6a5b0566f7b')");
        }
        
        public override void Down()
        {
        }
    }
}
