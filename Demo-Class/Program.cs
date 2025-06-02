using Demo_Class.Models;

namespace Demo_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Voiture maFerrari = new Voiture(); 
            //maFerrari.couleur = "Rouge";
            //maFerrari.immatriculation = "2-ABC-123";
            //maFerrari.nbRoues = 4;

            Voiture maFerrari = new Voiture()
            {
                couleur = "Rouge",
                immatriculation = "2-ABC-123",
                nbRoues = 4
            };

            Voiture laFraise = maFerrari;

            Console.WriteLine($"Voici ma voiture {maFerrari.couleur}, immatricullée {maFerrari.immatriculation}.");

            Console.WriteLine($"Voici la voiture de mon fils {laFraise.couleur}, immatricullée {laFraise.immatriculation}.");

            Console.WriteLine($"Je roule à pleine vitesse avec les {maFerrari.nbRoues} roues de ma voiture!");

            Console.WriteLine("BOOM!");

            maFerrari.nbRoues--;

            Console.WriteLine($"Ma voiture a maintenant {maFerrari.nbRoues} roues...");
            Console.WriteLine($"La voiture de mon fils a maintenant {laFraise.nbRoues} roues...");
        }
    }
}
