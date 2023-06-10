public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0, right = 0, output = 0;
        HashSet<char> charSet = new();
        while(right < s.Length)
        {
            if(!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                output = Math.Max(output, charSet.Count());
                right ++;
            }
            else
            {
                charSet.Remove(s[left]);
                left ++;
            }
        }
        return output; 
    }
}