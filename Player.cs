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
        private float population;
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
        public float Population { get => population; set => population = value; }
        public uint Pop_limit { get => pop_limit; set => pop_limit = value; }

        public Player(int number, string color, string civ, int food, int wood, int gold, int stone, float population, 
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
            private int int_value;
            private uint uint_value;
            private double dbl_value;

            public LineValue(string value)
            {
                this.str_value = value;
                this.int_value = 0;
                this.uint_value = 0;
                this.dbl_value = 0;
            }

            public LineValue(int value)
            {
                this.str_value = null;
                this.int_value = value;
                this.uint_value = 0;
                this.dbl_value = 0;
            }

            public LineValue(uint value)
            {
                this.str_value = null;
                this.int_value = 0;
                this.uint_value = value;
                this.dbl_value = 0;
            }

            public LineValue(double value)
            {
                this.str_value = null;
                this.int_value = 0;
                this.uint_value = 0;
                this.dbl_value = value;
            }

            public string Str_value { get => str_value; }
            public int Int_value { get => int_value; }
            public uint Uint_value { get => uint_value; }
            public double Dbl_value { get => dbl_value; }
        }

        private void LineModify(string list, List<string> items, string field, LineValue value)
        {
            switch (list)
            {
                case "units":
                    foreach (string item in items)
                    {
                        switch (field)
                        {
                            case "name":
                                units.Single(n => n.Name == item).Name = value.Str_value;
                                break;
                            case "food":
                                units.Single(n => n.Name == item).Food = value.Uint_value;
                                break;
                            case "wood":
                                units.Single(n => n.Name == item).Wood = value.Uint_value;
                                break;
                            case "gold":
                                units.Single(n => n.Name == item).Gold = value.Uint_value;
                                break;
                            case "stone":
                                units.Single(n => n.Name == item).Stone = value.Uint_value;
                                break;
                            case "build_time":
                                units.Single(n => n.Name == item).Build_time = value.Uint_value;
                                break;
                            case "reload_time":
                                units.Single(n => n.Name == item).Reload_time = value.Dbl_value;
                                break;
                            case "attack_delay":
                                units.Single(n => n.Name == item).Attack_delay = value.Dbl_value;
                                break;
                            case "movement_rate":
                                units.Single(n => n.Name == item).Movement_rate = value.Dbl_value;
                                break;
                            case "line_of_sight":
                                units.Single(n => n.Name == item).Line_of_sight = value.Uint_value;
                                break;
                            case "init_health_points":
                                units.Single(n => n.Name == item).Init_health_points = value.Uint_value;
                                break;
                            case "health_points":
                                units.Single(n => n.Name == item).Health_points = value.Int_value;
                                break;
                            case "min_range":
                                units.Single(n => n.Name == item).Min_range = value.Dbl_value;
                                break;
                            case "max_range":
                                units.Single(n => n.Name == item).Max_range = value.Dbl_value;
                                break;
                            case "attack":
                                units.Single(n => n.Name == item).Attack = value.Uint_value;
                                break;
                            case "add_attack":
                                units.Single(n => n.Name == item).Add_attack = value.Uint_value;
                                break;
                            case "melee_armor":
                                units.Single(n => n.Name == item).Melee_armor = value.Int_value;
                                break;
                            case "add_melee_armor":
                                units.Single(n => n.Name == item).Add_melee_armor = value.Int_value;
                                break;
                            case "pierce_armor":
                                units.Single(n => n.Name == item).Pierce_armor = value.Int_value;
                                break;
                            case "add_pierce_armor":
                                units.Single(n => n.Name == item).Add_pierce_armor = value.Int_value;
                                break;
                            case "building":
                                units.Single(n => n.Name == item).Building = value.Str_value;
                                break;
                            case "age":
                                units.Single(n => n.Name == item).Age = value.Str_value;
                                break;
                            case "special":
                                units.Single(n => n.Name == item).Special = value.Str_value;
                                break;
                            case "garrison":
                                units.Single(n => n.Name == item).Garrison = value.Uint_value;
                                break;
                            case "state":
                                units.Single(n => n.Name == item).State = value.Int_value;
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
                                units.Single(n => n.Name == item).Name = value.Str_value;
                                break;
                            case "food":
                                units.Single(n => n.Name == item).Food = value.Uint_value;
                                break;
                            case "wood":
                                units.Single(n => n.Name == item).Wood = value.Uint_value;
                                break;
                            case "gold":
                                units.Single(n => n.Name == item).Gold = value.Uint_value;
                                break;
                            case "stone":
                                units.Single(n => n.Name == item).Stone = value.Uint_value;
                                break;
                            case "build_time":
                                units.Single(n => n.Name == item).Build_time = value.Uint_value;
                                break;
                            case "reload_time":
                                units.Single(n => n.Name == item).Reload_time = value.Dbl_value;
                                break;
                            case "line_of_sight":
                                units.Single(n => n.Name == item).Line_of_sight = value.Uint_value;
                                break;
                            case "init_health_points":
                                units.Single(n => n.Name == item).Init_health_points = value.Uint_value;
                                break;
                            case "health_points":
                                units.Single(n => n.Name == item).Health_points = value.Int_value;
                                break;
                            case "min_range":
                                units.Single(n => n.Name == item).Min_range = value.Dbl_value;
                                break;
                            case "max_range":
                                units.Single(n => n.Name == item).Max_range = value.Dbl_value;
                                break;
                            case "attack":
                                units.Single(n => n.Name == item).Attack = value.Uint_value;
                                break;
                            case "add_attack":
                                units.Single(n => n.Name == item).Add_attack = value.Uint_value;
                                break;
                            case "melee_armor":
                                units.Single(n => n.Name == item).Melee_armor = value.Int_value;
                                break;
                            case "add_melee_armor":
                                units.Single(n => n.Name == item).Add_melee_armor = value.Int_value;
                                break;
                            case "pierce_armor":
                                units.Single(n => n.Name == item).Pierce_armor = value.Int_value;
                                break;
                            case "add_pierce_armor":
                                units.Single(n => n.Name == item).Add_pierce_armor = value.Int_value;
                                break;
                            case "age":
                                units.Single(n => n.Name == item).Age = value.Str_value;
                                break;
                            case "special":
                                units.Single(n => n.Name == item).Special = value.Str_value;
                                break;
                            case "garrison":
                                units.Single(n => n.Name == item).Garrison = value.Uint_value;
                                break;
                            case "state":
                                units.Single(n => n.Name == item).State = value.Int_value;
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
                                units.Single(n => n.Name == item).Name = value.Str_value;
                                break;
                            case "food":
                                units.Single(n => n.Name == item).Food = value.Uint_value;
                                break;
                            case "wood":
                                units.Single(n => n.Name == item).Wood = value.Uint_value;
                                break;
                            case "gold":
                                units.Single(n => n.Name == item).Gold = value.Uint_value;
                                break;
                            case "stone":
                                units.Single(n => n.Name == item).Stone = value.Uint_value;
                                break;
                            case "build_time":
                                units.Single(n => n.Name == item).Build_time = value.Uint_value;
                                break;
                            case "building":
                                units.Single(n => n.Name == item).Building = value.Str_value;
                                break;
                            case "age":
                                units.Single(n => n.Name == item).Age = value.Str_value;
                                break;
                            case "effect":
                                units.Single(n => n.Name == item).Effect = value.Str_value;
                                break;
                            case "state":
                                units.Single(n => n.Name == item).State = value.Int_value;
                                break;
                            default: break;
                        }
                    }
                    break;
                default: break;
            }

        }

        public void TechModify(string tech)
        {
            switch (tech)
            {
                case "Crossbowman":
                    units.Single(u => u.Name == "Crossbowman").State = 0;
                    units.Single(u => u.Name == "Crossbowman").State = 1;
                    break;
                case "Thumb Ring":
                    units.Single(u => u.Name == "Archer").Reload_time *= 0.85;
                    units.Single(u => u.Name == "Crossbowman").Reload_time *= 0.85;
                    units.Single(u => u.Name == "Arbalest").Reload_time *= 0.85;
                    units.Single(u => u.Name == "Cavalry Archer").Reload_time *= 0.90;
                    units.Single(u => u.Name == "Heavy Cavalry Archer").Reload_time *= 0.90;
                    units.Single(u => u.Name == "War Wagon").Reload_time *= 0.90;
                    units.Single(u => u.Name == "Elite War Wagon").Reload_time *= 0.90;
                    units.Single(u => u.Name == "Chu Ko Nu").Reload_time *= 0.83;
                    units.Single(u => u.Name == "Elite Chu Ko Nu").Reload_time *= 0.84;
                    units.Single(u => u.Name == "Mangudai").Reload_time *= 0.85;
                    units.Single(u => u.Name == "Elite Mangudai").Reload_time *= 0.85;
                    units.Single(u => u.Name == "Plumend Archer").Reload_time *= 0.85;
                    units.Single(u => u.Name == "Elite Plumend Archer").Reload_time *= 0.85;
                    break;
                case "Arbalest":
                    units.Single(u => u.Name == "Crossbowman").State = 0;
                    units.Single(u => u.Name == "Arbalest").State = 1;
                    break;
                case "Elite Genitour":
                    units.Single(u => u.Name == "Genitour").State = 0;
                    units.Single(u => u.Name == "Elite Genitour").State = 1;
                    break;
                case "Elite Skirmisher":
                    units.Single(u => u.Name == "Skirmisher").State = 0;
                    units.Single(u => u.Name == "Elite Skirmishers").State = 1;
                    break;
                case "Heavy Cavalry Archer":
                    units.Single(u => u.Name == "Cavalry Archer").State = 0;
                    units.Single(u => u.Name == "Heavy Cavalry Archer").State = 1;
                    break;
                case "Imperial Skirmisher":
                    units.Single(u => u.Name == "Elite Skirmisher").State = 0;
                    units.Single(u => u.Name == "Imperial Skirmisher").State = 1;
                    break;
                case "Parthian Tactics":
                    units.Single(u => u.Name == "Cavalry Archer").Add_melee_armor += 1;
                    units.Single(u => u.Name == "Heavy Cavalry Archer").Add_melee_armor += 1;
                    units.Single(u => u.Name == "Elephant Archer").Add_melee_armor += 1;
                    units.Single(u => u.Name == "Cavalry Archer").Add_melee_armor += 1;

                    units.Single(u => u.Name == "Heavy Cavalry Archer").State = 1;
                    break;
                case "Man - at - arms":
                case "Tracking":
                case "Arson":
                case "Eagle Warrior":
                case "Long Swordsman":
                case "Pikeman":
                case "Squires":
                case "Champion":
                case "Elite Eagle Warrior":
                case "Halberdier":
                case "Two - handed Swordsman":
                case "Fletching":
                case "Forging":
                case "Padded Archer Armor":
                case "Scale Barding Armor":
                case "Scale Mail Armor":
                case "Bodkin Arrow":
                case "Chain Barding Armor":
                case "Chain Mail Armor":
                case "Iron Casting":
                case "Leather Archer Armor":
                case "Blast Furnace":
                case "Bracer":
                case "Plate Barding Armor":
                case "Plate Mail Armor":
                case "Ring Archer Armor":
                case "Conscription":
                case "Hoardings":
                case "Sappers":
                case "Spies":
                case "Treason":
                case "Careening":
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
        }//TODO

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
