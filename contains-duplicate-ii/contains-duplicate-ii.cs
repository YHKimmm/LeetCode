public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int,int> dict = new();
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]) && Math.Abs(dict[nums[i]] - i) <= k)
            {
                return true;
            }
            dict[nums[i]] = i;
        }
        return false;
    }
}