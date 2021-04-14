namespace Aplikacja_pogoda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.baza_danych",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        temperatura = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Weathers");
        }
        
        public override void Down()
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
            
            DropTable("dbo.baza_danych");
        }
    }
}
