using System;
using System.Collections.Generic;

namespace IronNinja.Classes
{
    class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if ( calorieIntake >= 1500)
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
            if ( IsFull == false)
            {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
                if (item.IsSweet == true)
                {
                    calorieIntake += 10;
                }
                else
                {
                    Console.WriteLine("this item is not sweet");
                }
            }
            else
            {
                Console.WriteLine("This SweetTooth Ninja is full! ");
            }
        }
    }
}