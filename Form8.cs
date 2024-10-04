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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 defender  = new Form7();
            defender.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //+1 na text 1//
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 defender = new Form10();
            defender.ShowD; ialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //+1 na text 2//
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //+1 na text 3//
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //-1 na text 1//
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //-1 na text 2//
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //-1 na text 3//
        }
    }
}
