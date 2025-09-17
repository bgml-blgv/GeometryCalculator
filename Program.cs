using System.Diagnostics;
using System;

namespace GeometryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nGeometry Calculator\n");
                Console.WriteLine("1.Krug");
                Console.WriteLine("2.Triugulnik");
                Console.WriteLine("3.Cetiriugulnik");
                Console.WriteLine("0.Exit");
                Console.Write("Izberi figura: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Vuvedi radius: ");
                        double r = double.Parse(Console.ReadLine());
                        Krug krug = new Krug(r);
                        PrintResults(krug);
                        break;

                    case "2":
                        Console.Write("Vuvedi strana a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Vuvedi strana b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Vuvedi strana c: ");
                        double c = double.Parse(Console.ReadLine());
                        Triugulnik tri = new Triugulnik(a, b, c);
                        PrintResults(tri);
                        break;

                    case "3":
                        Console.WriteLine("\nIzberi vid chetiriugulnik:");
                        Console.WriteLine("1.Kvadrat");
                        Console.WriteLine("2.Trapec");
                        Console.Write("Izbor: ");
                        string quadChoice = Console.ReadLine();

                        if (quadChoice == "1")
                        {
                            Console.Write("Vuvedi strana: ");
                            double s = double.Parse(Console.ReadLine());
                            Kvadrat sq = new Kvadrat(s);
                            PrintResults(sq);
                        }
                        else if (quadChoice == "2")
                        {
                            Console.Write("Vuvedi osnova a: ");
                            double ta = double.Parse(Console.ReadLine());
                            Console.Write("Vuvedi osnova b: ");
                            double tb = double.Parse(Console.ReadLine());
                            Console.Write("Vuvedi strana c: ");
                            double tc = double.Parse(Console.ReadLine());
                            Console.Write("Vuvedi strana d: ");
                            double td = double.Parse(Console.ReadLine());
                            Console.Write("Vuvedi visochina h: ");
                            double th = double.Parse(Console.ReadLine());
                            Trapec tr = new Trapec(ta, tb, tc, td, th);
                            PrintResults(tr);
                        }
                        else
                        {
                            Console.WriteLine("Nevaliden izbor!");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Do skoro!");
                        return;

                    default:
                        Console.WriteLine("Nevaliden izbor, opitai otnovo.");
                        break;
                }
            }
        }

        static void PrintResults(Figura figura)
        {
            Console.WriteLine($"\nTozi {figura.Name} e sus P i S:");
            Console.WriteLine($"Perimetur: {figura.Perimetur():F2}cm");
            Console.WriteLine($"Lice: {figura.Lice():F2}cm");
        }
    }
}

