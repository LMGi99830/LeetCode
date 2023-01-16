public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int num = 0;
        int len = s.Length;

        int i = 0;
        for ( int j = 0; j < len; j++ )
        {
            if(map.ContainsKey(s[j]))
            {
                i = Math.Max(map.FirstOrDefault(a => a.Key == s[j]).Value, i);
                map.Remove(s [ j ]);
            }
            num = Math.Max(num, j - i + 1);
            map.Add(s [ j ], j + 1);
        }
        return num;
    }
}