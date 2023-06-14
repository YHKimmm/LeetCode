public class Solution {
    public bool WordPattern(string pattern, string s) {
        var split = s.Split(" ");
        if(pattern.Length != split.Length)
        {
            return false;
        }
        for(int i = 0; i < pattern.Length; i++)
        {
            int pIdx = pattern.IndexOf(pattern[i]);
            int sIdx = Array.IndexOf(split, split[i]);
            if(pIdx != sIdx)
            {
                return false;
            }
        }
        return true;
    }
}