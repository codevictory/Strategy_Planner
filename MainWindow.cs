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
            //test_game.GetPlayer(1).TechModify("Thumb Ring");
            //test_game.GetPlayer(1).ToString();

            //debugRichTextBox.AppendText(test_game.GetPlayer(1).Units.Single(u => u.Name == "Crossbowman").ToString());

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

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel playerPanel = new System.Windows.Forms.FlowLayoutPanel();
            Panel playerNamePanel = new System.Windows.Forms.Panel();
            Label playerNameLabel = new System.Windows.Forms.Label();
            TableLayoutPanel playerInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            Label alliesLabel = new System.Windows.Forms.Label();
            ListBox alliesBox = new System.Windows.Forms.ListBox();
            Label ageLabel = new System.Windows.Forms.Label();
            Label colorLabel = new System.Windows.Forms.Label();
            Label civLabel = new System.Windows.Forms.Label();
            Label ageBox = new System.Windows.Forms.Label();
            Label colorBox = new System.Windows.Forms.Label();
            Label civBox = new System.Windows.Forms.Label();
            Label playerLabel = new System.Windows.Forms.Label();
            TableLayoutPanel resourcesPanel = new System.Windows.Forms.TableLayoutPanel();
            Label stoneLabel = new System.Windows.Forms.Label();
            Label goldLabel = new System.Windows.Forms.Label();
            Label woodLabel = new System.Windows.Forms.Label();
            Label foodLabel = new System.Windows.Forms.Label();
            NumericUpDown stoneAmountBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown goldAmountBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown woodAmountBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown foodAmountBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown stoneGatherRateBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown goldGatherRateBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown woodGatherRateBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown foodGatherRateBox = new System.Windows.Forms.NumericUpDown();
            Label amountLabel = new System.Windows.Forms.Label();
            Label rateLabel = new System.Windows.Forms.Label();
            Label villgersLabel = new System.Windows.Forms.Label();
            NumericUpDown foodVillagersBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown woodVillagersBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown goldVillagersBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown stoneVillagersBox = new System.Windows.Forms.NumericUpDown();
            TableLayoutPanel itemsTitlePanel = new System.Windows.Forms.TableLayoutPanel();
            Label availableItemsLabel = new System.Windows.Forms.Label();
            Label ownedItemsLabel = new System.Windows.Forms.Label();
            TreeView availableItemsTree = new System.Windows.Forms.TreeView();
            TableLayoutPanel boughtItemsPanel = new System.Windows.Forms.TableLayoutPanel();
            FlowLayoutPanel techsPanel = new System.Windows.Forms.FlowLayoutPanel();
            Label techsLabel = new System.Windows.Forms.Label();
            ListBox techsListBox = new System.Windows.Forms.ListBox();
            FlowLayoutPanel structuresPanel = new System.Windows.Forms.FlowLayoutPanel();
            Label structuresLabel = new System.Windows.Forms.Label();
            ListBox structuresListBox = new System.Windows.Forms.ListBox();
            FlowLayoutPanel unitsPanel = new System.Windows.Forms.FlowLayoutPanel();
            Label unitsLabel = new System.Windows.Forms.Label();
            ListBox unitsListBox = new System.Windows.Forms.ListBox();
            FlowLayoutPanel economyLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            Label gatherersLabel = new System.Windows.Forms.Label();
            TableLayoutPanel foodGatherersPanel = new System.Windows.Forms.TableLayoutPanel();
            NumericUpDown fishTrapsBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown deepFishingBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown shoreFishingBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown foragersBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown farmersBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown shepherdsBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown huntersBox = new System.Windows.Forms.NumericUpDown();
            Label foodGatheresLabel = new System.Windows.Forms.Label();
            TableLayoutPanel goldGatherersPanel = new System.Windows.Forms.TableLayoutPanel();
            Label goldGatherersLabel = new System.Windows.Forms.Label();
            NumericUpDown relicsBox = new System.Windows.Forms.NumericUpDown();
            NumericUpDown tradeCartsBox = new System.Windows.Forms.NumericUpDown();

            playerPanel.SuspendLayout();
            playerNamePanel.SuspendLayout();
            playerInfoPanel.SuspendLayout();
            resourcesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(stoneAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(goldAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(woodAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(foodAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stoneGatherRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(goldGatherRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(woodGatherRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(foodGatherRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(foodVillagersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(woodVillagersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(goldVillagersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stoneVillagersBox)).BeginInit();
            itemsTitlePanel.SuspendLayout();
            boughtItemsPanel.SuspendLayout();
            techsPanel.SuspendLayout();
            structuresPanel.SuspendLayout();
            unitsPanel.SuspendLayout();
            economyLayoutPanel.SuspendLayout();
            foodGatherersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(fishTrapsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(deepFishingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(shoreFishingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(foragersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(farmersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(shepherdsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(huntersBox)).BeginInit();
            goldGatherersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(relicsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(tradeCartsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(logoBox)).BeginInit();

            //
            //TreeView
            //

            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Barracks");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Palisade Wall");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Palisade Gate");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Outpost");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Military", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Farm");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Mining Camp");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Lumber Camp");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Dock");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Mill");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("House");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Economy", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Structures", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Fishing Ship");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Transport Ship");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Ships", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Militia");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Infantry", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Villager");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Civilian", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Units", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode18,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Loom");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Economy", new System.Windows.Forms.TreeNode[] {
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Feudal Age");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Ages", new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Techs", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode25});

            // 
            // panelContainer
            // 
            playerPanel.BackColor = System.Drawing.SystemColors.Window;
            playerPanel.Controls.Add(playerNamePanel);
            playerPanel.Controls.Add(playerInfoPanel);
            playerPanel.Controls.Add(resourcesPanel);
            playerPanel.Controls.Add(itemsTitlePanel);
            playerPanel.Controls.Add(availableItemsTree);
            playerPanel.Controls.Add(boughtItemsPanel);
            playerPanel.Location = new System.Drawing.Point(3, 3);
            playerPanel.Name = "panelContainer";
            playerPanel.Size = new System.Drawing.Size(451, 376);
            playerPanel.TabIndex = 2;
            // 
            // playerNamePanel
            // 
            playerNamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            playerNamePanel.Controls.Add(playerNameLabel);
            playerNamePanel.Location = new System.Drawing.Point(3, 3);
            playerNamePanel.Name = "playerNamePanel";
            playerNamePanel.Size = new System.Drawing.Size(445, 34);
            playerNamePanel.TabIndex = 4;
            // 
            // playerNameLabel
            // 
            playerNameLabel.AutoSize = true;
            playerNameLabel.Location = new System.Drawing.Point(199, 11);
            playerNameLabel.Name = "playerNameLabel";
            playerNameLabel.Size = new System.Drawing.Size(70, 13);
            playerNameLabel.TabIndex = 3;
            playerNameLabel.Text = "[player name]";
            playerNameLabel.Visible = false;
            // 
            // playerInfoPanel
            // 
            playerInfoPanel.ColumnCount = 2;
            playerInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            playerInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            playerInfoPanel.Controls.Add(alliesLabel, 0, 4);
            playerInfoPanel.Controls.Add(alliesBox, 1, 4);
            playerInfoPanel.Controls.Add(ageLabel, 0, 3);
            playerInfoPanel.Controls.Add(colorLabel, 0, 2);
            playerInfoPanel.Controls.Add(civLabel, 0, 1);
            playerInfoPanel.Controls.Add(ageBox, 1, 3);
            playerInfoPanel.Controls.Add(colorBox, 1, 2);
            playerInfoPanel.Controls.Add(civBox, 1, 1);
            playerInfoPanel.Controls.Add(playerLabel, 0, 0);
            playerInfoPanel.Location = new System.Drawing.Point(3, 43);
            playerInfoPanel.Name = "playerInfoPanel";
            playerInfoPanel.RowCount = 5;
            playerInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3953F));
            playerInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3953F));
            playerInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3953F));
            playerInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3953F));
            playerInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.41879F));
            playerInfoPanel.Size = new System.Drawing.Size(196, 94);
            playerInfoPanel.TabIndex = 0;
            // 
            // alliesLabel
            // 
            alliesLabel.AutoSize = true;
            alliesLabel.Location = new System.Drawing.Point(3, 68);
            alliesLabel.Name = "alliesLabel";
            alliesLabel.Size = new System.Drawing.Size(34, 13);
            alliesLabel.TabIndex = 3;
            alliesLabel.Text = "Allies:";
            // 
            // alliesBox
            // 
            alliesBox.FormattingEnabled = true;
            alliesBox.Items.AddRange(new object[] {
            "[ally_civ1]",
            "[ally_civ2]",
            "[ally_civ3]"});
            alliesBox.Location = new System.Drawing.Point(101, 71);
            alliesBox.Name = "alliesBox";
            alliesBox.Size = new System.Drawing.Size(70, 17);
            alliesBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(3, 51);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Age:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(3, 34);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 1;
            colorLabel.Text = "Color:";
            // 
            // civLabel
            // 
            civLabel.AutoSize = true;
            civLabel.Location = new System.Drawing.Point(3, 17);
            civLabel.Name = "civLabel";
            civLabel.Size = new System.Drawing.Size(59, 13);
            civLabel.TabIndex = 2;
            civLabel.Text = "Civilization:";
            // 
            // ageBox
            // 
            ageBox.AutoSize = true;
            ageBox.Location = new System.Drawing.Point(101, 51);
            ageBox.Name = "ageBox";
            ageBox.Size = new System.Drawing.Size(31, 13);
            ageBox.TabIndex = 9;
            ageBox.Text = "[age]";
            // 
            // colorBox
            // 
            colorBox.AutoSize = true;
            colorBox.Location = new System.Drawing.Point(101, 34);
            colorBox.Name = "colorBox";
            colorBox.Size = new System.Drawing.Size(36, 13);
            colorBox.TabIndex = 7;
            colorBox.Text = "[color]";
            // 
            // civBox
            // 
            civBox.AutoSize = true;
            civBox.Location = new System.Drawing.Point(101, 17);
            civBox.Name = "civBox";
            civBox.Size = new System.Drawing.Size(27, 13);
            civBox.TabIndex = 6;
            civBox.Text = "[civ]";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Location = new System.Drawing.Point(3, 0);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new System.Drawing.Size(36, 13);
            playerLabel.TabIndex = 11;
            playerLabel.Text = "Player";
            // 
            // resourcesPanel
            // 
            resourcesPanel.ColumnCount = 4;
            resourcesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            resourcesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            resourcesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            resourcesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            resourcesPanel.Controls.Add(stoneLabel, 0, 4);
            resourcesPanel.Controls.Add(goldLabel, 0, 3);
            resourcesPanel.Controls.Add(woodLabel, 0, 2);
            resourcesPanel.Controls.Add(foodLabel, 0, 1);
            resourcesPanel.Controls.Add(stoneAmountBox, 1, 4);
            resourcesPanel.Controls.Add(goldAmountBox, 1, 3);
            resourcesPanel.Controls.Add(woodAmountBox, 1, 2);
            resourcesPanel.Controls.Add(foodAmountBox, 1, 1);
            resourcesPanel.Controls.Add(stoneGatherRateBox, 2, 4);
            resourcesPanel.Controls.Add(goldGatherRateBox, 2, 3);
            resourcesPanel.Controls.Add(woodGatherRateBox, 2, 2);
            resourcesPanel.Controls.Add(foodGatherRateBox, 2, 1);
            resourcesPanel.Controls.Add(amountLabel, 1, 0);
            resourcesPanel.Controls.Add(rateLabel, 2, 0);
            resourcesPanel.Controls.Add(villgersLabel, 3, 0);
            resourcesPanel.Controls.Add(foodVillagersBox, 3, 1);
            resourcesPanel.Controls.Add(woodVillagersBox, 3, 2);
            resourcesPanel.Controls.Add(goldVillagersBox, 3, 3);
            resourcesPanel.Controls.Add(stoneVillagersBox, 3, 4);
            resourcesPanel.Location = new System.Drawing.Point(205, 43);
            resourcesPanel.Name = "resourcesPanel";
            resourcesPanel.RowCount = 5;
            resourcesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            resourcesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            resourcesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            resourcesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            resourcesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            resourcesPanel.Size = new System.Drawing.Size(243, 94);
            resourcesPanel.TabIndex = 0;
            // 
            // stoneLabel
            // 
            stoneLabel.AutoSize = true;
            stoneLabel.Location = new System.Drawing.Point(3, 72);
            stoneLabel.Name = "stoneLabel";
            stoneLabel.Size = new System.Drawing.Size(38, 13);
            stoneLabel.TabIndex = 3;
            stoneLabel.Text = "Stone:";
            // 
            // goldLabel
            // 
            goldLabel.AutoSize = true;
            goldLabel.Location = new System.Drawing.Point(3, 54);
            goldLabel.Name = "goldLabel";
            goldLabel.Size = new System.Drawing.Size(32, 13);
            goldLabel.TabIndex = 2;
            goldLabel.Text = "Gold:";
            // 
            // woodLabel
            // 
            woodLabel.AutoSize = true;
            woodLabel.Location = new System.Drawing.Point(3, 36);
            woodLabel.Name = "woodLabel";
            woodLabel.Size = new System.Drawing.Size(39, 13);
            woodLabel.TabIndex = 1;
            woodLabel.Text = "Wood:";
            // 
            // foodLabel
            // 
            foodLabel.AutoSize = true;
            foodLabel.Location = new System.Drawing.Point(3, 18);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new System.Drawing.Size(34, 13);
            foodLabel.TabIndex = 0;
            foodLabel.Text = "Food:";
            // 
            // stoneAmountBox
            // 
            stoneAmountBox.Location = new System.Drawing.Point(63, 75);
            stoneAmountBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            stoneAmountBox.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            stoneAmountBox.Name = "stoneAmountBox";
            stoneAmountBox.Size = new System.Drawing.Size(49, 20);
            stoneAmountBox.TabIndex = 15;
            stoneAmountBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // goldAmountBox
            // 
            goldAmountBox.Location = new System.Drawing.Point(63, 57);
            goldAmountBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            goldAmountBox.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            goldAmountBox.Name = "goldAmountBox";
            goldAmountBox.Size = new System.Drawing.Size(49, 20);
            goldAmountBox.TabIndex = 14;
            goldAmountBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // woodAmountBox
            // 
            woodAmountBox.Location = new System.Drawing.Point(63, 39);
            woodAmountBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            woodAmountBox.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            woodAmountBox.Name = "woodAmountBox";
            woodAmountBox.Size = new System.Drawing.Size(49, 20);
            woodAmountBox.TabIndex = 13;
            woodAmountBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // foodAmountBox
            // 
            foodAmountBox.Location = new System.Drawing.Point(63, 21);
            foodAmountBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            foodAmountBox.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            foodAmountBox.Name = "foodAmountBox";
            foodAmountBox.Size = new System.Drawing.Size(49, 20);
            foodAmountBox.TabIndex = 12;
            foodAmountBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // stoneGatherRateBox
            // 
            stoneGatherRateBox.DecimalPlaces = 3;
            stoneGatherRateBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            stoneGatherRateBox.Location = new System.Drawing.Point(123, 75);
            stoneGatherRateBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            196608});
            stoneGatherRateBox.Name = "stoneGatherRateBox";
            stoneGatherRateBox.Size = new System.Drawing.Size(49, 20);
            stoneGatherRateBox.TabIndex = 19;
            // 
            // goldGatherRateBox
            // 
            goldGatherRateBox.DecimalPlaces = 3;
            goldGatherRateBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            goldGatherRateBox.Location = new System.Drawing.Point(123, 57);
            goldGatherRateBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            196608});
            goldGatherRateBox.Name = "goldGatherRateBox";
            goldGatherRateBox.Size = new System.Drawing.Size(49, 20);
            goldGatherRateBox.TabIndex = 18;
            // 
            // woodGatherRateBox
            // 
            woodGatherRateBox.DecimalPlaces = 3;
            woodGatherRateBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            woodGatherRateBox.Location = new System.Drawing.Point(123, 39);
            woodGatherRateBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            196608});
            woodGatherRateBox.Name = "woodGatherRateBox";
            woodGatherRateBox.Size = new System.Drawing.Size(49, 20);
            woodGatherRateBox.TabIndex = 17;
            // 
            // foodGatherRateBox
            // 
            foodGatherRateBox.DecimalPlaces = 3;
            foodGatherRateBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            foodGatherRateBox.Location = new System.Drawing.Point(123, 21);
            foodGatherRateBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            196608});
            foodGatherRateBox.Name = "foodGatherRateBox";
            foodGatherRateBox.Size = new System.Drawing.Size(49, 20);
            foodGatherRateBox.TabIndex = 16;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(63, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(43, 13);
            amountLabel.TabIndex = 20;
            amountLabel.Text = "Amount";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new System.Drawing.Point(123, 0);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(43, 13);
            rateLabel.TabIndex = 21;
            rateLabel.Text = "Rate /s";
            // 
            // villgersLabel
            // 
            villgersLabel.AutoSize = true;
            villgersLabel.Location = new System.Drawing.Point(183, 0);
            villgersLabel.Name = "villgersLabel";
            villgersLabel.Size = new System.Drawing.Size(46, 13);
            villgersLabel.TabIndex = 22;
            villgersLabel.Text = "Villagers";
            // 
            // foodVillagersBox
            // 
            foodVillagersBox.Location = new System.Drawing.Point(183, 21);
            foodVillagersBox.Name = "foodVillagersBox";
            foodVillagersBox.Size = new System.Drawing.Size(51, 20);
            foodVillagersBox.TabIndex = 23;
            // 
            // woodVillagersBox
            // 
            woodVillagersBox.Location = new System.Drawing.Point(183, 39);
            woodVillagersBox.Name = "woodVillagersBox";
            woodVillagersBox.Size = new System.Drawing.Size(51, 20);
            woodVillagersBox.TabIndex = 24;
            // 
            // goldVillagersBox
            // 
            goldVillagersBox.Location = new System.Drawing.Point(183, 57);
            goldVillagersBox.Name = "goldVillagersBox";
            goldVillagersBox.Size = new System.Drawing.Size(51, 20);
            goldVillagersBox.TabIndex = 25;
            // 
            // stoneVillagersBox
            // 
            stoneVillagersBox.Location = new System.Drawing.Point(183, 75);
            stoneVillagersBox.Name = "stoneVillagersBox";
            stoneVillagersBox.Size = new System.Drawing.Size(51, 20);
            stoneVillagersBox.TabIndex = 26;
            // 
            // itemsTitlePanel
            // 
            itemsTitlePanel.ColumnCount = 2;
            itemsTitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.39326F));
            itemsTitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.60674F));
            itemsTitlePanel.Controls.Add(availableItemsLabel, 0, 0);
            itemsTitlePanel.Controls.Add(ownedItemsLabel, 1, 0);
            itemsTitlePanel.Location = new System.Drawing.Point(3, 143);
            itemsTitlePanel.Name = "itemsTitlePanel";
            itemsTitlePanel.RowCount = 1;
            itemsTitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            itemsTitlePanel.Size = new System.Drawing.Size(445, 16);
            itemsTitlePanel.TabIndex = 3;
            // 
            // availableItemsLabel
            // 
            availableItemsLabel.AutoSize = true;
            availableItemsLabel.Location = new System.Drawing.Point(3, 0);
            availableItemsLabel.Name = "availableItemsLabel";
            availableItemsLabel.Size = new System.Drawing.Size(78, 13);
            availableItemsLabel.TabIndex = 0;
            availableItemsLabel.Text = "Available Items";
            // 
            // ownedItemsLabel
            // 
            ownedItemsLabel.AutoSize = true;
            ownedItemsLabel.Location = new System.Drawing.Point(205, 0);
            ownedItemsLabel.Name = "ownedItemsLabel";
            ownedItemsLabel.Size = new System.Drawing.Size(69, 13);
            ownedItemsLabel.TabIndex = 1;
            ownedItemsLabel.Text = "Owned Items";
            // 
            // availableItemsTree
            // 
            availableItemsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            availableItemsTree.Location = new System.Drawing.Point(3, 165);
            availableItemsTree.Name = "availableItemsTree";
            treeNode1.Name = "barracksStruct";
            treeNode1.Text = "Barracks";
            treeNode2.Name = "palisadeWallStruct";
            treeNode2.Text = "Palisade Wall";
            treeNode3.Name = "palisadeGateStruct";
            treeNode3.Text = "Palisade Gate";
            treeNode4.Name = "outpostStruct";
            treeNode4.Text = "Outpost";
            treeNode5.Name = "militaryBuildings";
            treeNode5.Text = "Military";
            treeNode6.Name = "farmStruct";
            treeNode6.Text = "Farm";
            treeNode7.Name = "miningCampStruct";
            treeNode7.Text = "Mining Camp";
            treeNode8.Name = "lumberCampStruct";
            treeNode8.Text = "Lumber Camp";
            treeNode9.Name = "dockStruct";
            treeNode9.Text = "Dock";
            treeNode10.Name = "millStruct";
            treeNode10.Text = "Mill";
            treeNode11.Name = "houseStruct";
            treeNode11.Text = "House";
            treeNode12.Name = "economyBuilding";
            treeNode12.Text = "Economy";
            treeNode13.Name = "structuresRoot";
            treeNode13.Text = "Structures";
            treeNode14.Name = "fishingShipUnit";
            treeNode14.Text = "Fishing Ship";
            treeNode15.Name = "transportShipUnit";
            treeNode15.Text = "Transport Ship";
            treeNode16.Name = "shipUnits";
            treeNode16.Text = "Ships";
            treeNode17.Name = "militiaUnit";
            treeNode17.Text = "Militia";
            treeNode18.Name = "infantryUnits";
            treeNode18.Text = "Infantry";
            treeNode19.Name = "villagerUnit";
            treeNode19.Text = "Villager";
            treeNode20.Name = "civilianUnits";
            treeNode20.Text = "Civilian";
            treeNode21.Name = "unitsRoot";
            treeNode21.Text = "Units";
            treeNode22.Name = "loomTech";
            treeNode22.Text = "Loom";
            treeNode23.Name = "economyTechs";
            treeNode23.Text = "Economy";
            treeNode24.Name = "feudalAgeTech";
            treeNode24.Text = "Feudal Age";
            treeNode25.Name = "ageTechs";
            treeNode25.Text = "Ages";
            treeNode26.Name = "techsRoot";
            treeNode26.Text = "Techs";
            availableItemsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode21,
            treeNode26});
            availableItemsTree.Size = new System.Drawing.Size(196, 207);
            availableItemsTree.TabIndex = 5;
            // 
            // boughtItemsPanel
            // 
            boughtItemsPanel.ColumnCount = 2;
            boughtItemsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            boughtItemsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            boughtItemsPanel.Controls.Add(techsPanel, 0, 1);
            boughtItemsPanel.Controls.Add(structuresPanel, 1, 0);
            boughtItemsPanel.Controls.Add(unitsPanel, 0, 0);
            boughtItemsPanel.Controls.Add(economyLayoutPanel, 1, 1);
            boughtItemsPanel.Location = new System.Drawing.Point(205, 165);
            boughtItemsPanel.Name = "boughtItemsPanel";
            boughtItemsPanel.RowCount = 2;
            boughtItemsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.14563F));
            boughtItemsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.85437F));
            boughtItemsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            boughtItemsPanel.Size = new System.Drawing.Size(243, 207);
            boughtItemsPanel.TabIndex = 0;
            // 
            // techsPanel
            // 
            techsPanel.Controls.Add(techsLabel);
            techsPanel.Controls.Add(techsListBox);
            techsPanel.Location = new System.Drawing.Point(3, 96);
            techsPanel.Name = "techsPanel";
            techsPanel.Size = new System.Drawing.Size(115, 108);
            techsPanel.TabIndex = 2;
            // 
            // techsLabel
            // 
            techsLabel.AutoSize = true;
            techsLabel.Location = new System.Drawing.Point(3, 0);
            techsLabel.Name = "techsLabel";
            techsLabel.Size = new System.Drawing.Size(37, 13);
            techsLabel.TabIndex = 3;
            techsLabel.Text = "Techs";
            // 
            // techsListBox
            // 
            techsListBox.FormattingEnabled = true;
            techsListBox.Items.AddRange(new object[] {
            "Loom"});
            techsListBox.Location = new System.Drawing.Point(3, 16);
            techsListBox.Name = "techsListBox";
            techsListBox.Size = new System.Drawing.Size(112, 82);
            techsListBox.TabIndex = 4;
            // 
            // structuresPanel
            // 
            structuresPanel.Controls.Add(structuresLabel);
            structuresPanel.Controls.Add(structuresListBox);
            structuresPanel.Location = new System.Drawing.Point(124, 3);
            structuresPanel.Name = "structuresPanel";
            structuresPanel.Size = new System.Drawing.Size(116, 87);
            structuresPanel.TabIndex = 1;
            // 
            // structuresLabel
            // 
            structuresLabel.AutoSize = true;
            structuresLabel.Location = new System.Drawing.Point(3, 0);
            structuresLabel.Name = "structuresLabel";
            structuresLabel.Size = new System.Drawing.Size(55, 13);
            structuresLabel.TabIndex = 3;
            structuresLabel.Text = "Structures";
            // 
            // structuresListBox
            // 
            structuresListBox.FormattingEnabled = true;
            structuresListBox.Items.AddRange(new object[] {
            "Town Center",
            "House",
            "House",
            "Barracks",
            "Lumber Camp",
            "Mining Camp",
            "House",
            "House"});
            structuresListBox.Location = new System.Drawing.Point(3, 16);
            structuresListBox.Name = "structuresListBox";
            structuresListBox.Size = new System.Drawing.Size(113, 69);
            structuresListBox.TabIndex = 4;
            // 
            // unitsPanel
            // 
            unitsPanel.Controls.Add(unitsLabel);
            unitsPanel.Controls.Add(unitsListBox);
            unitsPanel.Location = new System.Drawing.Point(3, 3);
            unitsPanel.Name = "unitsPanel";
            unitsPanel.Size = new System.Drawing.Size(115, 87);
            unitsPanel.TabIndex = 0;
            // 
            // unitsLabel
            // 
            unitsLabel.AutoSize = true;
            unitsLabel.Location = new System.Drawing.Point(3, 0);
            unitsLabel.Name = "unitsLabel";
            unitsLabel.Size = new System.Drawing.Size(31, 13);
            unitsLabel.TabIndex = 3;
            unitsLabel.Text = "Units";
            // 
            // unitsListBox
            // 
            unitsListBox.FormattingEnabled = true;
            unitsListBox.Items.AddRange(new object[] {
            "Militia",
            "Militia",
            "Militia"});
            unitsListBox.Location = new System.Drawing.Point(3, 16);
            unitsListBox.Name = "unitsListBox";
            unitsListBox.Size = new System.Drawing.Size(112, 69);
            unitsListBox.TabIndex = 4;
            // 
            // economyLayoutPanel
            // 
            economyLayoutPanel.Controls.Add(gatherersLabel);
            economyLayoutPanel.Controls.Add(foodGatherersPanel);
            economyLayoutPanel.Controls.Add(goldGatherersPanel);
            economyLayoutPanel.Location = new System.Drawing.Point(124, 96);
            economyLayoutPanel.Name = "economyLayoutPanel";
            economyLayoutPanel.Size = new System.Drawing.Size(116, 98);
            economyLayoutPanel.TabIndex = 3;
            // 
            // gatherersLabel
            // 
            gatherersLabel.AutoSize = true;
            gatherersLabel.Location = new System.Drawing.Point(3, 0);
            gatherersLabel.Name = "gatherersLabel";
            gatherersLabel.Size = new System.Drawing.Size(53, 13);
            gatherersLabel.TabIndex = 0;
            gatherersLabel.Text = "Gatherers";
            // 
            // foodGatherersPanel
            // 
            foodGatherersPanel.ColumnCount = 3;
            foodGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            foodGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            foodGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            foodGatherersPanel.Controls.Add(fishTrapsBox, 2, 2);
            foodGatherersPanel.Controls.Add(deepFishingBox, 1, 2);
            foodGatherersPanel.Controls.Add(shoreFishingBox, 0, 2);
            foodGatherersPanel.Controls.Add(foragersBox, 2, 1);
            foodGatherersPanel.Controls.Add(farmersBox, 1, 1);
            foodGatherersPanel.Controls.Add(shepherdsBox, 0, 1);
            foodGatherersPanel.Controls.Add(huntersBox, 2, 0);
            foodGatherersPanel.Controls.Add(foodGatheresLabel, 0, 0);
            foodGatherersPanel.Location = new System.Drawing.Point(3, 16);
            foodGatherersPanel.Name = "foodGatherersPanel";
            foodGatherersPanel.RowCount = 3;
            foodGatherersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            foodGatherersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            foodGatherersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            foodGatherersPanel.Size = new System.Drawing.Size(113, 51);
            foodGatherersPanel.TabIndex = 12;
            // 
            // fishTrapsBox
            // 
            fishTrapsBox.Location = new System.Drawing.Point(77, 37);
            fishTrapsBox.Name = "fishTrapsBox";
            fishTrapsBox.Size = new System.Drawing.Size(27, 20);
            fishTrapsBox.TabIndex = 6;
            // 
            // deepFishingBox
            // 
            deepFishingBox.Location = new System.Drawing.Point(40, 37);
            deepFishingBox.Name = "deepFishingBox";
            deepFishingBox.Size = new System.Drawing.Size(27, 20);
            deepFishingBox.TabIndex = 9;
            // 
            // shoreFishingBox
            // 
            shoreFishingBox.Location = new System.Drawing.Point(3, 37);
            shoreFishingBox.Name = "shoreFishingBox";
            shoreFishingBox.Size = new System.Drawing.Size(27, 20);
            shoreFishingBox.TabIndex = 11;
            // 
            // foragersBox
            // 
            foragersBox.Location = new System.Drawing.Point(77, 20);
            foragersBox.Name = "foragersBox";
            foragersBox.Size = new System.Drawing.Size(27, 20);
            foragersBox.TabIndex = 10;
            // 
            // farmersBox
            // 
            farmersBox.Location = new System.Drawing.Point(40, 20);
            farmersBox.Name = "farmersBox";
            farmersBox.Size = new System.Drawing.Size(27, 20);
            farmersBox.TabIndex = 3;
            // 
            // shepherdsBox
            // 
            shepherdsBox.Location = new System.Drawing.Point(3, 20);
            shepherdsBox.Name = "shepherdsBox";
            shepherdsBox.Size = new System.Drawing.Size(27, 20);
            shepherdsBox.TabIndex = 4;
            // 
            // huntersBox
            // 
            huntersBox.Location = new System.Drawing.Point(77, 3);
            huntersBox.Name = "huntersBox";
            huntersBox.Size = new System.Drawing.Size(27, 20);
            huntersBox.TabIndex = 5;
            // 
            // foodGatheresLabel
            // 
            foodGatheresLabel.AutoSize = true;
            foodGatheresLabel.Location = new System.Drawing.Point(3, 0);
            foodGatheresLabel.Name = "foodGatheresLabel";
            foodGatheresLabel.Size = new System.Drawing.Size(31, 13);
            foodGatheresLabel.TabIndex = 2;
            foodGatheresLabel.Text = "Food";
            // 
            // goldGatherersPanel
            // 
            goldGatherersPanel.ColumnCount = 3;
            goldGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            goldGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            goldGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            goldGatherersPanel.Controls.Add(goldGatherersLabel, 0, 0);
            goldGatherersPanel.Controls.Add(relicsBox, 1, 0);
            goldGatherersPanel.Controls.Add(tradeCartsBox, 2, 0);
            goldGatherersPanel.Location = new System.Drawing.Point(3, 73);
            goldGatherersPanel.Name = "goldGatherersPanel";
            goldGatherersPanel.RowCount = 1;
            goldGatherersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            goldGatherersPanel.Size = new System.Drawing.Size(113, 25);
            goldGatherersPanel.TabIndex = 9;
            // 
            // goldGatherersLabel
            // 
            goldGatherersLabel.AutoSize = true;
            goldGatherersLabel.Location = new System.Drawing.Point(3, 0);
            goldGatherersLabel.Name = "goldGatherersLabel";
            goldGatherersLabel.Size = new System.Drawing.Size(29, 13);
            goldGatherersLabel.TabIndex = 0;
            goldGatherersLabel.Text = "Gold";
            // 
            // relicsBox
            // 
            relicsBox.Location = new System.Drawing.Point(40, 3);
            relicsBox.Name = "relicsBox";
            relicsBox.Size = new System.Drawing.Size(31, 20);
            relicsBox.TabIndex = 1;
            // 
            // tradeCartsBox
            // 
            tradeCartsBox.Location = new System.Drawing.Point(77, 3);
            tradeCartsBox.Name = "tradeCartsBox";
            tradeCartsBox.Size = new System.Drawing.Size(27, 20);
            tradeCartsBox.TabIndex = 2;

            playerPanel.ResumeLayout(false);
            playerNamePanel.ResumeLayout(false);
            playerNamePanel.PerformLayout();
            playerInfoPanel.ResumeLayout(false);
            playerInfoPanel.PerformLayout();
            resourcesPanel.ResumeLayout(false);
            resourcesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(stoneAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(goldAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(woodAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(foodAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stoneGatherRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(goldGatherRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(woodGatherRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(foodGatherRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(foodVillagersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(woodVillagersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(goldVillagersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stoneVillagersBox)).EndInit();
            itemsTitlePanel.ResumeLayout(false);
            itemsTitlePanel.PerformLayout();
            boughtItemsPanel.ResumeLayout(false);
            techsPanel.ResumeLayout(false);
            techsPanel.PerformLayout();
            structuresPanel.ResumeLayout(false);
            structuresPanel.PerformLayout();
            unitsPanel.ResumeLayout(false);
            unitsPanel.PerformLayout();
            economyLayoutPanel.ResumeLayout(false);
            economyLayoutPanel.PerformLayout();
            foodGatherersPanel.ResumeLayout(false);
            foodGatherersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(fishTrapsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(deepFishingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(shoreFishingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(foragersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(farmersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(shepherdsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(huntersBox)).EndInit();
            goldGatherersPanel.ResumeLayout(false);
            goldGatherersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(relicsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(tradeCartsBox)).EndInit();

            playersPanel.Controls.Add(playerPanel);
            
        }
    }
}
