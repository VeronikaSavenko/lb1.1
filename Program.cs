using System;

namespace lb1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть сторони трикутника (через Enter):");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Triangle t1 = new Triangle(a, b, c);
            Console.WriteLine($"Периметр дорiвнює: {t1.Perimetr()}");
            Console.WriteLine($"Площа дорiвнює: {t1.Square()}");
        }
    }
}
