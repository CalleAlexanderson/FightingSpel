using System.Dynamic;
using System;
using System.Collections.Generic;

namespace FightingSpel
{
    public class Fighter
    {
        public int hp = 500;
        private bool isALive;

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
        private string name;

        public Fighter()
        {
            name = names[generator.Next(0, 6)];
        }

        public bool GetAlive(int fHp)
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