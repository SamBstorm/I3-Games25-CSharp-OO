namespace Demo_PolyMorphisme.Models
{
    internal class InventaireItem
    {

        public string Nom { get; private set; }
        public int Prix { get; private set; }

        public InventaireItem(string nom, int prix)
        {
            Nom = nom;
            Prix = prix;
        }

        public void Vendre(Joueur joueur)
        {
            joueur.Solde += this.Prix;
            joueur.JeterObjet(this);
        }

    }
}