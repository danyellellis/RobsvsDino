using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinos
{
    class Robots
    {



        //Member Variables (HAS A)
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public Weapon robotWeapon;
        public int robotAttackPower;


        //Constructor
        public Robots()
        {

            robotAttackPower = 20;
            robotHealth = 100;
            robotPowerLevel = 95;
            robotWeapon = new Weapon("sword", 20);

            List<string> robotObjects = new List<string>();
            robotObjects.Add("robotAttackPower");
            robotObjects.Add("robotHealth");
            robotObjects.Add("robotPowerLevel");

            foreach (string robotObject in robotObjects)
            {
                Console.WriteLine(robotObject);
            }










        }

        //Member Methods (CAN DO)


        public void Attack(Dinosaurs dino)
        {
            dino.dinosaurHealth -= robotAttackPower;


            
        }
        
        

        



        

       
      
        

        

       

        

        



    }
}
