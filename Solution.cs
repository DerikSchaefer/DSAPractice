using System;
using System.Collections.Generic;

public class Solution
{

    /* #region https: //leetcode.com/problems/search-insert-position/ search index position
     public int SearchInsert(int[] nums, int target)
     {
         int indexOfTarget = 0;
         int lengthOfArray = nums.Length - 1;

         if (lengthOfArray == 0)
         {
             if (nums[0] == target)
             {
                 return indexOfTarget;
             }
             else if (nums[0] > target)
             {
                 return 0;
             }
             else if (nums[0] < target)
             {
                 return indexOfTarget + 1;
             }
         }

         for (int i = 0; i < nums.Length; i++)
         {
             if (nums[i] == target)
             {
                 indexOfTarget = i;
                 return indexOfTarget;
             }
         }

         if (indexOfTarget == 0)
         {
             for (int j = 0; j < nums.Length; j++)
             {
                 if (nums[j] < target && nums[j + 1] > target)
                 {
                     indexOfTarget = j;
                     return indexOfTarget;
                 }
                 else if (nums[lengthOfArray] < target)
                 {
                     return lengthOfArray + 1;
                 }
             }
         }
         return 0;
         #endregion
     }*/

    /*
    Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.

    You must write an algorithm with O(log n) runtime complexity.

    Example 1:

    Input: nums = [1, 3, 5, 6], target = 5
    Output: 2
    Example 2:

    Input: nums = [1, 3, 5, 6], target = 2
    Output: 1
    Example 3:

    Input: nums = [1, 3, 5, 6], target = 7
    Output: 4*/

    public int SearchInsert(int[] nums, int target)
    {
        var Dict = new Dictionary<int, int>();

        var index = 0;
        var lower = 0;
        var upper = 0;
        foreach (var value in nums)
        {


            Dict.Add(value, index);
            index++;
        }


        if (Dict.ContainsKey(target))
        {
            Console.WriteLine(Dict[target]);
            Console.ReadLine();
            return Dict[target];
        }




        else if (!Dict.ContainsKey(target))
        {
            foreach (var value in Dict)
            {

                Console.WriteLine(Dict[value]);
                Console.ReadLine();
            }
        }

        /*    foreach (var check in Dict)
    {
        Console.WriteLine(check);
        Console.ReadLine();
    }*/

        return -1;


    }
}


