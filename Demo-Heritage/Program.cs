using Demo_Heritage.Models;

namespace Demo_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forme f = new Forme("Rouge",2);

            Rectangle r = new Rectangle("Jaune",3,3,5);

            Cercle c = new Cercle("Vert",3,5);

            Carre c2 = new Carre("Bleu",2,5);
        }
    }
}
