using System;

namespace NewTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    str = "even";
                }
                else
                {
                    str = "odd";
                }
                Console.WriteLine($"The current text is in {str} position.", str);
            }
        }
    }
}
