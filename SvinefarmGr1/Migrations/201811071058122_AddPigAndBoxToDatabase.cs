namespace SvinefarmGr1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPigAndBoxToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pigs",
                c => new
                    {
                        PigId = c.Int(nullable: false, identity: true),
                        PigType = c.Int(nullable: false),
                        Box_BoxId = c.Int(),
                    })
                .PrimaryKey(t => t.PigId)
                .ForeignKey("dbo.Boxes", t => t.Box_BoxId)
                .Index(t => t.Box_BoxId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pigs", "Box_BoxId", "dbo.Boxes");
            DropIndex("dbo.Pigs", new[] { "Box_BoxId" });
            DropTable("dbo.Pigs");
        }
    }
}
