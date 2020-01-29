using System;
using System.Collections.Generic;

namespace IronNinja.Classes
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get 
            { 
                return health;
            }
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int hh)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hh;
        }
        public int Attack(Human target)
        {
            int dmg = 5 * Strength;
            target.health -= dmg;
            return health;
        }

    }
}