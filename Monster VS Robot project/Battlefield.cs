using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Monster_VS_Robot_project
{
    internal class Battlefield
    {
        public void displayWelcome(Dinosaur dinosaur, Robot robot)
        {
            Console.WriteLine($"Welcome to the showdown between the ferocious creature {dinosaur.Name} and the mechanical menace {robot.Name}");
        }
        public void combat(Dinosaur dinosaur, Robot robot)
        {
            Random rnd = new Random();
            while (dinosaur.Health > 0 && robot.Health > 0)
            {
                int num = rnd.Next(1, 3);
                if (num == 1)
                {
                    robot.attackDinosaur(dinosaur);
                    if (dinosaur.Health <= 0)
                    {
                        break;
                    }
                    dinosaur.attackRobot(robot);
                    
                }
                else
                {
                    dinosaur.attackRobot(robot);
                    if (robot.Health <= 0)
                    {
                        break;
                    }
                    robot.attackDinosaur(dinosaur);
                }
            }
        }
        public void displayVictor(Dinosaur dinosaur, Robot robot)
        {
            if (dinosaur.Health <= 0)
            {
                Console.WriteLine($"The robot {robot.Name} is vicotrious! What an amazing fight folks! ");
            }
            else
            {
                Console.WriteLine($"The dinosaur {dinosaur.Name} is vicotrious! What an amazing fight folks! ");
            }
        }
        public void runGame()
        {
            Dinosaur Trex = new Dinosaur("Trex");
            Trex.Health = 1200;
            Trex.AttackPower = 75;
            Robot Jager = new Robot("Jager");
            Jager.Health = 2000;
            displayWelcome(Trex,Jager);
            combat(Trex, Jager);
            displayVictor(Trex, Jager);


        }
    }
}
