//Yizhou Wang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, num3;
            num1 = 788;
            num2 = 482.2;
            num3 = 382.222;
            Add(5, 17.5);
            Console.WriteLine($"5+17.5={result.ToString("N2")}");
            result = Add(num1, num2);
            Console.WriteLine($"{num1}+{num2}={result}");

            double[] nums = { num3, num2.num3 };
            //nums = new double[3];
            //nums[0] = num1;
            //num1[1] = num2;
            //num2[2] = num3;
            //num3[3] ERROR:indexer OUT OF BOUNDS
            result = Add(nums);

            Console.ReadKey();
        }
        static double Add(double[] numbersToAddUp)
        {
            double r = 0;
            int counter = 0;

            while (counter < numbersToAddUp.Length)
            {
                var number = numbersToAddUp[counter];
                r += number;
                //r=r+number;
                counter++;
            }
            r = 0;
            for (counter = 0; counter < numbersToAddUp.Length; counter++)
            {
                var number = numbersToAddUp[counter];
                r += number;
            }
            r = 0;

                foreach (var number in numbersToAddUp)
            {
                r += number;
            }
   
                //d
            return r;
        }


        /// <summary>
        /// Sums up two numbers and provides the result
        /// </summary>
        /// <param name="val1">The lefthand operand of the operation</param>
        /// <param name="val2">The righthand operand of the operation</param>
        /// <returns>The sum of val1 and val2</returns>
        static double Add(double val1, double val2)
        {
            double sum = 0;

            //if (val1 == 2)
            //{

           sum = val1 + val2;
            //    return sum;
            ////}
            //else
            //{
            //    return 3;
        }
        return sum;
    }
}

