﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
    class MagicWarrior : warrior
    {
        // The bigger the number the more likely the chance
        // of successfully teleporting (100 Max Value)
        int teleportChance = 0;

        // Add interface functionality
        CanTeleport teleportType = new CanTeleport();
        
        public MagicWarrior(string name = "Warrior",
            double health = 0,
            double attkMax = 0,
            double blockMax = 0,
            int teleportChance = 0)
            : base(name, health, attkMax, blockMax)
        {
            this.teleportChance = teleportChance;
        }

        // We'll inherit all properties and methods in the Warrior
        // class but we'll override block
        public override double Defence()
        {
        
            // Generate a random value from 1 to 100
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);

            // Decide if teleport works based on percent assigned to teleportChance
            if (rndDodge < this.teleportChance)
            {
                Console.WriteLine("rndDodge {0} and teleportChance is {1}",
                     rndDodge, this.teleportChance);
                Console.WriteLine($"{Name} {teleportType.teleport()}");
                return 10000;
            }
            else
            {
                Console.WriteLine(" Teleport did not work {0}", rndDodge);   
                return base.Attack();
            }
        }
    }
}
