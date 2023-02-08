using System;


namespace DSAPractice
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // Example input
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            Solution solution = new Solution();
            ListNode result = solution.MergeTwoLists(list1, list2);

            // Output the result
            Console.WriteLine("Result: ");
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
            Console.WriteLine();
        }
    }
}