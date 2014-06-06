using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Amila" && textBox2.Text == "pwd")
            {
                Taxi mm = new Taxi();
                mm.Show();
                Form1 kk = new Form1();
                kk.Close();
            }
        }
    }
}
