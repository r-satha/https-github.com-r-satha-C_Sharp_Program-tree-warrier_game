using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
    class Battle
    {
        public static void StartFight(warrior warrior1, warrior warrior2)
        {
            while (true)
            {
                if ((GetAttackResult(warrior1, warrior2) == "Game Over") || (GetAttackResult(warrior2, warrior1) == "Game Over"))
                {
                    break;
                }
            }
        }

        public static string GetAttackResult(warrior warriorA, warrior warriorB)
        {
            double warAattackAmt = warriorA.Attack();
            double warBblockAmt = warriorB.Defence();
            double dmg2WarB = (warAattackAmt - warBblockAmt);
            if (dmg2WarB > 0)
            {
                warriorB.Health = (warriorB.Health - dmg2WarB);
            }
            else
                dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                warriorA.Name,
                warriorB.Name,
                dmg2WarB);

            Console.WriteLine("{0} Has {1} Health\n",
               warriorB.Name,
               warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious \n",
                    warriorB.Name,
                    warriorA.Name);
                return "Game Over";
            }
            else
            {
                return "Fight Again";
            }
        }
    }
}
