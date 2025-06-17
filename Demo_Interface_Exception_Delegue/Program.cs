// See https://aka.ms/new-console-template for more information
using Demo_Interface_Exception_Delegue.Models;
using Demo_Interface_Exception_Delegue.Enums;
using Demo_Interface_Exception_Delegue.Stuctures;
using Demo_Interface_Exception_Delegue.Exceptions;

Console.WriteLine("Demo - Interfaces, Exceptions, Délégués");

//Création de ma Poule
Poule Lava = new Poule("Lava");
//Déplacement de la poule
Position emplacementDeMaPoule = Lava.Avancer(4, DIRECTION.Avant);
//Affichage de la poule
Console.WriteLine($"Ma poule se trouve désormais à l'emplacement x:{emplacementDeMaPoule.x} - y:{emplacementDeMaPoule.y}");

//On fait un petit renard
Renard Goupil = new Renard("Ysengrin");
//La poule est attentive au cri du renard
Goupil.ECrie += Lava.FuitPauvrePoule;

Goupil.VoitLapoule();




//On plante tout!!!
DIRECTION Fausse =(DIRECTION)456;
try
{
    Position emplacementAvecDirectionFausee = Lava.Avancer(4, Fausse);
    /* Console.WriteLine($"Ma poule se trouve désormais à l'emplacement x:{emplacementDeMaPoule.x} - y:{emplacementDeMaPoule.y}");*/
    
}
catch(DirectionException de)
{
    Console.WriteLine(de.ToString());
}
catch(Exception e)
{
    Console.WriteLine($"Message système {e.Message}");
}