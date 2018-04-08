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
            decimal population, uint poplimit)
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

                Civilization civ = new Civilization(
                    values[0], //string name 
                    values[1], //string type
                    values[2], //string uniq_units
                    values[3], //string uniq_techs
                    values[4], //string team_bonus
                    values[5]);//string civ_bonus

                civilizations.Add(civ);
            }
            
            civ_reader.Close();

            var structure_reader = new StreamReader(@"InitData\structures.csv");

            structure_reader.ReadLine();

            while (!structure_reader.EndOfStream)
            {
                var line = structure_reader.ReadLine();
                var values = line.Split(';');
                Item structure = new Item(
                    values[0],                      //string name
                    Convert.ToDecimal(values[1], CultureInfo.InvariantCulture.NumberFormat),    //decimal food
                    Convert.ToDecimal(values[2], CultureInfo.InvariantCulture.NumberFormat),    //decimal wood
                    Convert.ToDecimal(values[3], CultureInfo.InvariantCulture.NumberFormat),    //decimal gold
                    Convert.ToDecimal(values[4], CultureInfo.InvariantCulture.NumberFormat),    //decimal stone
                    Convert.ToDecimal(values[5], CultureInfo.InvariantCulture.NumberFormat),    //decimal build_time
                    Convert.ToDecimal(values[6], CultureInfo.InvariantCulture.NumberFormat),    //double reload_time
                    Convert.ToDecimal(values[7], CultureInfo.InvariantCulture.NumberFormat),    //decimal line_of_sight
                    Convert.ToDecimal(values[8], CultureInfo.InvariantCulture.NumberFormat),    //decimal init_health_points
                    Convert.ToDecimal(values[9], CultureInfo.InvariantCulture.NumberFormat),    //double min_range
                    Convert.ToDecimal(values[10], CultureInfo.InvariantCulture.NumberFormat),   //double max_range
                    Convert.ToDecimal(values[11], CultureInfo.InvariantCulture.NumberFormat),   //decimal attack
                    Convert.ToDecimal(values[12], CultureInfo.InvariantCulture.NumberFormat),    //decimal melee_armor
                    Convert.ToDecimal(values[13], CultureInfo.InvariantCulture.NumberFormat),    //decimal pierce_armor
                    Convert.ToDecimal(values[14], CultureInfo.InvariantCulture.NumberFormat),   //decimal garrison
                    values[15],                     //string special
                    values[16]);                    //string age
                structures.Add(structure);
            }
            structure_reader.Close();

            var tech_reader = new StreamReader(@"InitData\techs.csv");

            tech_reader.ReadLine();

            while (!tech_reader.EndOfStream)
            {
                var line = tech_reader.ReadLine();
                var values = line.Split(';');
                Item tech = new Item(
                    values[0],                      //string name
                    Convert.ToDecimal(values[1], CultureInfo.InvariantCulture.NumberFormat),    //decimal food
                    Convert.ToDecimal(values[2], CultureInfo.InvariantCulture.NumberFormat),    //decimal wood
                    Convert.ToDecimal(values[3], CultureInfo.InvariantCulture.NumberFormat),    //decimal gold
                    Convert.ToDecimal(values[4], CultureInfo.InvariantCulture.NumberFormat),    //decimal stone
                    Convert.ToDecimal(values[5], CultureInfo.InvariantCulture.NumberFormat),    //decimal build_time
                    values[6],                      //string effect
                    values[7],                      //string building
                    values[8]);                     //string age

                techs.Add(tech);
            }

            tech_reader.Close();

            var unit_reader = new StreamReader(@"InitData\units.csv");

            unit_reader.ReadLine();

            while (!unit_reader.EndOfStream)
            {
                var line = unit_reader.ReadLine();
                var values = line.Split(';');
                Item unit = new Item(
                    values[0],                      //string name
                    Convert.ToDecimal(values[1], CultureInfo.InvariantCulture.NumberFormat),    //decimal food
                    Convert.ToDecimal(values[2], CultureInfo.InvariantCulture.NumberFormat),    //decimal wood
                    Convert.ToDecimal(values[3], CultureInfo.InvariantCulture.NumberFormat),    //decimal gold
                    Convert.ToDecimal(values[4], CultureInfo.InvariantCulture.NumberFormat),    //decimal stone
                    Convert.ToDecimal(values[5], CultureInfo.InvariantCulture.NumberFormat),    //decimal build_time
                    Convert.ToDecimal(values[6], CultureInfo.InvariantCulture.NumberFormat), //decimal reload_time
                    Convert.ToDecimal(values[7], CultureInfo.InvariantCulture.NumberFormat), //decimal attack_delay
                    Convert.ToDecimal(values[8], CultureInfo.InvariantCulture.NumberFormat), //decimal movement_rate
                    Convert.ToDecimal(values[9], CultureInfo.InvariantCulture.NumberFormat),    //decimal line_of_sight
                    Convert.ToDecimal(values[10], CultureInfo.InvariantCulture.NumberFormat),   //decimal init_health_points
                    Convert.ToDecimal(values[11], CultureInfo.InvariantCulture.NumberFormat),    //decimal min_range
                    Convert.ToDecimal(values[12], CultureInfo.InvariantCulture.NumberFormat),    //decimal max_range
                    Convert.ToDecimal(values[13], CultureInfo.InvariantCulture.NumberFormat),   //decimal attack
                    Convert.ToDecimal(values[14], CultureInfo.InvariantCulture.NumberFormat),    //decimal melee_armor
                    Convert.ToDecimal(values[15], CultureInfo.InvariantCulture.NumberFormat),    //decimal pierce_armor
                    Convert.ToDecimal(values[16], CultureInfo.InvariantCulture.NumberFormat),    //decimal garrison
                    values[17],                     //string building
                    values[18],                     //string age
                    values[19]);                    //string special
                    values[20]);                    //string attack_bonus
                    values[21]);                    //string armor_bonuus
                    values[22]);                    //string type
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
