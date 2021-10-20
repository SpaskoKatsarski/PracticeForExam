using System;

namespace T02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int stuntMen = int.Parse(Console.ReadLine());
            double pricePerClothingFor1 = double.Parse(Console.ReadLine());

            double decorPrice = 0.10 * budget;

            if (stuntMen > 150)
            {
                pricePerClothingFor1 *= 0.90;
            }
            double priceForAllClothing = stuntMen * pricePerClothingFor1;

            double total = decorPrice + priceForAllClothing;

            double difference = Math.Abs(total - budget);
            if (total <= budget)
            {
                Console.WriteLine($"Action!\nWingard starts filming with {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!\nWingard needs {difference:f2} leva more.");
            }
        }
    }
}
