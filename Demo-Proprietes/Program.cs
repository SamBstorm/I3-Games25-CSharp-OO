using Demo_Proprietes.Models;

namespace Demo_Proprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Personne p1 = new Personne();
            p1.Nom = " legrain  ";
            p1.Prenom = "Samuel";
            p1.DateNaissance = new DateOnly(1987, 9, 27);
            Console.WriteLine($"Bonjour, je suis {p1.Nom} {p1.Prenom}.");
            //Console.WriteLine($"Je suis né le {p1.DateNaissance}.");
            Console.WriteLine($"Je suis agé de {p1.Age} ans.");
            p1.JoyeuxAnniversaire();
        }
    }
}
