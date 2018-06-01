namespace StrategyPlanner
{
    partial class InitPlayerPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.civilizationLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.civBox = new System.Windows.Forms.ComboBox();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.teamBox = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBox)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(184, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(87, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "New Player";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(3, 50);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 2;
            this.colorLabel.Text = "Color:";
            // 
            // civilizationLabel
            // 
            this.civilizationLabel.AutoSize = true;
            this.civilizationLabel.Location = new System.Drawing.Point(3, 25);
            this.civilizationLabel.Name = "civilizationLabel";
            this.civilizationLabel.Size = new System.Drawing.Size(59, 13);
            this.civilizationLabel.TabIndex = 3;
            this.civilizationLabel.Text = "Civilization: ";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(3, 75);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(37, 13);
            this.teamLabel.TabIndex = 4;
            this.teamLabel.Text = "Team:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.08759F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.91241F));
            this.tableLayoutPanel1.Controls.Add(this.civBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.civilizationLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.colorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.teamLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.colorBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.teamBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(87, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 100);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // civBox
            // 
            this.civBox.FormattingEnabled = true;
            this.civBox.Items.AddRange(new object[] {
            "Franks",
            "Britons",
            "Byzantines"});
            this.civBox.Location = new System.Drawing.Point(68, 28);
            this.civBox.Name = "civBox";
            this.civBox.Size = new System.Drawing.Size(203, 21);
            this.civBox.TabIndex = 10;
            this.civBox.Text = "[civilization]";
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "red",
            "blue",
            "green"});
            this.colorBox.Location = new System.Drawing.Point(68, 53);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(203, 21);
            this.colorBox.TabIndex = 11;
            this.colorBox.Text = "[color]";
            // 
            // teamBox
            // 
            this.teamBox.Location = new System.Drawing.Point(68, 78);
            this.teamBox.Name = "teamBox";
            this.teamBox.Size = new System.Drawing.Size(44, 20);
            this.teamBox.TabIndex = 12;
            this.teamBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(68, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(203, 20);
            this.nameBox.TabIndex = 13;
            this.nameBox.Text = "[player name]";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(79, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(70, 23);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 2;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Controls.Add(this.cancelButton, 0, 0);
            this.buttonPanel.Controls.Add(this.createButton, 1, 0);
            this.buttonPanel.Location = new System.Drawing.Point(155, 355);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Size = new System.Drawing.Size(152, 31);
            this.buttonPanel.TabIndex = 12;
            // 
            // InitPlayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.titleLabel);
            this.Name = "InitPlayerPanel";
            this.Size = new System.Drawing.Size(464, 389);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBox)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label civilizationLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox civBox;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.NumericUpDown teamBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;

        protected void Empty()
        {
            titleLabel.Dispose();
            nameLabel.Dispose();
            colorLabel.Dispose();
            civilizationLabel.Dispose();
            teamLabel.Dispose();
            tableLayoutPanel1.Dispose();
            civBox.Dispose();
            colorBox.Dispose();
            teamBox.Dispose();
            nameBox.Dispose();
            createButton.Dispose();
            cancelButton.Dispose();
            buttonPanel.Dispose();
        }
    }
}
