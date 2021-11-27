using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var mas1 = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            int e = 0;
            int o = 0;

            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] > 0)
                {
                    e++;
                }
                else
                {
                    o++;
                }
            }
            int[] pol = new int[e];
            int[] otr = new int[o];

            int polIndex = 0;
            int otrIndex = 0;

            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] > 0)
                {
                    pol[polIndex] = mas1[i];
                    polIndex++;
                }
                else if (mas1[i] < 0)
                {
                    otr[otrIndex] = mas1[i];
                    otrIndex++;
                }
            }

            Console.WriteLine("Положительные:");
            for (int i = 0; i < pol.Length; i++)
            {
                Console.WriteLine($"{pol[i]} ");
            }

            Console.WriteLine("Отрицательные:");
            for (int i = 0; i < otr.Length; i++)
            {
                Console.WriteLine($"{otr[i]} ");
            }
        }
    }
}
