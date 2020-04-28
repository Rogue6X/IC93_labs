using System;
using System.IO;

namespace ooplab6
{
    class Vars
    {

        public double A { set; get; }
        public double B { set; get; }
        public double C { set; get; }
        public double D { set; get; }

        public Vars(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public static void log(string error)
        {
            File.WriteAllText(@"C:\Users\assas\source\repos\ОП 2сем\oop6sh\oop6sh\log.txt", error);
            
        }

        public double Calc()
        {
            if (B == 0)
            {
                throw new DivideByZeroException();
            }
            if (24 + D - C < 0)
            {
                throw new InvalidDataException();
            }
            return (1 + A - B / 2) / (Math.Sqrt(24 + D - C) + A / B);
        }


    }
}
