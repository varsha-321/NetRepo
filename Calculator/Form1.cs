﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { int sum;
            sum = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            textBox3.Text = Convert.ToString(sum);
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int subs;
            subs = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            textBox4.Text = Convert.ToString(subs);
        }
    }
}
