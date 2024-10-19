using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice6
{

    class Client
    {
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }

        public Client(string cin, string nom, string prenom, string tel)
        {
            CIN = cin;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
        }

        public void Afficher()
        {
            Console.WriteLine($"Client: {Nom} {Prenom}, CIN: {CIN}, Tel: {Tel}");
        }
    }
}
