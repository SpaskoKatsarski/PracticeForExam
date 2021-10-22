using System;

namespace T03._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugarOption = Console.ReadLine();
            int countDrinks = int.Parse(Console.ReadLine());

            double totalForOneCup = 0;
            double total = 0;

            if (drink == "Espresso")
            {
                if (sugarOption == "Without")
                {
                    totalForOneCup = 0.90;
                    total = (double)totalForOneCup * countDrinks * 0.65;
                }
                else if (sugarOption == "Normal")
                {
                    totalForOneCup = 1;
                }
                else
                {
                    totalForOneCup = 1.20;
                }
                if (sugarOption != "Without")
                {
                    total = (double)totalForOneCup * countDrinks;
                }
                if (countDrinks >= 5)
                {
                    total *= 0.75;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (sugarOption == "Without")
                {
                    totalForOneCup = 1;
                    total = (double)countDrinks * totalForOneCup * 0.65; 
                }
                else if (sugarOption == "Normal")
                {
                    totalForOneCup = 1.20;
                }
                else
                {
                    totalForOneCup = 1.60;
                }
                if (sugarOption != "Without")
                {
                    total = (double)totalForOneCup * countDrinks;
                }
            }
            else
            {
                if (sugarOption == "Without")
                {
                    totalForOneCup = 0.50;
                    total = (double)countDrinks * totalForOneCup * 0.65;
                }
                else if (sugarOption == "Normal")
                {
                    totalForOneCup = 0.60;
                }
                else
                {
                    totalForOneCup = 0.70;
                }
                if (sugarOption != "Without")
                {
                    total = (double)totalForOneCup * countDrinks;
                }
            }
            if (total > 15)
            {
                total *= 0.80;
            }
            Console.WriteLine($"You bought {countDrinks} cups of {drink} for {total:f2} lv.");
        }
    }
}
