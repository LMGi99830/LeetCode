public class Solution {
    public int RomanToInt(string s) {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        dic.Add("I", 1);
        dic.Add("V", 5);
        dic.Add("X", 10);
        dic.Add("L", 50);
        dic.Add("C", 100);
        dic.Add("D", 500);
        dic.Add("M", 1000);

        char [ ] cha = s.ToArray();
        string [ ] array = cha.Select(a => a.ToString()).ToArray();
        int answer = 0;
        for(int i = 0; i < array.Length; i++)
        {
            int val = dic.FirstOrDefault(a => a.Key == array[i]).Value;
            if(i == array.Length - 1)
            {
                answer += val;
                continue;
            }
            if(array[i] == "I"
                || array[i] == "X"
                || array[i] == "C")
            {
                int nextVal = dic.FirstOrDefault(a => a.Key == array[i + 1]).Value;

                if(val * 5 == nextVal
                    || val * 10 == nextVal)
                {
                    answer += nextVal - val;
                    i++;
                    continue;
                }
            }
            answer += val;
        }
        return answer;
    }
}