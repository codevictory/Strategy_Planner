using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientatedProgramming2018
{
    class Player
    {
        private int number;
        private string color;
        private string civ;
        private int food;
        private int wood;
        private int gold;
        private int stone;
        private decimal population;
        private uint pop_limit;
        //TODO allies List<T>

        private enum PlayerColor { blue, red, green, yellow, cyan, violet, grey, orange };

        List<Item> units = new List<Item>();
        List<Item> structures = new List<Item>();
        List<Item> techs = new List<Item>();

        public int Number { get => number; set => number = value; }
        public string Color { get => color; set => color = value; }
        public string Civ { get => civ; set => civ = value; }
        public int Food { get => food; set => food = value; }
        public int Wood { get => wood; set => wood = value; }
        public int Gold { get => gold; set => gold = value; }
        public int Stone { get => stone; set => stone = value; }
        public decimal Population { get => population; set => population = value; }
        public uint Pop_limit { get => pop_limit; set => pop_limit = value; }
        internal List<Item> Units { get => units; set => units = value; }
        internal List<Item> Structures { get => structures; set => structures = value; }
        internal List<Item> Techs { get => techs; set => techs = value; }

        public Player(int number, string color, string civ, int food, int wood, int gold, int stone, decimal population, 
            uint pop_limit, List<Item> units, List<Item> structures, List<Item> techs)
        {
            this.number = number;
            this.color = color ?? throw new ArgumentNullException(nameof(civ));
            this.civ = civ ?? throw new ArgumentNullException(nameof(civ));
            this.food = food;
            this.wood = wood;
            this.gold = gold;
            this.stone = stone;
            this.population = population;
            this.pop_limit = pop_limit;
            this.units = units;
            this.structures = structures;
            this.techs = techs;
        }

        public override string ToString()
        {
            string data = "";
            data += "Player " + number + "\nColor: " + color + "\nCivilization: " + civ + "\n"
                + "\nUnits:\n";
            foreach (Item item in units)
                data += item.Name + "\n";
            foreach (Item item in structures)
                data += item.Name + "\n";
            foreach (Item item in techs)
                data += item.Name + "\n";

            return data;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private class LineValue
        {
            private string str_value;
            private decimal dec_value;

            public LineValue(string value)
            {
                this.str_value = value;
                this.dec_value = 0;
            }

            public LineValue(decimal value)
            {
                this.str_value = null;
                this.dec_value = value;
            }

            public string Str_value { get => str_value; }
            public decimal Dec_value { get => dec_value; }
        }

        private void GroupModify(string list, List<string> items, string field, LineValue value, string operation)
        {
            switch (list)
            {
                case "units":
                    foreach (string item in items)
                    {
                        switch (field)
                        {
                            case "name":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Name = value.Str_value; break;
                                    case "append": units.Single(n => n.Name == item).Name += value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "food":
                                switch(operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Food = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Food += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Food *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "wood":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Wood = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Wood += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Wood *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "gold":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Gold = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Gold += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Gold *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "stone":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Stone = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Stone += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Stone *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "build_time":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Build_time = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Build_time += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Build_time *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "reload_time":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Reload_time = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Reload_time += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Reload_time *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "attack_delay":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Attack_delay = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Attack_delay += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Attack_delay *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "movement_rate":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Movement_rate = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Movement_rate += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Movement_rate *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "line_of_sight":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Line_of_sight = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Line_of_sight += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Line_of_sight *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "init_health_points":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Init_health_points = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Init_health_points += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Init_health_points *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "health_points":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Health_points = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Health_points += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Health_points *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "min_range":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Min_range = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Min_range += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Min_range *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "max_range":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Max_range = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Max_range += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Max_range *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "attack":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Attack = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Attack += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Attack *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "add_attack":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Add_attack = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Add_attack += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Add_attack *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "melee_armor":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Melee_armor = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Melee_armor += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Melee_armor *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "add_melee_armor":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Add_melee_armor = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Add_melee_armor += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Add_melee_armor *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "pierce_armor":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Pierce_armor = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Pierce_armor += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Pierce_armor *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "add_pierce_armor":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Add_pierce_armor = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).Add_pierce_armor += value.Dec_value; break;
                                    case "multiply": units.Single(n => n.Name == item).Add_pierce_armor *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "building":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Building = value.Str_value; break;
                                    case "append": units.Single(n => n.Name == item).Building += value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "age":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Age = value.Str_value; break;
                                    case "append": units.Single(n => n.Name == item).Age += value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "special":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Special = value.Str_value; break;
                                    case "append": units.Single(n => n.Name == item).Special += value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "state":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).State = value.Dec_value; break;
                                    case "increase": units.Single(n => n.Name == item).State += value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "attack_bonus":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Attack_bonus = value.Str_value; break;
                                    case "append": units.Single(n => n.Name == item).Attack_bonus += value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "armor_bonus":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Armor_bonus = value.Str_value; break;
                                    case "append": units.Single(n => n.Name == item).Armor_bonus += value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "unit_type":
                                switch (operation)
                                {
                                    case "set": units.Single(n => n.Name == item).Unit_type = value.Str_value; break;
                                    case "append": units.Single(n => n.Name == item).Unit_type += value.Str_value; break;
                                    default: break;
                                }
                                break;
                            default: break;
                        }
                    }
                    break;
                case "structures":
                    foreach (string item in items)
                    {
                        switch (field)
                        {
                            case "name":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Name = value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "food":
                                switch(operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Food = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Food += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Food *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "wood":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Wood = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Wood += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Wood *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "gold":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Gold = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Gold += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Gold *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "stone":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Stone = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Stone += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Stone *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "build_time":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Build_time = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Build_time += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Build_time *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "reload_time":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Reload_time = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Reload_time += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Reload_time *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "line_of_sight":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Line_of_sight = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Line_of_sight += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Line_of_sight *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "init_health_points":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Init_health_points = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Init_health_points += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Init_health_points *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "health_points":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Health_points = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Health_points += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Health_points *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "min_range":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Min_range = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Min_range += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Min_range *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "max_range":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Max_range = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Max_range += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Max_range *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "attack":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Attack = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Attack += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Attack *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "add_attack":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Add_attack = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Add_attack += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Add_attack *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "melee_armor":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Melee_armor = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Melee_armor += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Melee_armor *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "add_melee_armor":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Add_melee_armor = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Add_melee_armor += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Add_melee_armor *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "pierce_armor":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Pierce_armor = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Pierce_armor += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Pierce_armor *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "add_pierce_armor":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Add_pierce_armor = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Add_pierce_armor += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Add_pierce_armor *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "age":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Age = value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "special":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Special = value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "garrison":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Garrison = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Garrison += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Garrison *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "state":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).State = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).State = value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            default: break;
                        }
                    }
                    break;
                case "techs":
                    foreach (string item in items)
                    {
                        switch (field)
                        {
                            case "name":
                                switch (operation)
                                {
                                    case "set": techs.Single(n => n.Name == item).Name = value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "food":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Food = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Food += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Food *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "wood":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Wood = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Wood += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Wood *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "gold":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Gold = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Gold += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Gold *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "stone":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Stone = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Stone += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Stone *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "build_time":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).Build_time = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).Build_time += value.Dec_value; break;
                                    case "multiply": structures.Single(n => n.Name == item).Build_time *= value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            case "building":
                                switch (operation)
                                {
                                    case "set": techs.Single(n => n.Name == item).Building = value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "age":
                                switch (operation)
                                {
                                    case "set": techs.Single(n => n.Name == item).Age = value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "effect":
                                switch (operation)
                                {
                                    case "set": techs.Single(n => n.Name == item).Effect = value.Str_value; break;
                                    default: break;
                                }
                                break;
                            case "state":
                                switch (operation)
                                {
                                    case "set": structures.Single(n => n.Name == item).State = value.Dec_value; break;
                                    case "increase": structures.Single(n => n.Name == item).State += value.Dec_value; break;
                                    default: break;
                                }
                                break;
                            default: break;
                        }
                    }
                    break;
                default: break;
            }

        }

        private void TypeModify(string type, string field, LineValue value, string operation)
        {
            foreach(Item item in units)
            {
                if (item.Unit_type == type)
                {
                    switch (field)
                    {
                        case "name":
                            switch (operation)
                            {
                                case "set": item.Name = value.Str_value; break;
                                case "append": item.Name += value.Str_value; break;
                                default: break;
                            }
                            break;
                        case "food":
                            switch(operation)
                            {
                                case "set": item.Food = value.Dec_value; break;
                                case "increase": item.Food += value.Dec_value; break;
                                case "multiply": item.Food *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "wood":
                            switch (operation)
                            {
                                case "set": item.Wood = value.Dec_value; break;
                                case "increase": item.Wood += value.Dec_value; break;
                                case "multiply": item.Wood *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "gold":
                            switch (operation)
                            {
                                case "set": item.Gold = value.Dec_value; break;
                                case "increase": item.Gold += value.Dec_value; break;
                                case "multiply": item.Gold *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "stone":
                            switch (operation)
                            {
                                case "set": item.Stone = value.Dec_value; break;
                                case "increase": item.Stone += value.Dec_value; break;
                                case "multiply": item.Stone *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "build_time":
                            switch (operation)
                            {
                                case "set": item.Build_time = value.Dec_value; break;
                                case "increase": item.Build_time += value.Dec_value; break;
                                case "multiply": item.Build_time *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "reload_time":
                            switch (operation)
                            {
                                case "set": item.Reload_time = value.Dec_value; break;
                                case "increase": item.Reload_time += value.Dec_value; break;
                                case "multiply": item.Reload_time *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "attack_delay":
                            switch (operation)
                            {
                                case "set": item.Attack_delay = value.Dec_value; break;
                                case "increase": item.Attack_delay += value.Dec_value; break;
                                case "multiply": item.Attack_delay *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "movement_rate":
                            switch (operation)
                            {
                                case "set": item.Movement_rate = value.Dec_value; break;
                                case "increase": item.Movement_rate += value.Dec_value; break;
                                case "multiply": item.Movement_rate *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "line_of_sight":
                            switch (operation)
                            {
                                case "set": item.Line_of_sight = value.Dec_value; break;
                                case "increase": item.Line_of_sight += value.Dec_value; break;
                                case "multiply": item.Line_of_sight *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "init_health_points":
                            switch (operation)
                            {
                                case "set": item.Init_health_points = value.Dec_value; break;
                                case "increase": item.Init_health_points += value.Dec_value; break;
                                case "multiply": item.Init_health_points *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "health_points":
                            switch (operation)
                            {
                                case "set": item.Health_points = value.Dec_value; break;
                                case "increase": item.Health_points += value.Dec_value; break;
                                case "multiply": item.Health_points *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "min_range":
                            switch (operation)
                            {
                                case "set": item.Min_range = value.Dec_value; break;
                                case "increase": item.Min_range += value.Dec_value; break;
                                case "multiply": item.Min_range *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "max_range":
                            switch (operation)
                            {
                                case "set": item.Max_range = value.Dec_value; break;
                                case "increase": item.Max_range += value.Dec_value; break;
                                case "multiply": item.Max_range *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "attack":
                            switch (operation)
                            {
                                case "set": item.Attack = value.Dec_value; break;
                                case "increase": item.Attack += value.Dec_value; break;
                                case "multiply": item.Attack *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "add_attack":
                            switch (operation)
                            {
                                case "set": item.Add_attack = value.Dec_value; break;
                                case "increase": item.Add_attack += value.Dec_value; break;
                                case "multiply": item.Add_attack *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "melee_armor":
                            switch (operation)
                            {
                                case "set": item.Melee_armor = value.Dec_value; break;
                                case "increase": item.Melee_armor += value.Dec_value; break;
                                case "multiply": item.Melee_armor *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "add_melee_armor":
                            switch (operation)
                            {
                                case "set": item.Add_melee_armor = value.Dec_value; break;
                                case "increase": item.Add_melee_armor += value.Dec_value; break;
                                case "multiply": item.Add_melee_armor *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "pierce_armor":
                            switch (operation)
                            {
                                case "set": item.Pierce_armor = value.Dec_value; break;
                                case "increase": item.Pierce_armor += value.Dec_value; break;
                                case "multiply": item.Pierce_armor *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "add_pierce_armor":
                            switch (operation)
                            {
                                case "set": item.Add_pierce_armor = value.Dec_value; break;
                                case "increase": item.Add_pierce_armor += value.Dec_value; break;
                                case "multiply": item.Add_pierce_armor *= value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "building":
                            switch (operation)
                            {
                                case "set": item.Building = value.Str_value; break;
                                case "append": item.Building += value.Str_value; break;
                                default: break;
                            }
                            break;
                        case "age":
                            switch (operation)
                            {
                                case "set": item.Age = value.Str_value; break;
                                case "append": item.Age += value.Str_value; break;
                                default: break;
                            }
                            break;
                        case "special":
                            switch (operation)
                            {
                                case "set": item.Special = value.Str_value; break;
                                case "append": item.Special += value.Str_value; break;
                                default: break;
                            }
                            break;
                        case "state":
                            switch (operation)
                            {
                                case "set": item.State = value.Dec_value; break;
                                case "increase": item.State += value.Dec_value; break;
                                default: break;
                            }
                            break;
                        case "attack_bonus":
                            switch (operation)
                            {
                                case "set": item.Attack_bonus = value.Str_value; break;
                                case "append": item.Attack_bonus += value.Str_value; break;
                                default: break;
                            }
                            break;
                        case "armor_bonus":
                            switch (operation)
                            {
                                case "set": item.Armor_bonus = value.Str_value; break;
                                case "append": item.Armor_bonus += value.Str_value; break;
                                default: break;
                            }
                            break;
                        case "unit_type":
                            switch (operation)
                            {
                                case "set": item.Unit_type = value.Str_value; break;
                                case "append": item.Unit_type += value.Str_value; break;
                                default: break;
                            }
                            break;
                        default: break;
                    }
                }
            }
        }

        private void UnitUpgrade(string from, string to)
        {
            units.Single(u => u.Name == from).State = 0;
            units.Single(u => u.Name == to).State = 1;
        }

        //old version of the method, GroupModify() not implemented yet
        public void TechModify(string tech)
        {
            techs.Single(t => t.Name == "tech").State = 2;
            switch (tech)
            {
                case "Crossbowman":
                    UnitUpgrade("Archer", "Crossbowman");
                    break;
                case "Thumb Ring":
                    units.Single(u => u.Name == "Chu Ko Nu").Reload_time *= 0.83m;
                    units.Single(u => u.Name == "Elite Chu Ko Nu").Reload_time *= 0.84m;

                    GroupModify("units", 
                        new List<string>{
                            "Archer",
                            "Crossbowman",
                            "Arbalest",
                            "Mangudai",
                            "Elite Mangudai",
                            "Plumed Archer",
                            "Elite Plumed Archer"
                        }, 
                        "reload_time", 
                        new LineValue(0.85m),
                        "multiply");
                    GroupModify("units", 
                        new List<string>{
                            "Cavalry Archer",
                            "Heavy Cavalry Archer",
                            "War Wagon",
                            "Elite War Wagon"
                        }, 
                        "reload_time", 
                        new LineValue(0.90m),
                        "multiply");
                    break;
                case "Arbalest":
                    UnitUpgrade("Crossbowman", "Arbalest");
                    break;
                case "Elite Genitour":
                    UnitUpgrade("Genitour", "Elite Genitour");
                    break;
                case "Elite Skirmisher":
                    UnitUpgrade("Skirmisher", "Elite Skirmisher");
                    break;
                case "Heavy Cavalry Archer":
                    UnitUpgrade("Cavalry Archer", "Heavy Cavalry Archer");
                    break;
                case "Imperial Skirmisher":
                    UnitUpgrade("Elite Skirmisher", "Imperial Skirmisher");
                    break;
                case "Parthian Tactics":
                    GroupModify("units",
                        new List<string>
                        {
                            "Cavalry Archer",
                            "Heavy Cavalry Archer",
                            "Elephant Archer",
                            "Elite Elephant Archer",
                            "Mangudai",
                            "Elite Mangudai"
                        }, 
                        "add_melee_armor",
                        new LineValue(1),
                        "set");
                    GroupModify("units",
                        new List<string>
                        {
                            "Cavalry Archer",
                            "Heavy Cavalry Archer",
                            "Elephant Archer",
                            "Elite Elephant Archer",
                            "Mangudai",
                            "Elite Mangudai"
                        },
                        "add_pierce_armor",
                        new LineValue(2),
                        "set");
                    GroupModify("units",
                        new List<string>
                        {
                            "Cavalry Archer",
                            "Heavy Cavalry Archer",
                        },
                        "attack_bonus",
                        new LineValue("\n+4 attack against spearman line"),
                        "append");
                    GroupModify("units",
                        new List<string>
                        {
                            "Elephant Archer",
                            "Elite Elephant Archer",
                            "Mangudai",
                            "Elite Mangudai"
                        },
                        "attack_bonus",
                        new LineValue("+2 attack against spearman line"),
                        "append");
                    break;
                case "Man-at-arms":
                    UnitUpgrade("Militia", "Man-at-arms");
                    break;
                case "Tracking":
                    TypeModify("infantry","line_of_sight", new LineValue(2m), "increase");
                    break;
                case "Arson":
                    TypeModify("infantry", "attack_bonus", new LineValue("\n+2 attack vs standard buildings"), "append");
                    break;
                case "Eagle Warrior":
                    UnitUpgrade("Eagle Scout", "Eagle Warrior");
                    break;
                case "Long Swordsman":
                    UnitUpgrade("Man-at-arms", "Long Swordsman");
                    break;
                case "Pikeman":
                    UnitUpgrade("Spearman", "Pikeman");
                    break;
                case "Squires":
                    TypeModify("infantry", "movement_rate", new LineValue(1.1m), "multiply");
                    break;
                case "Champion":
                    UnitUpgrade("Two-handed Swordsman", "Champion");
                    break;
                case "Elite Eagle Warrior":
                    UnitUpgrade("Elite Eagle Warrior", "Elite Elite Eagle Warrior");
                    break;
                case "Halberdier":
                    UnitUpgrade("Pikeman", "Halberdier");
                    break;
                case "Two-handed Swordsman":
                    UnitUpgrade("Long Swordsman", "Two-handed Swordsman");
                    break;
                case "Fletching":
                    TypeModify("archer", "add_attack", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "add_attack", new LineValue(1m), "increase");
                    TypeModify("archer", "max_range", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "max_range", new LineValue(1m), "increase");
                    TypeModify("archer", "line_of_sight", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "line_of_sight", new LineValue(1m), "increase");
                    GroupModify("units", new List<string> { "Scorpion", "Heavy Scorpion" }, "line_of_sight", new LineValue(1m), "increase");
                    GroupModify("structures", new List<string> {
                        "Town Center",
                        "Castle",
                        "Watch Tower",
                        "Guard Tower",
                        "Keep"
                    }, "line_of_sight", new LineValue(1m), "increase");
                    GroupModify("structures", new List<string> {
                        "Town Center",
                        "Castle",
                        "Watch Tower",
                        "Guard Tower",
                        "Keep"
                    }, "attack", new LineValue(1m), "increase");
                    GroupModify("structures", new List<string> {
                        "Castle",
                        "Watch Tower",
                        "Guard Tower",
                        "Keep"
                    }, "max_range", new LineValue(1m), "increase");
                    GroupModify("units", new List<string> {
                        "Galley",
                        "War Galley",
                        "Galleon",
                        "Longboat",
                        "Elite Longboat"
                    }, "line_of_sight", new LineValue(1m), "increase");
                    GroupModify("units", new List<string> {
                        "Galley",
                        "War Galley",
                        "Galleon",
                        "Longboat",
                        "Elite Longboat"
                    }, "attack", new LineValue(1m), "increase");
                    GroupModify("units", new List<string> {
                        "Galley",
                        "War Galley",
                        "Galleon",
                        "Longboat",
                        "Elite Longboat"
                    }, "max_range", new LineValue(1m), "increase");
                    break;
                case "Forging":
                    TypeModify("infantry", "add_attack", new LineValue(1m), "increase");
                    TypeModify("cavalry", "add_attack", new LineValue(1m), "increase");
                    break;
                case "Padded Archer Armor":
                    TypeModify("archer", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("archer", "add_pierce_armor", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "add_pierce_armor", new LineValue(1m), "increase");
                    TypeModify("gunbowder unit", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("gunbowder unit", "add_pierce_armor", new LineValue(1m), "increase");
                    break;
                case "Scale Barding Armor":
                    TypeModify("cavalry", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("cavalry", "add_pierce_armor", new LineValue(1m), "increase");
                    break;
                case "Scale Mail Armor":
                    TypeModify("infantry", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("infantry", "add_pierce_armor", new LineValue(1m), "increase");
                    break;
                case "Bodkin Arrow":
                    TypeModify("archer", "add_attack", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "add_attack", new LineValue(1m), "increase");
                    TypeModify("archer", "max_range", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "max_range", new LineValue(1m), "increase");
                    TypeModify("archer", "line_of_sight", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "line_of_sight", new LineValue(1m), "increase");
                    GroupModify("structures", new List<string> {
                        "Town Center",
                        "Castle",
                        "Watch Tower",
                        "Guard Tower",
                        "Keep"
                    }, "line_of_sight", new LineValue(1m), "increase");
                    GroupModify("structures", new List<string> {
                        "Town Center",
                        "Castle",
                        "Watch Tower",
                        "Guard Tower",
                        "Keep"
                    }, "attack", new LineValue(1m), "increase");
                    GroupModify("structures", new List<string> {
                        "Castle",
                        "Watch Tower",
                        "Guard Tower",
                        "Keep"
                    }, "max_range", new LineValue(1m), "increase");
                    GroupModify("units", new List<string> {
                        "Galley",
                        "War Galley",
                        "Galleon",
                        "Longboat",
                        "Elite Longboat"
                    }, "line_of_sight", new LineValue(1m), "increase");
                    GroupModify("units", new List<string> {
                        "Galley",
                        "War Galley",
                        "Galleon",
                        "Longboat",
                        "Elite Longboat"
                    }, "attack", new LineValue(1m), "increase");
                    GroupModify("units", new List<string> {
                        "Galley",
                        "War Galley",
                        "Galleon",
                        "Longboat",
                        "Elite Longboat"
                    }, "max_range", new LineValue(1m), "increase");
                    break;
                case "Chain Barding Armor":
                    TypeModify("cavalry", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("cavalry", "add_pierce_armor", new LineValue(1m), "increase");
                    break;
                case "Chain Mail Armor":
                    TypeModify("infantry", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("infantry", "add_pierce_armor", new LineValue(1m), "increase");
                    break;
                case "Iron Casting":
                    TypeModify("infantry", "add_attack", new LineValue(1m), "increase");
                    TypeModify("cavalry", "add_attack", new LineValue(1m), "increase");
                    break;
                case "Leather Archer Armor":
                    TypeModify("archer", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("archer", "add_pierce_armor", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "add_pierce_armor", new LineValue(1m), "increase");
                    TypeModify("gunbowder unit", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("gunbowder unit", "add_pierce_armor", new LineValue(1m), "increase");
                    break;
                case "Blast Furnace":
                    TypeModify("infantry", "add_attack", new LineValue(2m), "increase");
                    TypeModify("cavalry", "add_attack", new LineValue(2m), "increase");
                    break;
                case "Bracer":
                    TypeModify("archer", "add_attack", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "add_attack", new LineValue(1m), "increase");
                    TypeModify("archer", "max_range", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "max_range", new LineValue(1m), "increase");
                    TypeModify("archer", "line_of_sight", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "line_of_sight", new LineValue(1m), "increase");
                    GroupModify("structures", new List<string> {
                        "Town Center",
                        "Castle",
                        "Watch Tower",
                        "Guard Tower",
                        "Keep"
                    }, "line_of_sight", new LineValue(1m), "increase");
                    GroupModify("structures", new List<string> {
                        "Town Center",
                        "Castle",
                        "Watch Tower",
                        "Guard Tower",
                        "Keep"
                    }, "attack", new LineValue(1m), "increase");
                    GroupModify("structures", new List<string> {
                        "Castle",
                        "Watch Tower",
                        "Guard Tower",
                        "Keep"
                    }, "max_range", new LineValue(1m), "increase");
                    GroupModify("units", new List<string> {
                        "Galley",
                        "War Galley",
                        "Galleon",
                        "Longboat",
                        "Elite Longboat"
                    }, "line_of_sight", new LineValue(1m), "increase");
                    GroupModify("units", new List<string> {
                        "Galley",
                        "War Galley",
                        "Galleon",
                        "Longboat",
                        "Elite Longboat"
                    }, "attack", new LineValue(1m), "increase");
                    GroupModify("units", new List<string> {
                        "Galley",
                        "War Galley",
                        "Galleon",
                        "Longboat",
                        "Elite Longboat"
                    }, "max_range", new LineValue(1m), "increase");
                    break;
                case "Plate Barding Armor":
                    TypeModify("cavalry", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("cavalry", "add_pierce_armor", new LineValue(2m), "increase");
                    break;
                case "Plate Mail Armor":
                    TypeModify("infantry", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("infantry", "add_pierce_armor", new LineValue(2m), "increase");
                    break;
                case "Ring Archer Armor":
                    TypeModify("archer", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("archer", "add_pierce_armor", new LineValue(2m), "increase");
                    TypeModify("cavalry archer", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("cavalry archer", "add_pierce_armor", new LineValue(2m), "increase");
                    TypeModify("gunbowder unit", "add_melee_armor", new LineValue(1m), "increase");
                    TypeModify("gunbowder unit", "add_pierce_armor", new LineValue(2m), "increase");
                    break;
                case "Conscription":
                    TypeModify("infantry", "build_time", new LineValue(0.75m), "multiply");
                    TypeModify("archer", "build_time", new LineValue(0.75m), "multiply");
                    TypeModify("cavalry archer", "build_time", new LineValue(0.75m), "multiply");
                    TypeModify("cavalry", "build_time", new LineValue(0.75m), "multiply");
                    TypeModify("gunbowder unit", "build_time", new LineValue(0.75m), "multiply");
                    break;
                case "Hoardings":
                    structures.Single(s => s.Name == "Castle").Init_health_points *= 1.12m;
                    structures.Single(s => s.Name == "Castle").Health_points *= 1.12m;
                    break;
                case "Sappers":
                    units.Single(u => u.Name == "Villager").Attack_bonus += "\n+15 attack vs buildings and stone defenses.";
                    break;
                case "Spies":
                    break;
                case "Treason":
                    break;
                case "Careening":
                    TypeModify("ship", "add_pierce_armor", new LineValue(1m), "increase");
                    units.Single(u => u.Name == "Transport ship").Garrison += 5m;
                    break;
                case "Gillnets":
                case "War Galley":
                case "Cannon Galleon":
                case "Dry Dock":
                case "Elite Cannon Galleon":
                case "Elite Caravel":
                case "Elite Longboat":
                case "Elite Turtle Ship":
                case "Fast Fire Ship":
                case "Galleon":
                case "Heavy Demolition Ship":
                case "Shipwright":
                case "Double - Bit Axe":
                case "Bow Saw":
                case "Two - Man Saw":
                case "Cartography":
                case "Coinage":
                case "Banking":
                case "Caravan":
                case "Guilds":
                case "Horse Collar":
                case "Heavy Plow":
                case "Crop Rotation":
                case "Gold Mining":
                case "Stone Mining":
                case "Gold Shaft Mining":
                case "Stone Shaft Mining":
                case "Atonement":
                case "Fervor":
                case "Herbal Medicine":
                case "Heresy":
                case "Redemption":
                case "Sanctity":
                case "Block Printing":
                case "Faith":
                case "Illumination":
                case "Theocracy":
                case "Capped Ram":
                case "Heavy Scorpion":
                case "Onager":
                case "Siege Onager":
                case "Siege Ram":
                case "Bloodlines":
                case "Husbandry":
                case "Light Cavalry":
                case "Cavalier":
                case "Elite Battle Elephant":
                case "Heavy Camel":
                case "Hussar":
                case "Imperial Camel":
                case "Paladin":
                case "Feudal Age":
                case "Loom":
                case "Castle Age":
                case "Town Watch":
                case "Wheelbarrow":
                case "Hand Cart":
                case "Imperial Age":
                case "Town Patrol":
                case "Anarchy":
                case "Andean Sling":
                case "Atlatl":
                case "Boiling Oil":
                case "Carrack":
                case "Chatras":
                case "Chieftains":
                case "Chivalry":
                case "Great Wall":
                case "Greek Fire":
                case "Howdah":
                case "Inquisition":
                case "Ironclad":
                case "Kasbah":
                case "Madrasah":
                case "Marauders":
                case "Mercenaries":
                case "Nomads":
                case "Obsidian Arrow":
                case "Orthodoxy":
                case "Panokseon":
                case "Pavise":
                case "Royal Heirs":
                case "Sipahi":
                case "Stronghold":
                case "Sultans":
                case "Thalassocracy":
                case "Tigui":
                case "Tusk Swords":
                case "Yasama":
                case "Yeomen":
                case "Arquebus":
                case "Artillery":
                case "Atheism":
                case "Bearded Axe":
                case "Berserkergang":
                case "Couriers":
                case "Crenellations":
                case "Double Crossbow":
                case "Drill":
                case "Druzhina":
                case "El Dorado":
                case "Farimba":
                case "Forced Levy":
                case "Furor Celtica":
                case "Garland Wars":
                case "Kataparuto":
                case "Logistica":
                case "Maghrabi Camels":
                case "Mahouts":
                case "Manipur Cavalry":
                case "Paper Money":
                case "Perfusion":
                case "Recurve Bow":
                case "Rocketry":
                case "Shatagni":
                case "Shinkichon":
                case "Silk Road":
                case "Supremacy":
                case "Torsion Engines":
                case "Warwolf":
                case "Zealotry":
                case "Elite Arambai":
                case "Elite Ballista Elephant":
                case "Elite Berserk":
                case "Elite Boyar":
                case "Elite Camel Archer":
                case "Elite Cataphract":
                case "Elite Chu Ko Nu":
                case "Elite Conquistador":
                case "Elite Elephant Archer":
                case "Elite Gbeto":
                case "Elite Genoese Crossbowman":
                case "Elite Huskarl":
                case "Elite Jaguar Warrior":
                case "Elite Janissary":
                case "Elite Kamayuk":
                case "Elite Karambit Warrior":
                case "Elite Longbowman":
                case "Elite Magyar Huszar":
                case "Elite Mameluke":
                case "Elite Mangudai":
                case "Elite Organ Gun":
                case "Elite Plumed Archer":
                case "Elite Rattan Archer":
                case "Elite Samurai":
                case "Elite Shotel Warrior":
                case "Elite Tarkan":
                case "Elite Teutonic Knight":
                case "Elite Throwing Axeman":
                case "Elite War Elephant":
                case "Elite War Wagon":
                case "Elite Woad Raider":
                case "Ballistics":
                case "Fortified Wall":
                case "Guard Tower":
                case "Heated Shot":
                case "Masonry":
                case "Murder Holes":
                case "Treadmill Crane":
                case "Architecture":
                case "Arrowslits":
                case "Bombard Tower":
                case "Chemistry":
                case "Keep":
                case "Siege Engineers":
                default: break;
            }
        }

        public void CivModify() //TODO
        {
            switch (civ)
            {
                case "Aztecs":
                case "Berbers":
                case "Burmese":
                case "Byzantines":
                case "Celts":
                case "Chinese":
                case "Ethiopians":
                case "Franks":
                case "Goths":
                case "Huns":
                case "Incas":
                case "Indians":
                case "Italians":
                case "Japanese":
                case "Khmer":
                case "Koreans":
                case "Magyars":
                case "Malay":
                case "Malians":
                case "Mayans":
                case "Mongols":
                case "Persians":
                case "Portuguese":
                case "Saracens":
                case "Slavs":
                case "Spanish":
                case "Teutons":
                case "Turks":
                case "Vietnamese":
                case "Vikings":
                default: break;
            }
    }

        public void AlliesModify(string ally) //TODO
        {
            switch (ally)
            {
                case "Aztecs":
                case "Berbers":
                case "Burmese":
                case "Byzantines":
                case "Celts":
                case "Chinese":
                case "Ethiopians":
                case "Franks":
                case "Goths":
                case "Huns":
                case "Incas":
                case "Indians":
                case "Italians":
                case "Japanese":
                case "Khmer":
                case "Koreans":
                case "Magyars":
                case "Malay":
                case "Malians":
                case "Mayans":
                case "Mongols":
                case "Persians":
                case "Portuguese":
                case "Saracens":
                case "Slavs":
                case "Spanish":
                case "Teutons":
                case "Turks":
                case "Vietnamese":
                case "Vikings":
                default: break;
            }
        }

    }
}
