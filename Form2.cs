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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 striker = new Form3();
            striker.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 defender = new Form7();
            defender.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 keeper = new Form6();
            keeper.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 finalizar = new Form11();
            finalizar.ShowDialog();
        }

}
