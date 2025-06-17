using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_VirtualOverride.Models
{
    internal class Animal
    {
        public string Nom { get; private set; }

        public Animal(string nom)
        {
            Nom = nom;
        }

        public override string ToString()
        {
            return $"Notre animal se nomme {Nom}.";
        }

        public virtual void SeDeplacer()
        {
            Console.WriteLine($"{Nom} se déplace.");
        }
    }
}
