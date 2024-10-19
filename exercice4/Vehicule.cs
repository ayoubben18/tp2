using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    abstract class Vehicule
    {
        public string Matricule {  get; private set; }
        public int Annee { get; private set; }
        public decimal Prix { get; private set; }
        private static int compteur = 0;

        public Vehicule(int annee, decimal prix)
        {
            Matricule = "V-" + (++compteur);
            Annee = annee;
            Prix = prix;
        }

        public abstract void Demarrer();
        public abstract void Accelerer();

        public override string ToString()
        {
            return $"Matricule: {Matricule}, Annee: {Annee}, Prix: {Prix}$";
        }
    }
}
