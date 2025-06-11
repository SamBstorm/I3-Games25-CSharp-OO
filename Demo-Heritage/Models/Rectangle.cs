using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage.Models
{
    internal class Rectangle : Forme
    {
		private int _largeur;

		public int Largeur
		{
			get { return _largeur; }
			set { 
				if(value > _longueur)
				{
					_largeur = _longueur;
					_longueur = value;
				}
				else
				{
					_largeur = value; 
				}
			}
		}

		private int _longueur;

		public int Longueur
		{
			get { return _longueur; }
			set {
                if (value < _largeur)
                {
                    _longueur = _largeur;
                    _largeur = value;
                }
                else
                {
                    _longueur = value;
                }
            }
		}

        public Rectangle(string color, int borderWidth, int largeur, int longueur) : base(color, borderWidth)
        {
			Longueur = longueur;
			Largeur = largeur;
        }

        public void Test()
		{
			BorderWidth = 4;
		}
	}
}
