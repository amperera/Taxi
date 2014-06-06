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
    public partial class PickupEdit : Form
    {
        private string CustomerName;
        private string Number;
        private string From;
        private string To;
        private string Date;
        private string Note;
        private int JNO;


        public PickupEdit(string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            InitializeComponent();
            this.CustomerName = p1;
            this.Number = p2;
            this.From = p3;
            this.To = p4;
            this.Date = p5;
            this.Note = p6;
            this.JNO = int.Parse(p7);

            textBox1.Text = CustomerName;
            textBox2.Text = Number;
            textBox3.Text = From;
            textBox4.Text = To;
            textBox5.Text = Date;
            richTextBox1.Text = Note;
            textBox6.Text = p7;
            
        }

        

        

        private void PickupEdit_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PickUpEdit pke = new PickUpEdit();
            var data = pke.PickUpUpdate(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, richTextBox1.Text);

            MessageBox.Show(data);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        
    }
}
