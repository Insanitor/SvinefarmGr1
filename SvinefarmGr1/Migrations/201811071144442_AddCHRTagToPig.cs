namespace SvinefarmGr1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCHRTagToPig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pigs", "CHRTag", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pigs", "CHRTag");
        }
    }
}
