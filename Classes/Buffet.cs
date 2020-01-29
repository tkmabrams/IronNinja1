using System;
using System.Collections.Generic;

namespace IronNinja.Classes
{
    public class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Pizza", 300, false, false),
                new Food("Chicken", 200, false, false),
                new Food("Chocolate", 80, false, true),
                new Food("Rice", 60, false, false),
                new Food("Chilli", 320, true, false),
                new Food("Strawberries", 40, false, true),
                new Food("Cherries", 70, false, true),
                new Drink("Orange Soda", 300, false),
                new Drink("Lemonade", 80, false),
                new Drink("Fruit Drink", 90, false),
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            int randIConsumable = rand.Next(1,11);
            Console.WriteLine(Menu[randIConsumable]);
            return Menu[randIConsumable]; 
        }
    }
}