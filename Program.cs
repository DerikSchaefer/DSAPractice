using System;

namespace DSAPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var solution = new Solutions();

            int[] nums = { 3, 2, 2, 3 };
            int value = 2;
            int k = solution.RemoveElement(nums, value);


            Console.WriteLine(k);
            Console.ReadLine();




        }


    }
}