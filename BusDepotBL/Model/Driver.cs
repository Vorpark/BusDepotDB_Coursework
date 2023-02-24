using System.Collections.Generic;

namespace BusDepotBL.Model
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string DriverFirstName { get; set; }
        public string DriverMiddleName { get; set; }
        public string DriverLastName { get; set; }
        public string DriverFullName { get; set; }
        public int DriverAge { get; set; }
        public int DriverExperience { get; set; }
        public virtual ICollection<Bus> Buses { get; set; }
        public Driver()
        {
            Buses = new List<Bus>();
            DriverFullName = $"{DriverLastName} {DriverFirstName} {DriverMiddleName}";
        }
        public override string ToString()
        {
            return DriverFullName;
        }
    }
}
