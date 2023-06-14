public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        //{eat: {ate, eat, tea}}
        Dictionary<string, List<string>> dict = new();
        foreach(var str in strs)
        {
            var charArr = str.ToCharArray();
            Array.Sort(charArr);
            string newStr = new string(charArr);
            if(!dict.ContainsKey(newStr))
            {
                dict[newStr] = new List<string>();
            }
            dict[newStr].Add(str);
        }
        return new List<IList<string>>(dict.Values);
    }
}