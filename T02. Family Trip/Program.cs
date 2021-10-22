using System;

namespace T02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceForNight = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                priceForNight *= 0.95;
            }

            double priceForNights = (double)nights * priceForNight;
            double savedMoneyFromTheBudget = budget * ((double)percent / 100);
            double total = priceForNights + savedMoneyFromTheBudget;

            double differnce = Math.Abs(budget - total);

            if (total <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {differnce:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{differnce:f2} leva needed.");
            }
        }
    }
}
