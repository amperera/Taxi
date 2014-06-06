using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLogicLayer
{
    public class PickUpData
    {
        private string CustomerName;
        private int ContactNumber;
        private string From;
        private string To;
        private string VehicleType;
        private string DId;
        private DateTime date;
        private string Note;

        public void Pickupinitialization(string p1, string p2, string p3, string p4, string p5, string p6, DateTime dateTime, string p8)
        {
            this.CustomerName = p1;
            this.ContactNumber = int.Parse(p2);
            this.From = p3;
            this.To = p4;
            this.VehicleType = p5;
            this.DId = p6;
            this.date = dateTime;
            this.Note = p8;

            
            using (var db = new TaxiiContext())
            {
                var Driver = db.CabDrivers.Where(i => i.FirstName.Equals(DId)).Select(i => i.ID).First();



                PickUp ad = new PickUp();
                ad.CustomerName = CustomerName;
                ad.ContactNumber = ContactNumber;
                ad.BeginFrom = From;
                ad.Destination = To;
                ad.VehicleTypeID = GetVehicleDetails(VehicleType);
                ad.DriverId = Driver;
                ad.Date = date;
                ad.Note = Note;

                SaveALLPickUpData(ad);
                

            }
        }

        private void SaveALLPickUpData(PickUp ad)
        {
           
            using (var db = new TaxiiContext())
            {
                db.PickUps.Add(new PickUp
                    {
                        CustomerName = ad.CustomerName,
                        ContactNumber = ad.ContactNumber,
                        BeginFrom = ad.BeginFrom,
                        Destination = ad.Destination,    
                        DriverId = ad.DriverId,
                        Date = date,
                        VehicleTypeID = ad.VehicleTypeID,
                        Note = ad.Note

                    });
                db.SaveChanges();

                
            }
        }

        private int GetVehicleDetails(string vtype)
        {
            using (var db = new TaxiiContext())
            {
                return db.VehicleCts
                    .Where(i => i.VehicleCategory
                        .Equals(vtype))
                        .Select(i => i.ID)
                        .First();
            }
            
        }

        public List<String> LoadDriver(string combodata, string Frm)
        {
            this.From = Frm;
            this.VehicleType = combodata;
            
            using (var db = new TaxiiContext())
            {
                var data = GetVehicleDetails(VehicleType);

                var driver = db.CabDrivers
                   .Where(i => i.Address
                       .Equals(From) && i.VehicleType
                       .Equals(data))
                       .Select(i => i.FirstName)
                       .ToList();
                return driver;

            }
        }



        
    }
}
