using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Persoana ion;
        Persoana alex;
        int bank = 100;
        public void UpdateForm()
        {
            ionCashLabel.Text = ion.Name + "are  $" + ion.Cash;
            alexCashLabel.Text = alex.Name + "are  $" + alex.Cash;
            bankCashLabel.Text = "In baca sunt acum  $" + bank;
        }

        public Form1()
        {
            InitializeComponent();

            alex = new Persoana() { Cash = 100, Name = "Alex" };

            ion = new Persoana() { Cash = 50, Name = "Ion" };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            if (bank >= 10)
            {
                bank -= ion.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("In baca nu sunt bani");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += alex.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ion.Cash > 10)
            {
                alex.ReceiveCash(ion.GiveCash(10));

                UpdateForm();
            }
            else
            {
                MessageBox.Show("Ion nu are asa bani");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (alex.Cash > 5)
            {
                ion.ReceiveCash(alex.GiveCash(5));

                UpdateForm();
            }
            else
            {
                MessageBox.Show("Alex nu are asa bani");
            }
        }
    }

    class Persoana
    {
        public string Name;
        public int Cash;
        public int GiveCash(int suma)
        {
            if (suma <= Cash && suma > 0)
            {
                Cash -= suma;
                return suma;
            }
            else
            {
                MessageBox.Show(
                    "Nu am suficienti bani" + suma,
                   Name + "spune");
                return 0;
            }
        }

        public int ReceiveCash(int suma)
        {
            if (suma > 0)
            {
                Cash += suma;
                return suma;
            }
            else
            {
                MessageBox.Show(suma + "Nu am nevoie",
                   "spune" + Name);
                return 0;
            }
        }
    }
}
