public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int [ ] expectAnswer = nums.Intersect(nums).ToArray();
        for ( int i = 0; i < expectAnswer.Length; i++ )
        {
            nums [ i ] = expectAnswer [ i ];
        }
        return expectAnswer.Length;
    }
}