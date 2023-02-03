namespace DSAPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();


            #region https://leetcode.com/problems/search-insert-position/ search index position
            int[] nums = { 1, 3, 5, 6 };
            int target = 2;
            solution.SearchInsert(nums, target);
            #endregion


        }

    }
}
