using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract.Models
{
    internal abstract class Oiseau : Animal
    {
        public Oiseau(string nom) : base(nom)
        {
        }
    }
}
