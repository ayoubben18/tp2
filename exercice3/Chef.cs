using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
    class Chef : Employe
    {
        public string Service { get; set; }

        public Chef(string nom, string prenom, int age, decimal salaire, string service)
            : base(nom, prenom, age, salaire)
        {
            Service = service;
        }

        public override string ToString()
        {
            return base.ToString() + $", Service: {Service}";
        }

        public override void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
