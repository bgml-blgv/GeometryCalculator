using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    public class Triugulnik : Figura
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triugulnik(double a, double b, double c) : base("Triugulnik", 3)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double P { get; set; }

        public override double Perimetur()
        {
            P = (A + B + C);
            return P;
        }

        public override double Lice()
        {
            double s = (A + B + C) / 2;
            double area = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            return Math.Round(area, 2);
        }
    }
}
