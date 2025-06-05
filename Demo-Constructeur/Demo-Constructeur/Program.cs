using Demo_Constructeur.Models;

namespace Demo_Constructeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Personne deuxieme = new Personne("Alba","Jessica"); 
            Console.WriteLine( deuxieme.Nom);
        }
    }
}
