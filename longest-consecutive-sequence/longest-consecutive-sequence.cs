public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, bool> dict = new();
        foreach(var num in nums)
        {
            dict[num] = true;
        }
        // {100: true, 4:true, 200:true, 1:true, 3:true, 2:true}
        int longest = 0;
        foreach(var num in dict.Keys)
        {
            if(!dict.ContainsKey(num - 1))
            {
                int count = 1;
                int nextVal = num + 1;
                while(dict.ContainsKey(nextVal))
                {
                    count++;
                    nextVal++;
                }
                longest = Math.Max(longest, count);
            }
        }
        return longest;
    }
}