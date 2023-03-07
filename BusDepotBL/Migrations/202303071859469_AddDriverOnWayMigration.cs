namespace BusDepotBL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    
    public partial class AddDriverOnWayMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buses", "DriverOnWay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Buses", "DriverOnWay");
        }
    }
}
