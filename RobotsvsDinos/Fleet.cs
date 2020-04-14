using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinos
{
    class Fleet
    {

        //Member Variables (HAS A)
        public List<Robots> robots;

        //Constructor
        public Fleet()
        {

                robots = new List<Robots>();

                Robots robot1 = new Robots();
                robot1.robotHealth = 100;
                robot1.robotAttackPower = 20;
                robot1.robotPowerLevel = 95;
                robot1.robotName = "Bender";

                robots.Add(robot1);

                Robots robot2 = new Robots();
                
                robot2.robotAttackPower = 20;
                robot2.robotHealth = 75;
                robot2.robotPowerLevel = 95;
                robot2.robotName = "Gort";

                robots.Add(robot2);

                Robots robot3 = new Robots();

                robot3.robotAttackPower = 20;
                robot3.robotHealth = 85;
                robot3.robotPowerLevel = 95;
                robot3.robotName = "Gort";

                robots.Add(robot3);



        }
            


            //Instantiate 3 robots and add them to roboList

        }

        //Member Methods (CAN DO)


    }