using System;

namespace _01._Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statuesPrice = (double)0.70 * rent;
            double catering = (double)0.85 * statuesPrice;
            double sound = (double)0.5 * catering;

            Console.WriteLine($"{(rent + statuesPrice + catering + sound):f2}");
        }
    }
}
