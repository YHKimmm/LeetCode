public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> dict = new();
        for(int i = 0; i < numbers.Length; i++)
        {
            dict[numbers[i]] = i + 1;
        }
        for(int i = 0; i < numbers.Length; i++)
        {
            int neededNum = target - numbers[i];
            if(dict.ContainsKey(neededNum) && i + 1 != dict[neededNum])
            {
                return new int[] {i+1, dict[neededNum]};
            }
        }
        return default;
    }
}