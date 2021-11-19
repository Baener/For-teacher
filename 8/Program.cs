using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, fac = 1;
            Console.WriteLine("Введите положительное число, чтобы вычислить его факториал: ");
            int h = Convert.ToInt32(Console.ReadLine());
            if (h <= 0)
            {
                Console.WriteLine("Просьба ввести ПОЛОЖИТЕЛЬНОЕ число >:(:");
                int c = Convert.ToInt32(Console.ReadLine());
                {
                    do
                    {
                        a += 1;
                        fac *= a;

                    } while (c != a);

                    Console.WriteLine($"Факториал числа {c} равен: {fac}");
                }
            }
            else if (h > 0)
            {
                do
                {
                    a += 1;
                    fac *= a;

                } while (h != a);

                Console.WriteLine($"Факториал числа {p} равен: {fac}");
            }
        }
    }
}
