public class Solution {
    public string LongestPalindrome(string s) {
        int len = s.Length;
        int begin = 0;
        int maxLen = 0;

        if ( s == null || s.Trim().Equals("") )
        {
            return s;
        }
        for ( int i = 0; i < len - maxLen / 2; i++ )
        {
            int j = i;
            int k = i;
            while ( k < len - 1 && s[k] == s[k + 1] )
            { 
                k++;
            }
            while ( j > 0 && k < len - 1 && s[j - 1] == s[k + 1] )
            { // Expand both left and right
                j--;
                k++;
            }
            int newLen = k - j + 1;
            if ( newLen > maxLen )
            {
                begin = j;
                maxLen = newLen;
            }
        }
        return s.Substring(begin, maxLen);
    }
}