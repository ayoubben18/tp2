using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    class Voiture : Vehicule
    {
        public Voiture(int annee, decimal prix) : base(annee, prix) { }

        public override void Demarrer()
        {
            Console.WriteLine("La voiture demarre.");
        }

        public override void Accelerer()
        {
            Console.WriteLine("La voiture accelere.");
        }
    }
}
