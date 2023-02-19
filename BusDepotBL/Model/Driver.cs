using System.Collections.Generic;

namespace BusDepotBL.Model
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string DriverFirstName { get; set; }
        public string DriverMiddleName { get; set; }
        public string DriverLastName { get; set; }
        public string DriverFullName { get; set; } // Реализовать в конструкторе
        public int DriverAge { get; set; }
        public int DriverExperience { get; set; }
        public virtual ICollection<Bus> Buses { get; set; }
        public override string ToString()
        {
            return DriverFullName;
        }
    }
}
