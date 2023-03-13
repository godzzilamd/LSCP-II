using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string name = "Nicolai";

        public int x = 20;

        public double d = 1.34532452345;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 v = new Form2(); v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x != 10)
            {
                Form3 v = new Form3(); 
                
                v.ShowDialog();
            } else {
                Form4 v = new Form4(); 

                v.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random(200);

            int modalNumber = r.Next(4, 6);

            if (modalNumber == 4)
            {
                Form5 v = new Form5();

                v.ShowDialog();
            }

            if (modalNumber == 5)
            {
                Form6 v = new Form6();

                v.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 v = new Form7();

            v.ShowDialog();
        }
    }
}
