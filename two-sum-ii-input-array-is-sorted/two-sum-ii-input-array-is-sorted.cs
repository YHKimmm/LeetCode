public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // two pointer
        int left =0, right = numbers.Length - 1;
        while(left != right)
        {
            if(numbers[right] + numbers[left] > target)
            {
                right--;
            }
            else if(numbers[right] + numbers[left] < target)
            {
                left++;
            }
            else if(numbers[right] + numbers[left] == target)
            {
                return new int[] {left+1, right+1};
            }
        }
        return default;
    }
}