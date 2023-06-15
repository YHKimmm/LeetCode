public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int j;
        for (var i = 0; i < nums.Length; i++)
        {
            j = i + 1;
            while (j < nums.Length && j <= i + k)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
                j++;
            }
        }

        return false;
    }
}