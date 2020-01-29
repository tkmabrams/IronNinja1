using System;
namespace IronNinja.Classes
{
    public class Drink : IConsumable
    {
        public string Name {get; set;}
        public int Calories {get; set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        public string GetInfo()
        {
            Console.WriteLine($"{Name}(Drink). Calories: {Calories}. Spicy?: {IsSpicy}. Sweet?: {IsSweet}");
            return $"{Name}(Drink). Calories: {Calories}. Spicy?: {IsSpicy}. Sweet?: {IsSweet}";
        }
        public Drink(string name, int cal, bool spicy)
        {
            Name = name;
            IsSweet = true;
            Calories = cal;
            IsSpicy = spicy;
        }
    }
}