using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinos
{
    class Battlefield
    {

        //Member Variables (HAS A)
        // added Herd to Battlefield 

        Herd herd = new Herd();
        // added Fleet to Battlefield 
        Fleet fleet = new Fleet();





        //Constructor
        public Battlefield()
        {

        }



        //Member Methods (CAN DO)
        public void RunBattle()
        {














            //};
             herd.dinosaurs[0].Attack(fleet.robots[0]);
             for (int i = 100; i >= 20; i--)
            //{

            //}

            // This is the first robot in the fleet => fleet.robots[0]
            //This is the first robot attacking the first dino => fleet.robots[0].Attack(herd.dinosaurs[0]);
           
            Console.WriteLine(fleet.robots[0].robotHealth);

            //






            //Ask user to enter a number, save it as input, then use that number in fleet.robots[input]?
         Console.ReadLine();
        }


    }
}
