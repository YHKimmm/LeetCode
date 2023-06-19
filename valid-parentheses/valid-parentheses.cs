public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> dict = new();
        dict[')'] = '(';
        dict[']'] = '[';
        dict['}'] = '{';
        Stack<char> stack = new();
        foreach(var c in s)
        {
            if(!dict.ContainsKey(c))
            {
                stack.Push(c);
            }
            else if(stack.Count() == 0 || dict[c] != stack.Pop())
            {
                return false;
            }
        }
        return stack.Count() == 0;
    }
}