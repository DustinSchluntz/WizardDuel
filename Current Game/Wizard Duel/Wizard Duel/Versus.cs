﻿using System;
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
            playerName.Text = player.Name;
            playerHealth.Text = player.Health.ToString();
            playerCasts.Text = player.CastsRemaining.ToString();

            computer.Name = "COMPUTER";
            computer.Health = 50;
            computer.CastsRemaining = 100;
            opponentName.Text = computer.Name;
            enemyHealth.Text = computer.Health.ToString();
            enemyCasts.Text = computer.CastsRemaining.ToString();
        }

        private void Versus_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void versusPlayArea_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void removeEnemyHealth_Click(object sender, EventArgs e)
        {
            enemyHealth.Text = (Int32.Parse(enemyHealth.Text) - 1).ToString();
        }

        private void removePlayerHealth_Click(object sender, EventArgs e)
        {
            playerHealth.Text = (Int32.Parse(playerHealth.Text) - 1).ToString();
        }
    }
}
