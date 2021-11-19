using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа, среди которых хотите найти меньшее");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (1 <= a && a <= 3) Console.WriteLine(a);
            else Console.WriteLine();

            if (1 <= b && b <= 3) Console.WriteLine(b);
            else Console.WriteLine();

            if (1 <= c && c <= 3) Console.WriteLine(c);
            else Console.WriteLine();
        }
    }
}
