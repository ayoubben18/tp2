using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice5
{
    interface ICrier
    {
        void Crier();
    }

    class Chat : ICrier
    {
        public void Crier()
        {
            Console.WriteLine("Le chat miaule.");
        }
    }

    class Chien : ICrier
    {
        public void Crier()
        {
            Console.WriteLine("Le chien aboie.");
        }
    }

    class Lapin
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ICrier[] animaux = new ICrier[4];
            animaux[0] = new Chat();
            animaux[1] = new Chien();
            animaux[2] = new Chien();
            animaux[3] = new Chat();

            foreach (var animal in animaux)
            {
                animal.Crier();
            }
        }
    }
}
