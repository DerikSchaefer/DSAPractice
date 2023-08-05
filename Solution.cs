using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 
using System.Collections.Specialized;
using System.Text.RegularExpressions; 
using System.Diagnostics;
using System.IO; 
using System.Numerics; 
using System.Globalization; 
using System.Reflection; 
using System.Runtime.InteropServices; 
using System.Threading; 
using System.Xml; 
using System.Xml.Serialization; 
using System.Net; 
using System.Net.Sockets; 
using System.Security.Cryptography; 

public class Solutions
{

    /* 
    https://leetcode.com/problems/remove-element/
    Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.The order of the elements may be changed.Then return the number of elements in nums which are not equal to val.

    Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

    Change the array nums such that the first k elements of nums contain the elements which are not equal to val.The remaining elements of nums are not important as well as the size of nums.
    Return k.*/

    public int RemoveElement(int[] nums, int val)
    {




        
        int k = 0;

        /*Change the array nums such that the first k elements of nums contain the elements which are not equal to val.
        The remaining elements of nums are not important as well as the size of nums.*/
        /*Input: nums = [3, 2, 2, 3], val = 3
        Output: 2, nums = [2, 2, _, _]
        Explanation: Your function should return k = 2, with the first two elements of nums being 2.*/

        if (nums.Length == 0)
        {
            return k;
        }


        foreach (var num in nums)
        {
            Console.WriteLine("original input array: " + num);
        }
        Console.WriteLine("val is: " + val);

        if (nums[0] == val)
        {
            k++;
            nums[0] = nums[1];
        }

        for (int i = 0; i < nums.Length; i++)
        {

            if (i == nums.Length - 1)
            {
                break;
            }
            
            if (nums[i] == val)
            {
                k++;
                nums[i] = nums[i + 1];
                if (nums[i] == val)
                {
                    nums[i] = nums[i + 1];
                }
            }


            /* if (nums[i] == val)
             {

                 k++;
                 if (i == nums.Length - 1)
                 {
                     break;
                 }
                 else
                 {
                     nums[i] = nums[i + 1];
                     if (nums[i] == val)
                     {
                         nums[i] = nums[i + 1];
                     }
                 }


             }
             Console.WriteLine("input array after loop: " + nums[i]);*/

        }

        Console.WriteLine("should go from [ 0, 1, 2, 2, 3, 0, 4, 2] to [0, 1, 3, 0, 4, _, _, _");
        foreach (var num in nums)
        {
            Console.WriteLine("changed input array: " + num);
        }
        Console.WriteLine("value of k: " + k);
        Console.ReadLine();



        return k;

    }
}

