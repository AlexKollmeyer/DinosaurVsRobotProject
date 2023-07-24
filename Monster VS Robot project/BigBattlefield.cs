using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Monster_VS_Robot_project
{
    internal class BigBattlefield
    {
        //Set up a new Battlefield for bonus task 2
        public void BigDisplayWelcome(DinosaurHerd dinosaurHerd, RobotFleet robotFleet)
        {
            Console.WriteLine($"Ladies and gentlemen, today we have a 3 v 3 matchup between a dinosaur herd and a robot fleet! " +
                $"In the dinosaur herd we have a vicious{dinosaurHerd.DinosaurMembers[0]}, a rugged {dinosaurHerd.DinosaurMembers[1]} " +
                $"and a ferocious {dinosaurHerd.DinosaurMembers[2]}!");
            Console.WriteLine($"In the Robot fleet we have an advanced {robotFleet.RobotMembers[0]}, " +
                $"an industructible{robotFleet.RobotMembers[1]}," +
                $"and a resolute {robotFleet.RobotMembers[2]}!");
            Console.WriteLine("What a fight it is going to be!");
        }
      
        Random rnd = new Random();
        public Dinosaur SelectTargetDinosaur(DinosaurHerd dinosaurHerd)
        {
            int num = rnd.Next();
            while (dinosaurHerd.DinosaurMembers[num].Health <= 0)
            {
                num = rnd.Next();
            }
            return dinosaurHerd.DinosaurMembers[num];
        }
        public Robot SelectTargetRobot(RobotFleet robotFleet)
        {
            int num = rnd.Next();
            while (robotFleet.RobotMembers[num].Health <= 0)
            {
                num = rnd.Next();
            }
            return robotFleet.RobotMembers[num];
        }
        public void BigCombat(DinosaurHerd dinosaurHerd,RobotFleet robotFleet) 
        {
            while (robotFleet.RobotMembers[0].Health + robotFleet.RobotMembers[1].Health+ robotFleet.RobotMembers[2].Health>0 && dinosaurHerd.DinosaurMembers[0].Health+ dinosaurHerd.DinosaurMembers[1].Health+ dinosaurHerd.DinosaurMembers[2].Health>0) { }        
            for (int i=0; i<3; i++)
            {
                if (robotFleet.RobotMembers[i].Health > 0)
                {
                        robotFleet.RobotMembers[i].attackDinosaur(SelectTargetDinosaur(dinosaurHerd));
                }
                else
                {
                    Console.WriteLine($"{robotFleet.RobotMembers[i].Name} is down, their attack is skipped.");
                    
                }
                if (dinosaurHerd.DinosaurMembers[i].Health > 0)
                {
                    dinosaurHerd.DinosaurMembers[i].attackRobot(SelectTargetRobot(robotFleet));
                }
                else
                {
                    Console.WriteLine($"{dinosaurHerd.DinosaurMembers[i].Name} is down, their attack is skipped.");

                }
            }
        }
        public void runBigGame()
        {
            Dinosaur Trex = new Dinosaur("Trex");
            Trex.Health = 300;
            Trex.AttackPower = 75;
            Dinosaur Allosaurus = new Dinosaur("Allosaurus");
            Allosaurus.Health = 225;
            Allosaurus.AttackPower = 75;
            Dinosaur Anxylosaurus = new Dinosaur("Anxylosaurus");
            Anxylosaurus.Health = 400;
            Anxylosaurus.AttackPower = 40;

            Robot Jager = new Robot("Jager");
            Jager.Health = 400;
            Robot Lancer = new Robot("Lancer");
            Lancer.Health = 250;
            Robot Titan = new Robot("Titan");
            Titan.Health = 500;
            DinosaurHerd dinosaurHerd = new DinosaurHerd(Allosaurus, Anxylosaurus, Trex);
            RobotFleet robotfleet = new RobotFleet(Lancer, Titan, Jager);
            BigDisplayWelcome(dinosaurHerd,robotfleet);
            BigCombat(dinosaurHerd, robotfleet);
        }  

        //Start of random selection code
        //Random rnd = new Random();
        //public Robot SelectRobot(RobotFleet robotFleet)
        //{
        //    int num = rnd.Next(0, 3);
        //    return robotFleet.RobotMembers[num];
        //}
        //public Dinosaur SelectDinosaur(DinosaurHerd dinosaurHerd)
        //{

        //    int num = rnd.Next(0, 3);
        //    return dinosaurHerd.DinosaurMembers[num];
        //}
    }
}
