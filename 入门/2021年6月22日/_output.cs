using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 入门._2021年6月22日
{
    class _output
    {
        public static void TestOutPut()
        {
            int[] testArray = { 4, 6, 4, 2, 7, 3, 7, 8, 9, 1,9 };
            int[] maxValIndices;
            int maxVal = Maxima(testArray,out maxValIndices);
            Console.WriteLine($"Maxium value {maxVal} found at element indices.");
            foreach (int index in maxValIndices)
            {
                Console.WriteLine(index);
            }
        }
        static int Maxima(int[] integers, out int[] indices)
        {
            Debug.WriteLine("Maxima value search strarted.");
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1;
            Debug.WriteLine(string.Format($"Maxima value initialized to {maxVal},at element index 0."));
            for (int i = 1; i <integers.Length; i++)
            {
                Debug.WriteLine(string.Format($"Now looking at element at index{i}."));
                if (integers[i]>maxVal)
                {
                   maxVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                    Debug.WriteLine(string.Format($"New maximum found.New value is {maxVal},element index{i}."));
                }
                else
                {
                    if (integers[i]==maxVal)
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];
                        oldIndices.CopyTo(indices,0);
                        indices[count - 1] = i;
                         Debug.WriteLine(string.Format($"Duplicate maxium found at element index[i]")); 
                    }
                }
            }
            Trace.WriteLine(string.Format($"Maximum value {maxVal} found, with {count} occurrences."));
            Debug.WriteLine("Maxium value serach completed");
            return maxVal;
        }
    }
}
