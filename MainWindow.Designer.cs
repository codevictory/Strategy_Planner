namespace Object_OrientatedProgramming2018
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.debugRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.debugRichTextBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(433, 324);
            this.MainPanel.TabIndex = 0;
            // 
            // debugRichTextBox
            // 
            this.debugRichTextBox.AcceptsTab = true;
            this.debugRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.debugRichTextBox.Name = "debugRichTextBox";
            this.debugRichTextBox.Size = new System.Drawing.Size(433, 324);
            this.debugRichTextBox.TabIndex = 0;
            this.debugRichTextBox.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 324);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainWindow";
            this.Text = "Object-Orientated Programming Course 2018 ";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.RichTextBox debugRichTextBox;

        
    };
}

