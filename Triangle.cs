using System;
using System.Collections.Generic;
using System.Text;

namespace lb1._1
{
    public class Triangle
    {
        private double[] sides = new double[3];
        public double this[int index]
        {
            get { return sides[index]; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона не може бути вiд'ємною чи дорiвнювати нулю.");
                sides[index] = value;
            }
        }
        public void InputSides(double a, double b, double c)
        {
            this[0] = a;
            this[1] = b;
            this[2] = c;
        }
        public Triangle(double a, double b, double c)
        {
            InputSides(a, b, c);
            if (!IsExistTriangle(this[0], this[1], this[2])) throw new ArgumentException("Трикутник не iснує.");
        }
        private bool IsExistTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
        public double Perimetr()
        {
            return this[0] + this[1] + this[2];
        }
        public double Square()
        {
            double p = Perimetr() / 2;
            return Math.Sqrt(p * (p - this[0]) * (p - this[1]) * (p - this[2]));
        }
    }
}
