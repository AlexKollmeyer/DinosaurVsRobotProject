using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_VS_Robot_project
{
    internal class DinosaurHerd
    {
        public List<Dinosaur> DinosaurMembers = new List<Dinosaur>
        {

        };
        public DinosaurHerd(Dinosaur Dino1, Dinosaur Dino2, Dinosaur Dino3)
        {
            this.DinosaurMembers = new List<Dinosaur>
            {
                Dino1,
                Dino2,
                Dino3
            };
        }
    }
}
