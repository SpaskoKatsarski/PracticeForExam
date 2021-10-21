using System;

namespace T04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double sumAllGrades = 0;
            int counter = 0;
            while (presentation != "Finish")
            {
                double sumCurrentGrades = 0;
                for (int i = 0; i < judges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    counter++;
                    sumCurrentGrades += grade;
                    sumAllGrades += grade;
                }
                double averageForCurrentPresentation = (double)sumCurrentGrades / judges;
                Console.WriteLine($"{presentation} - {averageForCurrentPresentation:f2}.");

                presentation = Console.ReadLine();
            }
            double averageFromAllPresentations = sumAllGrades / counter;
            Console.WriteLine($"Student's final assessment is {averageFromAllPresentations:f2}.");
        }
    }
}
