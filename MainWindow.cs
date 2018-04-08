using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_OrientatedProgramming2018
{
    public partial class MainWindow : Form
    {

        
        public MainWindow()
        {
            InitializeComponent();
            Debugging();

        }
        private void Debugging()
        {
            Game test_game = InitGame();
            test_game.InitPlayer(1, "red", "Aztecs", 100, 200, 300, 400, 5, 10);
            test_game.GetPlayer(1).TechModify("Thumb Ring");
            //test_game.GetPlayer(1).ToString();

            debugRichTextBox.AppendText(test_game.GetPlayer(1).Units.Single(u => u.Name == "Crossbowman").ToString());

            //debugRichTextBox.AppendText(test_game.ToString());
            //debugRichTextBox.AppendText("\n\n");

            //debugRichTextBox.AppendText("\nStructures: \n");
            //debugRichTextBox.AppendText(test_game.StructuresToString());
            //debugRichTextBox.AppendText("\nUnits: \n");
            //debugRichTextBox.AppendText(test_game.UnitsToString());
            //debugRichTextBox.AppendText("\nTechs: \n");
            //debugRichTextBox.AppendText(test_game.TechsToString());
            //debugRichTextBox.AppendText("\nCivilizations: \n");
            //debugRichTextBox.AppendText(test_game.CivilizationsToString());

            //debugRichTextBox.AppendText(test_game.ItemNamesToString());
        }

        private Game InitGame()
        {

            Game game = new Game("Test", true, "Standard", "Arabia", "Small", "Moderate", "Standard", 200, "Standard", "Dark age", "Imperial Age", "10 minutes", "Conquest", true, true, false);
            return game;
        }
    }
}
