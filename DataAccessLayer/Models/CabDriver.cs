using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class CabDriver
    {
        public CabDriver()
        {
            this.PickUps = new List<PickUp>();
        }

        public int ID { get; set; }
        public string DriverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNo { get; set; }
        public string Address { get; set; }
        public int VehicleType { get; set; }
        public string VehicaleNo { get; set; }
        public System.DateTime RegisterdDate { get; set; }
        public string Paymethod { get; set; }
        public string IsAvailable { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<PickUp> PickUps { get; set; }
    }
}
