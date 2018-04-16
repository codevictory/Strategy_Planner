using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPlanner
{
    abstract class APlayer : IGUIPanel
    {
        protected List<Item> units = new List<Item>();
        protected List<Item> structures = new List<Item>();
        protected List<Item> techs = new List<Item>();

        public void CreatePanel(object player)
        {
        }
    }
}
