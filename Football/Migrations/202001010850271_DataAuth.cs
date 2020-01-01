namespace Football.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAuth : DbMigration
    {
        public override void Up()
        {
           
            Sql("Insert into Roles(Name) Values ('SuperAdmin')");
            Sql("Insert into Roles(Name) Values ('Admin')");
            Sql("Insert into Roles(Name) Values ('Normal')");
            Sql("Insert into Users (UserId,UserName,Password,RoleId) Values ('ostrikov','Sergey Ostrikov','QAZwsx111',1)");
            Sql("Insert into Users (UserId,UserName,Password,RoleId) Values ('irina','Irina Ostrikova','111',2)");
            Sql("Insert into Users (UserId,UserName,Password,RoleId) Values ('operator','Operator','111',3)");
        }
        
        public override void Down()
        {
           
        }
    }
}
