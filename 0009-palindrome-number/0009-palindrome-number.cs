public class Solution {
    public bool IsPalindrome(int x) {
        int val = x;
        int valRev = x.ToString().Reverse().Aggregate(0, (b, y) => 10 * b + y - '0');
        return val == valRev ? true : false;
    }
}