public class Solution {
    public bool IsValid(string s) {
        string answer = string.Empty;
        Dictionary<string, string> map = new Dictionary<string, string>();
        map.Add("(", ")");
        map.Add("{", "}");
        map.Add("[", "]");

        for(int i = 0; i < s.Length; i++)
        {
            if(!map.ContainsValue(s[i].ToString()))
            {
                answer += s[i].ToString();
                continue;
            }
            if(answer.Length == 0)
            {
                return false;
            }
            string firstValue = answer.Substring(answer.Length - 1, 1);
            if(map.FirstOrDefault(a => a.Value == s[i].ToString()).Key == firstValue)
            {
                answer = answer.Remove(answer.Length - 1, 1);
                continue;
            }
            return false;
        }
        if(answer.Length != 0)
        {
            return false;
        }
        return true;
    }
}