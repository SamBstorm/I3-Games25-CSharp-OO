using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract.Models
{
    internal class Pigeon : Oiseau
    {
        public Pigeon(string nom) : base(nom)
        {
        }

        public override void Crier()
        {
            Console.WriteLine("Rou! Rou!");
        }
    }
}
