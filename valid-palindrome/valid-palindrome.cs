public class Solution {
    public bool IsPalindrome(string s) {
        if (s == " ")
        {
            return true;
        }
        char[] arr = s.Where(c => char.IsLetterOrDigit(c)).ToArray();
        string str = new string(arr);
        if(str.ToLower() == ReverseStringToLower(str))
        {
            return true;
        }
        return false;
    }
    static string ReverseStringToLower(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        string str = new string(arr);
        string lowerStr = str.ToLower();
        return lowerStr;
    }
}