using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
    class Employe : Personne
    {
        public decimal Salaire { get; set; }

        public Employe(string nom, string prenom, int age, decimal salaire)
            : base(nom, prenom, age)
        {
            Salaire = salaire;
        }

        public override string ToString()
        {
            return base.ToString() + $", Salaire: {Salaire}$";
        }

        public override void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
