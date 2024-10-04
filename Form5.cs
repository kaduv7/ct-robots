using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  +1 na text box 2//
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 cadastrar = new Form2();
            cadastrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  +1 na text box 1//
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  +1 na text box 3//
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //show the amount of this asked for//
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //show the amount of this asked for//
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //show the amount of this asked for//
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //show the amount of this asked for//
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // -1 na text 1//
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // -1 na text 3//
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // -1 na text 4//
        }
    }
}
