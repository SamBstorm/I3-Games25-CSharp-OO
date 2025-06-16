using Demo_PolyMorphisme.Models;

namespace Demo_PolyMorphisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Joueur player = new Joueur();
            /* Démo Debut
            InventaireItem pepite = new InventaireItem("Pépite", 5000);

            player.Loot(pepite);

            Console.WriteLine("Inventaire :");
            foreach (InventaireItem item in player.Inventaire)
            {
                Console.WriteLine($"\t- {item.Nom}");
            }

            player.Inventaire[0].Vendre(player);
            Console.WriteLine($"Votre solde est de {player.Solde}");

            Console.WriteLine("Inventaire :");
            foreach (InventaireItem item in player.Inventaire)
            {
                Console.WriteLine($"\t- {item.Nom}");
            }

            Equipement epee = new Equipement("Épée de vérité", 10000, 2, 5);

            player.Loot(epee);
            /* //Ancienne méthode
            //if(player.Inventaire[0] is Equipement)
            //{
            //    Equipement equipementInventaire = (Equipement)player.Inventaire[0];
            //    player.Equiper( equipementInventaire , true);
            //}
            if (player.Inventaire[0] is Equipement equipementInventaire)
            {
                player.Equiper(equipementInventaire, true);
            }*/

            /*Démo avec Coffre*/

            List<Coffre> coffres = new List<Coffre>();
            for (int i = 0; i < 5; i++)
            {
                coffres.Add(new Coffre([
                    new InventaireItem("Pépite",5000),
                    new InventaireItem("Poussière de diamant", 1000),
                    new InventaireItem("Potion", 500),
                    new Equipement("Casque", 1200, 5, 0),
                    new Equipement("Épée de vérité", 2500, 2, 5),
                    new Equipement("Masse du chatillement", 2200, 0, 8)
                    ]));
            }
            coffres.Add(new Coffre(new InventaireItem("Clé du donjon", 0)));
            coffres.Add(new Coffre(new Equipement("Anneau de pouvoir", 0, 10, 10)));

            foreach (Coffre c in coffres)
            {
                player.Loot(c.Contenu);
                c.ViderCoffre();
            }

            

            while (player.Inventaire.Length > 0)
            {
                Console.Clear();
                Console.WriteLine("Inventaire : ");
                for (int i = 0; i < player.Inventaire.Length; i++)
                {
                    InventaireItem item = player.Inventaire[i];
                    Console.WriteLine($"{i} - {item.Nom}");
                }
                Console.WriteLine($"Votre solde : {player.Solde}");

                Console.WriteLine("Quel objet voulez-vous manipuler ?");
                int choix = int.Parse(Console.ReadLine());
                InventaireItem objetSelectionne = player.Inventaire[choix];
                Console.Write("(V)endre");
                if (objetSelectionne is Equipement)
                {
                    Console.WriteLine(" - (E)quiper");
                }
                switch (Console.ReadKey().KeyChar)
                {
                    case 'V':
                        objetSelectionne.Vendre(player);
                        break;
                    case 'E':
                        if (objetSelectionne is Equipement equipement)
                        {
                            player.Equiper(equipement, true);
                        }
                        break;
                } 
            }
        }
    }
}
