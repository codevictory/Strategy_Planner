using System.Windows.Forms;

namespace StrategyPlanner
{
    partial class PlayerPanel : APlayer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer panelContainer = null;
        private AutoScaleMode AutoScaleMode;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.playerNamePanel = new System.Windows.Forms.Panel();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.alliesLabel = new System.Windows.Forms.Label();
            this.alliesBox = new System.Windows.Forms.ListBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.civLabel = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.Label();
            this.civBox = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.resourcesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.stoneLabel = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.woodLabel = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.stoneAmountBox = new System.Windows.Forms.NumericUpDown();
            this.goldAmountBox = new System.Windows.Forms.NumericUpDown();
            this.woodAmountBox = new System.Windows.Forms.NumericUpDown();
            this.foodAmountBox = new System.Windows.Forms.NumericUpDown();
            this.stoneGatherRateBox = new System.Windows.Forms.NumericUpDown();
            this.goldGatherRateBox = new System.Windows.Forms.NumericUpDown();
            this.woodGatherRateBox = new System.Windows.Forms.NumericUpDown();
            this.foodGatherRateBox = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.villgersLabel = new System.Windows.Forms.Label();
            this.foodVillagersBox = new System.Windows.Forms.NumericUpDown();
            this.woodVillagersBox = new System.Windows.Forms.NumericUpDown();
            this.goldVillagersBox = new System.Windows.Forms.NumericUpDown();
            this.stoneVillagersBox = new System.Windows.Forms.NumericUpDown();
            this.itemsTitlePanel = new System.Windows.Forms.TableLayoutPanel();
            this.availableItemsLabel = new System.Windows.Forms.Label();
            this.ownedItemsLabel = new System.Windows.Forms.Label();
            this.availableItemsTree = new System.Windows.Forms.TreeView();
            this.boughtItemsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.techsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.techsLabel = new System.Windows.Forms.Label();
            this.techsListBox = new System.Windows.Forms.ListBox();
            this.structuresPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.structuresLabel = new System.Windows.Forms.Label();
            this.structuresListBox = new System.Windows.Forms.ListBox();
            this.unitsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.unitsListBox = new System.Windows.Forms.ListBox();
            this.economyLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gatherersLabel = new System.Windows.Forms.Label();
            this.foodGatherersPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fishTrapsBox = new System.Windows.Forms.NumericUpDown();
            this.deepFishingBox = new System.Windows.Forms.NumericUpDown();
            this.shoreFishingBox = new System.Windows.Forms.NumericUpDown();
            this.foragersBox = new System.Windows.Forms.NumericUpDown();
            this.farmersBox = new System.Windows.Forms.NumericUpDown();
            this.shepherdsBox = new System.Windows.Forms.NumericUpDown();
            this.huntersBox = new System.Windows.Forms.NumericUpDown();
            this.foodGatheresLabel = new System.Windows.Forms.Label();
            this.goldGatherersPanel = new System.Windows.Forms.TableLayoutPanel();
            this.goldGatherersLabel = new System.Windows.Forms.Label();
            this.relicsBox = new System.Windows.Forms.NumericUpDown();
            this.tradeCartsBox = new System.Windows.Forms.NumericUpDown();
            this.mainPanel.SuspendLayout();
            this.playerNamePanel.SuspendLayout();
            this.playerInfoPanel.SuspendLayout();
            this.resourcesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoneAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneGatherRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldGatherRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodGatherRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGatherRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodVillagersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodVillagersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldVillagersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneVillagersBox)).BeginInit();
            this.itemsTitlePanel.SuspendLayout();
            this.boughtItemsPanel.SuspendLayout();
            this.techsPanel.SuspendLayout();
            this.structuresPanel.SuspendLayout();
            this.unitsPanel.SuspendLayout();
            this.economyLayoutPanel.SuspendLayout();
            this.foodGatherersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fishTrapsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepFishingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoreFishingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foragersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shepherdsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huntersBox)).BeginInit();
            this.goldGatherersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relicsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeCartsBox)).BeginInit();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainPanel.Controls.Add(this.playerNamePanel);
            this.mainPanel.Controls.Add(this.playerInfoPanel);
            this.mainPanel.Controls.Add(this.resourcesPanel);
            this.mainPanel.Controls.Add(this.itemsTitlePanel);
            this.mainPanel.Controls.Add(this.availableItemsTree);
            this.mainPanel.Controls.Add(this.boughtItemsPanel);
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(451, 376);
            this.mainPanel.TabIndex = 2;
            // 
            // playerNamePanel
            // 
            this.playerNamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerNamePanel.Controls.Add(this.playerNameLabel);
            this.playerNamePanel.Location = new System.Drawing.Point(3, 3);
            this.playerNamePanel.Name = "playerNamePanel";
            this.playerNamePanel.Size = new System.Drawing.Size(445, 34);
            this.playerNamePanel.TabIndex = 4;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(199, 11);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(70, 13);
            this.playerNameLabel.TabIndex = 3;
            this.playerNameLabel.Text = "[player name]";
            this.playerNameLabel.Visible = false;
            // 
            // playerInfoPanel
            // 
            this.playerInfoPanel.ColumnCount = 2;
            this.playerInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerInfoPanel.Controls.Add(this.alliesLabel, 0, 4);
            this.playerInfoPanel.Controls.Add(this.alliesBox, 1, 4);
            this.playerInfoPanel.Controls.Add(this.ageLabel, 0, 3);
            this.playerInfoPanel.Controls.Add(this.colorLabel, 0, 2);
            this.playerInfoPanel.Controls.Add(this.civLabel, 0, 1);
            this.playerInfoPanel.Controls.Add(this.ageBox, 1, 3);
            this.playerInfoPanel.Controls.Add(this.colorBox, 1, 2);
            this.playerInfoPanel.Controls.Add(this.civBox, 1, 1);
            this.playerInfoPanel.Controls.Add(this.playerLabel, 0, 0);
            this.playerInfoPanel.Location = new System.Drawing.Point(3, 43);
            this.playerInfoPanel.Name = "playerInfoPanel";
            this.playerInfoPanel.RowCount = 5;
            this.playerInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3953F));
            this.playerInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3953F));
            this.playerInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3953F));
            this.playerInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3953F));
            this.playerInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.41879F));
            this.playerInfoPanel.Size = new System.Drawing.Size(196, 94);
            this.playerInfoPanel.TabIndex = 0;
            // 
            // alliesLabel
            // 
            this.alliesLabel.AutoSize = true;
            this.alliesLabel.Location = new System.Drawing.Point(3, 68);
            this.alliesLabel.Name = "alliesLabel";
            this.alliesLabel.Size = new System.Drawing.Size(34, 13);
            this.alliesLabel.TabIndex = 3;
            this.alliesLabel.Text = "Allies:";
            // 
            // alliesBox
            // 
            this.alliesBox.FormattingEnabled = true;
            this.alliesBox.Items.AddRange(new object[] {
            "[ally_civ1]",
            "[ally_civ2]",
            "[ally_civ3]"});
            this.alliesBox.Location = new System.Drawing.Point(101, 71);
            this.alliesBox.Name = "alliesBox";
            this.alliesBox.Size = new System.Drawing.Size(70, 17);
            this.alliesBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(3, 51);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(3, 34);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 1;
            this.colorLabel.Text = "Color:";
            // 
            // civLabel
            // 
            this.civLabel.AutoSize = true;
            this.civLabel.Location = new System.Drawing.Point(3, 17);
            this.civLabel.Name = "civLabel";
            this.civLabel.Size = new System.Drawing.Size(59, 13);
            this.civLabel.TabIndex = 2;
            this.civLabel.Text = "Civilization:";
            // 
            // ageBox
            // 
            this.ageBox.AutoSize = true;
            this.ageBox.Location = new System.Drawing.Point(101, 51);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(31, 13);
            this.ageBox.TabIndex = 9;
            this.ageBox.Text = "[age]";
            // 
            // colorBox
            // 
            this.colorBox.AutoSize = true;
            this.colorBox.Location = new System.Drawing.Point(101, 34);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(36, 13);
            this.colorBox.TabIndex = 7;
            this.colorBox.Text = "[color]";
            // 
            // civBox
            // 
            this.civBox.AutoSize = true;
            this.civBox.Location = new System.Drawing.Point(101, 17);
            this.civBox.Name = "civBox";
            this.civBox.Size = new System.Drawing.Size(27, 13);
            this.civBox.TabIndex = 6;
            this.civBox.Text = "[civ]";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(3, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(36, 13);
            this.playerLabel.TabIndex = 11;
            this.playerLabel.Text = "Player";
            // 
            // resourcesPanel
            // 
            this.resourcesPanel.ColumnCount = 4;
            this.resourcesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resourcesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resourcesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resourcesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resourcesPanel.Controls.Add(this.stoneLabel, 0, 4);
            this.resourcesPanel.Controls.Add(this.goldLabel, 0, 3);
            this.resourcesPanel.Controls.Add(this.woodLabel, 0, 2);
            this.resourcesPanel.Controls.Add(this.foodLabel, 0, 1);
            this.resourcesPanel.Controls.Add(this.stoneAmountBox, 1, 4);
            this.resourcesPanel.Controls.Add(this.goldAmountBox, 1, 3);
            this.resourcesPanel.Controls.Add(this.woodAmountBox, 1, 2);
            this.resourcesPanel.Controls.Add(this.foodAmountBox, 1, 1);
            this.resourcesPanel.Controls.Add(this.stoneGatherRateBox, 2, 4);
            this.resourcesPanel.Controls.Add(this.goldGatherRateBox, 2, 3);
            this.resourcesPanel.Controls.Add(this.woodGatherRateBox, 2, 2);
            this.resourcesPanel.Controls.Add(this.foodGatherRateBox, 2, 1);
            this.resourcesPanel.Controls.Add(this.amountLabel, 1, 0);
            this.resourcesPanel.Controls.Add(this.rateLabel, 2, 0);
            this.resourcesPanel.Controls.Add(this.villgersLabel, 3, 0);
            this.resourcesPanel.Controls.Add(this.foodVillagersBox, 3, 1);
            this.resourcesPanel.Controls.Add(this.woodVillagersBox, 3, 2);
            this.resourcesPanel.Controls.Add(this.goldVillagersBox, 3, 3);
            this.resourcesPanel.Controls.Add(this.stoneVillagersBox, 3, 4);
            this.resourcesPanel.Location = new System.Drawing.Point(205, 43);
            this.resourcesPanel.Name = "resourcesPanel";
            this.resourcesPanel.RowCount = 5;
            this.resourcesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resourcesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resourcesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resourcesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resourcesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resourcesPanel.Size = new System.Drawing.Size(243, 94);
            this.resourcesPanel.TabIndex = 0;
            // 
            // stoneLabel
            // 
            this.stoneLabel.AutoSize = true;
            this.stoneLabel.Location = new System.Drawing.Point(3, 72);
            this.stoneLabel.Name = "stoneLabel";
            this.stoneLabel.Size = new System.Drawing.Size(38, 13);
            this.stoneLabel.TabIndex = 3;
            this.stoneLabel.Text = "Stone:";
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.Location = new System.Drawing.Point(3, 54);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(32, 13);
            this.goldLabel.TabIndex = 2;
            this.goldLabel.Text = "Gold:";
            // 
            // woodLabel
            // 
            this.woodLabel.AutoSize = true;
            this.woodLabel.Location = new System.Drawing.Point(3, 36);
            this.woodLabel.Name = "woodLabel";
            this.woodLabel.Size = new System.Drawing.Size(39, 13);
            this.woodLabel.TabIndex = 1;
            this.woodLabel.Text = "Wood:";
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(3, 18);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(34, 13);
            this.foodLabel.TabIndex = 0;
            this.foodLabel.Text = "Food:";
            // 
            // stoneAmountBox
            // 
            this.stoneAmountBox.Location = new System.Drawing.Point(63, 75);
            this.stoneAmountBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stoneAmountBox.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.stoneAmountBox.Name = "stoneAmountBox";
            this.stoneAmountBox.Size = new System.Drawing.Size(49, 20);
            this.stoneAmountBox.TabIndex = 15;
            this.stoneAmountBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // goldAmountBox
            // 
            this.goldAmountBox.Location = new System.Drawing.Point(63, 57);
            this.goldAmountBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.goldAmountBox.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.goldAmountBox.Name = "goldAmountBox";
            this.goldAmountBox.Size = new System.Drawing.Size(49, 20);
            this.goldAmountBox.TabIndex = 14;
            this.goldAmountBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // woodAmountBox
            // 
            this.woodAmountBox.Location = new System.Drawing.Point(63, 39);
            this.woodAmountBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.woodAmountBox.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.woodAmountBox.Name = "woodAmountBox";
            this.woodAmountBox.Size = new System.Drawing.Size(49, 20);
            this.woodAmountBox.TabIndex = 13;
            this.woodAmountBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // foodAmountBox
            // 
            this.foodAmountBox.Location = new System.Drawing.Point(63, 21);
            this.foodAmountBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.foodAmountBox.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.foodAmountBox.Name = "foodAmountBox";
            this.foodAmountBox.Size = new System.Drawing.Size(49, 20);
            this.foodAmountBox.TabIndex = 12;
            this.foodAmountBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // stoneGatherRateBox
            // 
            this.stoneGatherRateBox.DecimalPlaces = 3;
            this.stoneGatherRateBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.stoneGatherRateBox.Location = new System.Drawing.Point(123, 75);
            this.stoneGatherRateBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            196608});
            this.stoneGatherRateBox.Name = "stoneGatherRateBox";
            this.stoneGatherRateBox.Size = new System.Drawing.Size(49, 20);
            this.stoneGatherRateBox.TabIndex = 19;
            // 
            // goldGatherRateBox
            // 
            this.goldGatherRateBox.DecimalPlaces = 3;
            this.goldGatherRateBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.goldGatherRateBox.Location = new System.Drawing.Point(123, 57);
            this.goldGatherRateBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            196608});
            this.goldGatherRateBox.Name = "goldGatherRateBox";
            this.goldGatherRateBox.Size = new System.Drawing.Size(49, 20);
            this.goldGatherRateBox.TabIndex = 18;
            // 
            // woodGatherRateBox
            // 
            this.woodGatherRateBox.DecimalPlaces = 3;
            this.woodGatherRateBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.woodGatherRateBox.Location = new System.Drawing.Point(123, 39);
            this.woodGatherRateBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            196608});
            this.woodGatherRateBox.Name = "woodGatherRateBox";
            this.woodGatherRateBox.Size = new System.Drawing.Size(49, 20);
            this.woodGatherRateBox.TabIndex = 17;
            // 
            // foodGatherRateBox
            // 
            this.foodGatherRateBox.DecimalPlaces = 3;
            this.foodGatherRateBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.foodGatherRateBox.Location = new System.Drawing.Point(123, 21);
            this.foodGatherRateBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            196608});
            this.foodGatherRateBox.Name = "foodGatherRateBox";
            this.foodGatherRateBox.Size = new System.Drawing.Size(49, 20);
            this.foodGatherRateBox.TabIndex = 16;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(63, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 20;
            this.amountLabel.Text = "Amount";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(123, 0);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(43, 13);
            this.rateLabel.TabIndex = 21;
            this.rateLabel.Text = "Rate /s";
            // 
            // villgersLabel
            // 
            this.villgersLabel.AutoSize = true;
            this.villgersLabel.Location = new System.Drawing.Point(183, 0);
            this.villgersLabel.Name = "villgersLabel";
            this.villgersLabel.Size = new System.Drawing.Size(46, 13);
            this.villgersLabel.TabIndex = 22;
            this.villgersLabel.Text = "Villagers";
            // 
            // foodVillagersBox
            // 
            this.foodVillagersBox.Location = new System.Drawing.Point(183, 21);
            this.foodVillagersBox.Name = "foodVillagersBox";
            this.foodVillagersBox.Size = new System.Drawing.Size(51, 20);
            this.foodVillagersBox.TabIndex = 23;
            // 
            // woodVillagersBox
            // 
            this.woodVillagersBox.Location = new System.Drawing.Point(183, 39);
            this.woodVillagersBox.Name = "woodVillagersBox";
            this.woodVillagersBox.Size = new System.Drawing.Size(51, 20);
            this.woodVillagersBox.TabIndex = 24;
            // 
            // goldVillagersBox
            // 
            this.goldVillagersBox.Location = new System.Drawing.Point(183, 57);
            this.goldVillagersBox.Name = "goldVillagersBox";
            this.goldVillagersBox.Size = new System.Drawing.Size(51, 20);
            this.goldVillagersBox.TabIndex = 25;
            // 
            // stoneVillagersBox
            // 
            this.stoneVillagersBox.Location = new System.Drawing.Point(183, 75);
            this.stoneVillagersBox.Name = "stoneVillagersBox";
            this.stoneVillagersBox.Size = new System.Drawing.Size(51, 20);
            this.stoneVillagersBox.TabIndex = 26;
            // 
            // itemsTitlePanel
            // 
            this.itemsTitlePanel.ColumnCount = 2;
            this.itemsTitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.39326F));
            this.itemsTitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.60674F));
            this.itemsTitlePanel.Controls.Add(this.availableItemsLabel, 0, 0);
            this.itemsTitlePanel.Controls.Add(this.ownedItemsLabel, 1, 0);
            this.itemsTitlePanel.Location = new System.Drawing.Point(3, 143);
            this.itemsTitlePanel.Name = "itemsTitlePanel";
            this.itemsTitlePanel.RowCount = 1;
            this.itemsTitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemsTitlePanel.Size = new System.Drawing.Size(445, 16);
            this.itemsTitlePanel.TabIndex = 3;
            // 
            // availableItemsLabel
            // 
            this.availableItemsLabel.AutoSize = true;
            this.availableItemsLabel.Location = new System.Drawing.Point(3, 0);
            this.availableItemsLabel.Name = "availableItemsLabel";
            this.availableItemsLabel.Size = new System.Drawing.Size(78, 13);
            this.availableItemsLabel.TabIndex = 0;
            this.availableItemsLabel.Text = "Available Items";
            // 
            // ownedItemsLabel
            // 
            this.ownedItemsLabel.AutoSize = true;
            this.ownedItemsLabel.Location = new System.Drawing.Point(205, 0);
            this.ownedItemsLabel.Name = "ownedItemsLabel";
            this.ownedItemsLabel.Size = new System.Drawing.Size(69, 13);
            this.ownedItemsLabel.TabIndex = 1;
            this.ownedItemsLabel.Text = "Owned Items";
            // 
            // availableItemsTree
            // 
            this.availableItemsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableItemsTree.Location = new System.Drawing.Point(3, 165);
            this.availableItemsTree.Name = "availableItemsTree";
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
            this.availableItemsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode21,
            treeNode26});
            this.availableItemsTree.Size = new System.Drawing.Size(196, 207);
            this.availableItemsTree.TabIndex = 5;
            // 
            // boughtItemsPanel
            // 
            this.boughtItemsPanel.ColumnCount = 2;
            this.boughtItemsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.boughtItemsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.boughtItemsPanel.Controls.Add(this.techsPanel, 0, 1);
            this.boughtItemsPanel.Controls.Add(this.structuresPanel, 1, 0);
            this.boughtItemsPanel.Controls.Add(this.unitsPanel, 0, 0);
            this.boughtItemsPanel.Controls.Add(this.economyLayoutPanel, 1, 1);
            this.boughtItemsPanel.Location = new System.Drawing.Point(205, 165);
            this.boughtItemsPanel.Name = "boughtItemsPanel";
            this.boughtItemsPanel.RowCount = 2;
            this.boughtItemsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.14563F));
            this.boughtItemsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.85437F));
            this.boughtItemsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.boughtItemsPanel.Size = new System.Drawing.Size(243, 207);
            this.boughtItemsPanel.TabIndex = 0;
            // 
            // techsPanel
            // 
            this.techsPanel.Controls.Add(this.techsLabel);
            this.techsPanel.Controls.Add(this.techsListBox);
            this.techsPanel.Location = new System.Drawing.Point(3, 96);
            this.techsPanel.Name = "techsPanel";
            this.techsPanel.Size = new System.Drawing.Size(115, 108);
            this.techsPanel.TabIndex = 2;
            // 
            // techsLabel
            // 
            this.techsLabel.AutoSize = true;
            this.techsLabel.Location = new System.Drawing.Point(3, 0);
            this.techsLabel.Name = "techsLabel";
            this.techsLabel.Size = new System.Drawing.Size(37, 13);
            this.techsLabel.TabIndex = 3;
            this.techsLabel.Text = "Techs";
            // 
            // techsListBox
            // 
            this.techsListBox.FormattingEnabled = true;
            this.techsListBox.Items.AddRange(new object[] {
            "Loom"});
            this.techsListBox.Location = new System.Drawing.Point(3, 16);
            this.techsListBox.Name = "techsListBox";
            this.techsListBox.Size = new System.Drawing.Size(112, 82);
            this.techsListBox.TabIndex = 4;
            // 
            // structuresPanel
            // 
            this.structuresPanel.Controls.Add(this.structuresLabel);
            this.structuresPanel.Controls.Add(this.structuresListBox);
            this.structuresPanel.Location = new System.Drawing.Point(124, 3);
            this.structuresPanel.Name = "structuresPanel";
            this.structuresPanel.Size = new System.Drawing.Size(116, 87);
            this.structuresPanel.TabIndex = 1;
            // 
            // structuresLabel
            // 
            this.structuresLabel.AutoSize = true;
            this.structuresLabel.Location = new System.Drawing.Point(3, 0);
            this.structuresLabel.Name = "structuresLabel";
            this.structuresLabel.Size = new System.Drawing.Size(55, 13);
            this.structuresLabel.TabIndex = 3;
            this.structuresLabel.Text = "Structures";
            // 
            // structuresListBox
            // 
            this.structuresListBox.FormattingEnabled = true;
            this.structuresListBox.Items.AddRange(new object[] {
            "Town Center",
            "House",
            "House",
            "Barracks",
            "Lumber Camp",
            "Mining Camp",
            "House",
            "House"});
            this.structuresListBox.Location = new System.Drawing.Point(3, 16);
            this.structuresListBox.Name = "structuresListBox";
            this.structuresListBox.Size = new System.Drawing.Size(113, 69);
            this.structuresListBox.TabIndex = 4;
            // 
            // unitsPanel
            // 
            this.unitsPanel.Controls.Add(this.unitsLabel);
            this.unitsPanel.Controls.Add(this.unitsListBox);
            this.unitsPanel.Location = new System.Drawing.Point(3, 3);
            this.unitsPanel.Name = "unitsPanel";
            this.unitsPanel.Size = new System.Drawing.Size(115, 87);
            this.unitsPanel.TabIndex = 0;
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(3, 0);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(31, 13);
            this.unitsLabel.TabIndex = 3;
            this.unitsLabel.Text = "Units";
            // 
            // unitsListBox
            // 
            this.unitsListBox.FormattingEnabled = true;
            this.unitsListBox.Items.AddRange(new object[] {
            "Militia",
            "Militia",
            "Militia"});
            this.unitsListBox.Location = new System.Drawing.Point(3, 16);
            this.unitsListBox.Name = "unitsListBox";
            this.unitsListBox.Size = new System.Drawing.Size(112, 69);
            this.unitsListBox.TabIndex = 4;
            // 
            // economyLayoutPanel
            // 
            this.economyLayoutPanel.Controls.Add(this.gatherersLabel);
            this.economyLayoutPanel.Controls.Add(this.foodGatherersPanel);
            this.economyLayoutPanel.Controls.Add(this.goldGatherersPanel);
            this.economyLayoutPanel.Location = new System.Drawing.Point(124, 96);
            this.economyLayoutPanel.Name = "economyLayoutPanel";
            this.economyLayoutPanel.Size = new System.Drawing.Size(116, 98);
            this.economyLayoutPanel.TabIndex = 3;
            // 
            // gatherersLabel
            // 
            this.gatherersLabel.AutoSize = true;
            this.gatherersLabel.Location = new System.Drawing.Point(3, 0);
            this.gatherersLabel.Name = "gatherersLabel";
            this.gatherersLabel.Size = new System.Drawing.Size(53, 13);
            this.gatherersLabel.TabIndex = 0;
            this.gatherersLabel.Text = "Gatherers";
            // 
            // foodGatherersPanel
            // 
            this.foodGatherersPanel.ColumnCount = 3;
            this.foodGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.foodGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.foodGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.foodGatherersPanel.Controls.Add(this.fishTrapsBox, 2, 2);
            this.foodGatherersPanel.Controls.Add(this.deepFishingBox, 1, 2);
            this.foodGatherersPanel.Controls.Add(this.shoreFishingBox, 0, 2);
            this.foodGatherersPanel.Controls.Add(this.foragersBox, 2, 1);
            this.foodGatherersPanel.Controls.Add(this.farmersBox, 1, 1);
            this.foodGatherersPanel.Controls.Add(this.shepherdsBox, 0, 1);
            this.foodGatherersPanel.Controls.Add(this.huntersBox, 2, 0);
            this.foodGatherersPanel.Controls.Add(this.foodGatheresLabel, 0, 0);
            this.foodGatherersPanel.Location = new System.Drawing.Point(3, 16);
            this.foodGatherersPanel.Name = "foodGatherersPanel";
            this.foodGatherersPanel.RowCount = 3;
            this.foodGatherersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.foodGatherersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.foodGatherersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.foodGatherersPanel.Size = new System.Drawing.Size(113, 51);
            this.foodGatherersPanel.TabIndex = 12;
            // 
            // fishTrapsBox
            // 
            this.fishTrapsBox.Location = new System.Drawing.Point(77, 37);
            this.fishTrapsBox.Name = "fishTrapsBox";
            this.fishTrapsBox.Size = new System.Drawing.Size(27, 20);
            this.fishTrapsBox.TabIndex = 6;
            // 
            // deepFishingBox
            // 
            this.deepFishingBox.Location = new System.Drawing.Point(40, 37);
            this.deepFishingBox.Name = "deepFishingBox";
            this.deepFishingBox.Size = new System.Drawing.Size(27, 20);
            this.deepFishingBox.TabIndex = 9;
            // 
            // shoreFishingBox
            // 
            this.shoreFishingBox.Location = new System.Drawing.Point(3, 37);
            this.shoreFishingBox.Name = "shoreFishingBox";
            this.shoreFishingBox.Size = new System.Drawing.Size(27, 20);
            this.shoreFishingBox.TabIndex = 11;
            // 
            // foragersBox
            // 
            this.foragersBox.Location = new System.Drawing.Point(77, 20);
            this.foragersBox.Name = "foragersBox";
            this.foragersBox.Size = new System.Drawing.Size(27, 20);
            this.foragersBox.TabIndex = 10;
            // 
            // farmersBox
            // 
            this.farmersBox.Location = new System.Drawing.Point(40, 20);
            this.farmersBox.Name = "farmersBox";
            this.farmersBox.Size = new System.Drawing.Size(27, 20);
            this.farmersBox.TabIndex = 3;
            // 
            // shepherdsBox
            // 
            this.shepherdsBox.Location = new System.Drawing.Point(3, 20);
            this.shepherdsBox.Name = "shepherdsBox";
            this.shepherdsBox.Size = new System.Drawing.Size(27, 20);
            this.shepherdsBox.TabIndex = 4;
            // 
            // huntersBox
            // 
            this.huntersBox.Location = new System.Drawing.Point(77, 3);
            this.huntersBox.Name = "huntersBox";
            this.huntersBox.Size = new System.Drawing.Size(27, 20);
            this.huntersBox.TabIndex = 5;
            // 
            // foodGatheresLabel
            // 
            this.foodGatheresLabel.AutoSize = true;
            this.foodGatheresLabel.Location = new System.Drawing.Point(3, 0);
            this.foodGatheresLabel.Name = "foodGatheresLabel";
            this.foodGatheresLabel.Size = new System.Drawing.Size(31, 13);
            this.foodGatheresLabel.TabIndex = 2;
            this.foodGatheresLabel.Text = "Food";
            // 
            // goldGatherersPanel
            // 
            this.goldGatherersPanel.ColumnCount = 3;
            this.goldGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.goldGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.goldGatherersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.goldGatherersPanel.Controls.Add(this.goldGatherersLabel, 0, 0);
            this.goldGatherersPanel.Controls.Add(this.relicsBox, 1, 0);
            this.goldGatherersPanel.Controls.Add(this.tradeCartsBox, 2, 0);
            this.goldGatherersPanel.Location = new System.Drawing.Point(3, 73);
            this.goldGatherersPanel.Name = "goldGatherersPanel";
            this.goldGatherersPanel.RowCount = 1;
            this.goldGatherersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.goldGatherersPanel.Size = new System.Drawing.Size(113, 25);
            this.goldGatherersPanel.TabIndex = 9;
            // 
            // goldGatherersLabel
            // 
            this.goldGatherersLabel.AutoSize = true;
            this.goldGatherersLabel.Location = new System.Drawing.Point(3, 0);
            this.goldGatherersLabel.Name = "goldGatherersLabel";
            this.goldGatherersLabel.Size = new System.Drawing.Size(29, 13);
            this.goldGatherersLabel.TabIndex = 0;
            this.goldGatherersLabel.Text = "Gold";
            // 
            // relicsBox
            // 
            this.relicsBox.Location = new System.Drawing.Point(40, 3);
            this.relicsBox.Name = "relicsBox";
            this.relicsBox.Size = new System.Drawing.Size(31, 20);
            this.relicsBox.TabIndex = 1;
            // 
            // tradeCartsBox
            // 
            this.tradeCartsBox.Location = new System.Drawing.Point(77, 3);
            this.tradeCartsBox.Name = "tradeCartsBox";
            this.tradeCartsBox.Size = new System.Drawing.Size(27, 20);
            this.tradeCartsBox.TabIndex = 2;
            // 
            // mainPanel
            // 
            //this.panelContainer.Add(mainPanel);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(458, 383);
            this.mainPanel.ResumeLayout(false);
            this.playerNamePanel.ResumeLayout(false);
            this.playerNamePanel.PerformLayout();
            this.playerInfoPanel.ResumeLayout(false);
            this.playerInfoPanel.PerformLayout();
            this.resourcesPanel.ResumeLayout(false);
            this.resourcesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoneAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneGatherRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldGatherRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodGatherRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGatherRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodVillagersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodVillagersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldVillagersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneVillagersBox)).EndInit();
            this.itemsTitlePanel.ResumeLayout(false);
            this.itemsTitlePanel.PerformLayout();
            this.boughtItemsPanel.ResumeLayout(false);
            this.techsPanel.ResumeLayout(false);
            this.techsPanel.PerformLayout();
            this.structuresPanel.ResumeLayout(false);
            this.structuresPanel.PerformLayout();
            this.unitsPanel.ResumeLayout(false);
            this.unitsPanel.PerformLayout();
            this.economyLayoutPanel.ResumeLayout(false);
            this.economyLayoutPanel.PerformLayout();
            this.foodGatherersPanel.ResumeLayout(false);
            this.foodGatherersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fishTrapsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepFishingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoreFishingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foragersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shepherdsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huntersBox)).EndInit();
            this.goldGatherersPanel.ResumeLayout(false);
            this.goldGatherersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relicsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeCartsBox)).EndInit();

        }

        #endregion

        private FlowLayoutPanel mainPanel;
        private Panel playerNamePanel;
        private Label playerNameLabel;
        private TableLayoutPanel playerInfoPanel;
        private Label alliesLabel;
        private ListBox alliesBox;
        private Label ageLabel;
        private Label colorLabel;
        private Label civLabel;
        private Label ageBox;
        private Label colorBox;
        private Label civBox;
        private Label playerLabel;
        private TableLayoutPanel resourcesPanel;
        private Label stoneLabel;
        private Label goldLabel;
        private Label woodLabel;
        private Label foodLabel;
        private NumericUpDown stoneAmountBox;
        private NumericUpDown goldAmountBox;
        private NumericUpDown woodAmountBox;
        private NumericUpDown foodAmountBox;
        private NumericUpDown stoneGatherRateBox;
        private NumericUpDown goldGatherRateBox;
        private NumericUpDown woodGatherRateBox;
        private NumericUpDown foodGatherRateBox;
        private Label amountLabel;
        private Label rateLabel;
        private Label villgersLabel;
        private NumericUpDown foodVillagersBox;
        private NumericUpDown woodVillagersBox;
        private NumericUpDown goldVillagersBox;
        private NumericUpDown stoneVillagersBox;
        private TableLayoutPanel itemsTitlePanel;
        private Label availableItemsLabel;
        private Label ownedItemsLabel;
        private TreeView availableItemsTree;
        private TableLayoutPanel boughtItemsPanel;
        private FlowLayoutPanel techsPanel;
        private Label techsLabel;
        private ListBox techsListBox;
        private FlowLayoutPanel structuresPanel;
        private Label structuresLabel;
        private ListBox structuresListBox;
        private FlowLayoutPanel unitsPanel;
        private Label unitsLabel;
        private ListBox unitsListBox;
        private FlowLayoutPanel economyLayoutPanel;
        private Label gatherersLabel;
        private TableLayoutPanel foodGatherersPanel;
        private NumericUpDown fishTrapsBox;
        private NumericUpDown deepFishingBox;
        private NumericUpDown shoreFishingBox;
        private NumericUpDown foragersBox;
        private NumericUpDown farmersBox;
        private NumericUpDown shepherdsBox;
        private NumericUpDown huntersBox;
        private Label foodGatheresLabel;
        private TableLayoutPanel goldGatherersPanel;
        private Label goldGatherersLabel;
        private NumericUpDown relicsBox;
        private NumericUpDown tradeCartsBox;
    }
}
