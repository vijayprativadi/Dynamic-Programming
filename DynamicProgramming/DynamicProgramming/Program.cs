using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //08/29
            //LCS
            //Longest Common Substring
            String str1 = "ABCBDAB", str2 = "BDCABA";
            Console.WriteLine("Length of Longest Common Subsequence is: " + DynamicProgrammingModule.LongestCommonSubsequence(str1, str2));
            Console.WriteLine("Length of Longest Common Substring is: " + DynamicProgrammingModule.LongestCommonSubstring(str1, str2));


            //08/30
            //LIS
            //LDS
            int[] arr = new int[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            DynamicProgrammingModule.LongestIncreasingSubsequence(arr);
            DynamicProgrammingModule.LongestDecreasingSubsequence(arr);
            Console.ReadKey();

            //08/31
            //Incresing Subseqence with Max Sum
            //Edit Distance Problem
            //Minimum cost to reach last cell of the matrix from the first cell

            //09/01
            //Longest Sequence formed by adjacent numbers in matrix
            //Knapsack Problem
            //Partion Problem

            //09/02
            //Subset Sum Problem
            //3 Partion Problem
            //Minimum Sum Partion Problem

            //09/03
            //Rod Cutting
            //Maximum Product Rod Cutting
            //Number of ways to make change

            //09/04
            //Min Number of Coins for Change
            //Word Break Problem
            //Box Stacking Problem

            //09/05
            //Path in Matrix
            //Number of time pattern appers in given string as a subsequence 
            //WildCard Pattern Matching Problem

            //09/06
            //Palidrome Partioning Min Cuts
            //Min Jums from source to destination
            //Maximum Sum of SubSequence with no adjacent elements

            //09/07
            //Maximum Sum Subarray (Kadane)
            //Max Profit K Transactions

        }
    }
}
