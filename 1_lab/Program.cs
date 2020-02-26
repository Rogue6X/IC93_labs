using System;

namespace trySh
{
    class Program
    {
        static void Main(string[] args)
        {
            int fnum, snum, tnum;
            Console.WriteLine("Введите число для операции инкремента: ");
            fnum = Convert.ToInt32(Console.ReadLine());
            Incr(ref fnum);
            Console.WriteLine(fnum);

            Console.Write("Введите первое число для операции <: ");
            snum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число для операции <: ");
            tnum = Convert.ToInt32(Console.ReadLine());
            Console.Write(Compare(snum, tnum));
        }
        static void Incr(ref int num)
        {
            for (int i = 0; i < 32; i++)
            {
                Out(num);
                int bit = num & (1 << i);
                num ^= (1 << i);
                if (bit == 0)
                {
                    Out(num);
                    break;
                }
            }
        }
        static string Compare(int a, int b)
        {
            int bitA = a >> 31;
            int bitB = b >> 31;
            if (bitA > bitB)
            {
                return "Отношение не выполняется - второе число НЕ больше первого";
            }
            else if (bitA < bitB)
            {
                return "Отношение выполняется - второе число больше первого";
            }
            else
                Out(a);
                Out(b);
            for (int i = 30; i > 0; i--)
                {
                    bitA = (a >> i) & 1;
                    bitB = (b >> i) & 1;
                    if (bitA > bitB)
                    {
                        return "Отношение не выполняется - второе число НЕ больше первого";
                    }
                    if (bitA < bitB)
                    {
                        return "Отношение выполняется - второе число больше первого";
                    }
                }
            return "Числа равны";
        }
        static void Out(int num){
            Console.WriteLine(Convert.ToString(num, 2));
            }
    }
}