using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSwaps2
{
    class Program
    {
        private static int counter = 0;
        static int minimumSwaps(int[] arr)
        {
            int temp1,temp2;
            int count = arr.Length;
            bool isFinished= true;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] != i + 1)
                {
                    temp1 = arr[i] - 1;
                    temp2 = arr[temp1];

                    arr[temp1] = arr[i];
                    arr[i] = temp2;
                    counter++;
                    isFinished = false;
                }
            }
            if (!isFinished)
            {
                isFinished = true;
                minimumSwaps(arr);
            }

            return counter;
        }


        static void Main(string[] args)
        {
            string array = "4 3 1 2";
            int[] arr = Array.ConvertAll(array.Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int res = minimumSwaps(arr);
        }
    }
}
