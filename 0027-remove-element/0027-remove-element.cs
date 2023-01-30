public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int[] expectAnswer = nums.Where(a => a != val).ToArray();
        for ( int i = 0; i < expectAnswer.Length; i++ )
        {
            nums [ i ] = expectAnswer [ i ];
        }
        return expectAnswer.Length;
    }
}