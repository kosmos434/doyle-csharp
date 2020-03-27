using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] examScore;
            int totalScores = 0;
            int countOfScores = 0;
            string inValue;
            double averageTestScore;
            try
            {
                Console.Write("how many scores will you enter? ");
                inValue = Console.ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];

                for (int i = 0; i < countOfScores; i++)
                {
                    Console.Write($"enter score {i + 1}: ");
                    inValue = Console.ReadLine();
                    examScore[i] = int.Parse(inValue);
                    totalScores += examScore[i];
                }

                averageTestScore = totalScores / countOfScores;
                Console.WriteLine($"average is {averageTestScore}");
            }
            //catch    generic catch all
            catch (System.Exception e)
            {
                Console.WriteLine("problem with scores ~ cannot compute average");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
