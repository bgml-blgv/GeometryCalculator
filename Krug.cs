using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometryCalculator
{
    public class Krug : Figura
    {
        public double Radius { get; set; }

        public Krug(double radius) : base("Krug", 0)
        {
            Radius = radius;
        }

        public override double P { get; set; }

        public override double Perimetur()
        {
            P = (2 * Math.PI * Radius);
            return Math.Round(P, 2);
        }

        public override double Lice()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }
    }
}

