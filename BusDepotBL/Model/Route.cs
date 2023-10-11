using System.Collections.Generic;

namespace BusDepotBL.Model
{
    public class Route
    {
        public int RouteId { get; set; }
        public int RouteNumber { get; set; }
        public string RouteName { get; set; }
        public virtual ICollection<Bus> Buses { get; set; }
        public Route()
        {
            Buses = new List<Bus>();
        }
        public override string ToString()
        {
            return RouteNumber.ToString();
        }
    }
}
