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
using System.Runtime.Remoting.Messaging;

public class Solutions
{
    #region RemoveElement   https://leetcode.com/problems/remove-element/
    /* 
  
    Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.The order of the elements may be changed.Then return the number of elements in nums which are not equal to val.

    Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

    Change the array nums such that the first k elements of nums contain the elements which are not equal to val.The remaining elements of nums are not important as well as the size of nums.
    Return k.*/

    /*    public int RemoveElement(int[] nums, int val)
        {

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] == val)
                {
                    nums[left] = nums[right];
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return left;
        }
    }*/
    #endregion

}