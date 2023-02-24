using System.Collections.Generic;

namespace BusDepotBL.Model
{
    public class Bus
    {
        public int BusId { get; set; }
        public string BusNumber { get; set; }
        public bool BusOnWay { get; set; } = false;
        public virtual BusModel BusModel { get; set; }
        public virtual BusDepot BusDepot { get; set; }
        public virtual Route Route { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public Bus ()
        {
            Drivers = new List<Driver> ();
        }
        public override string ToString()
        {
            return BusNumber;
        }
    }
}
