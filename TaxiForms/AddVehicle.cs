using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer.Models;

namespace TaxiForms
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
          
            InitializeComponent();
        }

        

        
        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle vv = new Vehicle();
            
           
            vv.Type = comboBox1.Text;
            using (var db = new TaxiiContext())
            {
                var data = db.VehicleCts.Where(i => i.VehicleCategory
                    .Equals(comboBox1.Text))
                    .Select(i => i.ID)
                    .First();

                if (data == 1)
                {
                    vv.DepositAmount = 35000;
                }
                else if(data == 2)
                {
                    vv.DepositAmount = 25000;
                }
                else
                {
                    vv.DepositAmount = 15000;
                }
                
            }
            

            
            vv.PerKM = int.Parse(textBox3.Text);

            
            //vv.PerKM = int.Parse(textBox3.Text);

            AddvehicleDetails ss = new AddvehicleDetails();
             string msg = ss.AddVehicle(vv);

             MessageBox.Show(msg);

        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiiDataSet.VehicleCt' table. You can move, or remove it, as needed.
            this.vehicleCtTableAdapter.Fill(this.taxiiDataSet.VehicleCt);

        }


      

        
    }
}
