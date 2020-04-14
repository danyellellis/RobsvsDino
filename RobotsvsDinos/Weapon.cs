using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinos
{
    class Weapon
    {
        //private string v;

        //Member Variables (HAS A)
        string type;
        int attackPower;

        //Constructor
        public Weapon(string type, int attackPower)
        {
            // List<Weapon> Weapon = new List<Weapon>();
            // Weapon weapon1 = new Weapon("sword");
            // Weapon.Add(weapon1);
            this.type = type;
            this.attackPower = attackPower;


        }

        //public Weapon(string v)
        //{
        //    this.v = "sword";
        //}

        //Member Methods (CAN DO)


    }
}
