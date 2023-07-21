using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_VS_Robot_project
{
    internal class RobotFleet
    {
        public List<Robot> RobotMembers = new List<Robot>
        {

        };
        public RobotFleet(Robot member1, Robot member2, Robot member3)
        {
            this.RobotMembers = new List<Robot>
            {
                member1,
                member2,
                member3
            };
        }

    }
}
