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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count = ++count;
            }

            for (int i = 0; i < 5; i++)
            {
                count = --count;
            }

            label1.Text = "Raspunsul este " + count;
        }
    }
}
