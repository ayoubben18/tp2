using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice6
{
    class Compte
    {
        private static int compteur = 0;
        public int NumeroCompte { get; private set; }
        public decimal Solde { get; private set; }
        public Client Proprietaire { get; private set; }

        public Compte(Client proprietaire, decimal soldeInitial = 0)
        {
            NumeroCompte = ++compteur;
            Proprietaire = proprietaire;
            Solde = soldeInitial;
        }

        public void Crediter(decimal montant)
        {
            Solde += montant;
            Console.WriteLine($"Compte {NumeroCompte} credite de {montant}$. Nouveau solde: {Solde}$.");
        }

        public void Crediter(decimal montant, Compte autreCompte)
        {
            autreCompte.Debiter(montant);
            this.Crediter(montant);
        }

        public void Debiter(decimal montant)
        {
            if (montant <= Solde)
            {
                Solde -= montant;
                Console.WriteLine($"Compte {NumeroCompte} debite de {montant}$. Nouveau solde: {Solde}$.");
            }
            else
            {
                Console.WriteLine($"Compte {NumeroCompte}: Solde insuffisant pour débiter {montant}$.");
            }
        }

        public void Debiter(decimal montant, Compte autreCompte)
        {
            autreCompte.Crediter(montant);
            this.Debiter(montant);
        }

        public void AfficherResume()
        {
            Console.WriteLine($"Resume du compte {NumeroCompte}: Proprietaire {Proprietaire.Nom} {Proprietaire.Prenom}, Solde: {Solde}$.");
        }

        public static void AfficherNombreComptes()
        {
            Console.WriteLine($"Nombre de comptes crees: {compteur}");
        }
    }
}
