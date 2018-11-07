namespace SvinefarmGr1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBarnToTemperatureSensor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TemperatureSensors", "Barn_BarnId", c => c.Int());
            CreateIndex("dbo.TemperatureSensors", "Barn_BarnId");
            AddForeignKey("dbo.TemperatureSensors", "Barn_BarnId", "dbo.Barns", "BarnId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TemperatureSensors", "Barn_BarnId", "dbo.Barns");
            DropIndex("dbo.TemperatureSensors", new[] { "Barn_BarnId" });
            DropColumn("dbo.TemperatureSensors", "Barn_BarnId");
        }
    }
}
