using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;


namespace BusinessLogicLayer
{
    public class AddvehicleDetails
    {
       
        public string AddVehicle(Vehicle ob)
        {
            string msg;
            try
            {
                using(TaxiiContext db = new TaxiiContext())
                {
                    
                    db.Vehicles.Add(
                        new Vehicle
                        {
                            Type = ob.Type,
                            DepositAmount = ob.DepositAmount,
                            PerKM = ob.PerKM
                        });
                    db.SaveChanges();
                }
            }
            //catch (Exception e)
            //{
            //    return e.Message;
            //}
            finally
            {
               msg =  " the data has been added";
            }
            return msg;

        
        }

         public string SaveDriverDetails(CabDriver dd)
            {
                using (var db = new TaxiiContext())
                {
                    db.CabDrivers.Add(
                        new CabDriver
                        {
                            ContactNo = dd.ContactNo,
                            FirstName = dd.FirstName,
                            LastName = dd.LastName,
                            DriverId = dd.DriverId,
                            Address = dd.Address,
                            VehicleType = dd.VehicleType,
                            VehicaleNo = dd.VehicaleNo,
                            RegisterdDate = dd.RegisterdDate,
                            Paymethod = dd.Paymethod,
                            IsAvailable = dd.IsAvailable
                        });
                    db.SaveChanges();
                    return "successfully added to the database";
                }

            }

    }
}
