using System.Collections.Generic;

namespace BusDepotBL.Model
{
    internal class Route
    {
        public int RouteId { get; set; }
        public int RouteNumber { get; set; }
        public virtual ICollection<Bus> Buses { get; set; }
        public override string ToString()
        {
            return RouteNumber.ToString();
        }
    }
}
