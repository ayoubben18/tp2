using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice1
{
    internal class Equation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Delta { get; private set; }
        public double R1 { get; private set; }
        public double R2 { get; private set; }

        public Equation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void CalculerRacines()
        {
            Delta = B * B - 4 * A * C;
            if (Delta > 0)
            {
                R1 = (-B + Math.Sqrt(Delta)) / (2 * A);
                R2 = (-B - Math.Sqrt(Delta)) / (2 * A);
            }
            else if (Delta == 0)
            {
                R1 = R2 = -B / (2 * A);
            }
            else
            {
                R1 = R2 = double.NaN;
            }
        }

        public override string ToString()
        {
            if (Delta < 0)
            {
                return "Pas de racines réelles";
            }
            else if (Delta == 0)
            {
                return $"Une seule racine: {R1}";
            }
            else
            {
                return $"Les racines sont: r1 = {R1}, r2 = {R2}";
            }
        }
    }
}
