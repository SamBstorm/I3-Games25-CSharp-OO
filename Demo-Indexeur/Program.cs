using Demo_Indexeur.Models;

namespace Demo_Indexeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Créer une personnage
            Personnage MatouCar = new Personnage
            {
                Nom = "MatouCar",
                Taille = 12
            };
            //2 - Equipements


            //3 - Associer l'équipement à notre personnage
            //Version Classique
            //if (MatouCar.Equipements is null)
            //{
            //    MatouCar.Equipements = new List<Equipement>();
            //}
            //MatouCar.Equipements.Add( CroketDistributor );
            //MatouCar.Equipements.Add ( Santiac );
            //MatouCar.Equipements.Add(Fleuret );
            ////Afficher tous les équipements
            //Console.WriteLine($"Mon pesonnage {MatouCar.Nom} possède :");
            //foreach (Equipement item in MatouCar.Equipements)
            //{
            //    Console.WriteLine($"Equipement : {item.Nom} - Couleur: {item.Couleur} - Puissance :{item.Puissance}");
            //}
            ////Recherche les bottes
            //MatouCar.Equipements[1].Couleur = "Magenta";

            //Version intermédaire pour faciliter la vie

            // MatouCar.Equipements["CroketDistributor"] = CroketDistributor;

            //Version Indexeur


            Equipement CroketDistributor = new Equipement() { Nom = "Krokettor", Couleur = "Brun", Puissance = 1 };
            Equipement Santiac = new Equipement() { Nom = "Bottes enchantées", Couleur = "Violet", Puissance = 6 };
            Equipement Fleuret = new Equipement() { Nom = "ExCatlibur", Couleur = "Argent", Puissance = 12 };
           // Santiac["Hauteur"] = 12;
            MatouCar["Nourriture"] =  CroketDistributor;
            MatouCar["Pied"] = Santiac;
            MatouCar["Main"] = Fleuret;

            MatouCar["Pied"].Couleur = "Pourpre";


            int PuissanceTotale =  CroketDistributor +  Santiac + Fleuret;
            Console.WriteLine(PuissanceTotale);
        }
    }
}
