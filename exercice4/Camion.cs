using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    class Camion : Vehicule
    {
        public Camion(int annee, decimal prix) : base(annee, prix) { }

        public override void Demarrer()
        {
            Console.WriteLine("Le camion demarre.");
        }

        public override void Accelerer()
        {
            Console.WriteLine("Le camion accelere.");
        }
    }
}
