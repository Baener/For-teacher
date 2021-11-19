using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что бы увидеть таблицу умножения введите F");
            string x = Console.ReadLine();
            string z = "F";
            int sum;
            if (x == z)
            {
                for (int i = 2; i <= 9; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        sum = i * j;
                        Console.WriteLine($"{i} x {j} = {sum}");
                    }
                }
            }
            else Console.WriteLine("Видимо это программа не очень та и нужна)");
        }
    }
}
