using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public static class DynamicProgrammingModule
    {
        public static void LongestIncreasingSubsequence(int[] arr)
        {
            IList<IList<int>> LIS = new List<IList<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                LIS.Add(new List<int>());
            }

            LIS[0].Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] < arr[i] && LIS[j].Count > LIS[i].Count)
                    {
                        LIS[i] = new List<int>(LIS[j]);
                    }
                }
                
                LIS[i].Add(arr[i]);
            }

            // LIS Length
            var lisResult = LIS.OrderByDescending(x => x.Count()).Take(1).ToArray()[0];
            Console.WriteLine("Length of LIS: " + lisResult.Count());

            StringBuilder sb = new StringBuilder();
            String SEPARATOR = "";
            foreach (var item in lisResult)
            {
                sb.Append(SEPARATOR);
                sb.Append(item.ToString());
                SEPARATOR = ",";
            }

            // LIS Result
            Console.WriteLine("Result of LIS: " + sb.ToString());
        }

        public static void LongestDecreasingSubsequence(int[] arr)
        {
            IList<IList<int>> LDS = new List<IList<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                LDS.Add(new List<int>());
            }

            LDS[0].Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[i] && LDS[j].Count > LDS[i].Count)
                    {
                        LDS[i] = new List<int>(LDS[j]);
                    }
                }

                LDS[i].Add(arr[i]);
            }

            // LDS Length
            var ldsResult = LDS.OrderByDescending(x => x.Count()).Take(1).ToArray()[0];
            Console.WriteLine("Length of LDS: " + ldsResult.Count());

            StringBuilder sb = new StringBuilder();
            String SEPARATOR = "";
            foreach (var item in ldsResult)
            {
                sb.Append(SEPARATOR);
                sb.Append(item.ToString());
                SEPARATOR = ",";
            }

            // LDS Result
            Console.WriteLine("Result of LDS: " + sb.ToString());
        }
    }
}
