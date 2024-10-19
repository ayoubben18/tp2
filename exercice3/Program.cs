using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne[] personnes = new Personne[8];

            personnes[0] = new Employe("ISmail", "Ashibat", 30, 2500);
            personnes[1] = new Employe("Zakaria", "Azila", 28, 2600);
            personnes[2] = new Employe("Hamid", "Zahir", 35, 3000);
            personnes[3] = new Employe("Oum", "Kltoum", 32, 2800);
            personnes[4] = new Employe("Hassan", "Hassan", 40, 3200);
            personnes[5] = new Chef("Hassan", "Skikri", 45, 4000, "IT");
            personnes[6] = new Chef("Ali", "Fassi Fihri", 42, 4200, "RH");
            personnes[7] = new Directeur("Ayoub", "Bensalah", 50, 5000, "IT", "CapitaleTech");

            for (int i = 0; i < personnes.Length; i++)
            {
                if (personnes[i] is Employe emp)
                {
                    emp.Age += 10;
                }

                if (personnes[i] is Chef chef)
                {
                    chef.Salaire += 500; 
                    chef.Service = "Nv Service"; 
                }
            }

            foreach (var personne in personnes)
            {
                personne.Afficher();
            }
        }
    }
}
