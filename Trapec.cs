using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    public class Trapec : Cetiriugulnik
    {
        public Trapec(double a, double b, double c, double d, double h)
            : base(a, b, c, d, h)
        {
            Name = "Trapec";
        }

        public override double Lice()
        {
            return Math.Round(((a + b) / 2) * h, 2);
        }
    }
}
