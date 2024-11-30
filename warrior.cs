using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
     class warrior
    {
        public String Name { get; set; }
        public double Health { get; set; }
        public double AttackMax { get; set; }
        public double DefenceMax { get; set; }

        Random rand = new Random();

        public warrior (String name ="Warrior",
            double health = 0,
            double attackMax = 0,
            double defenceMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            DefenceMax = defenceMax;
        }
        public virtual double Attack()
        {
            return rand.Next(1, (int)AttackMax);
        }

        public virtual double Defence()
        {
            return rand.Next(1, (int)DefenceMax);
        }
    }
}
