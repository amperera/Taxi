using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Models;
using BusinessLogicLayer;

namespace TaxiForms
{
    public partial class CabDriversDetails : Form
    {
        public CabDriversDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddvehicleDetails passdata = new AddvehicleDetails();
            DateTime dd = DateTime.Now;            
            CabDriver create = new CabDriver();

            create.VehicaleNo = textBox6.Text;
            create.FirstName = textBox2.Text;
            create.LastName = textBox3.Text;
            create.ContactNo = int.Parse(textBox4.Text);
            create.Address = textBox5.Text;
            create.VehicleType = SelectvehicleID();
           
            create.RegisterdDate = dd;
            create.Paymethod = textBox7.Text;
            create.IsAvailable = textBox8.Text;
            create.DriverId = textBox1.Text;


            passdata.SaveDriverDetails(create);

        }


        private int SelectvehicleID()
        {
            using (var db = new TaxiiContext())
            {
                var data = db.VehicleCts.Where(i => i.VehicleCategory
                    .Equals(textBox9.Text))
                    .Select(i => i.ID)
                    .First();
                return data;
            }
        }
    }
}
