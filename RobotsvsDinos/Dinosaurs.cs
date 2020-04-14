using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinos
{
    class Dinosaurs
    {

        //Member Variables (HAS A)

        public string dinosaurType;

        public int dinosaurHealth;
        public int dinosaurEnergy;
        public int dinosaurAttackPower;


        //Constructor
        public Dinosaurs()
        {
            dinosaurHealth = 100;
            dinosaurEnergy = 98;
            dinosaurAttackPower = 20;

            List<string> dinosaurObjects = new List<string>();
            dinosaurObjects.Add("dinosaurHealth");
            dinosaurObjects.Add("dinosaurEnergy");
            dinosaurObjects.Add("dinosaurAttackPower");
            foreach (string dinosaurObject in dinosaurObjects)
            {
                Console.WriteLine(dinosaurObject);
            }




        }

        //Member Methods (CAN DO)
        public void Attack(Robots robots)
        {
            robots.robotHealth -= dinosaurAttackPower;

        }


       



    }
}
