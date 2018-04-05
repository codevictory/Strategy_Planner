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
        private decimal food;
        private decimal wood;
        private decimal gold;
        private decimal stone;
        private decimal build_time;
        private decimal reload_time;
        private decimal attack_delay;
        private decimal movement_rate;
        private decimal line_of_sight;
        private decimal init_health_points;
        private decimal health_points;
        private decimal min_range;
        private decimal max_range;
        private decimal attack;
        private decimal add_attack;
        private decimal melee_armor;
        private decimal add_melee_armor;
        private decimal pierce_armor;
        private decimal add_pierce_armor;
        private string building;
        private string age;
        private string effect;
        private string special;
        private decimal garrison;
        private decimal state;

        public string Name { get => name; set => name = value; }
        public decimal Food { get => food; set => food = value; }
        public decimal Wood { get => wood; set => wood = value; }
        public decimal Gold { get => gold; set => gold = value; }
        public decimal Stone { get => stone; set => stone = value; }
        public decimal Build_time { get => build_time; set => build_time = value; }
        public decimal Reload_time { get => reload_time; set => reload_time = value; }
        public decimal Attack_delay { get => attack_delay; set => attack_delay = value; }
        public decimal Movement_rate { get => movement_rate; set => movement_rate = value; }
        public decimal Line_of_sight { get => line_of_sight; set => line_of_sight = value; }
        public decimal Init_health_points { get => init_health_points; set => init_health_points = value; }
        public decimal Health_points { get => health_points; set => health_points = value; }
        public decimal Min_range { get => min_range; set => min_range = value; }
        public decimal Max_range { get => max_range; set => max_range = value; }
        public decimal Attack { get => attack; set => attack = value; }
        public decimal Add_attack { get => add_attack; set => add_attack = value; }
        public decimal Melee_armor { get => melee_armor; set => melee_armor = value; }
        public decimal Add_melee_armor { get => add_melee_armor; set => add_melee_armor = value; }
        public decimal Pierce_armor { get => pierce_armor; set => pierce_armor = value; }
        public decimal Add_pierce_armor { get => add_pierce_armor; set => add_pierce_armor = value; }
        public string Building { get => building; set => building = value; }
        public string Age { get => age; set => age = value; }
        public string Effect { get => effect; set => effect = value; }
        public string Special { get => special; set => special = value; }
        public decimal Garrison { get => garrison; set => garrison = value; }
        public decimal State { get => state; set => state = value; } // private enum ItemState { unavailable, available, bought };

        //Constructor for units
        public Item(string name, decimal food, decimal wood, decimal gold, decimal stone, decimal build_time, decimal reload_time, decimal attack_delay, 
            decimal movement_rate, decimal line_of_sight, decimal init_health_points, decimal min_range, decimal max_range, decimal attack, 
            decimal melee_armor, decimal pierce_armor, string building, string age, string special)
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
        public Item(string name, decimal food, decimal wood, decimal gold, decimal stone, decimal build_time, string effect, string building, 
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
        public Item(string name, decimal food, decimal wood, decimal gold, decimal stone, decimal build_time, decimal reload_time, decimal line_of_sight, 
            decimal init_health_points, decimal min_range, decimal max_range, decimal attack, decimal melee_armor, decimal pierce_armor, decimal garrison, 
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
            health_points = init_health_points;
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
