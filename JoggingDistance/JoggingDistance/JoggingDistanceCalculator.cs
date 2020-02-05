using System;


namespace JoggingDistance
{
    /// <summary>
    /// author: stu
    /// date: 2020
    /// program: jogging distance
    /// purpose: to calculate.. jogging distance
    /// </summary>
    class JoggingDistanceCalculator
    {
        static void Main(string[] args)
        {
            //declare variables here


            //intro
            DisplayHello();

            //gather stride inputs
            double avgStridesPerMinute = StridesInput();

            //gather time in total minutes
            int totalMinutesRun = RunTimeInput();

            //total strides taken over time
            double totalStrides = CalculateTotalStrides(avgStridesPerMinute, totalMinutesRun);

            //distance travelled (feet --> miles)
            double distanceTravelled = CalculateDistance(totalStrides);

            //outro
            Adios(avgStridesPerMinute, totalMinutesRun, distanceTravelled);


        }


        /// <summary>
        /// simple welcome message
        /// </summary>
        static void DisplayHello()
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("this is the jogging distance calculator");
            Console.WriteLine("enter your first and last minute's average stride");
            Console.WriteLine("and the time spent running in hours, minutes");
            Console.WriteLine("I'll output the distance travelled in miles");
            Console.WriteLine("honk");
            Console.WriteLine("*************************************************");
        }//end DisplayHello



        /// <summary>
        /// StridesInput takes in user inputs about the run, 
        /// and returns an average of strides per minute
        /// </summary>
        /// <returns></returns>
        static double StridesInput()
        {
            Console.Write("please enter the steps in your first minute: ");
            string tempInput = Console.ReadLine();
            int firstStrideAverage = int.Parse(tempInput);
            Console.Write("please enter the steps in your LAST minute: ");
            tempInput = Console.ReadLine();
            int lastStrideAverage = int.Parse(tempInput);

            return (firstStrideAverage + lastStrideAverage) / 2;

        }//end StridesInput


        static int RunTimeInput()
        {
            Console.Write("please enter hours spent running: ");
            string tempInput = Console.ReadLine();
            int hoursSpent = int.Parse(tempInput);
            Console.Write("please enter minutes spent running: ");
            tempInput = Console.ReadLine();
            int minutesSpent = int.Parse(tempInput);

            // now to convert to minutes and return
            return (hoursSpent * 60) + minutesSpent;
        }//end RunTimeInput



        /// <summary>
        /// CalculateTotalStrides takes in the average of first and last strides 
        /// and multiplies by minutes
        /// </summary>
        /// <param name="avgStrides"></param>
        /// <param name="runTime"></param>
        /// <returns></returns>
        static double CalculateTotalStrides(double avgStrides, int runTime)
        {
            return avgStrides * runTime;
        }//end CalculateTotalStrides


        /// <summary>
        /// CalculateDistance takes in the strides and makes a distance out of them
        /// </summary>
        /// <param name="totalStrides"></param>
        /// <returns></returns>
        static double CalculateDistance(double totalStrides)
        {
            //method variable (local)
            const double STRIDE_LENGTH = 2.5;
            const int FEET_PER_MILE = 5280;

            return (totalStrides * STRIDE_LENGTH) / FEET_PER_MILE;
        }//end CalculateDistance


        static void Adios(double stridesPerMinute, int joggingTime, double distance)
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("average strides per minute {0}", stridesPerMinute);
            Console.WriteLine("minutes jogging: {0}", joggingTime);
            Console.WriteLine("TOTAL miles traveled: {0:f2}", distance);
            Console.WriteLine("*************************************************");
            Console.ReadKey();
        }//end Adios

    }//end class
}//end namespace
