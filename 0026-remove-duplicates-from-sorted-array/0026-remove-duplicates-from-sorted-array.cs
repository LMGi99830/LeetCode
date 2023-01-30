public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int [ ] expectAnswer = nums.Intersect(nums).ToArray();
        for ( int i = 0; i < expectAnswer.Length; i++ )
        {
            nums [ i ] = expectAnswer [ i ];
            if (i == expectAnswer.Length - 1)
            {
                List<int> list = nums.ToList();
                list.RemoveRange(i + 1, nums.Length - expectAnswer.Length);
                nums = list.ToArray();
            }
        }
        return nums.Length;
    }
}