namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpadteComputerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Computers", "CoolingAmmount", c => c.Int(nullable: true));
            AddColumn("dbo.Computers", "RamAmmount", c => c.Int(nullable: true));
            AddColumn("dbo.Computers", "StorageAmmount", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Computers", "StorageAmmount");
            DropColumn("dbo.Computers", "RamAmmount");
            DropColumn("dbo.Computers", "CoolingAmmount");
        }
    }
}
