using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage.Models
{
    internal sealed class Carre : Rectangle
    {
        public Carre(string color, int borderWidth, int cote) : base(color, borderWidth, cote, cote)
        {
        }
    }
}
