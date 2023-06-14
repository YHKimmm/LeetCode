public class Solution {
    public bool IsIsomorphic(string s, string t) {
        for(int i = 0; i < s.Length; i++)
        {
            int sIdx = s.IndexOf(s[i]);
            int tIdx = t.IndexOf(t[i]);
            if(sIdx != tIdx)
            {
                return false;
            }
        }
        return true;
    }
}