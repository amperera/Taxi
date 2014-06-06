using DataAccessLayer.Models;
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

namespace TaxiForms
{
    public partial class Pick : Form
    {
        public Pick()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pick_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiiDataSet1.VehicleCt' table. You can move, or remove it, as needed.
            this.vehicleCtTableAdapter.Fill(this.taxiiDataSet1.VehicleCt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PickUpData Dri = new PickUpData();
            List<String> driver = Dri.LoadDriver(comboBox1.Text, textBox3.Text);
            DateTime dd = DateTime.Now;
            
                foreach (var item in driver)
                {
                    comboBox2.Items.Add(item);
                }
                textBox6.Text = dd.ToString();
      

           
           }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == "")
            {
                MessageBox.Show("You should enter Name ");
            }
            else if(textBox2.Text == "")
            {
                MessageBox.Show("Phone number should be enter");
            }
            else if(textBox3.Text == "")
            {
                MessageBox.Show("Enter Customer Current Location");
            }
            else if(textBox4.Text == "")
            {
                MessageBox.Show(" Enter Destination");
            }
            else if(!comboBox1.Text.Any())
            {
                MessageBox.Show("Select a Driver");
            }
            else
            {
                var result = MessageBox.Show("Click save to store data in database", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    Cleartextboxes();
                }
                else
                {
                    PickUpData ad = new PickUpData();
                    ad.Pickupinitialization(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text, comboBox2.Text, dateTimePicker1.Value, richTextBox1.Text);

                }
            }
            

        }

      

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void Cleartextboxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
                                

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cleartextboxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



       }
 }

