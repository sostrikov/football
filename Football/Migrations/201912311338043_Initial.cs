namespace Football.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            //Sql("Insert into Users (UserId,UserName,Password) Values ('ostrikov','Sergey Ostrikov','QAZwsx111')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
