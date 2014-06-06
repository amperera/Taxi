using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class PickUp
    {
        public int JNO { get; set; }
        public string CustomerName { get; set; }
        public int ContactNumber { get; set; }
        public string BeginFrom { get; set; }
        public string Destination { get; set; }
        public int VehicleTypeID { get; set; }
        public System.DateTime Date { get; set; }
        public string Note { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int DriverId { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual CabDriver CabDriver { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Vehicle Vehicle { get; set; }
    }
}
