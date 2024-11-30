// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oops_concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick",
                   4, 160);
            if (buick is IDrivable)
            {
                buick.move();
                buick.stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }

            // Pick up the TV remote
            IElectronicDevice TV = TVRemote.GetDevice();

            // Create the power button
            PowerButton powBut = new PowerButton(TV);

            // Turn the TV on and off with each 
            // press
            powBut.Execute();
            powBut.Undo();
            powBut.Execute();
            powBut.Undo();
            powBut.Execute();
            TV.VolumeUp();
            TV.VolumeUp();
            TV.VolumeUp();
            TV.VolumeDown();

            //warrior thor = new warrior("thor", 100, 20, 10);
            //warrior loki = new warrior("loki", 100, 20, 10);
            MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 10, 50);
            LighteningWarrier thor = new LighteningWarrier("thor", 75, 20, 20, 35);
            Battle.StartFight(thor, loki);

        }
    }
}



