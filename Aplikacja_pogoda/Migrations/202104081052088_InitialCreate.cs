namespace Aplikacja_pogoda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Weathers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        coord_lon = c.Double(nullable: false),
                        coord_lat = c.Double(nullable: false),
                        main_temp = c.Double(nullable: false),
                        main_pressure = c.Double(nullable: false),
                        wind_speed = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Weathers");
        }
    }
}
