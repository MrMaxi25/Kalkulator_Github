using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(NumberA.Text);
                int b = int.Parse(NumberB.Text);
                int result = a + b;
                sum.Text = result.ToString();
            }
            catch (FormatException) 
            {
                MessageBox.Show("Podaj same cyfry");
            }

        }
    }
}
