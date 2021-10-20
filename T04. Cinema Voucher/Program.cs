using System;

namespace T04._Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());
            string product = Console.ReadLine();

            int sum = 0;
            int counter1 = 0;
            int counter2 = 0;

            int checkSum = 0;

            while (product != "End")
            {
                int firstDigit = (int)(product[0]);
                int secondDigit = (int)(product[1]);

                int firstDigitOfSecondCase = (int)(product[0]);

                if (product.Length > 7)
                {
                    checkSum += firstDigit + secondDigit;
                }
                else
                {
                    checkSum += firstDigitOfSecondCase;
                }

                if (checkSum > voucher)
                {
                    break;
                }

                if (product.Length > 7)
                {
                    sum += firstDigit + secondDigit;
                    counter1++;
                }
                else
                {
                    sum += firstDigitOfSecondCase;
                    counter2++;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"{counter1}\n{counter2}"); 
        }
    }
}
