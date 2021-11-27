using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 8 чисел");
            var mas = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            for (int i = 0; i < 8; i++)
            {
                if (mas[i] < 15)
                {
                    mas[i] *= mas[i];
                }
            }
            for (int i = 0; i < 8; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
    }
}
