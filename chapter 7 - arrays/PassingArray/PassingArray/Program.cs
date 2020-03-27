using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperature = new int[5];
            int[] t = new int[5];

            InputValues(temperature);

            // Array t wil reference the same array
            // as the temperature array!!
            t = temperature;
            t[1] = 44;
            Console.WriteLine(temperature[1]);
            Console.WriteLine($"value stored in temperature[1]: {temperature[1]}");
            Console.ReadKey();
        }

        public static void InputValues(int[] temp)
        {
            string inValue;
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write($"enter temperature {i + 1}: ");
                inValue = Console.ReadLine();
                if (int.TryParse(inValue, out temp[i]) == false)
                    Console.WriteLine("invlaid data yada yada ----- 0 stored as the value");
            }
        }
    }
}
