﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 comeco = new Form1();
            comeco.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //show a random 4 digit number//
        }
    }
}
