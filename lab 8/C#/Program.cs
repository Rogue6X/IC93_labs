using System;

namespace oop8sh
{
    class Program
    {

        static void Main(string[] args)
        {
            Operations math = new Operations();
            double a;
            double b;
            int ask=0;
            math.Tell += ShowMessage;
            while (true)
            {
                a = 0;
                b = 0;
                Console.WriteLine("Choose option:");
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Substract");
                Console.WriteLine("3 - Multiplicate");
                Console.WriteLine("4 - Divide");
                Console.WriteLine("0 - Exit");
                try {
                    ask = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Not valid value");
                }
                if (ask == 0)
                    break;
                Console.WriteLine("Insert а");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert b");
                b = Convert.ToInt32(Console.ReadLine());
                
                switch (ask)
                {
                    case 1:
                        Console.WriteLine("Result: {0}", math.Add(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Result: {0}", math.Substract(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Result: {0}", math.Multiplicate(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Result: {0}", math.Divide(a, b));
                        break;
                }
            }
        }
        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}