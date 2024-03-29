namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactoring : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User_Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ComputerId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.User_Computers", "UserId");
            CreateIndex("dbo.User_Computers", "ComputerId");
            AddForeignKey("dbo.User_Computers", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.User_Computers", "ComputerId", "dbo.Computers", "Id", cascadeDelete: true);
        }
    }
}
