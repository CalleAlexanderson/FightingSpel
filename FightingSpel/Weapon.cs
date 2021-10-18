using System.Net.Mime;
using System;
using System.Collections.Generic;

namespace FightingSpel
{
    public class Weapon
    {
        public int damage = 1;
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
                multiplier = 16;
            }
            else if (i == 3 || i == 5)
            {
                damage = 5;
                multiplier = 11;
            }
        }

        public void Attack(Fighter self, Fighter enemy)
        {
            int x = generator.Next(1, multiplier);
            int dmg = damage * x - enemy.armor;
            dmg = Math.Max(dmg, 0);

            if (!(generator.Next(100) < enemy.dodge))
            {
                List<string> attacks = new List<string>() { $"{enemy.name} got hit!", $"{enemy.name} did not manage to avoid the attack!", $"{self.name} struck {enemy.name}!", $"{self.name} aim was true!", $"{self.name}'s attack connected!" };
                Console.WriteLine(attacks[generator.Next(0, 5)]);

                if (x == multiplier - 1)
                {
                    enemy.Hp -= dmg * 2;
                    Console.WriteLine("Critical hit!");
                }
                else
                {
                    enemy.Hp -= dmg;
                }

                if (dmg == 0)
                {
                    Console.WriteLine("The damage was blocked");
                }
                else
                {
                    Console.WriteLine($"{self.name} dealt {dmg} damage!");
                }
                Console.WriteLine();
            }
            else
            {
                List<string> dodges = new List<string>() { $"{enemy.name} dodged!", $"{enemy.name} avoided the attack!", $"{self.name} missed!", $"{enemy.name} evaded the strike!", $"{self.name} fumbled the attack!" };
                Console.WriteLine(dodges[generator.Next(0, 5)]);
                Console.WriteLine();
            }
        }
    }
}