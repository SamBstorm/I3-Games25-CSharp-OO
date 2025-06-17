using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_VirtualOverride.Models
{
    internal class SwimmingAnimal : Animal
    {
        public SwimmingAnimal(string nom) : base(nom)
        {
        }

        public override void SeDeplacer()
        {
            Console.Write("En agitant ses nageoires, ");
            base.SeDeplacer();
        }
    }
}
