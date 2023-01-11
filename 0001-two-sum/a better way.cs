int numsLength = nums.Length;
Dictionary<int, int> dic = new Dictionary<int, int>();
int [ ] answer = new int [ 2 ];
for ( int i = 0; i < numsLength; i++ )
{
    if(dic.ContainsKey(target - nums[i]))
    {
        answer [ 1 ] = i;
        answer [ 0 ] = dic.FirstOrDefault(a => a.Key == ( target - nums [ i ] )).Value;
        return answer;
    }
    dic.Add(nums [ i ], i);
}
return answer;
