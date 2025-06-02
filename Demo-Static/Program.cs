using Demo_Static.Models;

namespace Demo_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Formation games = new Formation() { 
                nom = "Games25",
                eleves = new List<string>(["Manon","Begüm", "Estelle", "Gaëlle", "Lyst"])
            };

            Formation.centre = "Interface 3";

            Formation wad = new Formation() { 
                nom = "WAD 25",
                eleves = new List<string>(["Laura","Émilie","Yulia","Anaïs","Siham", "Tran"])
            };

            games.Decrire();
            wad.Decrire();
            Formation.Description();*/

            int result = Mathematique.MettreAuCarre(3);
            ConsoleRainbow.WriteLine($"3 au carré donne {result}");
        }
    }
}
