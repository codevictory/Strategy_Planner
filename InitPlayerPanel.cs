using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPlanner
{
    public partial class InitPlayerPanel : UserControl
    {
        public InitPlayerPanel()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            
            Controls.Add(new PlayerPanel());
            Empty();
            Controls.Remove(this);
            
        }
    }
}
