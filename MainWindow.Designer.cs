namespace StrategyPlanner
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBarStrip = new System.Windows.Forms.ToolStripProgressBar();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gameTimeLabel = new System.Windows.Forms.Label();
            this.gameInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.timeSecsBox = new System.Windows.Forms.NumericUpDown();
            this.timeMinsBox = new System.Windows.Forms.NumericUpDown();
            this.timeHoursBox = new System.Windows.Forms.NumericUpDown();
            this.playersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.gameInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSecsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeHoursBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(747, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "Main menu strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.newPlayerToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.saveGameAsToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "File...";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newGameToolStripMenuItem.Text = "New Game...";
            // 
            // newPlayerToolStripMenuItem
            // 
            this.newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            this.newPlayerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newPlayerToolStripMenuItem.Text = "New Player...";
            this.newPlayerToolStripMenuItem.Click += new System.EventHandler(this.newPlayerToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            // 
            // saveGameAsToolStripMenuItem
            // 
            this.saveGameAsToolStripMenuItem.Name = "saveGameAsToolStripMenuItem";
            this.saveGameAsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveGameAsToolStripMenuItem.Text = "Save Game As...";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionInfoToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionInfoToolStripMenuItem
            // 
            this.versionInfoToolStripMenuItem.Name = "versionInfoToolStripMenuItem";
            this.versionInfoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.versionInfoToolStripMenuItem.Text = "Version Info";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarStrip});
            this.statusStrip.Location = new System.Drawing.Point(0, 547);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(747, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // progressBarStrip
            // 
            this.progressBarStrip.Name = "progressBarStrip";
            this.progressBarStrip.Size = new System.Drawing.Size(100, 16);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.gameTimeLabel);
            this.mainPanel.Controls.Add(this.gameInfoPanel);
            this.mainPanel.Controls.Add(this.playersPanel);
            this.mainPanel.Controls.Add(this.logoBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(747, 523);
            this.mainPanel.TabIndex = 6;
            // 
            // gameTimeLabel
            // 
            this.gameTimeLabel.AutoSize = true;
            this.gameTimeLabel.Location = new System.Drawing.Point(236, 7);
            this.gameTimeLabel.Name = "gameTimeLabel";
            this.gameTimeLabel.Size = new System.Drawing.Size(64, 13);
            this.gameTimeLabel.TabIndex = 2;
            this.gameTimeLabel.Text = "Game Time:";
            // 
            // gameInfoPanel
            // 
            this.gameInfoPanel.ColumnCount = 3;
            this.gameInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.gameInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.gameInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gameInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gameInfoPanel.Controls.Add(this.timeSecsBox, 2, 0);
            this.gameInfoPanel.Controls.Add(this.timeMinsBox, 1, 0);
            this.gameInfoPanel.Controls.Add(this.timeHoursBox, 0, 0);
            this.gameInfoPanel.Location = new System.Drawing.Point(230, 26);
            this.gameInfoPanel.Name = "gameInfoPanel";
            this.gameInfoPanel.RowCount = 1;
            this.gameInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameInfoPanel.Size = new System.Drawing.Size(122, 28);
            this.gameInfoPanel.TabIndex = 1;
            // 
            // timeSecsBox
            // 
            this.timeSecsBox.Location = new System.Drawing.Point(83, 3);
            this.timeSecsBox.Name = "timeSecsBox";
            this.timeSecsBox.Size = new System.Drawing.Size(34, 20);
            this.timeSecsBox.TabIndex = 3;
            // 
            // timeMinsBox
            // 
            this.timeMinsBox.Location = new System.Drawing.Point(43, 3);
            this.timeMinsBox.Name = "timeMinsBox";
            this.timeMinsBox.Size = new System.Drawing.Size(34, 20);
            this.timeMinsBox.TabIndex = 2;
            // 
            // timeHoursBox
            // 
            this.timeHoursBox.Location = new System.Drawing.Point(3, 3);
            this.timeHoursBox.Name = "timeHoursBox";
            this.timeHoursBox.Size = new System.Drawing.Size(34, 20);
            this.timeHoursBox.TabIndex = 1;
            // 
            // playersPanel
            // 
            this.playersPanel.AutoScroll = true;
            this.playersPanel.AutoSize = true;
            this.playersPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playersPanel.BackColor = System.Drawing.SystemColors.Control;
            this.playersPanel.Location = new System.Drawing.Point(0, 74);
            this.playersPanel.MaximumSize = new System.Drawing.Size(1500, 0);
            this.playersPanel.Name = "playersPanel";
            this.playersPanel.Size = new System.Drawing.Size(0, 0);
            this.playersPanel.TabIndex = 0;
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(0, 1);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(224, 59);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(747, 569);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainWindow";
            this.Text = "Strategy Planner alpha1.0";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.gameInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeSecsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeHoursBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBarStrip;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.FlowLayoutPanel playersPanel;
        private System.Windows.Forms.TableLayoutPanel gameInfoPanel;
        private System.Windows.Forms.NumericUpDown timeSecsBox;
        private System.Windows.Forms.NumericUpDown timeMinsBox;
        private System.Windows.Forms.NumericUpDown timeHoursBox;
        private System.Windows.Forms.Label gameTimeLabel;
    };
}

