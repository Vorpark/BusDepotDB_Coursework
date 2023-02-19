using System.Collections.Generic;

namespace BusDepotBL.Model
{
    public class BusModel
    {
        public int BusModelId { get; set; }
        public string BusName { get; set; }
        public virtual ICollection<Bus> Buses { get; set; }
        public override string ToString()
        {
            return BusName;
        }
    }
}
