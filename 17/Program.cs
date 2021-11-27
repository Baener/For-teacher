using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var mas = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));

            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += mas[i];
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма {sum}");
        }
    }
}
