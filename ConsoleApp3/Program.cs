using System;

namespace Lab6.part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 1 | a[i] < 0)
                    sum = sum + a[i];
            }
            Console.Write(sum);

        }
    }
}