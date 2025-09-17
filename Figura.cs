using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    public abstract class Figura
    {
        private string name;
        private int brStr;

        public Figura(string name, int brStr)
        {
            this.name = name;
            this.brStr = brStr;
        }

        // Properties
        public string Name { get => name; set => name = value; }
        public int BrStr { get => brStr; set => brStr = value; }

        public abstract double P { get; set; } 

        public abstract double Perimetur();
        public abstract double Lice();
    }
}

