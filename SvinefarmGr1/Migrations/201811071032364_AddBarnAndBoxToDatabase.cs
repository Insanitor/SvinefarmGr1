namespace SvinefarmGr1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBarnAndBoxToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boxes",
                c => new
                    {
                        BoxId = c.Int(nullable: false, identity: true),
                        BoxName = c.String(),
                        BoxType = c.Int(nullable: false),
                        Barn_BarnId = c.Int(),
                    })
                .PrimaryKey(t => t.BoxId)
                .ForeignKey("dbo.Barns", t => t.Barn_BarnId)
                .Index(t => t.Barn_BarnId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Boxes", "Barn_BarnId", "dbo.Barns");
            DropIndex("dbo.Boxes", new[] { "Barn_BarnId" });
            DropTable("dbo.Boxes");
        }
    }
}
