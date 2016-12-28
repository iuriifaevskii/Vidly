namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomer : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Customers( Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Yuriy Faevskyi','True' ,2 ,'1996-03-14')");
        }
        
        public override void Down()
        {
        }
    }
}
