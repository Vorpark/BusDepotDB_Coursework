using System.Data.Entity;

namespace BusDepotBL.Model
{
    internal class BusDepotContext : DbContext
    {
        public BusDepotContext() : base("BusDepotConnection") { }

        public DbSet<BusDepot> BusDepots { get; set;}
        public DbSet<Driver> Drivers { get; set;}
        public DbSet<BusModel> BusModels { get; set;}
        public DbSet<Route> Routes { get; set;}
        public DbSet<Bus> Buses { get; set;}
    }
}
