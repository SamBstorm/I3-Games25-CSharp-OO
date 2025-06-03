using Demo_Enumeration.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Enumeration.Models
{
    internal class Trafficlight
    {
        public TrafficlightColors currentColor;

        public void ChangeColor() {
            if (currentColor is TrafficlightColors.vert)
            {
                currentColor = TrafficlightColors.orange;
            }
            else if (currentColor is TrafficlightColors.orange)
            {
                currentColor = TrafficlightColors.rouge;
            }
            else
            {
                currentColor = TrafficlightColors.vert;
            }
        }
    }
}
