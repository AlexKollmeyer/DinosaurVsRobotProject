using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_VS_Robot_project
{
    internal class Weapon
    {
        public string Type;
        public int AttackPower;
        public Weapon(string type,int attackPower)
        {
            Type = type;
            AttackPower = attackPower;
        }
    }
    
}
