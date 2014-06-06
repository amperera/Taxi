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
    public partial class JourneyView : Form
    {
        public JourneyView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            


        }

        private void JourneyView_Load(object sender, EventArgs e)
        {
            PassDataToDataGridView();
            
        }

        private void PassDataToDataGridView()
        {
            var db = new TaxiiContext();

            var data = db.PickUps.Select(i => i).ToList();

            dataGridView1.DataSource = data;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PickUp pk = new PickUp();
            pk.JNO = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            pk.CustomerName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pk.ContactNumber = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            pk.BeginFrom= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pk.Destination = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            pk.Date = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            pk.Note = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();



            PickupEdit Pe = new PickupEdit(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), dataGridView1.SelectedRows[0].Cells[6].Value.ToString(), dataGridView1.SelectedRows[0].Cells[7].Value.ToString(), dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
          
            Pe.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassDataToDataGridView();
        }

       





        
    }
}
