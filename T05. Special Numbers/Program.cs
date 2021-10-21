using System;

namespace T05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    for (int k = 1; k <= number; k++)
                    {
                        for (int l = 1; l <= number; l++)
                        {
                            if (number % i == 0 && number % j == 0 && number % k == 0 && number % l == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
