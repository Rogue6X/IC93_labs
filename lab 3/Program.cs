using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Matr
    {
        private double x = 0;//переменная умножения
        public int[,] mx;
        // Размерность двухмерного массива
        public int rows, cols;
        public int Length;

        public Matr(int rows, int cols)
        {
            Random ran = new Random();
            this.rows = rows;
            this.cols = cols;
            mx = new int[this.rows, this.cols];
            Length = rows * cols;
            for (int i = 0; i < rows ; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mx[i, j] = ran.Next(1, 10);
                };
            }
            for (int i = 0; i < rows  ; i++)
            {
                for (int j = 0; j < cols ; j++)
                {
                    x += (mx[i, j] * mx[i, j]);
                }
            }
            x /= Length;
        }

        // Индексатор
        public int this[int index]
        {
            get
            {
           
                int sum = 0;
                for (int j = 0; j < rows; j++)
                {
                    sum += mx[j, index];
                }
                return sum;
            }
        }
        public double multiplicate//Описание свойства умножения
        {
            get
            {
                return x;
            }
        }
        public void Out()
        {
            for (int i = 0; i < rows ; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mx[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter which column's sum to count: ");
            int ans = Convert.ToInt32(Console.ReadLine());
            Matr arr = new Matr(4, 4);
            double sum = arr[ans-1];
            arr.Out();
            Console.WriteLine("Sum - "+sum);
            Console.WriteLine("Average of all squared elements: "+arr.multiplicate);

        }
    }
}