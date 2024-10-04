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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IncrementTextBox(textBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IncrementTextBox(textBox4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IncrementTextBox(textBox5);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 cadastrar = new Form2();
            cadastrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncrementTextBox(textBox1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "0";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IncrementTextBox(textBox2);
        }

        private void IncrementTextBox(TextBox textBox2)
        {
            throw new NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DecrementTextBox(textBox1);
        }

        private void DecrementTextBox(TextBox textBox1)
        {
            throw new NotImplementedException();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DecrementTextBox(textBox2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DecrementTextBox(textBox3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DecrementTextBox(textBox4);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DecrementTextBox(textBox5);

        }
        private static void IncrementTextBox(TextBox textBox)
        {
            int currentValue = 0;
            if (int.TryParse(textBox.Text, out currentValue))
            {
                textBox.Text = (currentValue + 1).ToString();
            }
            else
            {
                textBox.Text = "1";
            }
        }

        private void DecrementTextBox(TextBox textBox)
        {
            int currentValue = 0;
            if (int.TryParse(textBox.Text, out currentValue))
            {
                if (currentValue > 0)
                {
                    textBox.Text = (currentValue - 1).ToString();
                }
            }
            else
            {
                textBox.Text = "0";
            }
        }
    }
}

