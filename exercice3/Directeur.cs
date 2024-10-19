using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
    class Directeur : Chef
    {
        public string Societe { get; set; }

        public Directeur(string nom, string prenom, int age, decimal salaire, string service, string societe)
            : base(nom, prenom, age, salaire, service)
        {
            Societe = societe;
        }

        public override string ToString()
        {
            return base.ToString() + $", Societe: {Societe}";
        }

        public override void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
