using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract.Models
{
    internal class Mesange : Oiseau
    {
        public Mesange(string nom) : base(nom)
        {
        }

        public override void Crier()
        {
            Console.WriteLine("Cui! Cui!");
        }
    }
}
