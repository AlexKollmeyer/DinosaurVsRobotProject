using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_VS_Robot_project
{
    internal class Robot
    {
        public string Name;
        public int Health;
        public Weapon activeWeapon;

        public Robot(string name)
        {
            Name = name;
        }

        public Weapon selectWeapon()
        {
            //bonus story 1
            Weapon sword = new Weapon("sword",50);
            Weapon powerFist = new Weapon("powerFist",40);
            Weapon energyBeam = new Weapon("energyBeam",80);

            List<Weapon> Weapons = new List<Weapon>
            {
                sword,
                powerFist,
                energyBeam,
            };
            Random rnd = new Random();
            int num = rnd.Next(1, 4);
            if (num == 1)
            {
                return sword;
            }
            else if (num == 2)
            {
                return powerFist;
            }
            else
            {
                return energyBeam;
            }
        }
        public void attackDinosaur(Dinosaur dinosaur)
        {
            this.activeWeapon = selectWeapon();
            Console.WriteLine($"{Name} attacks {dinosaur.Name} and does {activeWeapon.AttackPower} damage with it's {activeWeapon.Type}");
            dinosaur.Health -= activeWeapon.AttackPower;
            Console.WriteLine($"{dinosaur.Name} has {dinosaur.Health} health left");
        }
    }
}
