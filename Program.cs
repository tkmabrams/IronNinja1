using System;
using IronNinja.Classes;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ninja john = new Ninja();
            //Buffet entree = new Buffet();
            //john.Eat(entree.Serve());
            Buffet entree = new Buffet();
            SweetTooth bill = new SweetTooth();
            SpiceHound kim = new SpiceHound();
            bill.Consume(entree.Serve());
            kim.Consume(entree.Serve());

            Console.WriteLine("Hello World!");
        }
    }
}
