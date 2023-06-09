public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0, sum = 0;
        int res = int.MaxValue;
        for(int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];
            while(sum >= target)
            {
                res = Math.Min(res, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }
        return res == int.MaxValue ? 0 : res;
    }
}