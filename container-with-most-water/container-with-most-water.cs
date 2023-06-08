public class Solution {
    public int MaxArea(int[] height) {
        int x = height.Length - 1;
        int left = 0, right = height.Length -1; //pointer in height
        int maxWidth = 0;
        while(left < right)
        {
            int miniHeight = Math.Min(height[left], height[right]); //1
            // width = x * miniHeight; // 8
            maxWidth = Math.Max(maxWidth, x * miniHeight);
            if(height[left] < height[right])
            {
                x--;
                left ++;
            }
            else
            {
                x--;
                right --;
            }
        }
        return maxWidth;
    }
}