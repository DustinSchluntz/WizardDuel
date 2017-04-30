using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wizard_Duel
{
    public partial class Versus : Form
    {
        public Versus()
        {
            InitializeComponent();

            Character player = new Character();
            Character computer = new Character();

            player.Name = "ARGOS";
            player.Health = 50;
            player.CastsRemaining = 100;

            computer.Name = "COMPUTER";
            computer.Health = 50;
            computer.CastsRemaining = 100;
            opponentName.Text = computer.Name;
        }

        private void Versus_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
