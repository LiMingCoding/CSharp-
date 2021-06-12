using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 入门._2021年6月21日
{
    public class delegateTest
    {
        public delegate double ProcessDelegate(double param1, double param2);
        public static double Multiply(double param1, double param2) => param1 * param2;
        public static double Divide(double param1, double param2) => param1 / param2;
        public static void Test()
        {
            delegateTest.ProcessDelegate process;
            Console.WriteLine("Enter 2 numbers separeted with a comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(",");
            double param1 = Double.Parse(input.Substring(0, commaPos));
            double param2 = Double.Parse(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            Console.WriteLine("Enter M to multiply or Enter D to Divide:");
            input = Console.ReadLine();
            if (input == "M")
            {
                process = new delegateTest.ProcessDelegate(delegateTest.Multiply);

            }
            else
            {
                process = new delegateTest.ProcessDelegate(delegateTest.Divide);
            }
            Console.WriteLine($"{process(param1, param2)}");
            int myNumber = 5;
            Methods.ShowDouble(ref myNumber);
            Console.WriteLine(myNumber);
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            Console.WriteLine($"The maximum value in myArray is {Methods.MaxValue(myArray, out _)}");
        }

    }  
}
