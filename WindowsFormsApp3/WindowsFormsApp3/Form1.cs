using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int startKilometraj, stopKilometraj;

        double kilometrajParcurs, rataRambursata = 40, sumaRambursata;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            startKilometraj = Decimal.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            stopKilometraj = Decimal.ToInt32(numericUpDown2.Value);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (startKilometraj > stopKilometraj)
            {
                MessageBox.Show("Distanta initiala nu poate fi mai mare ca cea finala", "Nu pot calcula");

                return;
            }

            kilometrajParcurs = stopKilometraj - startKilometraj;

            label4.Text = (kilometrajParcurs * rataRambursata).ToString() + " lei";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Distanta este " + kilometrajParcurs, "Distanta parcursa");
        }
    }
}
