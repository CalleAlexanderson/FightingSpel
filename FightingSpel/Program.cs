using System;

namespace FightingSpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter fighter1 = new Fighter();
            Fighter fighter2 = new Fighter();
            int round = 0;

            Console.WriteLine($"Fighters:\n{fighter1.name}, weapon of choice: {fighter1.weapon.weaponName} \n{fighter2.name}, weapon of choice: {fighter2.weapon.weaponName} ");
            Console.WriteLine();
            while (fighter1.GetAlive() && fighter2.GetAlive())
            {
                round++;
                Console.WriteLine($"Current hp:\n{fighter1.name}: {fighter1.hp}\n{fighter2.name}: {fighter2.hp}");
                Console.ReadLine();
                Console.WriteLine($"Round {round}");
                fighter1.weapon.Attack(fighter1, fighter2);
                fighter2.weapon.Attack(fighter2, fighter1);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
