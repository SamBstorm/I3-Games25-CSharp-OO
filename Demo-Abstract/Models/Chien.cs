using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract.Models
{
    internal sealed class Chien : Animal
    {
        public Chien(string nom) : base(nom)
        {
        }

        public override void Crier()
        {
            Console.WriteLine("Wouaf! Waouf!");
        }
    }
}
