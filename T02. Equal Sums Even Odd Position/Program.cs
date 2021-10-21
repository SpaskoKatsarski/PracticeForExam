using System;

namespace T02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int num = start; num <= end; num++)
            {
                int oddSum = 0;
                int evenSum = 0;
                int counter = 0;
                int currentNum = num;

                while (currentNum != 0)
                {
                    int currDigit = currentNum % 10;
                    if (counter % 2 == 0)
                    {
                        evenSum += currDigit;
                    }
                    else
                    {
                        oddSum += currDigit;
                    }
                    counter++;
                    currentNum /= 10;
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
