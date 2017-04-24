using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wizard_Duel;
using static System.Windows.Forms.DataFormats;

namespace Wizard_Duel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Versus Versus = new Versus();
            Versus.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
