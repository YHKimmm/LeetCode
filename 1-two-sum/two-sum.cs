public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> output = new();
        Dictionary<int, int> dict = new();
        for(int i =0; i < nums.Length; i++)
        {
            dict[nums[i]] = i;
        }
        for(int i =0; i < nums.Length; i++)
        {
            int neededNum = target - nums[i];
            if(dict.ContainsKey(neededNum) && dict[neededNum] != i)
            {
                output.Add(i);
                output.Add(dict[neededNum]);
                return output.ToArray();
            }
        }
        return default;
    }
}