using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometryCalculator
{
    public abstract class Cetiriugulnik : Figura
    {
        protected double a, b, c, d, h;

        public Cetiriugulnik(double a, double b, double c, double d, double h = 0)
            : base("Cetiriugulnik", 4)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.h = h;
        }

        public override double P { get; set; }

        public override double Perimetur()
        {
            P = (a + b + c + d);
            return P;
        }

        public override abstract double Lice();
    }
}

