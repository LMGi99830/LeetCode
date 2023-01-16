public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs, ( x, y ) => x.Length.CompareTo(y.Length));
        string firstArrayValue = strs [ 0 ];
        int len = firstArrayValue.Length;
        int count = 0;
        string answer = "";

        if(strs.Length == 1)
        {
            return answer = strs [ 0 ];
        }

        for ( int i = 0; i < firstArrayValue.Length; i++ )
        {
            for ( int j = 1; j < strs.Length; j++ )
            {
                if(strs[j].Substring(i,1).Equals(firstArrayValue [ i ].ToString()))
                {
                    count++;
                }
            }
            if ( count == strs.Length - 1 )
            {
                answer += firstArrayValue [ i ];
            }
            else
            {
                return answer;
            }
            count = 0;
        }
        return answer;
    }
}