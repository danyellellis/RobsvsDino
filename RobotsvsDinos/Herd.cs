using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinos
{
    class Herd
    {

        //Member Variables (HAS A)
        public List<Dinosaurs> dinosaurs;
        //Constructor
        public Herd()
        {
            dinosaurs = new List<Dinosaurs>();

            Dinosaurs dinosaurs1 = new Dinosaurs();
            dinosaurs1.dinosaurHealth = 100;
            dinosaurs1.dinosaurEnergy = 88;
            dinosaurs1.dinosaurAttackPower = 25;
            dinosaurs1.dinosaurType = "TRex";

            dinosaurs.Add(dinosaurs1);

            Dinosaurs dinosaurs2 = new Dinosaurs();
            dinosaurs2.dinosaurHealth = 100;
            dinosaurs2.dinosaurEnergy = 95;
            dinosaurs2.dinosaurAttackPower = 25;
            dinosaurs2.dinosaurType = "Raptor";

            dinosaurs.Add(dinosaurs2);

            Dinosaurs dinosaurs3 = new Dinosaurs();
            dinosaurs3.dinosaurHealth = 100;
            dinosaurs3.dinosaurEnergy = 95;
            dinosaurs3.dinosaurAttackPower = 25;
            dinosaurs3.dinosaurType = "Tyrann";

            dinosaurs.Add(dinosaurs3);



        }

        //Member Methods (CAN DO)


    }
}
