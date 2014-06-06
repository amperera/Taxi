using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PickUpEdit
    {
        


        public string PickUpUpdate(string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            string message;
            PickUp pk = new PickUp();
            pk.CustomerName = p1;
            pk.ContactNumber = int.Parse(p2);
            pk.BeginFrom = p3;
            pk.Destination = p4;
            pk.Date = DateTime.Parse(p5);
            pk.Note = p7;
            pk.JNO = int.Parse(p6);


            try
            {
                ;
                using (var db = new TaxiiContext())
                {
                    int TO = int.Parse(p6);
                    var data = db.PickUps.Where(i => i.JNO.Equals(TO)).First();
                    data.Destination = p4;

                    db.SaveChanges();
                }
            }
            catch(Exception e)
            {
                 message = "Data Is Not Updated";
            }
            finally
            {
                 message = "Data Is Successfully Updated ";
                
            }
            return message;
            
        }
    }
}
