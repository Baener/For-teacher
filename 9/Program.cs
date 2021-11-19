using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("Введите три числа, чтобы определить меньшее из них:");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            m = x < y ? x < z ? x : z : y < z ? y : z;
            Console.WriteLine($"min = {m}");
        }
    }
}
