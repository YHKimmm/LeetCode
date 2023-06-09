public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> output = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            int left = i + 1, right = nums.Length - 1;
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum > 0)
                {
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else if (sum == 0)
                {
                    output.Add(new List<int> { nums[i], nums[left], nums[right] });
                    while (left < right && nums[left] == nums[left + 1])
                    {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right - 1])
                    {
                        right--;
                    }
                    left++;
                    right--;
                }
            }
        }
        return output;
    }   
}