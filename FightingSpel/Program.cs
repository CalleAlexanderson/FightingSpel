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

            System.Console.WriteLine($"Fighters:\n{fighter1.name}, weapon of choice: {fighter1.weapon.weaponName} \n{fighter2.name}, weapon of choice: {fighter2.weapon.weaponName} ");

            while (fighter1.GetAlive(fighter1.hp) && fighter2.GetAlive(fighter2.hp))
            {
                round++;
                Console.WriteLine($"Round {round}");
                Console.ReadLine();
                fighter1.weapon.Attack(fighter1.dodge, fighter1.armor, fighter1.weapon.damage, fighter1.hp);
                fighter2.weapon.Attack(fighter2.dodge, fighter2.armor, fighter2.weapon.damage, fighter2.hp);
            }

            Console.ReadLine();
        }
    }
}
