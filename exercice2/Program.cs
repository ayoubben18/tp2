using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nom, prenom, tel;
            int age;

            Console.WriteLine("Entrer le nom de la personne: ");
            nom = Console.ReadLine();

            Console.WriteLine("Entrer le prenom de la personne: ");
            prenom = Console.ReadLine();

            Console.WriteLine("Entrer le tel de la personne: ");
            tel = Console.ReadLine();

            Console.WriteLine("Entrer l'age de la personne: ");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Entrer une valeur valide pour l'age: ");
            }

            Personne personne = new Personne(nom, prenom, age, tel);

            Console.WriteLine("Choisir une ville pour la personne:");
            Console.WriteLine("1. Fes");
            Console.WriteLine("2. Marrakech");
            Console.WriteLine("3. Rabat");
            Console.WriteLine("4. Casablanca");

            int villeChoisie;
            while (!int.TryParse(Console.ReadLine(), out villeChoisie) || villeChoisie < 1 || villeChoisie > 4)
            {
                Console.WriteLine("Choisir un numero valide (1-4): ");
            }

            personne.Origine = (Ville)(villeChoisie - 1);

            personne.SavoirOrigine();
        }
    }
}
