using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeur.Models
{
    internal class Triangle
    {
        private int _cotea;
        private int _coteb;
        private int _cotec;


        public Triangle(int cote1=5, int cote2=6, int cote3=15)
        {
                _cotea = cote1;
            _coteb = cote2;
            _cotec = cote3;
        }
    }
}
