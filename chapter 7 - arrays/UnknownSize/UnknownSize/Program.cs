using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnknownSize
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[50];
            string inValue;
            int scoreCnt = 0;
            Console.Write($"enter score {scoreCnt + 1}: ((-99 to exit my friend)) ");
            inValue = Console.ReadLine();                                       // prime the read

            while (inValue != "-99")
            {
                if(int.TryParse(inValue, out score[scoreCnt]) == false)
                    Console.WriteLine("Invalid yada yada - 0 stored in the thing");
                ++scoreCnt;
                Console.Write($"enter score {scoreCnt + 1}: ((-99 to exit my firend))");
                inValue = Console.ReadLine();
            }
            Console.WriteLine($"the number of scores is {scoreCnt}");
            foreach (var item in score)
            {
                Console.Write(item);
            }
        }
    }
}
