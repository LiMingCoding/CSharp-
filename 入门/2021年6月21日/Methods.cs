using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 入门._2021年6月21日
{
   public class Methods
    {
        #region ShowDouble
        //把myNumber当作一个参数，调用ShowDouble（）并不影响Main（）中myNumber的值。
        public static void ShowDouble(ref int val)
        {
            val *= 2;
            Console.WriteLine($"val doubled = {val}");
        }
        #endregion

        #region SumVals
        public static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum = sum + val;
            }
            return sum;
        }
        #endregion
        #region MaxValue
        public static int MaxValue(int[] intArray,out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i]>maxVal)
                {
                    maxVal = intArray[i];
                    maxIndex= i;
                }
                
            }
            return maxVal;
        }

        #endregion
    }
}
