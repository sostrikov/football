namespace Football.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class q : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RoleId");
            DropTable("dbo.Roles");
        }
    }
}
