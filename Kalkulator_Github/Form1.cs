﻿using System;
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
                sum.Text = (int.Parse(NumberA.Text.ToString()) + int.Parse(NumberB.Text.ToString())).ToString();
            }
            catch (FormatException) 
            {
                MessageBox.Show("Podaj same cyfry");
            }

        }
    }
}
