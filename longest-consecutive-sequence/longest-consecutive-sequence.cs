public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, bool> dict = new();
        foreach(var num in nums)
        {
            dict[num] = true;
        }
        int ans = 0;
        foreach(var num in dict.Keys)
        {
            if(!dict.ContainsKey(num-1))
            {
                int nextVal = num + 1;
                int count = 1;
                while(dict.ContainsKey(nextVal))
                {
                    count++;
                    nextVal++;
                }
                ans = Math.Max(ans, count);
            }
        }
        return ans;
    }
}