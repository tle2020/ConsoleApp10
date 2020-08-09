using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Collections.Immutable;

namespace ConsoleApp10
{
    public class Solution
    {
       
        static void Main()
        {
            Test(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Console.ReadLine();
        }
        static void Test (int[] nums)
        {
            var reverse = ReverseOrder(nums);
            for(int i = 0; i < reverse.Length; i++)
            {
                Console.WriteLine(reverse[i]);
              
            }
          
        }
        public static int[] ReverseOrder (int[] nums)
        {
            int length = nums.Length;
            int[] reverseOrder = new int[length];
            for(int i = 0; i < length; i++)
            {
                reverseOrder[length - i - 1] = nums[i];
            }
            return reverseOrder;
        }
       
       
        

        //    Test(new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 });
        //}

            //static void Test(int[] nums)
            //{
            //    var fiboCounts = FibonacciCounts(nums);

            //    Console.WriteLine("There are {0} even numbers and {0} odd numbers", fiboCounts);
            //    Console.ReadLine();
            //}
            //public static (int, int) FibonacciCounts(int[] nums)
            //{
            //    int oddFibo = 0;
            //    int evenFibo = 0;

            //    foreach (int fiboNum in nums)
            //    {
            //        if (fiboNum % 2 == 0)
            //        {
            //            evenFibo += 1;
            //        }
            //        else
            //        {
            //            oddFibo += 1;
            //        }
            //    }
            //    return (evenFibo, oddFibo);

        
    }
}
