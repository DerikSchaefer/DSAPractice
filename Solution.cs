public class Solution
{

    #region https://leetcode.com/problems/search-insert-position/ search index position
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
}

