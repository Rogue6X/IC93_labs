using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop8sh
{
    class Operations
    {
        public delegate void Handler(string message);
        public event Handler Tell;
        public double Add(double a, double b)
        {
            if (a + b == 0)
            {
                Tell.Invoke("Result is 0");
                return 0;
            }
            else
            {
                return a + b;
            }

        }
        public double Substract(double a, double b)
        {
            if (a - b == 0)
            {
                Tell?.Invoke("Result is 0");
                return 0;
            }
            else
            {
                return a - b;
            }

        }
        public double Multiplicate(double a, double b)
        {
            if (a * b == 0)
            {
                Tell?.Invoke("Result is 0");
                return 0;
            }
            else
            {
                return a * b;
            }

        }
        public double Divide(double a, double b)
        {
            if (a / b == 0)
            {
                Tell?.Invoke("Result is 0");
                return 0;
            }
            else
            {
                return a / b;
            }

        }
    }
}