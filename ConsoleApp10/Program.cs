using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.IO;

namespace ConsoleApp10
{
    class Program
    {
        
        static void Main()
        {
            var path = @"C:\Windows\Systems32\mmc.exe";
            Console.WriteLine(Path.IsPathRooted(path));
            Console.ReadLine();









        //    Test(new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 });
        //}
        
        //static void Test (int[] nums)
        //{
        //    var fiboCounts = FibonacciCounts(nums);
        
        //    Console.WriteLine("There are {0} even numbers and {0} odd numbers", fiboCounts);
        //    Console.ReadLine();
        //}
        //public static (int, int) FibonacciCounts(int [] nums) 
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
}
