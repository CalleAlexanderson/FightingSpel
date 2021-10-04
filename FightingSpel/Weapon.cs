using System.Net.Mime;
using System;
using System.Collections.Generic;

namespace FightingSpel
{
    public class Weapon
    {
        public int damage;
        public int multiplier;
        Random generator = new Random();
        private List<string> weapons = new List<string>() { "Sword", "Spear", "Spear", "Axe", "Sword", "Axe" };
        public string weaponName;

        public Weapon(int i)
        {
            weaponName = weapons[i];
            if (i == 0 || i == 4)
            {
                damage = 4;
                multiplier = 13;

            }
            else if (i == 1 || i == 2)
            {
                damage = 3;
                multiplier = 15;
            }
            else if (i == 3 || i == 5)
            {
                damage = 5;
                multiplier = 12;
            }
        }

        public int Attack(int dodge, int armor, int dmg, int health, string name1, int multi, string name2)
        {
            int damage = dmg * generator.Next(multi) - armor;
            damage = Math.Max(damage, 0);

            if (!(generator.Next(100) < dodge))
            {
                health -= damage;
                Console.WriteLine();
            }
            else
            {
                List<string> dodges = new List<string>() { $"{name1} dodged!", $"{name1} avoided the attack!", $"{name2} missed!", $"{name1} evaded the strike!", $"{name2} fumbled the attack!" };
                Console.WriteLine(dodges[generator.Next(0, 4)]);
            }


            return health;
        }
    }
}