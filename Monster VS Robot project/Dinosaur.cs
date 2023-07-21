using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_VS_Robot_project
{
    class Dinosaur
    {
        public string Name;
        public int Health;
        public int AttackPower;

        public Dinosaur(string name)
        {
            Name = name;
        }
        public void attackRobot(Robot robot)
        {
            Console.WriteLine($"{Name} attacks {robot.Name} and does {AttackPower} damage");
            robot.Health -= AttackPower;
            Console.WriteLine($"{robot.Name} has {robot.Health} health left");

        }
    }
}
