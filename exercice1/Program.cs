using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Entrer la valeur de A: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Entrer une valeur valide pour A: ");
            }
            Console.WriteLine("Entrer la valeur de B: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Entrer une valeur valide pour B: ");
            }
            Console.WriteLine("Entrer la valeur de C: ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Entrer une valeur valide pour C: ");
            }

            Equation equation = new Equation(a, b, c);

            equation.CalculerRacines();

            Console.WriteLine(equation.ToString());

        }
    }
}
