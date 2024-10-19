using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule voiture = new Voiture(2021, 20000);
            Vehicule camion = new Camion(2019, 40000);

            Console.WriteLine(voiture.ToString());
            voiture.Demarrer();
            voiture.Accelerer();

            Console.WriteLine(camion.ToString());
            camion.Demarrer();
            camion.Accelerer();
        }
    }
}
