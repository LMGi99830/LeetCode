public class Solution {
    public int[] RunningSum(int[] nums) {
    
    int [ ] runningSum = new int [ nums.Length ];
    
    for ( int i = 0; i < nums.Length; i++ )
    {
        if(i == 0)
        {
            runningSum [ i ] = nums [ i ];
            continue;
        }
        if(i == 1)
        {
            runningSum [ i ] = nums [ i ] + nums [ i - 1 ];
            continue;
        }
        runningSum[i] = nums[i] + runningSum[i - 1];
    }
    return runningSum;
    }
}