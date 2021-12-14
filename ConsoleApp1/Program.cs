using System;

namespace Melyakina.Lab5.Num1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            int dmax = a[0, 0];
            int di = 0;

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Введите {0}-ю строку", i + 1);
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i, i] > dmax)
                {
                    dmax = a[i, i];
                    di = i;
                }

            }
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[di, j]);
            }
        }
    }
}