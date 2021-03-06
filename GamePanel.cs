﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPlanner
{
    public partial class MainWindow : Form
    {
        List<Game> games = new List<Game>();
        
        public MainWindow()
        {
            InitializeComponent();
            Debugging();

        }
        private void Debugging()
        {
            Game test_game = InitGame();
            games.Add(test_game);
        }

        private Game InitGame()
        {

            Game game = new Game("Test", true, "Standard", "Arabia", "Small", "Moderate", "Standard", 200, "Standard", "Dark age", "Imperial Age", "10 minutes", "Conquest", true, true, false);
            return game;
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playersPanel.Controls.Add(new InitPlayerPanel());
        }
    }
}
