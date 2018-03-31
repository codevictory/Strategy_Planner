using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientatedProgramming2018
{
    class Game
    {
        private string name;
        bool expansions;
        string map_style;
        string location;
        string map_size;
        string difficulty;
        string resources;
        uint pop_limit;
        string reveal_map;
        string start_age;
        string end_age;
        string treaty_length;
        string victory_condition;
        bool team_together;
        bool lock_teams;
        bool all_tech;

        private int game_time;

        List<Player> players = new List<Player>();
        List<Item> techs = new List<Item>();
        List<Item> structures = new List<Item>();
        List<Item> units = new List<Item>();
        List<Civilization> civilizations = new List<Civilization>();


        public Game(string name, bool expansions, string map_style, string location, string map_size, string difficulty, string resources, uint pop_limit, string reveal_map, string start_age, string end_age, string treaty_length, string victory_condition, bool team_together, bool lock_teams, bool all_tech)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.expansions = expansions;
            this.map_style = map_style ?? throw new ArgumentNullException(nameof(map_style));
            this.location = location ?? throw new ArgumentNullException(nameof(location));
            this.map_size = map_size ?? throw new ArgumentNullException(nameof(map_size));
            this.difficulty = difficulty ?? throw new ArgumentNullException(nameof(difficulty));
            this.resources = resources ?? throw new ArgumentNullException(nameof(resources));
            this.pop_limit = pop_limit;
            this.reveal_map = reveal_map ?? throw new ArgumentNullException(nameof(reveal_map));
            this.start_age = start_age ?? throw new ArgumentNullException(nameof(start_age));
            this.end_age = end_age ?? throw new ArgumentNullException(nameof(end_age));
            this.treaty_length = treaty_length ?? throw new ArgumentNullException(nameof(treaty_length));
            this.victory_condition = victory_condition ?? throw new ArgumentNullException(nameof(victory_condition));
            this.team_together = team_together;
            this.lock_teams = lock_teams;
            this.all_tech = all_tech;
            game_time = 0;

            ParseItemLists();
        }

        public int Game_time { get => game_time; set => game_time = value; }

        public void InitPlayer(int number, string color, string civ, int food, int wood, int gold, int stone, 
            float population, uint poplimit)
        {
            Player player = new Player(number, color, civ, food, wood, gold, stone, population, poplimit, 
                units, structures, techs);
            players.Add(player);
        }

        public Player GetPlayer(int number)
        {
            return players.Single(n => n.Number == number);
        }

        internal void ParseItemLists()
        {

            var civ_reader = new StreamReader(@"InitData\civilizations.csv");


            civ_reader.ReadLine();

            while (!civ_reader.EndOfStream)
            {
                var line = civ_reader.ReadLine();
                var values = line.Split(';');

                Civilization civ = new Civilization(values[0], values[1], values[2], values[3], values[4], values[5]);

                civilizations.Add(civ);
            }
            
            civ_reader.Close();

            var structure_reader = new StreamReader(@"InitData\structures.csv");

            structure_reader.ReadLine();

            while (!structure_reader.EndOfStream)
            {
                var line = structure_reader.ReadLine();
                var values = line.Split(';');
                Item structure = new Item(values[0], Convert.ToUInt32(values[1]), Convert.ToUInt32(values[2]), 
                    Convert.ToUInt32(values[3]), Convert.ToUInt32(values[4]), Convert.ToUInt32(values[5]), 
                    Convert.ToUInt32(values[6]), Convert.ToUInt32(values[7]), Convert.ToUInt32(values[8]), 
                    Convert.ToUInt32(values[9]), Convert.ToInt32(values[10]), Convert.ToInt32(values[11]), 
                    Convert.ToUInt32(values[12]), values[13], values[14]);
                structures.Add(structure);
            }

            structure_reader.Close();

            var tech_reader = new StreamReader(@"InitData\techs.csv");

            tech_reader.ReadLine();

            while (!tech_reader.EndOfStream)
            {
                var line = tech_reader.ReadLine();
                var values = line.Split(';');
                Item tech = new Item(values[0], Convert.ToUInt32(values[1]), Convert.ToUInt32(values[2]), 
                    Convert.ToUInt32(values[3]), Convert.ToUInt32(values[4]), Convert.ToUInt32(values[5]), 
                    values[6], values[7], values[8]);

                techs.Add(tech);
                
            }

            tech_reader.Close();

            var unit_reader = new StreamReader(@"InitData\units.csv");

            unit_reader.ReadLine();

            while (!unit_reader.EndOfStream)
            {
                var line = unit_reader.ReadLine();
                var values = line.Split(';');
                Item unit = new Item(values[0], Convert.ToUInt32(values[1]), Convert.ToUInt32(values[2]), 
                    Convert.ToUInt32(values[3]), Convert.ToUInt32(values[4]), Convert.ToUInt32(values[5]), 
                    float.Parse(values[6], CultureInfo.InvariantCulture.NumberFormat), float.Parse(values[7], 
                    CultureInfo.InvariantCulture.NumberFormat), float.Parse(values[8], 
                    CultureInfo.InvariantCulture.NumberFormat), Convert.ToUInt32(values[9]), 
                    Convert.ToUInt32(values[10]), float.Parse(values[11], CultureInfo.InvariantCulture.NumberFormat), 
                    float.Parse(values[12], CultureInfo.InvariantCulture.NumberFormat), Convert.ToUInt32(values[13]), 
                    Convert.ToInt32(values[14]), Convert.ToInt32(values[15]), values[16], values[17], values[18]);

                units.Add(unit);
                
            }
            unit_reader.Close();
        }

        public string StructuresToString()
        {
            string data = "";
            foreach (Object item in structures)
                data += item.ToString() + "\n";
            return data;
        }

        public string UnitsToString()
        {
            string data = "";
            foreach (Item item in units)
                data += item.ToString() + "\n";
            return data;
        }

        public string TechsToString()
        {
            string data = "";
            foreach (Item item in techs)
                data += item.ToString() + "\n";
            return data;
        }

        public string CivilizationsToString()
        {
            string data = "";
            foreach (Civilization civ in civilizations)
                data += civ.ToString() + "\n";
            return data;
        }

        public string ItemNamesToString()
        {
            string data = "";
            foreach (Item item in units)
                data += item.Name + "\n";
            foreach (Item item in structures)
                data += item.Name + "\n";
            foreach (Item item in techs)
                data += item.Name + "\n";
            foreach (Civilization item in civilizations)
                data += item.Name + "\n";
            return data;
        }

        public override string ToString()
        {
            return "Game:\n\n" + name + "\n" + expansions + "\n" + map_style + "\n" + location + "\n" + map_size + "\n" + difficulty + "\n" + resources + "\n" + pop_limit + "\n" + reveal_map + "\n" + start_age + "\n" + end_age + "\n" + treaty_length + "\n" + victory_condition + "\n" + team_together + "\n" + lock_teams + "\n" + all_tech;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
