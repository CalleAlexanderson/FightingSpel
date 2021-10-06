using System.Dynamic;
using System;
using System.Collections.Generic;

namespace FightingSpel
{
    public class Fighter
    {
        public int hp;
        public int armor;
        public int dodge;
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                hp = Math.Max(hp, 0);
            }
        }

        private List<string> names = new List<string>() { "Josephine", "Alex", "Christina", "Jörgen", "Nicolas", "Björn" };
        Random generator = new Random();
        public int i;
        public string name;

        public Weapon weapon;

        public Fighter()
        {
            i = generator.Next(0, 6);
            name = names[i];
            weapon = new Weapon(i);

            if (i == 0 || i == 4)
            {
                armor = 14;
                dodge = 30;
                hp = 400;
            }
            else if (i == 1 || i == 2)
            {
                armor = 10;
                dodge = 60;
                hp = 350;
            }
            else if (i == 3 || i == 5)
            {
                armor = 18;
                dodge = 10;
                hp = 600;
            }
        }

        public bool GetAlive()
        {
            bool alive;

            if (hp > 0)
            {
                alive = true;
            }
            else
            {
                alive = false;
            }

            return alive;
        }
    }
}