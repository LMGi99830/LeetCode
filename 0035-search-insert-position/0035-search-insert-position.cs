public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int indexValue = Array.IndexOf(nums, target);
        if(indexValue == -1)
        {
            List<int> list = nums.ToList();
            list.Add(target);
            list.Sort();
            indexValue = Array.IndexOf(list.ToArray(), target);
        }
        return indexValue;
    }
}