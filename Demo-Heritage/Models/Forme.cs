using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage.Models
{
    internal class Forme
    {
        private int _borderWidth;


        public string Color { get; set; }

        public int BorderWidth
        {
            protected get
            {
                return _borderWidth;
            }

            set
            {
                _borderWidth = (value < 0) ? -value : value;
            }
        }
        public Forme(string color, int borderWidth)
        {
            Color = color;
            BorderWidth = borderWidth;
        }

    }
}
