using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    public class Kvadrat : Cetiriugulnik
    {
        public Kvadrat(double strana) : base(strana, strana, strana, strana)
        {
            Name = "Kvadrat";
        }

        public override double Lice()
        {
            return a * a;
        }
    }
}