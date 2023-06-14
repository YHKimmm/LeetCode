public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> dict = new();
        foreach(var word in s)
        {
            if(dict.ContainsKey(word))
            {
                dict[word] += 1;
            }
            else
            {
                dict[word] = 1;
            }
        }
        // aacc
        //{a:2, c:2} ccac
        //{a:3, n:1, g:1, r:1, m:1}
        foreach(var word in t)
        {
            if(dict.ContainsKey(word))
            {
                dict[word] -= 1;
            }
        }
        foreach(var ele in dict)
        {
            if(ele.Value != 0)
            {
                return false;
            }
        }
        return true;
    }
}