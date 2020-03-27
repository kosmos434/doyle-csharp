using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleCatches
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

                for(int i = 0; i < countOfScores; i++)
                {
                    Console.Write($"enter score {i + 1}"); ;
                    inValue = Console.ReadLine();
                    examScore[i] = int.Parse(inValue);
                    totalScores += examScore[i];
                }

                averageTestScore = totalScores / countOfScores;
                Console.WriteLine($"averafe is {averageTestScore}");
            }
            catch (System.FormatException e)
            {
                Console.Error.WriteLine($"problem with one of the operands ~" +
                    $" cannot compute average!");
                Console.Error.WriteLine($"exception type: {e.Message}");
            }
            catch(System.DivideByZeroException e)
            {
                Console.Error.WriteLine("no exam scores were entered!! cannot compute");
                Console.Error.WriteLine($"exception type: {e.Message}");
            }
            catch (System.ArithmeticException e)
            {
                Console.Error.WriteLine("error in arithmetic or casing");
                Console.Error.WriteLine($"exception type: {e.Message}");
            }
            catch (System.Exception e)      // can write this as just catch {}
            {
                Console.Error.WriteLine("any other problem ~~ that's an error, bud");
                Console.Error.WriteLine($"exception type: {e.Message}");
            }
            finally
            {
                Console.WriteLine("...\n...\n..." +
                    "Terminated normally!!");
            }
            Console.ReadKey();
        }
    }
}
