using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
    class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public virtual string ToString()
        {
            return $"{Nom} {Prenom}, Age: {Age}";
        }

        public virtual void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
