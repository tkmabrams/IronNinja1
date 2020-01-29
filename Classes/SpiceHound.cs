using System;
using System.Collections.Generic;

namespace IronNinja.Classes
{
    class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override void Consume(IConsumable item)
        {
            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
                if ( item.IsSpicy == true)
                {
                    calorieIntake -= 5;
                }
                else
                {
                    Console.WriteLine("This item is not spicy.");
                }
            }
            else
            {
                Console.WriteLine("This Spicy Ninja is full.");
            }
        }
       
    }
}