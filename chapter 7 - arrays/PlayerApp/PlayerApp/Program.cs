using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string ln,
                fn,
                iden;
            string inValue;

            int playerCnt,
                loopCnt = 0,
                gameCnt;
            int[] points = new int[1000];

            Console.Write("How many players playering?? ");
            inValue = Console.ReadLine();
            if(int.TryParse(inValue, out playerCnt) == false)
                Console.WriteLine("invalid yada yada -- 0 stored in the thing");

            Player[] teamMember = new Player[playerCnt];
            while (loopCnt < playerCnt)
            {
                GetIdInfo(out ln, out fn, out iden);
                gameCnt = 0;
                points = GetScores(ref gameCnt);
                teamMember[loopCnt] = new Player(ln, fn, iden, points, gameCnt);

                loopCnt++;
            }
            DisplayStats(teamMember);
            Console.ReadKey();
        }

        public static int [] GetScores(ref int gameCnt)
        {
            int[] points = new int[1000];
            string inValue;
            Console.Write($"Game {gameCnt + 1}: ((type -99 to exit))");
            inValue = Console.ReadLine();

            while (inValue != "-99")
            {
                if(int.TryParse(inValue, out points[gameCnt]) == false)
                    Console.WriteLine("Invalid data yada yada ------- 0 points recorded in array element");
                ++gameCnt;
                Console.Write($"Game {gameCnt + 1}: ((type -99 to exit))");
                inValue = Console.ReadLine();
            }
            return points;
        }

        public static void GetIdInfo(out string ln, out string fn, out string iden)
        {
            Console.WriteLine();
            Console.Write("Player firzt name: ");
            fn = Console.ReadLine();
            Console.Write("Player lazt name: ");
            ln = Console.ReadLine();
            Console.Write("Player identity number: ");
            iden = Console.ReadLine();
        }

        public static void DisplayStats(Player[] teamMember)
        {
            Console.WriteLine();
            Console.WriteLine("{0,12} {1, 25}", "Player", "Avg Points");
            Console.WriteLine("---------------------------------------");
            foreach (Player pl in teamMember)
            {
                Console.WriteLine("{0, -25} {1, 17}", 
                    (pl.FName + "" + pl.LName),
                    pl.ComputeAverage().ToString("F0"));
            }
        }
    }
}
