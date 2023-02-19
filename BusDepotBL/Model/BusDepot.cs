using System.Collections.Generic;

namespace BusDepotBL.Model
{
    public class BusDepot
    {
        public int BusDepotId { get; set; }
        public string BusDepotAddress { get; set; }
        public virtual ICollection<Bus> Buses { get; set; }
        public override string ToString()
        {
            return BusDepotAddress; 
        }
    }
}
