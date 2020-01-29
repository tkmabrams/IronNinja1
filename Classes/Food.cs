using System;

namespace IronNinja.Classes
{
    public class Food : IConsumable
    {
        public string Name {get; set;}
        public int Calories {get; set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get; set;}
        public string GetInfo()
        {
            Console.WriteLine($"{Name}(Food). Calories: {Calories}. Spicy?: {IsSpicy}. Sweet?: {IsSweet}");
            return $"{Name}(Food). Calories: {Calories}. Spicy?: {IsSpicy}. Sweet?: {IsSweet}";
        }
        
        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}