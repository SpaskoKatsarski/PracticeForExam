using System;

namespace T03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop")
            {
                int currentNum = int.Parse(input);

                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else 
                {
                    int counter = 0;
                    for (int i = 1; i <= currentNum; i++)
                    {
                        if (currentNum % i == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter == 2)
                    {
                        primeSum += currentNum;
                    }
                    else
                    {
                        nonPrimeSum += currentNum;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
