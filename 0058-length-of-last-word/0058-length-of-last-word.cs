public class Solution {
    public int LengthOfLastWord(string s) {
        string[] expectAnswer = s.Split(' ');
        int len = 0;
        for ( int i = expectAnswer.Length - 1; i >= 0; i-- )
        {
            if ( expectAnswer [ i ] != "" )
            {
                len = expectAnswer [ i ].Length;
                break;
            }
        }
        return len;
    }
}