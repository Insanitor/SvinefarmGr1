namespace SvinefarmGr1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFarmAndBarnToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barns",
                c => new
                    {
                        BarnId = c.Int(nullable: false, identity: true),
                        BarnName = c.String(),
                        Farm_FarmId = c.Int(),
                    })
                .PrimaryKey(t => t.BarnId)
                .ForeignKey("dbo.Farms", t => t.Farm_FarmId)
                .Index(t => t.Farm_FarmId);
            
            CreateTable(
                "dbo.Farms",
                c => new
                    {
                        FarmId = c.Int(nullable: false, identity: true),
                        FarmName = c.String(),
                    })
                .PrimaryKey(t => t.FarmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Barns", "Farm_FarmId", "dbo.Farms");
            DropIndex("dbo.Barns", new[] { "Farm_FarmId" });
            DropTable("dbo.Farms");
            DropTable("dbo.Barns");
        }
    }
}
