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

        public int Attack(int dodge, int armor, int dmg, int hp)
        {

            //generator.Next(0, multiplier);
            int health = 0;

            return health;
        }
    }
}