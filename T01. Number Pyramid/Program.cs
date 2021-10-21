using System;

namespace T01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int current = 1;

            for (int rows = 1; rows <= input; rows++)
            {
                for (int i = 1; i <= rows; i++)
                {
                    if (current > input)
                    {
                        return;
                    }
                    Console.Write($"{current} ");
                    current++;
                }
                Console.WriteLine();
            }
        }
    }
}
