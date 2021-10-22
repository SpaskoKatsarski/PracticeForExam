using System;

namespace T01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double entryPrice = double.Parse(Console.ReadLine());
            double priceForOneChair = double.Parse(Console.ReadLine());
            double priceForOneUmbrella = double.Parse(Console.ReadLine());

            double totalEnterPrice = entryPrice * people;
            double countForChairs = Math.Ceiling(people * 0.75);
            double countForUmbrellas = Math.Ceiling(people / 2.0);

            double total = totalEnterPrice + countForChairs * priceForOneChair + countForUmbrellas * priceForOneUmbrella;

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
