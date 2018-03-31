using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientatedProgramming2018
{
    class Item
    {
        private string name;
        private uint food;
        private uint wood;
        private uint gold;
        private uint stone;
        private uint build_time;
        private double reload_time;
        private double attack_delay;
        private double movement_rate;
        private uint line_of_sight;
        private uint init_health_points;
        private int health_points;
        private double min_range;
        private double max_range;
        private uint attack;
        private uint add_attack;
        private int melee_armor;
        private int add_melee_armor;
        private int pierce_armor;
        private int add_pierce_armor;
        private string building;
        private string age;
        private string effect;
        private string special;
        private uint garrison;
        private int state;

        public string Name { get => name; set => name = value; }
        public uint Food { get => food; set => food = value; }
        public uint Wood { get => wood; set => wood = value; }
        public uint Gold { get => gold; set => gold = value; }
        public uint Stone { get => stone; set => stone = value; }
        public uint Build_time { get => build_time; set => build_time = value; }
        public double Reload_time { get => reload_time; set => reload_time = value; }
        public double Attack_delay { get => attack_delay; set => attack_delay = value; }
        public double Movement_rate { get => movement_rate; set => movement_rate = value; }
        public uint Line_of_sight { get => line_of_sight; set => line_of_sight = value; }
        public uint Init_health_points { get => init_health_points; set => init_health_points = value; }
        public int Health_points { get => health_points; set => health_points = value; }
        public double Min_range { get => min_range; set => min_range = value; }
        public double Max_range { get => max_range; set => max_range = value; }
        public uint Attack { get => attack; set => attack = value; }
        public uint Add_attack { get => add_attack; set => add_attack = value; }
        public int Melee_armor { get => melee_armor; set => melee_armor = value; }
        public int Add_melee_armor { get => add_melee_armor; set => add_melee_armor = value; }
        public int Pierce_armor { get => pierce_armor; set => pierce_armor = value; }
        public int Add_pierce_armor { get => add_pierce_armor; set => add_pierce_armor = value; }
        public string Building { get => building; set => building = value; }
        public string Age { get => age; set => age = value; }
        public string Effect { get => effect; set => effect = value; }
        public string Special { get => special; set => special = value; }
        public uint Garrison { get => garrison; set => garrison = value; }
        public int State { get => state; set => state = value; } // private enum ItemState { unavailable, available, bought };

        //Constructor for units
        public Item(string name, uint food, uint wood, uint gold, uint stone, uint build_time, double reload_time, double attack_delay, 
            double movement_rate, uint line_of_sight, uint init_health_points, double min_range, double max_range, uint attack, 
            int melee_armor, int pierce_armor, string building, string age, string special)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.food = food;
            this.wood = wood;
            this.gold = gold;
            this.stone = stone;
            this.build_time = build_time;
            this.reload_time = reload_time;
            this.attack_delay = attack_delay;
            this.movement_rate = movement_rate;
            this.line_of_sight = line_of_sight;
            this.init_health_points = init_health_points;
            this.min_range = min_range;
            this.max_range = max_range;
            this.attack = attack;
            this.melee_armor = melee_armor;
            this.pierce_armor = pierce_armor;
            this.building = building ?? throw new ArgumentNullException(nameof(building));
            this.age = age ?? throw new ArgumentNullException(nameof(age));
            this.special = special ?? throw new ArgumentNullException(nameof(special));
            health_points = (int)init_health_points;
            add_attack = 0;
            add_melee_armor = 0;
            add_pierce_armor = 0;
            state = 0; //unavailable
        }

        //Constructor for techs
        public Item(string name, uint food, uint wood, uint gold, uint stone, uint build_time, string effect, string building, 
            string age)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.effect = effect ?? throw new ArgumentNullException(nameof(effect));
            this.building = building ?? throw new ArgumentNullException(nameof(building));
            this.age = age ?? throw new ArgumentNullException(nameof(age));
            this.food = food;
            this.wood = wood;
            this.gold = gold;
            this.stone = stone;
            this.build_time = build_time;
            state = 0; //unavailable
        }

        //Constructor for structures
        public Item(string name, uint food, uint wood, uint gold, uint stone, uint build_time, double reload_time, uint line_of_sight, 
            uint init_health_points, double min_range, double max_range, uint attack, int melee_armor, int pierce_armor, uint garrison, 
            string special, string age)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.special = special ?? throw new ArgumentNullException(nameof(special));
            this.age = age ?? throw new ArgumentNullException(nameof(age));
            this.food = food;
            this.wood = wood;
            this.gold = gold;
            this.stone = stone;
            this.build_time = build_time;
            this.reload_time = reload_time;
            this.line_of_sight = line_of_sight;
            this.init_health_points = init_health_points;
            this.min_range = min_range;
            this.max_range = max_range;
            this.attack = attack;
            this.melee_armor = melee_armor;
            this.pierce_armor = pierce_armor;
            this.garrison = garrison;
            health_points = (int)init_health_points;
            add_attack = 0;
            add_melee_armor = 0;
            add_pierce_armor = 0;
            state = 0; //unavailable
        }

        public override string ToString()
        {
            return name
           + "\t" + food
           + "\t" + wood
           + "\t" + gold
           + "\t" + stone
           + "\t" + build_time
           + "\t" + reload_time
           + "\t" + attack_delay
           + "\t" + movement_rate
           + "\t" + line_of_sight
           + "\t" + init_health_points
           + "\t" + health_points
           + "\t" + min_range
           + "\t" + max_range
           + "\t" + attack
           + "\t" + add_attack
           + "\t" + melee_armor
           + "\t" + add_melee_armor
           + "\t" + pierce_armor
           + "\t" + add_pierce_armor
           + "\t" + building
           + "\t" + age
           + "\t" + effect
           + "\t" + special
           + "\t" + garrison;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
