using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_VirtualOverride.Models
{
    internal class WalkingAnimal : Animal
    {
        public WalkingAnimal(string nom) : base(nom)
        {
        }

        public override void SeDeplacer()
        {
            Console.Write("En mettant une patte devant l'autre, ");
            base.SeDeplacer();
        }
    }
}
