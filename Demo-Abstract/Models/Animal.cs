using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract.Models
{
    internal abstract class Animal
    {
        public string Nom { get; private set; }

        public Animal(string nom)
        {
            Nom = nom;
        }

        public abstract void Crier();
    }
}
