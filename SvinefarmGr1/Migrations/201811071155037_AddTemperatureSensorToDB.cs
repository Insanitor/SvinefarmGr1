namespace SvinefarmGr1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTemperatureSensorToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TemperatureSensors",
                c => new
                    {
                        SensorId = c.Int(nullable: false, identity: true),
                        SensorName = c.String(),
                        MacAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SensorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TemperatureSensors");
        }
    }
}
