using System;

namespace FightingSpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter fighter1 = new Fighter();
            Fighter fighter2 = new Fighter();
            Console.ReadLine();

            while (fighter1.GetAlive(fighter1.hp) && fighter2.GetAlive(fighter2.hp))
            {

            }
        }
    }
}
