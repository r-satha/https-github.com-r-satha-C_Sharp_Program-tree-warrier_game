using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
    class LighteningWarrier : warrior
    {
        int LighteningChance = 0;

        CanThunder thunderType = new CanThunder();
        public LighteningWarrier(string name = "Warrior",
            double health = 0,
            double attkMax = 0,
            double blockMax = 0,
            int LighteningChance = 0)
            : base(name, health, attkMax, blockMax)
        {
            this.LighteningChance = LighteningChance;
        }
        public override double Attack()
        {

            // Generate a random value from 1 to 100
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);

            // Decide if teleport works based on percent assigned to teleportChance
            if (rndDodge < this.LighteningChance)
            {
                Console.WriteLine("rndDodge {0} and Lightening Chance is {1}",
                     rndDodge, this.LighteningChance);
                Console.WriteLine($"{Name} {thunderType.thunderLight()}");
                return rndDodge*3;
            }
            else
            {
                Console.WriteLine("Thunder Did not work {0}", rndDodge);
                return base.Defence();
            }
        }
        /*public override double Defence()
        {

            // Generate a random value from 1 to 100
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);

            // Decide if teleport works based on percent assigned to teleportChance
            if (rndDodge < this.LighteningChance)
            {
                Console.WriteLine("rndDodge {0} and Lightening Chance is {1}",
                     rndDodge, this.LighteningChance);
                Console.WriteLine($"{Name} {thunderType.thunderLight()}");
                return 10000;
            }
            else
            {
                Console.WriteLine("Thunder Did not work {0}", rndDodge);
                return base.Defence();
            }
        }*/
    }
}
