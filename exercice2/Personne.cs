using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    enum Ville { Fes, Marrakech, Rabat, Casablanca };

    internal class Personne
    {
        private string nom;
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Tel { get; set; }
        public Ville Origine { get; set; }

        public Personne()
        {
            Console.WriteLine("Construction de classe Personne");
        }

        public Personne(string nom, string prenom, int age, string tel) : this()
        {
            this.nom = nom; 
            Prenom = prenom;
            Age = age;
            Tel = tel;
        }

        public Personne(Personne p) : this(p.nom, p.Prenom, p.Age, p.Tel)
        {
        }

        public void ChangePersonne(int nouvelAge)
        {
            Age = nouvelAge;
        }

        public void SavoirOrigine()
        {
            switch (Origine)
            {
                case Ville.Fes:
                    Console.WriteLine("Origine: Fes");
                    break;
                case Ville.Marrakech:
                    Console.WriteLine("Origine: Marrakech");
                    break;
                case Ville.Rabat:
                    Console.WriteLine("Origine: Rabat");
                    break;
                case Ville.Casablanca:
                    Console.WriteLine("Origine: Casablanca");
                    break;
                default:
                    Console.WriteLine("Origine inconnue");
                    break;
            }
        }
    }
}
