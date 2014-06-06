using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            this.CabDrivers = new List<CabDriver>();
            this.PickUps = new List<PickUp>();
        }

        public int VId { get; set; }
        public string Type { get; set; }
        public int DepositAmount { get; set; }
        public int PerKM { get; set; }
        public virtual ICollection<CabDriver> CabDrivers { get; set; }
        public virtual ICollection<PickUp> PickUps { get; set; }
    }
}
