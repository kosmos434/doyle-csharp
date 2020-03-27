using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AverageDiff
    {
        static void Main(string[] args)
        {
            int total = 0;
            double avg;
            double distance;
            string inValue;
            int[] score = new int[4];

            // values are entered
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write($"enter score {i + 1} ");
                inValue = Console.ReadLine();
                if (int.TryParse(inValue, out score[i]) == false)
                    Console.WriteLine("Invalid data entered my dude - 0 stored in array");
            }

            // values are averaged
            for (int i = 0; i < score.Length; i++)
            {
                total += score[i];
            }
            avg = (double) total / score.Length;                // casting is done to avoid integer division
            Console.WriteLine();
            Console.WriteLine($"average: {avg.ToString("F0")}");

            // output is the array element and how far the value is from the mean (absolute value)
            Console.WriteLine();
            Console.WriteLine("Score\tDist. from Avg.");

            for (int i = 0; i < score.Length; i++)
            {
                distance = Math.Abs((avg - score[i]));
                Console.WriteLine($"{score[i]}\t\t{distance.ToString("F0")}");
            }
            Console.ReadKey();
        }
    }
}
