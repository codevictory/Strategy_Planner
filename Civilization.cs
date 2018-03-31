using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientatedProgramming2018
{
    class Civilization
    {
        private string name;
        private string type;
        private string uniq_units;
        private string uniq_techs;
        private string team_bonus;
        private string civ_bonus;

        public Civilization(string name, string type, string uniq_units, string uniq_techs, string team_bonus, string civ_bonus)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.uniq_units = uniq_units ?? throw new ArgumentNullException(nameof(uniq_units));
            this.uniq_techs = uniq_techs ?? throw new ArgumentNullException(nameof(uniq_techs));
            this.team_bonus = team_bonus ?? throw new ArgumentNullException(nameof(team_bonus));
            this.civ_bonus = civ_bonus ?? throw new ArgumentNullException(nameof(civ_bonus));
        }

        public string Name { get => name; }
        public string Type { get => type; }
        public string Uniq_units { get => uniq_units; }
        public string Uniq_techs { get => uniq_techs; }
        public string Team_bonus { get => team_bonus; }
        public string Civ_bonus { get => civ_bonus; }

        public override string ToString()
        {
            return name + "\t" + type + " | " + uniq_units + " | "
                + uniq_techs + " | " + team_bonus + " | " + civ_bonus;
        }


    }
}
