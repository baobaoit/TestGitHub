﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox1.Text);
            double tong = a + b;
            //Khong su dung MessageBox
            //MessageBox.Show(tong.ToString());
            //Dung label
            label1.Text = tong.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Lớp ỒN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                double a = Convert.ToDouble(textBox2.Text);
                double b = Convert.ToDouble(textBox1.Text);
                double hieu = a - b;
                label1.Text = hieu.ToString();
            }
        }
    }
}
