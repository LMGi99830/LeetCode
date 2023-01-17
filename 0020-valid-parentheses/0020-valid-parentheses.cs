public class Solution {
    public bool IsValid(string s) {
        Stack<string> map = new Stack<string>();
        for(int i = 0; i < s.Length; i++)
        {
            switch(s[i].ToString())
            {
                case "(":
                    map.Push(")");
                    break;
                case "{":
                    map.Push("}");
                    break;
                case "[":
                    map.Push("]");
                    break;
                default:
                    if( map.Count == 0 || map.Pop() != s [ i ].ToString())
                    {
                        return false;
                    }
                    break;
            }
        }
        return map.Count == 0;
    }
}