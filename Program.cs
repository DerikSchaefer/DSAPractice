using System;

namespace DSAPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var solution = new Solutions();

            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int value = 2;
            int k = solution.RemoveElement(nums, value);

         

            Console.WriteLine(k);
            Console.ReadLine();




        }


    }
}