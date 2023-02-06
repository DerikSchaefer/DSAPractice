using System;
using System.Collections.Generic;

public class Solution
{
    /*    #region https: //leetcode.com/problems/search-insert-position/ search index position 

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
    Output: 4*


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
      }
    */

    /*#region https://leetcode.com/problems/roman-to-integer/ 
    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    Symbol Value
    I             1
    V             5
    X             10
    L             50
    C             100
    D             500
    M             1000
    For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II.The number 27 is written as XXVII, which is XX + V + II.

    Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV.Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:

    I can be placed before V (5) and X(10) to make 4 and 9. 
    X can be placed before L(50) and C(100) to make 40 and 90. 
    C can be placed before D(500) and M(1000) to make 400 and 900.
    Given a roman numeral, convert it to an integer.



    Example 1:

    Input: s = "III"
    Output: 3
    Explanation: III = 3.
    Example 2:

    Input: s = "LVIII"
    Output: 58
    Explanation: L = 50, V= 5, III = 3.
    Example 3:

    Input: s = "MCMXCIV"
    Output: 1994
    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.*/

    public int RomanToInt(string s)
    {


        // Create a Dictionary with all the Roman numerals as keys and the integer values as the values





        int result = 0;


        Dictionary<char, int> Romans = new Dictionary<char, int>();

        Romans.Add('I', 1);
        Romans.Add('V', 5);
        Romans.Add('X', 10);
        Romans.Add('L', 50);
        Romans.Add('C', 100);
        Romans.Add('D', 500);
        Romans.Add('M', 1000);




        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length - 1)
            {
                result += Romans[s[i]];
            }

            else if (Romans[s[i]] == 1 && Romans[s[i + 1]] == 5)
            {
                // did three and 8 instead of 4 and 9 because I think the 1 from the previous value 'I' will already have been added 
                result += 4;
                i++;
            }
            else if (Romans[s[i]] == 1 && Romans[s[i + 1]] == 10)
            {
                result += 9;
                i++;
            }
            else if (Romans[s[i]] == 10 && Romans[s[i + 1]] == 100)
            {
                result += 90;
                i++;
            }
            else if (Romans[s[i]] == 10 && Romans[s[i + 1]] == 50)
            {
                result += 40;
                i++;
            }
            else if (Romans[s[i]] == 100 && Romans[s[i + 1]] == 500)
            {
                result += 400;
                i++;
            }
            else if (Romans[s[i]] == 100 && Romans[s[i + 1]] == 1000)
            {
                result += 900;
                i++;
            }
            else
            {
                result += Romans[s[i]];
            }
        }
        Console.WriteLine(result);
        Console.ReadLine();
        return result;
    }
}



