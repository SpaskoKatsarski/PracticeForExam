using System;

namespace T03._Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            string type = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double pricePerTicket = 0;

            if (film == "A Star Is Born")
            {
                if (type == "normal")
                {
                    pricePerTicket = 7.50;
                }
                else if (type == "luxury")
                {
                    pricePerTicket = 10.50;
                }
                else
                {
                    pricePerTicket = 13.50;
                }
            }
            else if (film == "Bohemian Rhapsody")
            {
                if (type == "normal")
                {
                    pricePerTicket = 7.35;
                }
                else if (type == "luxury")
                {
                    pricePerTicket = 9.45;
                }
                else
                {
                    pricePerTicket = 12.75;
                }
            }
            else if (film == "Green Book")
            {
                if (type == "normal")
                {
                    pricePerTicket = 8.15;
                }
                else if (type == "luxury")
                {
                    pricePerTicket = 10.25;
                }
                else
                {
                    pricePerTicket = 13.25;
                }
            }
            else if (film == "The Favourite")
            {
                if (type == "normal")
                {
                    pricePerTicket = 8.75;
                }
                else if (type == "luxury")
                {
                    pricePerTicket = 11.55;
                }
                else
                {
                    pricePerTicket = 13.95;
                }
            }
            double total = (double)pricePerTicket * tickets;
            Console.WriteLine($"{film} -> {total:f2} lv.");
        }
    }
}
